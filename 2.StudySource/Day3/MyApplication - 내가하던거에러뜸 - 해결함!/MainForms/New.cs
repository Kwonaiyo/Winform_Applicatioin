using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MainForms
{
    public partial class New : Form
    {
        SqlTransaction tran;
        public New()
        {
            InitializeComponent();
        }

        private void New_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sName = txtName.Text;
            string sID = txtID.Text;
            string sPW = txtPW.Text;
            string sMail = txtMail.Text;
            string sAddress = txtAddress.Text;
            string sNullCheck = string.Empty;

            // 1. 이름, ID, PW가 입력되었는지 확인
            if (sName == "")
                sNullCheck = "이름 ";
            if (sID == "")
                sNullCheck += "ID ";
            if (sPW == "")
                sNullCheck += "PW";

            if (sNullCheck != "")
            {
                MessageBox.Show($"{sNullCheck}을(를) 입력하세요!");
                return;
            }

            // 2. ID가 중복되지 않는지 중복여부 확인
            // DB와 연결 후 데이터베이스 받아와서 확인 ..
            SqlConnection sCon = new SqlConnection(Commons.strCon);
            
            DataTable dtTemp1 = new DataTable();

            sCon.Open();
             

            try
            {
                
                string sSQLCheckIDFlag = $"SELECT * FROM TB_User WHERE USERID = '{sID}'";
                // sSQLCheckIDFlag가 값을 받아왔다면, 중복된 아이디가 존재한다 

                SqlDataAdapter Adapter1 = new SqlDataAdapter(sSQLCheckIDFlag, sCon);
                Adapter1.Fill(dtTemp1);

                if (dtTemp1.Rows.Count != 0)
                {
                    MessageBox.Show("중복된 ID가 존재. 다시 입력해주세요.");
                    return;
                }
                else    // 입력된 데이터들(이름, ID, PW, Email, Address를 데이터베이스에 업데이트.
                // 트랜잭션 사용.
                {
                    
                    SqlCommand cmd = new SqlCommand();              // 실행할 객체 선언
                    tran = sCon.BeginTransaction();  // 트랜잭션 선언
                    
                    // cmd가 수행할 명령 선언
                    string sInsert = $"INSERT INTO TB_User(USERID, USERNAME, PW, EMAIL, C_ADDRESS) VALUES('{sID}', '{sName}', '{sPW}', '{sMail}', '{sAddress}')";

                    cmd.Connection = sCon;      // cmd에 DB 주소 등록
                    cmd.Transaction = tran;     // cmd에 트랜잭션 등록
                    cmd.CommandText = sInsert;  // cmd에 SQL 등록

                    cmd.ExecuteNonQuery();      // 실행

                    tran.Commit();              // commit
                    MessageBox.Show("회원가입 완료! 감사합니다.");

                }

            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                sCon.Close();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
