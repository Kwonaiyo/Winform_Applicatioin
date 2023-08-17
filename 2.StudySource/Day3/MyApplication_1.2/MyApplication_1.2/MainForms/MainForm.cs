using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class MainForm : Form
    {
        private Thread TimerThread;
        public MainForm()
        {
            //Login login = new Login();
            //login.ShowDialog();

            //if (Convert.ToBoolean(login.Tag) == false)
            //{
            //    //로그인을 실패했을 경우 또는 로그인 창을 그냥 닫았을경우 -> 프로그램종료
            //    // this.Close()로는 프로그램을 종료할 수 없는 에러가 뜬다..
            //    // --> 객체의 생성자에서 Close()시 정상 종료를 할 수 없음

            //    // --> 프로그램 강제 종료가 필요하다.
            //    Environment.Exit(0);
                
            //}

            // 폼에 구성되는 컨틀롤을 코딩하는 함수.
            InitializeComponent();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void WinTimer_Tick(object sender, EventArgs e)
        {
            tssNowTime.Text = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 1. 타이머 스레드를 구현.

            // 1-1. 스레드가 실행할 메서드 연결.
            ThreadStart threadStart = new ThreadStart(SetNowTime);

            // 1-2. Delegate를 실행할 스레드 객체 생성 및 연결.
            TimerThread = new Thread(threadStart);

            // 1-3. 스레드 시작.
            TimerThread.Start();
        }

        /// <summary>
        /// 타이머 스레드가 구현할 메서드 로직.
        /// </summary>
        private void SetNowTime()
        {
            // 스레드의 메서드는 한번만 호출된다. 따라서 반복적으로 수행해야 하는 로직은
            // 무한 루프를 통해 별도의 프로세스로 구현할 수 있다. 
            //int iCount = 0;
            while (true)
            {
                Thread.Sleep(1000);
                tssNowTime.Text = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);

                //iCount++;
                //if (iCount == 10)
                //{
                //    break;
                //}
            }
            //MessageBox.Show("10초가 경과하여 더 이상 시간을 표시하지 않습니다.");
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            // Environment.Exit() --> 현 시점에서 해당 어플리케이션을 강제종료한다. (불안정 종료)
            
            // 프로그램의 종료 여부를 묻고싶거나, 멀티스레드 등을 안정적으로 종료하기 위해서는
            // Applicaion.Exit() 사용.
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 메인 폼이 종료될때 일어나는 로직

            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            if (TimerThread.IsAlive)
                TimerThread.Abort();
        }
    }
}
