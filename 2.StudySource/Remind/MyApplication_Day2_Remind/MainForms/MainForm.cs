using System;
using System.Threading;
using System.Windows.Forms;

namespace MainForms
{
    public partial class MainForm : Form
    {
        Thread timethread;
        public MainForm()
        {
            //Login login = new Login();
            //login.ShowDialog();

            //if(Convert.ToBoolean(login.Tag) == false)
            //{
            //    // 프로그램 강제 종료.
            //    Environment.Exit(0);
            //}
            InitializeComponent();
        }

        private void NowTime_Tick(object sender, EventArgs e)
        {
            tslNowDate.Text = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ThreadStart thstart = new ThreadStart(SetNowTime);

            timethread = new Thread(thstart);

            timethread.Start();
        }
        private void SetNowTime()
        {
            while (true)
            {
                Thread.Sleep(1000);
                tslNowDate.Text = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.No) ;
            {
                e.Cancel = true;
                return;
            }
            if (timethread.IsAlive)
                timethread.Abort();
        }

        private void tssExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
