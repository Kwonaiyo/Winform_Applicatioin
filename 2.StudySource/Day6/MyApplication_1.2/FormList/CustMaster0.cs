using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Services;


namespace FormList
{
    public partial class CustMaster0 : Services.BaseChildForm
    {
        #region < 필드 멤버 변수 >
        SqlConnection sCon = new SqlConnection(Commons.strCon);
        SqlDataAdapter adapter;
        DataTable dtGrid = new DataTable();
        SqlCommand Command = new SqlCommand();
        SqlTransaction sTran;

        #endregion

        #region < 클래스 내부에서 공용으로 사용하는 메서드들 >
        public void Err(object ex)
        {
            MessageBox.Show(ex.ToString());
        }
        public void EndConnect()
        {
            if(sCon.State == ConnectionState.Open)
            {
                sCon.Close();
            }
        }
        public void OpenConnect()
        {
            if(sCon.State == ConnectionState.Closed)
            {
                sCon.Open();
            }
        }




        #endregion
        public CustMaster0()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustMaster0_Load(object sender, EventArgs e)
        {
            GridUtil _gridUtil = new GridUtil();
            _gridUtil.InitColumnGridUtil(grid1, "CUSTTYPE", "거래처구분", typeof(string), DataGridViewContentAlignment.MiddleLeft, 100, true, true);
            _gridUtil.InitColumnGridUtil(grid1, "CUSTCODE"  , "거래처코드"    , typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 100, true, true);
            _gridUtil.InitColumnGridUtil(grid1, "CUSTNAME"  , "거래처명"      , typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 100, true, true);
            _gridUtil.InitColumnGridUtil(grid1, "BIZREQNO"  , "사업자등록번호", typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 100, true, true);
            _gridUtil.InitColumnGridUtil(grid1, "BIZADDRESS", "주소"          , typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 100, true, true);
            _gridUtil.InitColumnGridUtil(grid1, "PHONE"     , "전화번호"      , typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 100, true, true);
            _gridUtil.InitColumnGridUtil(grid1, "OWNERNAME" , "대표자"        , typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 100, true, true);
            _gridUtil.InitColumnGridUtil(grid1, "MAKEDTAE"  , "생성일시"      , typeof(DateTime), DataGridViewContentAlignment.MiddleCenter, 100, true, false);
            _gridUtil.InitColumnGridUtil(grid1, "MAKER"     , "생성자"        , typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 100, true, false);
            _gridUtil.InitColumnGridUtil(grid1, "EDITDATE"  , "수정일시"      , typeof(DateTime), DataGridViewContentAlignment.MiddleCenter, 100, true, false);
            _gridUtil.InitColumnGridUtil(grid1, "EDITOR"    , "수정자"        , typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 100, true, false);


            // 콤보박스(cboCusttype)에 데이터 할당.
            Commons.GetCombo_Standard("DEPTCODE", CboDept);
        }
    }
}
