using Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

/*******************************************************************
 * NAME   : PasswordChange.cs
 * DESC   : 비밀번호 변경
 * DATE   : 2023-04-28
 * AUTHOR : 권문규
 * DESC   : 최초 프로그램 작성
 * 
 * DATE   :
 * EDITOR :
 * EESC   :
 * 
 *******************************************************************/

namespace MainForms
{
    public partial class PasswordChange : Form
    {
        
        public PasswordChange()
        {
            InitializeComponent();
            
        }

        /// <summary>                           
        /// 비밀번호 변경 버튼을 클릭할 때 일어나는 이벤트 
        /// </summary>
        /// <param name="sender"> sender : 버튼 컨트롤(도구)의 속성 </param>
        /// <param name="e"> e: 이벤트에 대한 속성(click) </param>
        private void btnPwChange_Click(object sender, EventArgs e)
        {
            #region <밸리데이션>
            /* 밸리데이션(Validation)
             *   응용프로그램 실행 시 발생할 수 있는 예외 상황을 미리 인지하여 
             *   예외상황 발생 경우를 사용자에게 전달하는 로직을 구현함으로써
             *   시스템 오류 상황을 막고 프로그램의 신뢰도를 높여주는 프로그래밍 구현 방법.
             */

            string sMessage = string.Empty;

            string sUserID = txtUserId.Text;        // 입력한 사용자 ID
            string sNowPassword = txtNowPw.Text;    // 입력한 현재 PW
            string sChangePw = txtChangePw.Text;    // 변경할 PW

            if (sUserID == "")
                sMessage = "사용자ID ";
            else if (sNowPassword == "")
                sMessage += "현재 비밀번호 ";
            else if (sChangePw == "")
                sMessage += "변경 비밀번호 ";

            if (sMessage != string.Empty)
            {
                MessageBox.Show($"{sMessage}를 입력하지 않았습니다!");
                return;
            }
            // ID와 PW를 정확하게 입력했는지 비교.
            #endregion

            #region <데이터베이스 연동 및 상태 체크>
            // 1. 데이터베이스 접속 주소 설정.
            SqlConnection sCon = new SqlConnection(Commons.strCon);

            // 2. 데이터베이스 오픈
            sCon.Open();

            try
            {
                // 3. 데이터베이스가 실행할 SQL구문 작성.
                string sSQL = $"SELECT * FROM TB_USER WHERE USERID = '{sUserID}' AND PW ='{sNowPassword}'";

                // 4. SQL을 실행할 ADAPTER 객체 생성
                SqlDataAdapter Adapter = new SqlDataAdapter(sSQL, sCon);

                // 5. SQL 실행 데이터 결과 리턴
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                // 6. id와 pw가 일치하는 경우(= 결과값이 있을 경우)
                if (dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("아이디와 비밀번호가 일치하지 않습니다.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                sCon.Close();
            }
            #endregion

            #region < 데이터베이스에 비밀번호 변경 로직 >
            // 1. Database Open
            sCon.Open();

            // 2. Insert, Update, Delete를 수행할 명령 객체 Command 선언
            SqlCommand cmd = new SqlCommand();

            // 3. 커맨드가 수행할 트랜잭션 선언.
            SqlTransaction tran = sCon.BeginTransaction();

            try
            {
                // 4. 커맨드에 트랜잭션 명령어 전달.
                cmd.Transaction = tran;

                // 5. 커맨드가 접근할 주소 할당
                cmd.Connection = sCon;

                // 6. 커맨드가 실행할 SQL
                string SQLupdate = $" UPDATE TB_USER SET PW = '{sChangePw}' WHERE USERID = '{sUserID}'";
                
                // 7. 커맨드에 SQL 전달.. 
                cmd.CommandText = SQLupdate;

                // 8. cmd가 명령 실행.
                cmd.ExecuteNonQuery();

                // 9. 트랜잭션 commit
                tran.Commit();
                MessageBox.Show("변경 완료됨");
                this.Close();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sCon.Close();
            }

            #endregion



        }

        private void PwChange_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnPwChange_Click(sender, e);
            }
        }
    }
}
