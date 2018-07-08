using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncForms
{
    public partial class Form1 : Form
    {
        private string _dummyData;
        private CancellationTokenSource _cts;
        private Task _cancellableTask;

        public Form1()
        {
            InitializeComponent();
            cancelTaskBtn.Enabled = false;
        }

        private async void asyncVoidRaceBtn_Click(object sender, EventArgs e)
        {
            _dummyData = null;
            GetSomeDummyData();
            await Task.Delay(500);
            outputTxtBox.AppendText(Environment.NewLine);
            outputTxtBox.AppendText(_dummyData ?? "No data available.");
        }

        

        private void asyncVoidCatchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ThrowException();
            }
            catch (Exception ex)
            {
                outputTxtBox.AppendText(Environment.NewLine);
                outputTxtBox.AppendText(ex.Message);
            }
        }
        
        private void deadlockBtn_Click(object sender, EventArgs e)
        {
            var t = DoSomeWorkAsync();
            t.Wait();
            outputTxtBox.AppendText(Environment.NewLine);
            outputTxtBox.AppendText("My task completed!");
        }

        private async Task DoSomeWorkAsync()
        {
            await Task.Delay(500); // but there is something here you can do
            outputTxtBox.AppendText(Environment.NewLine);
            outputTxtBox.AppendText("Inner task completed!");
        }

        private async void ThrowException()
        {
            await Task.Delay(500);
            throw new Exception("Well shit, who catches me?");
        }

        private async void GetSomeDummyData()
        {
            await Task.Delay(new Random().Next(400, 600));
            _dummyData = "We got the data!";
        }

        private async Task<string> DoSomeMoreWorkAsync(bool returnOnSameSyncContext = true)
        {
            var beforeContextId = Thread.CurrentThread.ManagedThreadId;
            await Task.Delay(100).ConfigureAwait(returnOnSameSyncContext);
            var afterContextId = Thread.CurrentThread.ManagedThreadId;
            return $"Task initially started on ManagedThreadId: {beforeContextId} and resumed on ManagedThreadId: {afterContextId}";
        }

        private async void startCTBtn_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            cancelTaskBtn.Enabled = true;
            startCTBtn.Enabled = false;
            var _cts2 = new CancellationTokenSource();

            _cancellableTask =  Task.Run(async () =>
            {
                await Task.Delay(3000, _cts.Token);
                Debug.WriteLine($"Waited for the first 3 sec. Cancellation is requested: {_cts.IsCancellationRequested}");
                //throw new Exception("Test!");
                //_cts.Token.ThrowIfCancellationRequested();
                //await Task.Delay(3000, _cts.Token);
                //Debug.WriteLine($"Waited for the last 3 sec. Cancellation is requested: {_cts.IsCancellationRequested}");
            }, _cts.Token);

            try
            {
                await _cancellableTask;
            }
            catch (OperationCanceledException ocEx) when (ocEx.CancellationToken == _cts.Token)
            {
                outputTxtBox.AppendText(Environment.NewLine);
                outputTxtBox.AppendText(
                    $"Task completed. Canceled: {_cancellableTask.IsCanceled}, Completed: {_cancellableTask.IsCompleted}, Faulted: {_cancellableTask.IsFaulted}");
            }
            catch (Exception ex)
            {
                outputTxtBox.AppendText(Environment.NewLine);
                outputTxtBox.AppendText(
                    $"Task completed. Canceled: {_cancellableTask.IsCanceled}, Completed: {_cancellableTask.IsCompleted}, Faulted: {_cancellableTask.IsFaulted}");
            }
            finally
            {
                _cts.Dispose();
                _cts2.Dispose();
            }
        }

        private void cancelTaskBtn_Click(object sender, EventArgs e)
        {
            cancelTaskBtn.Enabled = false;
            startCTBtn.Enabled = true;
            _cts.Cancel();
        }
    }
}