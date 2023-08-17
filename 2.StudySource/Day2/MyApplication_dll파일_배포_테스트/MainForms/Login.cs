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

                #region<3. 실습 - PW 3번 잘못입력했을 경우 프로그램 종료- Mine..작성중..>
                //// 프로그램 실행 -> ID별 비밀번호 입력 -> 비밀번호 일치하지 않을경우 (3번)
                //// 프로그램 종료. - this.Close()

                //string sSQL1 = $"SELECT * FROM TB_User WHERE USERID = '{sUserID}'";

                //SqlDataAdapter Adapter01 = new SqlDataAdapter(sSQL1, sCon);

                //DataTable dtTemp01 = new DataTable();

                //Adapter01.Fill(dtTemp01);



                //// 3. 결과에 따라 ID를 잘못 입력했는지 판단(if)



                //    if (dtTemp01.Rows.Count == 0)
                //    {
                //        txtUserId.Text = "";
                //        txtUserId.Focus();
                //        MessageBox.Show("아이디가 일치하지 않음");
                //        return;
                //    }

                //    // 4. ID는 맞는데, PW를 잘못 입력했는지 판단.(else if)
                //    else if (sPassword != dtTemp01.Rows[0]["PW"].ToString())
                //    {
                //        txtPassWord.Text = "";
                //        txtPassWord.Focus();
                //        MessageBox.Show("비밀번호가 일치하지 않음");
                //    if ( count == 2)         
                //    {
                //        MessageBox.Show("비밀번호 3회 입력 오류.\n종료합니다.");
                //        this.Close();
                //    }
                //    count += 1;         //count가 버튼클릭 메서드 안에서 초기화되면 버튼을 클릭할때마다
                //    return;             // 초기화되어버리므로 버튼클릭 메서드 밖에서 초기화해줘야한다.
                //}

                //    // if문을 모두 통과했다. (ID와 PW가 모두 일치한다.)
                //    string sUserName00 = dtTemp01.Rows[0]["USERNAME"].ToString();
                //    MessageBox.Show($"로그인 성공!\n{sUserName00}님 반갑습니다.");
                #endregion

                #region < 4. 비밀번호 잘못 입력했을 경우를 Database에서 체크 3회 오류시 프로그램 종료>

                //SqlCommand cmd = new SqlCommand();  // 명령을 수행할 커맨드 객체 생성

                //SqlTransaction tran = sCon.BeginTransaction();      // 트랜잭션 생성

                //cmd.Transaction = tran;     // cmd에 트랜잭션 명령어 전달.

                //cmd.Connection = sCon;

                //string SQL_Check_ID = $"SELECT USERID FROM TB_USER WHERE USERID = '{sUserID}'";  // 비교할 ID값 추출
                //string SQL_Check_PW = $"SELECT PW FROM TB_USER WHERE USERID = '{sUserID}'";      // 비교할 PW값 추출
                //string SQL_Check_Count = $"SELECT COUNT FROM TB_USER WHERE USERID = '{sUserID}'"; // 비교할 count값 추출
                //string SQLupdateCount = $"UPDATE TB_USER SET COUNT += 1 WHERE USERID = '{sUserID}'"; // 카운트 +1

                //cmd.CommandText = SQL_Check_ID;
                //string Compare_ID = cmd.ExecuteNonQuery().ToString();

                //cmd.CommandText = SQL_Check_PW;
                //string Compare_PW = cmd.ExecuteNonQuery().ToString();

                //cmd.CommandText = SQL_Check_Count;
                //int Compare_Count = Convert.ToInt32(cmd.ExecuteNonQuery()) ;

                //if (Compare_ID != sUserID)
                //{
                //    txtUserId.Text = "";
                //    txtUserId.Focus();
                //    MessageBox.Show("아이디가 일치하지 않음");
                //    return;
                //}
                //else if(Compare_PW != sPassword)
                //{
                //    cmd.CommandText = SQLupdateCount;
                //    cmd.ExecuteNonQuery();

                //    if(Compare_Count ==3)
                //    {
                //        MessageBox.Show("비밀번호 입력 3회 초과");
                //        this.Close();
                //    }
                //    txtPassWord.Text = "";
                //    txtPassWord.Focus();
                //    MessageBox.Show("비밀번호가 일치하지 않음");
                //    return;
                //}





                #endregion

                #region <4. 비밀번호 잘못 입력했을 경우를 Database에서 체크 3회 오류시 프로그램 종료 -->


                ////1. ID와 PW 받아오기 SQL문 작성
                //string sSql = $"SELECT USERID, PW, ISNULL(COUNT,0) AS COUNT FROM TB_USER WHERE USERID = '{sUserID}'";
                //SqlDataAdapter Adapter = new SqlDataAdapter(sSql, sCon);       //sql실행하고 결과 받아올 녀석
                //DataTable dtTemp = new DataTable();         // 데이터 담을 그릇 생성.

                //Adapter.Fill(dtTemp);   // adapter 실행 및 결과 datatable에 담기.

                //if (dtTemp.Rows.Count == 0)
                //{
                //    MessageBox.Show("일치하는 ID가 없음");
                //    return;
                //}

                ////2. 3회 오류 등록된 ID인가?
                //else if (Convert.ToInt32(dtTemp.Rows[0]["COUNT"]) == 3)
                //{
                //    MessageBox.Show("비밀번호 3회 입력 오류. 관리자에게 문의하세요.");
                //    return;
                //}

                ////3. 비밀번호가 맞는지 체크
                //else if(sPassword != dtTemp.Rows[0]["PW"].ToString())
                //{
                //    // 4. PW가 일치하지 않을 경우
                //    string sUpdate = $"UPDATE TB_USER SET COUNT = ISNULL(COUNT, 0) + 1 WHERE USERID = '{sUserID}'";

                //    SqlTransaction tran = sCon.BeginTransaction();
                //    SqlCommand com = new SqlCommand();      // 실행할 커맨드 객체 선언

                //    // 현재까지의 로그인 실패 횟수.
                //    int iLoginFailCount = Convert.ToInt32(dtTemp.Rows[0]["COUNT"]) + 1;
                //    try
                //    {
                //        com.Connection = sCon;  // DB 주소 등록.
                //        com.Transaction = tran; // 트랜잭션 등록
                //        com.CommandText = sUpdate;  // SQL 등록

                //        com.ExecuteNonQuery();      // 실행

                //        tran.Commit();

                //        MessageBox.Show($"비밀번호가 일치하지 않습니다. 남은 횟수 : {3 - iLoginFailCount}");

                //    }
                //    catch (Exception ex)
                //    {
                //        tran.Rollback();
                //        MessageBox.Show(ex.Message);
                //        return;
                //    }
                    

                //    if (iLoginFailCount == 3)
                //    {
                //        MessageBox.Show("비밀번호 3회 입력 오류..! 프로그램을 종료합니다.");
                //        this.Close();
                //    }
                    
                //}



                #endregion

                #region < 5. 강사 의 소스 4번내역 코딩 > 

                // 1. ID 와 PW 받아오기 sql 문 작성 
                string sSql = $" SELECT USERID, PW, ISNULL(LOGIN_FCNT,0) AS LOGIN_FCNT FROM TB_USER WHERE USERID = '{sUserId}'";
                SqlDataAdapter adapter = new SqlDataAdapter(sSql, sCon); // sql 실행하고 결과 받아올 녀석
                DataTable dtTemp = new DataTable(); // 데이터담을 그릇
                adapter.Fill(dtTemp); // adapter 실행 및 결과 datatable 에 담기.

                if (dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("일치하는 ID 가 없습니다.");
                    return;
                }
                // 2. 3회 오류 등록 된 ID 인가 ? 
                else if (Convert.ToInt32(dtTemp.Rows[0]["LOGIN_FCNT"]) == 3)
                {
                    MessageBox.Show("3회 비밀번호를 틀린 ID 입니다. 관리자와 문의하세요.");
                    return;
                }
                // 3. 비밀번호가 맞는지 체크 
                else if (sPassword != dtTemp.Rows[0]["PW"].ToString())
                {
                    // 4. PW 가 일치하지 않을경우. 오류카운트 1 증가. 
                    string sUpdate = $" UPDATE TB_USER SET LOGIN_FCNT = ISNULL(LOGIN_FCNT,0) +  1  WHERE USERID = '{sUserId}'";

                    SqlTransaction tran = sCon.BeginTransaction(); // 트랜잭션 선언 
                    SqlCommand com = new SqlCommand();             // 실행할 객체 선언. 

                    // 지금 현재까지 실패한 로그인 횟수.
                    int iLofingFalilCnt = Convert.ToInt32(dtTemp.Rows[0]["LOGIN_FCNT"]) + 1;

                    try
                    {
                        com.Connection = sCon;     // db 주소 등록
                        com.Transaction = tran;    // 트랜잭션 등록
                        com.CommandText = sUpdate; // SQL 등록

                        com.ExecuteNonQuery();     // 실행.

                        tran.Commit(); // 완료.

                        MessageBox.Show($" PW 가 일치 하지 않습니다. 남은 횟수 : {3 - iLofingFalilCnt}");
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    if (iLofingFalilCnt == 3)
                    {
                        MessageBox.Show("3회 비밀번호를 잘못입력하여 프로그램을 종료 합니다.");
                        this.Close();
                    }
                }


                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
