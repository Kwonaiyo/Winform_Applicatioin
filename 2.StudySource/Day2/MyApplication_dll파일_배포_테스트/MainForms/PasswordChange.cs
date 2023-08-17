using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                sMessage = "사용자ID " ;
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

            #region <데이터베이스 연동 및 상태 체크>
            // 1. 데이터베이스 접속 주소 설정.
            

            
            #endregion



        }
    }
}
