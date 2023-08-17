using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace MainForms
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        #region < 필드 멤버 변수 >
        SqlConnection sCon = new SqlConnection(Commons.strCon);

        SqlDataAdapter Adapter;

        SqlCommand Command = new SqlCommand();
        SqlTransaction sTran;

        DataTable dtTemp = new DataTable();
        #endregion
        public Login()
        {
            InitializeComponent();
        }
        private void DoOpenDB()
        { if (sCon.State == ConnectionState.Closed) sCon.Open(); }
        private void DoCloseDB()
        { if (sCon.State == ConnectionState.Open) sCon.Close(); }
        private void ExecuteNonQuery(string sSqlstring)
        {
            sTran = sCon.BeginTransaction();

            Command.Transaction = sTran;
            Command.Connection = sCon;
            Command.CommandText = sSqlstring;

            Command.ExecuteNonQuery();
            sTran.Commit();
        }
        private void btnLogIn_Click(object sender = null, EventArgs e = null)
        {
            string sUserId = txtUserId.Text;
            string sPassWord = txtPassWord.Text;

            string sMessage = string.Empty;
            if (sUserId == "" && sPassWord == "") sMessage = "아이디와 비밀번호";
            else if (sUserId == "") sMessage = "아이디";
            else if (sPassWord == "") sMessage = "비밀번호";

            if (sMessage != "")
            {
                MessageBox.Show($"{sMessage}를 입력해줘잉.");
                return;
            }
            try
            {
                DoOpenDB();
                #region < PW 3번 잘못입력까지 추가 >
                //string sSQL = $"SELECT * FROM TB_User WHERE USERID = '{sUserId}'";
                //SqlDataAdapter Adapter = new SqlDataAdapter(sSQL, sCon);

                //DataTable dtTemp = new DataTable();
                //Adapter.Fill(dtTemp);

                //if (dtTemp.Rows.Count == 0)
                //{
                //    txtUserId.Text = "";
                //    txtUserId.Focus();
                //    MessageBox.Show("ID가 없엉");
                //    return;
                //}
                //else if (sPassWord != dtTemp.Rows[0]["PW"].ToString())
                //{
                //    txtPassWord.Text = "";
                //    txtPassWord.Focus();
                //    login_count += 1;
                //    MessageBox.Show($"PW가 틀렸엉 (틀린 횟수 : {login_count}/3)");
                //    if (login_count >= 3)
                //    {
                //        MessageBox.Show("ㅂ2");
                //        this.Close();
                //    }
                //    return;
                //}
                //if (sPassWord == dtTemp.Rows[0]["PW"].ToString()) login_count = 0;
                //string sUserName = dtTemp.Rows[0]["USERNAME"].ToString();
                //MessageBox.Show($"{sUserName}님 ㅎㅇ");
                #endregion

                #region < 4. 비밀번호를 잘못 입력했을 경우를 Database에서 체크 3회 오류시 프로그램 종료 >


                //cmd.Transaction = tran;
                //cmd.Connection = sCon;

                //string sSQL = $" SELECT * FROM TB_USER WHERE USERID = '{sUserId}'";
                //cmd.CommandText = sSQL;
                //cmd.ExecuteNonQuery();
                //SqlDataAdapter Adapter = new SqlDataAdapter(sSQL, sCon);

                //DataTable dtTemp = new DataTable();
                //Adapter.Fill(dtTemp);

                //if (dtTemp.Rows.Count == 0) // ID는 존재하지 않는 경우
                //{
                //    txtUserId.Text = "";
                //    txtUserId.Focus();
                //    MessageBox.Show("ID가 없엉");
                //    return;
                //}// 4. ID는 맞는데 PW를 잘못입력했는지 판단 (if else)
                //else if (sPassWord != dtTemp.Rows[0]["PW"].ToString()) // 비밀번호가 일치하지 않는 경우
                //{
                //    txtPassWord.Text = "";
                //    txtPassWord.Focus();
                //    sSQL += $" UPDATE TB_USER SET PW_F_CNT += 1";
                //    cmd.CommandText = sSQL;
                //    cmd.ExecuteNonQuery();
                //    MessageBox.Show("PW가 틀렸엉");
                //    return;
                //}

                //if (Convert.ToInt32(dtTemp.Rows[0]["PW_F_CNT"]) >= 3)
                //{
                //    MessageBox.Show("비밀번호가 3회 틀려서 종료");
                //    this.Close();
                //}
                //cmd.CommandText = sSQL;
                //cmd.ExecuteNonQuery();

                //tran.Commit();
                //this.Close();

                #endregion

                #region < 5. 강사의 소스 4번내역 코딩 >

                // 1. ID와 PW 받아오기 (SQL문 작성)
                string sSQL = $" SELECT USERID, USERNAME, PW, ISNULL(PW_F_CNT, 0) AS PW_F_CNT FROM TB_USER WHERE USERID = '{sUserId}'";
                Adapter = new SqlDataAdapter(sSQL, sCon); // SQL 실행하고 결과 받아옴
                Adapter.Fill(dtTemp); // Adapter 실행 및 결과 DataTable에 담기

                if (dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("일치하는 아이디가 없음");
                    return;
                }
                // 2. 3회 오류 등록된 아이디인가?
                else if (Convert.ToInt32(dtTemp.Rows[0]["PW_F_CNT"]) == 3)
                {
                    MessageBox.Show("3회 비밀번호를 틀린 ID입니다. 관리자와 문의하세요.");
                    return;
                }
                // 3. 비밀번호가 맞는지 체크
                else if (sPassWord != dtTemp.Rows[0]["PW"].ToString())
                { // 4. PW가 일치하지 않을 경우 오류카운트 1 증가
                    string sUpdate = $" UPDATE TB_USER SET PW_F_CNT = ISNULL(PW_F_CNT, 0) + 1 WHERE USERID = '{sUserId}'";
                    int iLoginFailCnt = Convert.ToInt32(dtTemp.Rows[0]["PW_F_CNT"]) + 1; // 로그인 실패 누적횟수
                    try
                    {
                        ExecuteNonQuery(sUpdate);
                        MessageBox.Show($"PW가 일치하지 않습니다. 남은 로그인 횟수 : {3 - iLoginFailCnt}");
                    }
                    catch (Exception ex)
                    {
                        sTran.Rollback();
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    if (iLoginFailCnt >= 3)
                    {
                        MessageBox.Show("비밀번호 입력 오류 3회. 프로그램을 종료합니다.");
                        this.Close();
                    }
                    return;
                }
                string sUserName = dtTemp.Rows[0]["USERNAME"].ToString();
                Commons.UserId = sUserId;
                MessageBox.Show($"{sUserName}님 ㅎㅇ");

                this.Tag = true;
                // Commons.bLoginSF = true;
                this.Close();

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DoCloseDB();
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogIn_Click(null, null);
        }

        private void btnPasswordChg_Click(object sender, EventArgs e)
        {
            PasswordChange PwCh = new PasswordChange();
            this.Visible = false;

            PwCh.ShowDialog();
            this.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserId;
            txtUserId.Focus();
        }

        private void btnMemberJoin_Click(object sender, EventArgs e)
        {
            // Email, C_Address
            // 메일과 주소를 입력할 수 있는 컬럼을 생성하고
            // 회원가입을 하는 기능을 로그인 창에 버튼을 생성하여
            // 회원가입 팝업창으로 구현해보시오.
            //  * 중복ID 체크 기능 포함
            // * USERID, USERNAME, PW 필수입력

            // INSERT INTO TB_User (USER ID, USERNAME, PW, EMAIL, C_ADDRESS)
            //              VALUES ({ID},    {NM},    {PW},{MAIL},{ADDRESS})
            MemberJoin MemJo = new MemberJoin();
            this.Visible = false;

            MemJo.ShowDialog();
            this.Visible = true;

        }
    }
}
