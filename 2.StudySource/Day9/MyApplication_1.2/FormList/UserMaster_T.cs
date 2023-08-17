using Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

                Commons.SetGridComboBox(Grid1, "DEPTCODE", "DEPTCODE");

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

        public override void Add()
        {
            // Heap영역에 있는 그리드 DataSource의 행 정보를 가지고 신규 행을 생성한다. 
            DataRow dr = ((DataTable)Grid1.DataSource).NewRow();
            ((DataTable)Grid1.DataSource).Rows.Add(dr);

            // 신규 행 추가 후 부서 선택 콤보박스 등록.
            Commons.SetGridComboBox(Grid1, "DEPTCODE", "DEPTCODE", false);
        }


        public override void DoDelete()
        {
            // 삭제버튼 클릭시 로직.
            if (Grid1.Rows.Count == 0) 
            { return; }
            int iRowsIndex = Grid1.CurrentRow.Index;        // 현재 선택한 행의 인덱스를 iRowsIndex에 할당

            // Heap 영역에 있는 그리드의 데이터 속성을 DataTable로 전달.
            DataTable dtTemp = (DataTable)Grid1.DataSource;
            // dtTemp.Rows.RemoveAt(iRowsIndex);               // RemoveAt - 원본 Source를 통째로 삭제 --> 삭제된 상태를 확인할 수 없다. 
            dtTemp.Rows[iRowsIndex].Delete();                  // 선택한 행의 디스플레이 인덱스만 삭제 --> 삭제된 데이터를 확인할 수 있다.
        }

        public override void DoSave()
        {
            // 저장 버튼 클릭시 일괄 저장 및 일괄 롤백.

            // 1, DataBase Open / Transaction 선언
            DBHelper helper = new DBHelper(true);
            try
            {
                // 2. 그리드에 조회 이후 변경된 이력이 있는지 확인 및 변경 내역 리스트 추출.
                DataTable dtTemp = ((DataTable)Grid1.DataSource).GetChanges();
                if (dtTemp.Rows.Count == 0)
                { return; }

                // 3. 커맨드 객체 생성
                SqlCommand Com = new SqlCommand();
                // 3-1. 트랜잭션 연결
                Com.Transaction = helper.Tran;
                // 3-2. 접속정보 연결
                Com.Connection = helper.sCon;
                // 3-3. 저장 프로시저 형태로 연결하는것을 선언
                Com.CommandType = CommandType.StoredProcedure;

                string sMessage = string.Empty;
                string sRsCode  = string.Empty;     // 데이터베이스에서 받아온 성공여부
                string sMsg     = string.Empty;     // 데이터베이스 메세지

                foreach (DataRow dr in dtTemp.Rows)
                {
                    switch(dr.RowState)
                    {
                        case DataRowState.Deleted:      // 행이 삭제된경우
                            dr.RejectChanges();     // 지워진 행의 데이터를 복구

                            Com.CommandText = "SP_UserMaster_D1";   // 프로시져 명
                            Com.Parameters.AddWithValue("@USERID", dr["USERID"]);

                            Com.Parameters.AddWithValue("@LANG", "");
                            Com.Parameters.AddWithValue("@RS_CODE", "").Direction = ParameterDirection.Output;
                            Com.Parameters.AddWithValue("@RS_MSG", "").Direction = ParameterDirection.Output;

                            Com.ExecuteNonQuery();
                            break;

                        case DataRowState.Added:        // 행이 추가된경우
                            
                            if (dr["USERID"] == "")
                            { sMessage = "사용자ID "; }
                            if (dr["PW"] == "")
                            { sMessage += "비밀번호"; }
                            
                            if (sMessage != "")
                            {
                                helper.Rollback();
                                MessageBox.Show($"{sMessage}를 입력하지 않았습니다.");
                                return;
                            }
                            
                            Com.CommandText = "SP_UserMaster_I1";

                            Com.Parameters.AddWithValue("@USERID",   dr["USERID"]);
                            Com.Parameters.AddWithValue("@USERNAME", dr["USERNAME"]);
                            Com.Parameters.AddWithValue("@PW",       dr["PW"]);
                            Com.Parameters.AddWithValue("@COUNT",    Convert.ToString(dr["COUNT"]) == "" ? 0 : dr["COUNT"]);
                            Com.Parameters.AddWithValue("@DEPTCODE", dr["DEPTCODE"]);
                            Com.Parameters.AddWithValue("@MAKER",    Commons.UserId);

                            Com.Parameters.AddWithValue("@LANG",     "");
                            Com.Parameters.AddWithValue("@RS_CODE",  "").Direction = ParameterDirection.Output;
                            Com.Parameters.AddWithValue("@RS_MSG",   "").Direction = ParameterDirection.Output;

                            Com.ExecuteNonQuery();
                            break;

                        case DataRowState.Modified:     // 행이 수정된경우
                           
                            if (dr["USERID"] == "")
                            { sMessage = "사용자ID "; }
                            if (dr["PW"] == "")
                            { sMessage += "비밀번호"; }

                            if (sMessage != "")
                            {
                                helper.Rollback();
                                MessageBox.Show($"{sMessage}를 입력하지 않았습니다.");
                                return;
                            }

                            Com.CommandText = "SP_UserMaster_U1";

                            Com.Parameters.AddWithValue("@USERID",   dr["USERID"]);
                            Com.Parameters.AddWithValue("@USERNAME", dr["USERNAME"]);
                            Com.Parameters.AddWithValue("@PW",       dr["PW"]);
                            Com.Parameters.AddWithValue("@COUNT",    Convert.ToString(dr["COUNT"]) == "" ? 0 : dr["COUNT"]);
                            Com.Parameters.AddWithValue("@DEPTCODE", dr["DEPTCODE"]);
                            Com.Parameters.AddWithValue("@EDITOR",   Commons.UserId);

                            Com.Parameters.AddWithValue("@LANG", "");
                            Com.Parameters.AddWithValue("@RS_CODE", "").Direction = ParameterDirection.Output;
                            Com.Parameters.AddWithValue("@RS_MSG", "").Direction  = ParameterDirection.Output;

                            Com.ExecuteNonQuery();
                            break;
                    }
                    sRsCode = Convert.ToString(Com.Parameters["@RS_CODE"].Value);
                    sMsg    = Convert.ToString(Com.Parameters["@RS_MSG"].Value);
                    

                    if(sRsCode != "S")
                    {
                        //helper.Rollback();
                        //MessageBox.Show(sMsg);
                        //return;

                        throw new Exception(sMsg);
                    }
                    Com.Parameters.Clear();
                }

                helper.Commit();
                MessageBox.Show("정상적으로 저장되었습니다.");
            }
            catch(Exception ex)
            {
                helper.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                helper.Close();
            }
        }

    }

}
