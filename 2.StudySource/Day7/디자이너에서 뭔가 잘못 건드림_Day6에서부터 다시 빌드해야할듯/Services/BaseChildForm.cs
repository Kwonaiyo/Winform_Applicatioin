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
    public partial class BaseChildForm : Form, IChildCommand
    {
        public BaseChildForm()
        {
            InitializeComponent();
        }

        public void DoDelete()
        {
        }

        public void DoInquire()
        {
        }

        public void DoNew()
        {
        }

        public void DoSave()
        {
        }


    }
}
