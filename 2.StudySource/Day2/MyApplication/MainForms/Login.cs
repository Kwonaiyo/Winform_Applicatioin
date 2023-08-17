using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Services;
/*******************************************************************
 * NAME   : Login.cs
 * DESC   : 사용자 로그인 화면
 * 
 * DATE   : 2023-04-27
 * AUTHOR : 권문규
 * DESC   : 최초 프로그램 작성
 * 
 * 
 * DATE   : 2023-04-27
 * EDITOR : 홍길동
 * DESC   : 프로그램이 뭣같아서 ~~를 수정했음
 * 
 * 
 *******************************************************************/
namespace MainForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        int count = 0;
        /// <summary>
        /// 로그인 버튼 클릭 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender = null, EventArgs e = null)
        {
            // 1. ID와 PW를 입력하였는지 확인.
            string sUserID = txtUserId.Text;
            string sPassword = txtPassWord.Text;

            string sMessage = string.Empty;
            if (sUserID == "")
                sMessage = "아이디, ";
            if (sPassword == "")
                sMessage += "비밀번호, ";

            if (sMessage != "")
            {
                MessageBox.Show($"{sMessage}를 입력하세요.");
                return;
            }

            // 데이터베이스 접속경로 지정.
            //string strCon = "Server = localhost; Uid = sa ; Pwd = 1234 ; database = AppDev";


            // 접속 경로를 커넥터에게 전달 (커넥터 : 집배원)

            SqlConnection sCon = new SqlConnection(Commons.strCon);

            
            try
            {


                // 2. ID와 PW를 입력하였으므로 ID와 PW 일치여부를 확인.
                // (ID와 PW는 데이터베이스에 등록되어 있을 예정.)



                // 데이터베이스 오픈.
                sCon.Open();

                #region < 1. ID와 PW가 동시에 일치하지 않을 경우 >
                //// SQLAdapter : C#에서 받아온 명령을 데이터베이스에게 실행하라고 지시.
                ////              실행된 결과를 받아와서 C#으로 전달하는 역할

                //// 데이터베이스가 수행할 SQL구문
                //string sSQLCheckLogFlag = $"SELECT * FROM TB_User WHERE USERID = '{sUserID}' AND PW = '{sPassword}'";

                //SqlDataAdapter Adapter = new SqlDataAdapter(sSQLCheckLogFlag, sCon);

                //// 데이터베이스에서 결과를 받아올 자료형 그릇을 준비.
                //DataTable dtTemp = new DataTable();
                //Adapter.Fill(dtTemp);


                //// 아이디와 패스워드가 일치하지 않을 경우 -> 로그인 실패 메세지 출력 및 로그인 리턴
                //if (dtTemp.Rows.Count == 0)
                //{
                //    txtPassWord.Text = "";
                //    txtPassWord.Focus();
                //    MessageBox.Show("아이디와 패스워드 일치하지 않음");
                //    return;
                //}


                //// 로그인한 사용자의 이름을 받아와서 표현.
                //string sUserName = dtTemp.Rows[0]["USERNAME"].ToString();

                //MessageBox.Show($"로그인 성공!\n{sUserName}님 반갑습니다.");
                #endregion

                #region <2. ID를 잘못 입력하였는지, PW를 잘못 입력하였는지 확인 후 메세지 표현-Mine>
                //// 1. SQL문 작성 (string 변수에 입력)
                //string sSQLCheckLogFlag_ID = $"SELECT * FROM TB_User WHERE USERID = '{sUserID}'";
                //string sSQLCheckLogFlag_PW = $"SELECT * FROM TB_User WHERE USERID = '{sUserID}' AND PW = '{sPassword}'";

                //// 2. 데이터베이스에 조회 결과 받아오기(sqlAdapter)
                //SqlDataAdapter Adapter_ID = new SqlDataAdapter(sSQLCheckLogFlag_ID, sCon);
                //SqlDataAdapter Adapter_PW = new SqlDataAdapter(sSQLCheckLogFlag_PW, sCon);

                //DataTable dtTemp_ID = new DataTable();
                //DataTable dtTemp_PW = new DataTable();

                //Adapter_ID.Fill(dtTemp_ID);
                //Adapter_PW.Fill(dtTemp_PW);

                //// 3. 결과에 따라 ID를 잘못 입력했는지 판단(if)
                //if (dtTemp_ID.Rows.Count == 0)
                //{
                //    txtUserId.Text = "";
                //    txtUserId.Focus();
                //    MessageBox.Show("아이디가 일치하지 않음");
                //    return;
                //}

                //// 4. ID는 맞는데, PW를 잘못 입력했는지 판단.(else if)
                //if (dtTemp_PW.Rows.Count == 0)
                //{
                //    txtPassWord.Text = "";
                //    txtPassWord.Focus();
                //    MessageBox.Show("비밀번호가 일치하지 않음");
                //    return;
                //}

                //// if문을 모두 통과했다. (ID와 PW가 모두 일치한다.)
                //string sUserName = dtTemp_PW.Rows[0]["USERNAME"].ToString();
                //MessageBox.Show($"로그인 성공!\n{sUserName}님 반갑습니다.");
                #endregion

                #region <2. ID를 잘못 입력하였는지, PW를 잘못 입력하였는지 확인 후 메세지 표현-강사님ver>
                //// 1. SQL문 작성 (string 변수에 입력)
                //string sSQL = $"SELECT * FROM TB_User WHERE USERID = '{sUserID}'";

                //// 2. 데이터베이스에 조회 결과 받아오기(sqlAdapter)
                //SqlDataAdapter Adapter00 = new SqlDataAdapter(sSQL, sCon);

                //DataTable dtTemp00 = new DataTable();

                //Adapter00.Fill(dtTemp00);

                //// 3. 결과에 따라 ID를 잘못 입력했는지 판단(if)
                //if (dtTemp00.Rows.Count == 0)
                //{
                //    txtUserId.Text = "";
                //    txtUserId.Focus();
                //    MessageBox.Show("아이디가 일치하지 않음");
                //    return;
                //}

                //// 4. ID는 맞는데, PW를 잘못 입력했는지 판단.(else if)
                //else if (sPassword != dtTemp00.Rows[0]["PW"].ToString())
                //{
                //    txtPassWord.Text = "";
                //    txtPassWord.Focus();
                //    MessageBox.Show("비밀번호가 일치하지 않음");
                //    return;
                //}

                //// if문을 모두 통과했다. (ID와 PW가 모두 일치한다.)
                //string sUserName00 = dtTemp00.Rows[0]["USERNAME"].ToString();
                //MessageBox.Show($"로그인 성공!\n{sUserName00}님 반갑습니다.");
                #endregion

                #region<3. 실습 - PW 3번 잘못입력했을 경우 프로그램 종료>
                // 프로그램 실행 -> ID별 비밀번호 입력 -> 비밀번호 일치하지 않을경우 (3번)
                // 프로그램 종료. - this.Close()

                string sSQL1 = $"SELECT * FROM TB_User WHERE USERID = '{sUserID}'";

                SqlDataAdapter Adapter01 = new SqlDataAdapter(sSQL1, sCon);

                DataTable dtTemp01 = new DataTable();

                Adapter01.Fill(dtTemp01);

                

                // 3. 결과에 따라 ID를 잘못 입력했는지 판단(if)
                


                    if (dtTemp01.Rows.Count == 0)
                    {
                        txtUserId.Text = "";
                        txtUserId.Focus();
                        MessageBox.Show("아이디가 일치하지 않음");
                        return;
                    }

                    // 4. ID는 맞는데, PW를 잘못 입력했는지 판단.(else if)
                    else if (sPassword != dtTemp01.Rows[0]["PW"].ToString())
                    {
                        txtPassWord.Text = "";
                        txtPassWord.Focus();
                        MessageBox.Show("비밀번호가 일치하지 않음");
                    if ( count == 2)         
                    {
                        MessageBox.Show("비밀번호 3회 입력 오류.\n종료합니다.");
                        this.Close();
                    }
                    count += 1;         //count가 버튼클릭 메서드 안에서 초기화되면 버튼을 클릭할때마다
                    return;             // 초기화되어버리므로 버튼클릭 메서드 밖에서 초기화해줘야한다.
                }
                    
                    // if문을 모두 통과했다. (ID와 PW가 모두 일치한다.)
                    string sUserName00 = dtTemp01.Rows[0]["USERNAME"].ToString();
                    MessageBox.Show($"로그인 성공!\n{sUserName00}님 반갑습니다.");
                #endregion
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sCon.Close();
            }
        }

        private void btnPasswordChg_Click(object sender, EventArgs e)
        {
            // Login클래스에서 비밀번호 변경 버튼 클릭시 일어나는 일들  -> PasswordChange클래스를 호출해와야함

            // 1. 비밀번호 변경 클래스 선언
            PasswordChange PwCh = new PasswordChange();

            this.Visible = false;   // -> 로그인 창 숨김

            // 2. 비밀번호 변경 클래스 나타내기.
            // Show - 비동기식 .. 두 개의 창을 동시에 입력하는 등 다른 작업을 할 수 있다. 
            // ShowDialog - 동기식.. 비밀번호 변경 창에서 작업이 완료될 때 까지 다른 작업을 할 수 없다.
            PwCh.ShowDialog();
           
            this.Visible = true;    // -> 로그인 창 다시 나타내기
        }


        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        
    }
}
