using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class MemberJoin : MetroFramework.Forms.MetroForm
    {
        #region < 필드 멤버 변수 >
        SqlConnection sCon = new SqlConnection(Commons.strCon);

        SqlDataAdapter Adapter;

        SqlCommand Command = new SqlCommand();
        SqlTransaction sTran;

        DataTable dtTemp = new DataTable();
        #endregion
        public int id_check = 0;
        public MemberJoin()
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
        private void Join_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserId;
            txtUserId.Focus();
            // Email, C_Address
            // 메일과 주소를 입력할 수 있는 컬럼을 생성하고
            // 회원가입을 하는 기능을 로그인 창에 버튼을 생성하여
            // 회원가입 팝업창으로 구현해보시오.
            //  * 중복ID 체크 기능 포함
            // * USERID, USERNAME, PW 필수입력

            // INSERT INTO TB_User (USER ID, USERNAME, PW, EMAIL, C_ADDRESS)
            //              VALUES ({ID},    {NM},    {PW},{MAIL},{ADDRESS})
        }

        public void btnIdCheck_Click(object sender, EventArgs e)
        {
            
            string sUserID = txtUserId.Text;
            if (sUserID == "")
            {
                MessageBox.Show("ID를 입력해줘잉");
                return;
            }
            try
            {
                DoOpenDB();
                #region < 중복확인 구현 >

                string sSQL = $" SELECT * FROM TB_USER WHERE USERID = '{sUserID}' ";
                Adapter = new SqlDataAdapter(sSQL, sCon);
                dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count != 0)
                {
                    MessageBox.Show("존재하는 ID라네");
                    return;
                }
                else
                {
                    id_check += 1;
                    MessageBox.Show("사용가능 ID");
                    return;
                }

                #endregion
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            { DoCloseDB(); }
        }

        private void btnMemberJoin_Click(object sender, EventArgs e)
        {
            string sUserID = txtUserId.Text;
            string sPassWord = txtPassWord.Text;
            string sPassWord2 = txtPassWord2.Text;
            string sUserName = txtUserName.Text;
            string sUserMail = txtUserMail.Text;
            string sUserAddress = txtUserAddress.Text;

            if (sUserID == "" || sPassWord == "" || sPassWord2 == "" || sUserName == "")
            {
                MessageBox.Show("필수입력 항목을 입력해줘잉");
                return;
            }
            if (sPassWord != sPassWord2)
            {
                MessageBox.Show("비밀번호를 확인해줘잉");
                return;
            }
            if (id_check != 1)
            {
                MessageBox.Show("ID 중복확인을 해줘잉");
                return;
            }
            try
            {
                #region < 회원가입 버튼 >
                DoOpenDB();
                string sSQL = $" SELECT * FROM TB_USER";
                Adapter = new SqlDataAdapter(sSQL, sCon);
                dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                string sInsert = string.Empty;
                sInsert +=  " INSERT INTO TB_USER (USERID         ";
                sInsert +=  "                     ,USERNAME       ";
                sInsert +=  "                     ,PW             ";
                sInsert +=  "                     ,MAIL           ";
                sInsert +=  "                     ,ADDRESS        ";
                sInsert +=  "                     ,MAKEDATE       ";
                sInsert +=  "                     ,MAKER)         ";
                sInsert += $" VALUES ('{sUserID}'                 ";
                sInsert += $"        ,'{sUserName}'               ";
                sInsert += $"        ,'{sPassWord}'               ";
                sInsert += $"        ,'{sUserMail}'               ";
                sInsert += $"        ,'{sUserAddress}'            ";
                sInsert += $" ,REPLACE(CONVERT(VARCHAR(30),GETDATE(),120),'-','/') ";
                sInsert += $"        ,'{Commons.UserId}')         ";
                try
                {
                    ExecuteNonQuery(sInsert);
                    MessageBox.Show("회원가입 완료");
                    
                }
                catch (Exception ex)
                {
                    sTran.Rollback();
                    MessageBox.Show(ex.Message);
                    return;
                }
                #endregion
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            {
                this.Close();
                DoCloseDB();
            }
        }
        private void txtUserId_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) btnIdCheck_Click(null, null); }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        { id_check = 0; }
    }
}
