using Services;
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
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void btnPwChange_Click(object sender, EventArgs e)
        {
            // id/pw 입력여부
            string sMessage = string.Empty; // 필수입력 값 확인

            string sUserId = txtUserId.Text; // 입력한 사용자 ID
            string sPassword = txtNowPw.Text; // 입력한 현재 비밀번호
            string sChangePw = txtChangePw.Text; // 변경할 PW

            if (sUserId == string.Empty)
                sMessage = "아이디 ";
            if (sPassword == string.Empty)
                sMessage += "현재 비밀번호 ";
            if (sChangePw == string.Empty)
                sMessage += "변경 비밀번호 ";

            if (sMessage != string.Empty)
            {
                MessageBox.Show($"{sMessage}를 입력하세요.");
                return;
            }

            // ID와 PW가 일치?
            // 1. 데이터베이스 접속.
            SqlConnection sCon = new SqlConnection(Commons.strCon);

            sCon.Open();

            try
            {
                // 2. 데이터베이스가 수행할 sql 구문 작성
                string sSQL = $"SELECT * FROM TB_USER WHERE USERID = '{sUserId}' AND PW = '{sPassword}'";

                // 3. SQL을 실행할 ADAPTER 소환
                SqlDataAdapter Adapter = new SqlDataAdapter(sSQL, sCon);

                // 4. adapter 실행
                DataTable dtTemp = new DataTable(); // 데이터 테이블을 받아오는 그릇 생성.
                Adapter.Fill(dtTemp);

                if(dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show($"아이디와 비밀번호가 일치하지 않습니다.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sCon.Close();
            }

            // + 비밀번호 변경 로직을 수행.. 
        }
    }
}
