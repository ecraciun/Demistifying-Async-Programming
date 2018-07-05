using System;
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

        private async void GetSomeDummyData()
        {
            await Task.Delay(new Random().Next(400, 600));
            _dummyData = "We got the data!";
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

        private async void ThrowException()
        {
            await Task.Delay(500);
            throw new Exception("Well shit, who catches me?");
        }
    }
}
