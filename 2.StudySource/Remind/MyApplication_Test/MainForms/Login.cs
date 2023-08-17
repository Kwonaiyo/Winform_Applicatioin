using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sUserID = txtID.Text;
            string sUserPW = txtPW.Text;

            string sMsg_ID = "아이디";
            string sMsg_PW = "비밀번호";

            if (sUserID == "" && sUserPW =="")
            {
                MessageBox.Show($"{sMsg_ID}, {sMsg_PW}를 입력하세요!");
                return;
            }
            else if (sUserID == "")
            {
                MessageBox.Show($"{sMsg_ID}를 입력하세요!");
                return;
            }
            else if( sUserPW == "")
            {
                MessageBox.Show($"{sMsg_PW}를 입력하세요!");
                return;
            }

            // 데이터베이스 접속경로 지정.
            string strConnect = "Server = localhost; Uid = sa ; Pwd = 1234 ; database = AppDev";

            // 접속 경로를 커넥터에게 전달 (커넥터 : 집배원)

            SqlConnection sCon = new SqlConnection(strConnect);
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
