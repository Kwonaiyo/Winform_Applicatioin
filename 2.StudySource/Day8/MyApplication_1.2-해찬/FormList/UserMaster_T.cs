using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormList
{
    public partial class UserMaster_T : Services.BaseChildForm
    {
        public UserMaster_T()
        {
            InitializeComponent();
        }

        public override void DoInquire()
        {
            base.DoInquire();   // base는 나한테 상속해준 녀석임(BaseChildForm)
            // 사용자 마스터 테이블의 내용을 조회하는 로직이 들어갈 수 있음.
            MessageBox.Show("반갑습니다.");
        }
        public override void DoNew()
        {
            base.DoNew();
        }
        public override void DoSave()
        {
            base.DoSave();
        }
        public override void DoDelete()
        {
            base.DoDelete();
        }
    }
}
