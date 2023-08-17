using Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FormList
{
    public partial class UserMaster : Form
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


        public UserMaster()
        {
            InitializeComponent();
        }

        private void UserMaster_Load(object sender, EventArgs e)
        {

            #region < UserMaster 폼이 Load 될 때, GridView에 기본적으로 나올 값 셋팅.>
            dtGrid.Columns.Add("USERID", typeof(string));
            dtGrid.Columns.Add("USERNAME", typeof(string));
            dtGrid.Columns.Add("PW", typeof(string));
            dtGrid.Columns.Add("COUNT", typeof(string));
            dtGrid.Columns.Add("DEPTCODE", typeof(string));
            dtGrid.Columns.Add("MAKEDATE", typeof(string));
            dtGrid.Columns.Add("MAKER", typeof(string));
            dtGrid.Columns.Add("EDITDATE", typeof(string));
            dtGrid.Columns.Add("EDITOR", typeof(string));

            dgtView.DataSource = dtGrid;

            dgtView.Columns["UserID"].HeaderText = "사용자ID";
            dgtView.Columns["USERNAME"].HeaderText = "사용자명";
            dgtView.Columns["PW"].HeaderText = "비밀번호";
            dgtView.Columns["COUNT"].HeaderText = "실패횟수";
            dgtView.Columns["DEPTCODE"].HeaderText = "부서";
            dgtView.Columns["MAKEDATE"].HeaderText = "등록일시";
            dgtView.Columns["MAKER"].HeaderText = "등록자";
            dgtView.Columns["EDITDATE"].HeaderText = "수정일시";
            dgtView.Columns["EDITOR"].HeaderText = "수정자";

            dgtView.Columns["MAKEDATE"].ReadOnly = true;
            dgtView.Columns["MAKER"].ReadOnly = true;
            dgtView.Columns["EDITDATE"].ReadOnly = true;
            dgtView.Columns["EDITOR"].ReadOnly = true;
            #endregion

            #region<cmbDept (콤보박스에) 데이터 할당하기 ..>
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
                cmbDept.DataSource = dtTemp;
                cmbDept.ValueMember = "CODE";
                cmbDept.DisplayMember = "CODE_NAME";
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

        /// <summary>
        /// btnSearch_Click 메서드가 private이므로 Mainform에서 사용하기 위해 만들어둔 클래스.
        /// </summary>
        public void DoInquire()
        {
            btnSearch_Click(null, null);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            #region < 사용자ID, 사용자이름, 부서정보를 입력받아 조회버튼을 통하여 조회 후 GridView에 표현. >
            // 그리드의 행을 선택시 이미지뷰어에 선택된 사용자의 이미지를 나타낸다. 
            try
            {
                OpenConnect();


                string sUserID = txtUserId.Text;
                string sUserName = txtUserName.Text;
                string sDept = Convert.ToString(cmbDept.SelectedValue);

                string sSqlSelect = string.Empty;
                sSqlSelect = "  SELECT USERID                        ";
                sSqlSelect += "        ,PW                           ";
                sSqlSelect += "        ,COUNT                        ";
                sSqlSelect += "        ,DEPTCODE                     ";
                sSqlSelect += "        ,MAKEDATE                     ";
                sSqlSelect += "        ,MAKER                        ";
                sSqlSelect += "        ,EDITDATE                     ";
                sSqlSelect += "        ,EDITOR                       ";
                sSqlSelect += "    FROM TB_User                      ";
                sSqlSelect += $"   WHERE USERID   = '{sUserID}'      ";
                sSqlSelect += $"     AND USERNAME = '{sUserName}'    ";
                sSqlSelect += $"     AND DEPTCODE LIKE '%{sDept}%'   ";

                adapter = new SqlDataAdapter(sSqlSelect, sCon);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count == 0)
                {
                    ((DataTable)dgtView.DataSource).Rows.Clear();
                    MessageBox.Show("조회조건에 맞는 데이터가 없습니다.");
                    return;
                }

                dgtView.DataSource = dtTemp;

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

        private void dgtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region < 그리드뷰에 셀을 클릭했을 때 그 품목에 해당하는 이미지를 픽쳐박스에 띄워주기 >

            string sUserId = Convert.ToString(dgtView.CurrentRow.Cells["USERID"].Value);
            try
            {
                OpenConnect();

                string sSelect = $" SELECT USERIMAGE FROM TB_User WHERE USERID = '{sUserId}'";
                adapter = new SqlDataAdapter(sSelect, sCon);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count == 0)
                {
                    picBox1.Image = null;
                    return;
                }
                if (Convert.ToString(dtTemp.Rows[0]["USERIMAGE"]) == "")
                {
                    picBox1.Image = null;
                    return;
                }

                Byte[] bImages = (byte[])dtTemp.Rows[0]["USERIMAGE"];
                if (bImages == null)
                {
                    MessageBox.Show("이미지 형식으로 변형할 수 없는 데이터가 등록되어있습니다.");
                    return;
                }
                
                picBox1.Image = new Bitmap(new MemoryStream(bImages));

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region < 그리드에 새로운 행 추가 >

            DataRow dr = ((DataTable)dgtView.DataSource).NewRow();
            ((DataTable)dgtView.DataSource).Rows.Add(dr);
            
            #endregion
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            #region < 데이터 삭제버튼 클릭시 실행되는 로직>
            if ( dgtView.Rows.Count == 0)
            {
                return;
            }

            // 삭제 여부 물어보기
            if(MessageBox.Show("데이터를 삭제할까요?", "데이터 삭제", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // 데이터 삭제 로직 실행.
            try
            {
                string sitemcode = dgtView.CurrentRow.Cells["USERID"].Value.ToString();
                
                OpenConnect();
                sTran = sCon.BeginTransaction();

                Command.Transaction = sTran;
                Command.Connection = sCon;

                Command.CommandText = $"DELETE TB_User WHERE USERID = '{sitemcode}'";

                Command.ExecuteNonQuery();

                sTran.Commit();
                MessageBox.Show("데이터 삭제가 완료되었습니다.");
                btnSearch_Click(null, null);

            }
            catch(Exception ex) 
            {
                Err(ex); 
            }
            finally
            {
                EndConnect();
            }
            #endregion
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            #region < 데이터 저장 버튼 클릭시 실행되는 로직 >
            // 선택된 행의 데이터를 저장하는데, 셀이 변경되어서 Update를 해야하는지, 행이 추가되어서 Insert를 해야하는지 판단해야한다..
            
            if (dgtView.Rows.Count == 0)
            {
                return;
            }

            // 등록 또는 수정될 데이터를 변수에 할당.
            // txtUserId, txtUserName, cmbDept값, ... + a (작성중..)

            #endregion
        }
    }
}
