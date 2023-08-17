using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormList
{
    public partial class UserMaster_T : Services.BaseChildForm
    {
        #region < 클래스 내부에서 공용으로 사용하는 메서드들>
        public void Err(object ex)
        {
            MessageBox.Show(ex.ToString());
        }
        public void EndConnect()
        {
            if (sCon.State == ConnectionState.Open)
            {
                sCon.Close();
            }
        }
        public void OpenConnect()
        {
            if (sCon.State == ConnectionState.Closed)
            {
                sCon.Open();
            }

        }
        #endregion

        #region < 필드 멤버 변수 >
        SqlConnection sCon = new SqlConnection(Commons.strCon);
        SqlDataAdapter adapter;
        DataTable dtGrid = new DataTable();     // 그리드 세팅을 위한 DataTable 생성.
        SqlCommand Command = new SqlCommand();  // ExecuteNonQuery를 실행할 커맨드객체 생성.
        SqlTransaction sTran;


        #endregion
        public UserMaster_T()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserMaster_T_Load(object sender, EventArgs e)
        {
            GridUtil _gridUtil = new GridUtil();
            _gridUtil.InitColumnGridUtil(Grid1, "USERID"   ,"사용자ID"   ,typeof(string)  , 100, true , true);
            _gridUtil.InitColumnGridUtil(Grid1, "USERNAME" ,"사용자명"   ,typeof(string)  , 150, true , true);
            _gridUtil.InitColumnGridUtil(Grid1, "PW"       ,"비밀번호"   ,typeof(string)  , 100, true , true);
            _gridUtil.InitColumnGridUtil(Grid1, "COUNT"    ,"오류횟수"   ,typeof(string)  , 100, true , true);
            _gridUtil.InitColumnGridUtil(Grid1, "DEPTCODE" ,"관리부서"   ,typeof(string)  , 150, true , true);
            _gridUtil.InitColumnGridUtil(Grid1, "MAKEDATE" ,"생성일시"   ,typeof(DateTime), 200, false, true);
            _gridUtil.InitColumnGridUtil(Grid1, "MAKER"    ,"생성자"     ,typeof(string)  , 150, false, true);
            _gridUtil.InitColumnGridUtil(Grid1, "EDITDATE" ,"수정일시"   ,typeof(DateTime), 200, false, true);
            _gridUtil.InitColumnGridUtil(Grid1, "EDITOR"   ,"수정자"     ,typeof(string)  , 150, false, true);



            #region <cboDept(콤보박스)에 데이터 할당하기 ..>
            try
            {
                OpenConnect();
                string sSqlSelect = string.Empty;
                sSqlSelect = " SELECT ''                           AS CODE        ";
                sSqlSelect += "        ,'전체조회'                        AS CODE_NAME   ";
                sSqlSelect += "    FROM TB_User                                          ";
                sSqlSelect += "    UNION                                                 ";
                sSqlSelect += "    SELECT MINORCODE                       AS CODE        ";
                sSqlSelect += "    	   ,'[' + MINORCODE + ']' + CODENAME  AS CODE_NAME   ";
                sSqlSelect += "      FROM TB_Standard                                    ";
                sSqlSelect += "     WHERE MAJORCODE = 'DEPTCODE'                         ";
                sSqlSelect += "       AND MINORCODE<> '$'                                ";

                adapter = new SqlDataAdapter(sSqlSelect, sCon);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);
                cboDept.DataSource = dtTemp;
                cboDept.ValueMember = "CODE";
                cboDept.DisplayMember = "CODE_NAME";
            }
            catch (Exception ex)
            {
                Err(ex);
            }
            finally
            {
                EndConnect();
            }
            #endregion
        }
    }
}
