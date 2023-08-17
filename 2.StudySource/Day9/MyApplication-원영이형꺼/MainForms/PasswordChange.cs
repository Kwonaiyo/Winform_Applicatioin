﻿using Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/*******************************************************
 * NAME   : PasswordChang.cs
 * DESC   : 비밀번호 변경 화면
 * 
 * DATE   : 2023-04-28
 * AUTHOR : 정원영
 * DESC   : 최초 프로그램 작성 
 * *****************************************************/
namespace MainForms
{
    public partial class PasswordChange : MetroFramework.Forms.MetroForm
    {
        public PasswordChange()
        {
            InitializeComponent();
            this.ActiveControl = txtUserId;
            txtUserId.Focus();
        }

        /// <summary>
        /// 비밀번호 변경 버튼을 클릭할 때 일어나는 이벤트
        /// </summary>
        /// <param name="sender"> 버튼 컨트롤(도구)의 속성 </param>
        /// <param name="e"> 이벤트에 대한 속성 (Click) </param>
        private void btnPwChange_Click(object sender, EventArgs e)
        {
            // 밸리데이션(Validation)
            // - 응용프로그램 실행시 발생할 수 있는 예외상황을 미리 인지하여
            //   예외상황 발생 경우를 사용자에게 전달하는 로직을 구현함으로써
            //   시스템 오류상황을 막고 프로그램의 신뢰도를 높여주는 프로그래밍 구현 방법
            string sMessage = string.Empty;
            
            string sUserId = txtUserId.Text;
            string sNowPassword = txtNowPw.Text;
            string sChangePw = txtChangePw.Text;
            if (sUserId == "") sMessage += " 사용자 ID";
            else if (sNowPassword  == "") sMessage += " 현재 비밀번호";
            else if (sChangePw == "") sMessage += " 변경할 비밀번호";

            if (sMessage != string.Empty)
            {
                MessageBox.Show($"{sMessage}를 입력해줘잉.");
                return;
            }

            // 1. ID와 PW를 정확하게 입력했는지 비교

            #region < 데이터베이스 연동 및 상태체크 >
            // 1. 데이터베이스 접속 주소 설정
            SqlConnection sCon = new SqlConnection(Commons.strCon);

            // 2. 데이터베이스 오픈
            sCon.Open();

            try
            {
                // 3. 데이터베이스가 실행할 SQL 구문 작성
                string sSQL = $"SELECT * FROM TB_USER WHERE USERID = '{sUserId}' AND PW = '{sNowPassword}'";

                // 4. SQL을 실행할 Adapter 객체 생성
                SqlDataAdapter Adapter = new SqlDataAdapter(sSQL, sCon);

                // 5. SQL 실행 및 데이터 결과 리턴
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                // 6. ID와 PW가 일치하는 경우 (dtTemp에 결과값이 있을 경우)
                if (dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("ID와 PW가 일치하지 않습니다");
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

            #endregion

            #region < 데이터베이스에 비밀번호 변경 로직 >
            // 1. 데이터베이스 오픈
            sCon.Open();

            // 2. Insert, Update, Delete 를 수행할 명령 객체 Command
            SqlCommand cmd = new SqlCommand();

            // 3. 커맨드가 수행할 트랜잭션 선언
            SqlTransaction tran = sCon.BeginTransaction();

            try
            {
                // 4. 커맨드에 트랜잭션 명령어 전달
                cmd.Transaction = tran;

                // 5. 커맨드가 접근할 주소
                cmd.Connection = sCon;

                // 6. 커맨드가 실행할 SQL
                string SQLupdate = $" UPDATE TB_USER SET PW = '{sChangePw}' WHERE USERID = '{sUserId}' ";

                // 7. 커맨드에 SQL 전달
                cmd.CommandText = SQLupdate;

                // 8. CMD가 명령 실행
                cmd.ExecuteNonQuery();

                // 9. 트랜잭션 commit
                tran.Commit();
                MessageBox.Show("변경됐다네");
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

        private void txtChangePw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnPwChange_Click(null, null);
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void PasswordChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void txtNowPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void txtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserId;
            txtUserId.Focus();
        }
    }
}
