using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Services
{
    // interface 형식인 IChildCommand의 멤버를 모두 구현한 툴
    public partial class BaseChildForm : Form, IChildCommand
    {
        // BaseChildForm
        // Interface를 상속받아 필수로 입력해야하는 메서드의 기능을 모두 정의해놓고, 
        // 시스템 개발에 사용되는 Form의 틀을 정의하는 역할 
        // 공통 툴바의 기능 메서드를 상속해주는 역할을 한다. 
        public BaseChildForm()
        {
            InitializeComponent();
        }


        // virtual
        // 상속받은 메서드에서 기능을 재정의할 수 있도록 해주는 키워드.
        // 구현을 해도 되고, 안해도 상관없는 선택적.
        public virtual void DoDelete()
        {
            
        }

        public virtual void DoInquire()
        {

        }

        public virtual void DoNew()
        {

        }

        public virtual void DoSave()
        {

        }
    }
}
