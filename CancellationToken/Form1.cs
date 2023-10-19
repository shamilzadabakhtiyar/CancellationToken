using CancellationTokenApp.Data;
using static System.Reflection.Metadata.BlobBuilder;

namespace CancellationTokenApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public CancellationTokenSource cts { get; set; }
        public CancellationToken token { get; set; }
        public CancellationTokenSource ctsSleep { get; set; }
        public CancellationToken tokenSleep { get; set; }
        public CancellationTokenSource ctsData { get; set; }
        public CancellationToken tokenData { get; set; }

        public Form1()
        {
            InitializeComponent();

            cts = new CancellationTokenSource();
            token = cts.Token;

            ctsSleep = new CancellationTokenSource();
            tokenSleep = ctsSleep.Token;

            ctsData = new CancellationTokenSource();
            tokenData = ctsData.Token;
        }

        private void AddLog(string logMessage)
        {
            logMessage = $"[{DateTime.Now: dd.MM.yyyy HH:mm:ss:fff}] - {logMessage}";
            lbLogs.Items.Add(logMessage);
            lbLogs.SelectedIndex = lbLogs.Items.Count - 1;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            AddLog("App started");
            int checkTime = (int)numericCheckTime.Value;

            while (true)
            {
                try
                {
                    token.ThrowIfCancellationRequested();
                    AddLog("Checking emails");
                    await CheckEmails();

                    AddLog("Waiting for the next check time");
                    await SmartSleep(checkTime);
                }
                catch (OperationCanceledException)
                {
                    break;
                }
            }
            AddLog("App shutting down");
        }

        private async Task CheckEmails()
        {
            var dbContext = new MyDbContext();
            await dbContext.GetAllMailsAsync(tokenData);
        }

        private async Task SmartSleep(int second)
        {
            try
            {
                await Task.Delay(second * 1000, tokenSleep);
            }
            catch (OperationCanceledException)
            {

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private void btnGettingData_Click(object sender, EventArgs e)
        {
            ctsData.Cancel();
        }

        private void btnCheckNow_Click(object sender, EventArgs e)
        {
            ctsSleep.Cancel();

            ctsSleep = new CancellationTokenSource();
            tokenSleep = ctsSleep.Token;
        }
    }
}