using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncForms
{
    public partial class Form1 : Form
    {
        private string _dummyData;

        public Form1()
        {
            InitializeComponent();
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

        private async void sameSyncContextBtn_Click(object sender, EventArgs e)
        {
            var result = await Task.Run(async () => await DoSomeMoreWorkAsync());
            outputTxtBox.AppendText(Environment.NewLine);
            outputTxtBox.AppendText(result);
        }

        private async Task<string> DoSomeMoreWorkAsync(bool returnOnSameSyncContext = true)
        {
            var beforeContextId = Thread.CurrentThread.ManagedThreadId;
            await Task.Delay(100).ConfigureAwait(returnOnSameSyncContext);
            var afterContextId = Thread.CurrentThread.ManagedThreadId;
            return $"Task initially started on ManagedThreadId: {beforeContextId} and resumed on ManagedThreadId: {afterContextId}";
        }

        private async void irrelevantSyncContextBtn_Click(object sender, EventArgs e)
        {
            var result = await DoSomeMoreWorkAsync(false);
            //var result = await Task.Run(async () => await DoSomeMoreWorkAsync(false));
            outputTxtBox.AppendText(Environment.NewLine);
            outputTxtBox.AppendText(result);
        }
    }
}