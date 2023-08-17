using MetroFramework.Forms;
using Services;
using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace MainForms
{
    public partial class MainForm : MetroForm
    {
        public static MainForm pu_MainForm;

        private Thread TimerThread;
        public MainForm()
        {
            Login login = new Login();
            login.ShowDialog();

            if (Convert.ToBoolean(login.Tag) != true)
            // if (Commons.bLoginSF != true)
            {
                // 로그인을 실패했을 경우 또는 로그인 창을 그냥 닫아버렸을 경우 : 프로그램 종료

                // 객체의 생성자에서 Close()시 정상종료를 할 수 없음
                // this.Close(); 대신 프로그램 강제종료 방법
                Environment.Exit(0);
            }

            // 폼에 구성되는 컨트롤을 코딩하는 함수
            InitializeComponent();
        }

        private void WinTimer_Tick(object sender, EventArgs e)
        {
            tssNowTime.Text = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pu_MainForm = this;

            // 1. 타이머 스레드 구현

            // 1-1. 스레드가 실행할 메서드 연결
            ThreadStart threadStart = new ThreadStart(SetNowTime);

            // 1-2. Delegate를 실행할 스레드 객체 생성 및 연결
            TimerThread = new Thread(threadStart);

            // 1-3. 스레드 시작
            TimerThread.Start();

        }
        /// <summary>
        /// 타이머 스레드가 구현할 메서드 로직
        /// </summary>
        private void SetNowTime()
        {
            // 스레드의 메서드는 한 번만 호출된다.
            // 따라서 반복적으로 수행해야 하는 로직은
            // 무한루프를 통해 별도의 프로세스로 구현할 수 있다.
            while (true)
            {
                tssNowTime.Text = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
                Thread.Sleep(1000);
            }
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            // Environment.Exit(); : 현 시점에서 해당 어플리케이션을 강제종료 (불안정한 종료)
            // Application.Exit(); : 프로그램의 종료여부를 묻고싶거나 멀티스레드 등을 안정적으로 종료 후 프로그램을
            //                       종료하기 위해서는 아래 기능을 사용한다.
            this.Close();
            // Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //// 메인 폼이 종료될 때

            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            if (TimerThread.IsAlive) TimerThread.Abort();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();

        }

        private void M_Test_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // 1. MDI_Test1 클래스 화면을 직접 호출
            //MDI_Test1 MDI1 = new MDI_Test1();
            //MDI1.Show();

            // 2. MDI Container를 이용한 방식
            //    : 부모 창을 컨테이너로 두고 그 안에 자식의 형태로 표현하는 방식

            // MDI (Multiple Document Interface)
            //  : 한 개의 창에서 여러가지 작업을 하는 화면을 호출하는 방식

            //MDI_Test1 MDI1 = new MDI_Test1();
            //// MDI_Test1 클래스 객체 화면의 부모 컨테이너로 MainForm을 선택
            //// this.IsMdiContainer = true;
            //MDI1.MdiParent = this;

            //MDI1.Show();

            //// 3. TEST메뉴 클릭시 오픈되어야 할 폼 표시
            //if (e.ClickedItem.Name == "MDI_Test1")
            //    MessageBox.Show("MDI_Test1 화면을 탭컨트롤에 표현합니다.");
            //if (e.ClickedItem.Name == "MDI_Test2")
            //    MessageBox.Show("MDI_Test2 화면을 탭컨트롤에 표현합니다.");

            // 이미 등록되어 있는 페이지의 메뉴를 클릭했을 경우 해당 페이지 활성화
            for (int i = 0; i < MyTab.TabPages.Count; i++)
            {
                if (MyTab.TabPages[i].Name == e.ClickedItem.Name.ToString())
                {
                    MyTab.SelectedTab = MyTab.TabPages[i];
                    return;
                }
            }
            // 열려 있는 페이지가 없을 경우 신규 등록
            // 4. 선택한 메뉴의 이름에 맞는 클래스를 찾아서 폼 형식으로 형변환하기
            // 4-1. FormList.DLL을 호출
            Assembly FormList = Assembly.LoadFrom($"{Application.StartupPath}\\FormList.DLL");
            // 4-2. Assembly에서 클릭한 메뉴의 이름에 맞는 클래스 정보 추출하기
            Type type = FormList.GetType("FormList." + e.ClickedItem.Name.ToString(), true);
            // 4-3. Form 형식으로 전환
            Form NewForm = (Form)Activator.CreateInstance(type);
            // 4-4. 탭페이지에 폼을 추가하여 오픈
            MyTab.AddForm(NewForm);
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            // 닫기버튼 클릭
            if (MyTab.TabPages.Count == 0) return;
            MyTab.SelectedTab.Dispose();
        }
        public void SetMessage(string sRowCnt)
        {
            tssRowCnt.Text = sRowCnt;
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            if (MyTab.TabPages.Count == 0) return;

            // 메인메뉴의 조회버튼을 클릭했을 대

            // 1번 시나리오 : 품목마스터 객체를 생성해서 조회 메서드를 호출
            /* 객체가 다르므로 오픈된 화면의 품목마스터 조회내역을 확인할 수 없다.
            ItemMaster It = new ItemMaster();
            It.DoInquire(); */

            // 2. 탭페이지에 등록되어 있는 클래스를 가져와서 실행
            /* 모든 화면의 기능을 일일이 다 연결해야 한다. (확장성 저하)
             * 변경내역이 존재할 경우 수정해야 할 항목이 늘어난다. (유지보수성 저하)
            if (MyTab.SelectedTab.Name == "ItemMaster")
            {
                ItemMaster It = (ItemMaster)MyTab.SelectedTab.Controls[0];
                It.DoInquire();
            }
            else if (MyTab.SelectedTab.Name == "UserMaster")
            {
                UserMaster Um = (UserMaster)MyTab.SelectedTab.Controls[0];
                Um.DoInquire();
            } */

            // 3. 오픈하고자 하는 화면들을 하나의 추상클래스에 연결해서 공통으로 호출
            ChildCommand("SEARCH");
        }

        private void ChildCommand(string sToolBarName)
        {
            // 1. 현재 탭화면이 등록되어있지 않은 경우 return;
            if (MyTab.TabPages.Count == 0)
            { return; }

            // 툴바를 눌렀을때 활성화된 창의 유형이 BaseChildForm을 상속받지 않았을 경우에 return;
            if (MyTab.SelectedTab.Controls[0] is BaseChildForm == false)
            { return; }


            // 2. 업캐스팅을 통한 부모의 상속 메서드 호출.
            IChildCommand NewChild = (BaseChildForm)MyTab.SelectedTab.Controls[0];

            // 3. 비교
            if (NewChild == null)
            { return; }

            switch (sToolBarName)
            {
                case "SEARCH":
                    NewChild.DoInquire();
                    break;
                case "ADD":
                    NewChild.DoNew();
                    break;
                case "SAVE":
                    NewChild.DoSave();
                    break;
                case "DELETE":
                    NewChild.DoDelete();
                    break;
            }
        }


        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            ChildCommand("ADD");
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            ChildCommand("DELETE");
        }

        private void tsbtnSaveB_Click(object sender, EventArgs e)
        {
            ChildCommand("SAVE");
        }

    }
}
