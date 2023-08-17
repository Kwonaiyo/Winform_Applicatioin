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
            dtGrid.Columns.Add("USERID"  , typeof(string));
            dtGrid.Columns.Add("USERNAME", typeof(string));
            dtGrid.Columns.Add("PW"      , typeof(string));
            dtGrid.Columns.Add("COUNT"   , typeof(string));
            dtGrid.Columns.Add("DEPTCODE", typeof(string));
            dtGrid.Columns.Add("MAKEDATE", typeof(string));
            dtGrid.Columns.Add("MAKER"   , typeof(string));
            dtGrid.Columns.Add("EDITDATE", typeof(string));
            dtGrid.Columns.Add("EDITOR"  , typeof(string));

            dgtView.DataSource = dtGrid;

            dgtView.Columns["UserID"].HeaderText   = "사용자ID";
            dgtView.Columns["USERNAME"].HeaderText = "사용자명";
            dgtView.Columns["PW"].HeaderText       = "비밀번호";
            dgtView.Columns["COUNT"].HeaderText    = "실패횟수";
            dgtView.Columns["DEPTCODE"].HeaderText = "부서";
            dgtView.Columns["MAKEDATE"].HeaderText = "등록일시";
            dgtView.Columns["MAKER"].HeaderText    = "등록자";
            dgtView.Columns["EDITDATE"].HeaderText = "수정일시";
            dgtView.Columns["EDITOR"].HeaderText   = "수정자";

            dgtView.Columns["MAKEDATE"].ReadOnly = true;
            dgtView.Columns["MAKER"].ReadOnly    = true;
            dgtView.Columns["EDITDATE"].ReadOnly = true;
            dgtView.Columns["EDITOR"].ReadOnly   = true;
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
                sSqlSelect =  "  SELECT USERID                        ";
                sSqlSelect += "        ,USERNAME                      ";
                sSqlSelect += "        ,PW                            ";
                sSqlSelect += "        ,COUNT                         ";
                sSqlSelect += "        ,DEPTCODE                      ";
                sSqlSelect += "        ,MAKEDATE                      ";
                sSqlSelect += "        ,MAKER                         ";
                sSqlSelect += "        ,EDITDATE                      ";
                sSqlSelect += "        ,EDITOR                        ";
                sSqlSelect += "    FROM TB_User                       ";
                sSqlSelect += $"   WHERE USERID   LIKE '%{sUserID}%'  ";
                sSqlSelect += $"     AND USERNAME LIKE '%{sUserName}%'";
                sSqlSelect += $"     AND DEPTCODE LIKE '%{sDept}%'    ";

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
                string sUserId = dgtView.CurrentRow.Cells["USERID"].Value.ToString();
                
                OpenConnect();
                sTran = sCon.BeginTransaction();

                Command.Transaction = sTran;
                Command.Connection = sCon;

                Command.CommandText = $"DELETE TB_User WHERE USERID = '{sUserId}'";

                Command.ExecuteNonQuery();

                sTran.Commit();
                MessageBox.Show("데이터 삭제가 완료되었습니다.");
                btnSearch_Click(null, null);

            }
            catch(Exception ex) 
            {
                sTran.Rollback();
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
            //// 선택된 행의 데이터를 저장하는데, 셀이 변경되어서 Update를 해야하는지, 행이 추가되어서 Insert를 해야하는지 판단해야한다..

            //if (dgtView.Rows.Count == 0)
            //{
            //    return;
            //}

            //if (MessageBox.Show("변경사항을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    return;
            //}

            //// 저장버튼 클릭시 일괄적으로 저장 또는 롤백이 되어야한다.. -> 데이터의 일관성 ...

            //// 등록 또는 수정될 데이터들
            //string sUserId   = Convert.ToString(dgtView.CurrentRow.Cells["USERID"].Value);
            //string sUsername = Convert.ToString(dgtView.CurrentRow.Cells["USERNAME"].Value);
            //string sDeptcode = Convert.ToString(dgtView.CurrentRow.Cells["DEPTCODE"].Value);
            //string sPassword = Convert.ToString(dgtView.CurrentRow.Cells["PW"].Value);
            //string sCount    = Convert.ToString(dgtView.CurrentRow.Cells["COUNT"].Value);

            //// 필수 입력값 체크
            //string sMessage = string.Empty;
            //if (sUserId == "")
            //{
            //    sMessage += "ID ";
            //}
            //if (sUsername == "")
            //{
            //    sMessage += "사용자명 ";
            //}    
            //if (sPassword == "")
            //{
            //    sMessage += "비밀번호 ";
            //}
            //if (sMessage != "")
            //{
            //    MessageBox.Show($"{sMessage}을(를) 입력하지 않았습니다!");
            //    return;
            //}

            //// 데이터베이스 오픈 및 트랜잭션 선언하기
            //OpenConnect();
            //try
            //{
            //    // insert/update 판단 -> DB에 등록된 USERID인지 조회
            //    string sSearch = $"SELECT * FROM TB_User WHERE USERID = '{sUserId}'";
            //    adapter = new SqlDataAdapter(sSearch, sCon);
            //    DataTable dtTemp = new DataTable();
            //    adapter.Fill(dtTemp);
            //    sTran = sCon.BeginTransaction();

            //    if (dtTemp.Rows.Count != 0)     // 불러온 행이 0이 아니면 일치하는 USERID가 있다 -> UPDATE
            //    {
            //        string sUpdate  =  "UPDATE TB_User                      ";
            //               sUpdate += $"   SET USERNAME = '{sUsername}'     ";
            //               sUpdate += $"      ,PW       = '{sPassword}'     ";
            //               sUpdate += $"      ,COUNT    = '{sCount}'        ";
            //               sUpdate += $"      ,DEPTCODE = '{sDeptcode}'     ";
            //               sUpdate += $"      ,EDITDATE = GETDATE()         ";
            //               sUpdate += $"      ,EDITOR   = '{Commons.UserId}'";
            //               sUpdate += $" WHERE USERID   = '{sUserId}'       ";
            //        Command.Transaction = sTran;
            //        Command.CommandText = sUpdate;
            //        Command.Connection  = sCon;

            //        Command.ExecuteNonQuery();
            //    }
            //    else     // INSERT
            //    {
            //        string sInsert = string.Empty;
            //        sInsert += " INSERT INTO TB_User (USERID     ,  USERNAME    ,  PW ,           COUNT    ,  DEPTCODE    , MAKEDATE ,  MAKER) ";
            //        sInsert += $"             VALUES ('{sUserId}', '{sUsername}', '{sPassword}', '{sCount}', '{sDeptcode}', GETDATE(), '{Commons.UserId}') ";

            //        Command.Transaction = sTran;
            //        Command.Connection  = sCon;
            //        Command.CommandText = sInsert;

            //        Command.ExecuteNonQuery();
            //    }

            //    sTran.Commit();
            //    MessageBox.Show("정상적으로 등록을 완료하였습니다.");
            //    btnSearch_Click(null, null);

            //}
            //catch (Exception ex)
            //{
            //    sTran.Rollback();
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    EndConnect();
            //}


            #endregion

        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            // 파일탐색기를 통해 원하는 이미지를 가져와 픽쳐박스에 표현.
            if(dgtView.Rows.Count == 0)
            {
                return;
            }

            string sFilePath = string.Empty;   // 파일 경로를 담을 변수.

            // 파일탐색기 호출
            OpenFileDialog Dialog = new OpenFileDialog();

            if (Dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // 파일의 경로 받아오기
            sFilePath = Dialog.FileName;    // 선택한 파일의 물리적 위치 경로를 포함.
            picBox1.Tag = sFilePath;        // Tag에 이미지 경로 저장..
            picBox1.Image = Bitmap.FromFile(sFilePath);     // 이미지 파일을 bitmap으로 변경하여 image에 등록.
        }

        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            // 픽처박스에 등록된 이미지를 데이터베이스에 저장.
            if (dgtView.Rows.Count == 0)
            {
                return;
            }
            if (picBox1.Image == null)
            {
                return;
            }
            if (Convert.ToString(picBox1.Tag) == "")
            {
                return;
            }

            if (MessageBox.Show("선택한 이미지를 품목이미지로 등록하시겠습니까?", "이미지 등록", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // 이미지파일 등록 로직.
            try
            {
                // 이미지파일을 파일스트림으로 메모리에 등록 후 Byte[] 배열로 변경...
                FileStream stream = new FileStream(Convert.ToString(picBox1.Tag), FileMode.Open, FileAccess.Read);

                BinaryReader reader = new BinaryReader(stream); // 이진데이터로 바이너리 데이터를 램으로 가져올때..

                Byte[] bImage = reader.ReadBytes(Convert.ToInt32(stream.Length));   // 이진데이터를 Byte형식으로 RAM에 패킹

                // 데이터를 메모리에 등록 완료했으므로 바이너리 리더와 파일스트림을 종료시켜준다..
                reader.Close();
                stream.Close();

                // 데이터베이스에 저장 시작(bImage)
                // 이미지가 등록될 품목의 정보 가져오기.
                string sUserId = Convert.ToString(dgtView.CurrentRow.Cells["USERID"].Value);

                // 데이터베이스 오픈.
                OpenConnect();
                sTran = sCon.BeginTransaction();

                // SQL구문
                string sUpdate =  " UPDATE TB_User " ;
                       sUpdate += "    SET USERIMAGE = @ITEMIMAGE ";
                       sUpdate += $" WHERE USERID    = '{sUserId}'";

                Command.Parameters.Clear();
                Command.CommandText = sUpdate;
                Command.Parameters.Add("@ITEMIMAGE", bImage);
                Command.Transaction = sTran;
                Command.Connection  = sCon;

                Command.ExecuteNonQuery();

                sTran.Commit();
                MessageBox.Show("정상적으로 등록을 완료하였습니다.");
                dgtView_CellClick(null, null);
            }
            catch(Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                EndConnect();
            }
        }

        private void btnDeleteImg_Click(object sender, EventArgs e)
        {
            // 이미지 컬럼을 NULL 처리하도록 UPDATE
            if (dgtView.Rows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("선택한 품목의 이미지를 삭제하시겠습니까?", "이미지삭제", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string sUserId = Convert.ToString(dgtView.CurrentRow.Cells["USERID"].Value);
            string sDelete = $"UPDATE TB_User SET USERIMAGE = NULL WHERE USERID = '{sUserId}'";
            
            OpenConnect();
            try
            {
                sTran = sCon.BeginTransaction();
                Command.Transaction = sTran;
                Command.Connection = sCon;
                Command.CommandText = sDelete;

                Command.ExecuteNonQuery();

                sTran.Commit();
                MessageBox.Show("삭제가 완료되었습니다.");
                dgtView_CellClick(null, null);
            }
            catch(Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                EndConnect();
            }
            
        }
    }
}
