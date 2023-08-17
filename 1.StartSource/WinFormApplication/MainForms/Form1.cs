using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///  버튼 btnHello를 클릭할 때
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHello_Click(object sender, EventArgs e)
        {
            // 2. 텍스트박스 txtName에 있는 text 속성의 값을 받아서.
            string sName = txtName.Text;

            // 3. 메세지로 출력하라. ??님 반갑습니다.

            MessageBox.Show($"{sName}님 반갑습니다.");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
