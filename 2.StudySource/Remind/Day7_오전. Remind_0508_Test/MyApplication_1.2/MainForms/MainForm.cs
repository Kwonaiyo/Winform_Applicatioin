using FormList;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class MainForm : Form
    {
        public static MainForm pu_MainForm;

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

            // -- 1번 방법.
            // 조회버튼을 클릭했을때 탭 컨트롤에 오픈되어있는 화면의 조회기능을 수행하고자 할때.
            //ITEMMASTER it = new ITEMMASTER();
            //it.DoInquire();

            // -- 2번 방법.
            // 탭페이지에 등록된 화면 객체를 뽑아내서 조회 기능을 수행하게끔 로직을 짜보자
            // 유지보수 및 확장성이 떨어진다... 일일이 만들어줘야 하는 불편함..
            //if(myTab.SelectedTab.Name == "ITEMMASTER")
            //{
            //    ITEMMASTER It = (ITEMMASTER)myTab.SelectedTab.Controls[0];
            //    It.DoInquire();
            //}
            //else if (myTab.SelectedTab.Name == "UserMaster")
            //{
            //    UserMaster Um = (UserMaster)myTab.SelectedTab.Controls[0];
            //    Um.DoInquire();
            //}

            // -- 3. 공통으로 호출할 수 있는 추상 클래스로 각각의 탭페이지 클래스의 툴바 기능 구현. 
            if(myTab.TabPages.Count == 0)   // 탭 컨트롤에 활성화되어있는 화면이 없을때 return;
            { return; }

            BaseChildForm bs = (BaseChildForm)myTab.SelectedTab.Controls[0];
            bs.DoInquire();
        }

        private void WinTimer_Tick(object sender, EventArgs e)
        {
            tssNowTime.Text = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pu_MainForm = this;

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

        private void mDI1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void M_Test_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //// 1. MDI_Test1 클래스 화면을 직접 호출
            //MDI_Test1 MDI1 = new MDI_Test1();
            //MDI1.Show();

            // 2. MDI Container를 이용한 방식
            //    부모 창을 컨테이너로 두고 그 안에 자식의 형태로 표현하는 방식.

            // MDI ? (Multiple Document Interface)
            // -> 한개의 창에서 여러 가지 작업을 하는 화면을 호출하는 방식을 말한다.

            //MDI_Test1 MDI1 = new MDI_Test1();

            //// MDI_Test1 클래스 객체 화면의 부모 컨테이너로 MainForm을 선택하겠다. 
            //// this.IsMdiContainer = true;
            //MDI1.MdiParent = this;

            //MDI1.Show();

            //// 3. TEST 메뉴 클릭시 오픈되어야 할 폼 표시
            //if (e.ClickedItem.Name == "MDI_Test1")
            //    MessageBox.Show("MDI_Test1 화면을 탭 컨트롤에 표시합니다.");
            //if (e.ClickedItem.Name == "MDI_Test2")
            //    MessageBox.Show("MDI_Test2 화면을 탭 컨트롤에 표시합니다.");


            // 이미 등록되어있는 페이지의 메뉴를 클릭했을 경우 해당 페이지 활성화.
            for (int i = 0; i < myTab.TabPages.Count; i++)
            {
                if (myTab.TabPages[i].Name == e.ClickedItem.Name.ToString())
                {
                    myTab.SelectedTab = myTab.TabPages[i];
                    return;
                }
            }
            
            
            // 열려있는 페이지가 없을 경우 신규 등록
            // 4. 선택한 메뉴의 이름에 맞는 클래스를 찾아서 폼 형식으로 형변환하기.
            // 4-1. FormList.dll을 호출.
            Assembly FormList = Assembly.LoadFrom($"{Application.StartupPath}\\FormList.DLL");

            // 4-2. Assembly에서 클릭한 메뉴의 이름에 맞는 클래스 정보 추출하기.
            Type type = FormList.GetType("FormList." + e.ClickedItem.Name.ToString(), true);

            // 4-3. Form 형식으로 전환
            Form NewForm = (Form)Activator.CreateInstance(type);

            // 4-4. 탭 페이지에 폼을 추가하여 오픈한다. 
            myTab.AddForm(NewForm);
            
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            // 닫기 버튼 클릭 --> 활성화되어있는 Tab 페이지를 닫아주기.
            if (myTab.TabPages.Count == 0)
                return;
            myTab.SelectedTab.Dispose();
        }

        public void SetMessage (string sRowCnt)
        {
            tssRowCNT.Text = sRowCnt;
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
