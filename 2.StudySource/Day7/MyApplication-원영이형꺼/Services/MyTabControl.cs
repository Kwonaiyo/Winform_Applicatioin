using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Services
{
    // 사용자 정의 컨트롤 생성
    public class MyTabControl : MetroTabControl
    {
        /* 클래스 상속을 통한 사용자 정의 컨트롤 생성
         * TabControl의 모든 기능을 상속받고
         * 새로운 기능을 추가할 수 있다. */

        /// <summary>
        /// 탭 컨트롤에 폼 클래스를 탭 페이지에 추가하는 메서드
        /// </summary>
        /// <param name="NewForm"></param>
        public void AddForm(Form NewForm)
        {
            if (NewForm == null) return;    // 인자로 받은 폼이 없을 경우 리턴
            NewForm.TopLevel = false;       // 추가로 호출되는 화면이 뒤에 표시되도록 첫 페이지 고정하지 않음
            TabPage myPage = new TabPage(); // 폼을 담을 탭페이지 객체 생성

            myPage.Controls.Clear();        // 탭페이지 방청소
            myPage.Controls.Add(NewForm);   // 페이지에 폼 추가
            myPage.Text = NewForm.Text;     // 페이지의 제목을 폼의 Text로 설정
            myPage.Name = NewForm.Name;     // 페이지의 고유 명칭 설정

            base.TabPages.Add(myPage);      // 탭컨트롤의 페이지를 추가
            NewForm.Show();                 // 화면에 출력
            base.SelectedTab = myPage;      // 추가한 페이지를 활성화해서 보이게 함
        }
    }
}
