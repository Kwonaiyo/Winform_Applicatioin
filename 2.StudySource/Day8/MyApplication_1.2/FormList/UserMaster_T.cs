using Services;
using System;
using System.Data;
using System.Data.SqlClient;
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
            _gridUtil.InitColumnGridUtil(Grid1, "USERID"  , "사용자ID", typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 100, true, true);
            _gridUtil.InitColumnGridUtil(Grid1, "USERNAME", "사용자명", typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 150, true, true);
            _gridUtil.InitColumnGridUtil(Grid1, "PW"      , "비밀번호", typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 100, true, true);
            _gridUtil.InitColumnGridUtil(Grid1, "COUNT"   , "오류횟수", typeof(string)  , DataGridViewContentAlignment.MiddleRight , 100, true, true);
            _gridUtil.InitColumnGridUtil(Grid1, "DEPTCODE", "관리부서", typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 150, true, true);
            _gridUtil.InitColumnGridUtil(Grid1, "MAKEDATE", "생성일시", typeof(DateTime), DataGridViewContentAlignment.MiddleCenter, 200, false, true);
            _gridUtil.InitColumnGridUtil(Grid1, "MAKER"   , "생성자"  , typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 150, false, true);
            _gridUtil.InitColumnGridUtil(Grid1, "EDITDATE", "수정일시", typeof(DateTime), DataGridViewContentAlignment.MiddleCenter, 200, false, true);
            _gridUtil.InitColumnGridUtil(Grid1, "EDITOR"  , "수정자"  , typeof(string)  , DataGridViewContentAlignment.MiddleLeft  , 150, false, true);


            #region <cboDept(콤보박스)에 데이터 할당하기 ..>
            Commons.GetCombo_Standard("DEPTCODE", cboDept);
            #endregion
        }

        /* 메서드 오버라이딩
         * Virtual로 상송하 메서드를 각 화면에 맞는 기능으로 변경하여 재정의하고 구현하는 방식.
         * 상속을 준 클래스의 메서드를 호출할 경우 해당 클래스의 메서드도 동시에 실행되도록 연결해주는 방식.
         * 
         * base.DoInquire()를 실행하지 않으면 상위 클래스의 DoInquire() 메서드는 실행되지 않는다. 
         */
        public override void DoInquire()
        {
            // base.DoInquire(); -- BaseChildForm의 DoInquire()를 실행.

            // 저장 프로시저를 사용한 조회 로직
            /* 저장 프로시저
             *   1. 데이터베이스에 쿼리를 등록해두어서 로그인하지 않으면 확인할 수 없다. (보안성)
             *   2. 등록해 둔 쿼리를 저장프로시저 명으로 호출함으로서 재사용성이 증가한다.
             *   3. 프로시저를 한번 호출하면 메모리에 내역이 남아있어서 후속 호출 시 리소스가 줄어든다.
             *   4. 쿼리문을 소스에서 InQuery로 처리할 경우 네트워크 부하를 일으킬 수 있다. 
             */

            // 데이터베이스 접속
            DBHelper helper = new DBHelper();
            try
            {
                // 그리드에 표현되어 있는 데이터 삭제
                ((DataTable)Grid1.DataSource).Clear();

                //저장프로시저를 실행할 SqlAdatper를 선언.
                helper.Adapter = new SqlDataAdapter("SP_UserMaster_S1", Commons.strCon);

                // 저장 프로시저 형태로 실행하는 것을 설정.
                helper.Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                // Adapter가 프로시저에게 전달할 매개변수(파라메터) 등록.
                helper.Adapter.SelectCommand.Parameters.AddWithValue("@USERID", txtUserId.Text);
                helper.Adapter.SelectCommand.Parameters.AddWithValue("@USERNAME", txtUserName.Text);
                helper.Adapter.SelectCommand.Parameters.AddWithValue("@DEPTCODE", Convert.ToString(cboDept.SelectedValue));

                helper.Adapter.SelectCommand.Parameters.AddWithValue("@LANG", "");
                helper.Adapter.SelectCommand.Parameters.AddWithValue("@RS_CODE", "").Direction = ParameterDirection.Output;
                helper.Adapter.SelectCommand.Parameters.AddWithValue("@RS_MSG", "").Direction = ParameterDirection.Output;

                DataTable dttemp = new DataTable();
                helper.Adapter.Fill(dttemp);

                if (dttemp.Rows.Count == 0)
                {
                    MessageBox.Show("조회할 데이터가 없습니다.");
                    return;
                }
                // 그리드뷰에 데이터 삽입. 
                Grid1.DataSource = dttemp;

                #region <그리드 콤보박스 세팅(부서,DEPTCODE)>
                // 1. 그리드 콤보박스에 세팅할 관리부서 정보 가져오기. 
                DataTable dtTemp = Commons.GetCombo_Standard_Grid("DEPTCODE");

                // 2. 가져온 정보를 콤보박스화 해주기.
                if (dtTemp.Rows.Count == 0)
                { return; }
                for (int i = 0; i < Grid1.Rows.Count; i++)
                {
                    // Combobox유형의 셀을 생성.
                    DataGridViewComboBoxCell CellC = new DataGridViewComboBoxCell();
                    // 콤보박스 셀의 유형을 콤보박스로 선택.
                    CellC.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                    // 콤보박스에 데이터 등록
                    CellC.DataSource = dtTemp;
                    CellC.DisplayMember = "CODE_NAME";
                    CellC.ValueMember = "CODE";

                    // 생성한 콤보박스 유형의 그리드 콤보박스 컨트롤을 부서 컬럼에 매핑.
                    Grid1.Rows[i].Cells["DEPTCODE"] = CellC;

                }
               


                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                helper.Close();
            }

        }


    }

}
