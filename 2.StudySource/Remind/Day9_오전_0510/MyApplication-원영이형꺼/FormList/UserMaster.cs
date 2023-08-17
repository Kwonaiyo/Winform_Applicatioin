using MainForms;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*********************************
 * DATE   : 2023-05-04
 * AUTHOR : 
 * DESC   : 최초 프로그램 작성
 * 
 * DATE
 * EDITOR
 * DESC
 * 
 *********************************/
namespace FormList
{
    public partial class UserMaster : Form
    {
        #region < 필드 멤버 변수 >
        SqlConnection sCon = new SqlConnection(Commons.strCon);

        SqlDataAdapter Adapter;

        SqlCommand Command = new SqlCommand();
        SqlTransaction sTran;

        DataTable dtGrid = new DataTable();
        #endregion
        public UserMaster()
        {
            InitializeComponent();
        }
        private void DoOpenDB()
        { if (sCon.State == ConnectionState.Closed) sCon.Open(); }
        private void DoCloseDB()
        { if (sCon.State == ConnectionState.Open) sCon.Close(); }
        private void ExecuteNonQuery(string sSqlstring)
        {
            sTran = sCon.BeginTransaction();

            Command.Transaction = sTran;
            Command.Connection = sCon;
            Command.CommandText = sSqlstring;

            Command.ExecuteNonQuery();
            sTran.Commit();
        }
        private void UserMaster_Load(object sender, EventArgs e)
        {
            dtGrid.Columns.Add("USERID",   typeof(string));
            dtGrid.Columns.Add("USERNAME", typeof(string));
            dtGrid.Columns.Add("PW",       typeof(string));
            dtGrid.Columns.Add("PW_F_CNT", typeof(string));
            dtGrid.Columns.Add("DEPTCODE", typeof(string));
            dtGrid.Columns.Add("MAIL",     typeof(string));
            dtGrid.Columns.Add("ADDRESS",  typeof(string));
            dtGrid.Columns.Add("MAKEDATE", typeof(string));
            dtGrid.Columns.Add("MAKER",    typeof(string));
            dtGrid.Columns.Add("EDITDATE", typeof(string));
            dtGrid.Columns.Add("EDITOR",   typeof(string));

            dgtGrid.DataSource = dtGrid;

            dgtGrid.Columns["USERID"].HeaderText   = "사용자ID";
            dgtGrid.Columns["USERNAME"].HeaderText = "사용자명";
            dgtGrid.Columns["PW"].HeaderText       = "비밀번호";
            dgtGrid.Columns["PW_F_CNT"].HeaderText = "실패횟수";
            dgtGrid.Columns["DEPTCODE"].HeaderText = "부서";
            dgtGrid.Columns["MAIL"].HeaderText     = "이메일";
            dgtGrid.Columns["ADDRESS"].HeaderText  = "주소";
            dgtGrid.Columns["MAKEDATE"].HeaderText = "등록일시";
            dgtGrid.Columns["MAKER"].HeaderText    = "등록자";
            dgtGrid.Columns["EDITDATE"].HeaderText = "수정일시";
            dgtGrid.Columns["EDITOR"].HeaderText   = "수정자";

            dgtGrid.Columns["USERID"].Width   = 100;
            dgtGrid.Columns["USERNAME"].Width = 100;
            dgtGrid.Columns["DEPTCODE"].Width = 150;
            dgtGrid.Columns["MAIL"].Width     = 200;
            dgtGrid.Columns["ADDRESS"].Width  = 250;
            dgtGrid.Columns["MAKEDATE"].Width = 200;
            dgtGrid.Columns["EDITDATE"].Width = 200;

            dgtGrid.Columns["MAKEDATE"].ReadOnly = true;
            dgtGrid.Columns["MAKER"].ReadOnly    = true;
            dgtGrid.Columns["EDITDATE"].ReadOnly = true;
            dgtGrid.Columns["EDITOR"].ReadOnly   = true;

            try // 부서 콤보박스
            {
                DoOpenDB();

                string sSqlSelect = string.Empty;
                sSqlSelect += " SELECT ''                                 AS CODE_ID   ";
                sSqlSelect += "       ,'[ALL] 전체조회'                   AS CODE_NAME ";
                sSqlSelect += "  UNION                                                 ";
                sSqlSelect += "  SELECT MINORCODE AS CODE_ID                           ";
                sSqlSelect += "        ,'[' + MINORCODE + '] ' + CODENAME AS CODE_NAME ";
                sSqlSelect += "    FROM TB_Standard                                    ";
                sSqlSelect += "   WHERE MAJORCODE = 'DEPTCODE'                         ";
                sSqlSelect += "     AND MINORCODE<> '$'                                ";

                Adapter = new SqlDataAdapter(sSqlSelect, sCon);

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                cboDept.DataSource = dtTemp;
                cboDept.ValueMember = "CODE_ID";
                cboDept.DisplayMember = "CODE_NAME";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { DoCloseDB(); }
        }
        public void DoInquire()
        { btnSearch_Click(null, null); }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DoOpenDB();

                string sUserId = txtUserId.Text;
                string sUserName = txtUserName.Text;
                string sDeptCode = Convert.ToString(cboDept.SelectedValue);

                string sSqlSelect = string.Empty;
                sSqlSelect +=  " SELECT USERID                                  ";
                sSqlSelect +=  "	   ,USERNAME                                ";
                sSqlSelect +=  "	   ,PW                                      ";
                sSqlSelect +=  "	   ,PW_F_CNT                                ";
                sSqlSelect +=  "	   ,DEPTCODE                                ";
                sSqlSelect +=  "	   ,MAIL                                    ";
                sSqlSelect +=  "	   ,ADDRESS                                 ";
                sSqlSelect +=  "	   ,MAKEDATE                                ";
                sSqlSelect +=  "	   ,MAKER                                   ";
                sSqlSelect +=  "	   ,EDITDATE                                ";
                sSqlSelect +=  "	   ,EDITOR                                  ";
                sSqlSelect +=  "   FROM TB_User                                 ";
                sSqlSelect += $"  WHERE USERID LIKE '%{sUserId}%'               ";
                sSqlSelect += $"    AND USERNAME LIKE '%{sUserName}%'           ";
                sSqlSelect += $"    AND ISNULL(DEPTCODE,'') LIKE '%{sDeptCode}' ";

                Adapter = new SqlDataAdapter(sSqlSelect, sCon);
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count == 0)
                {
                    ((DataTable)dgtGrid.DataSource).Rows.Clear();
                    MessageBox.Show("조건에 맞는 데이터가 없다네");
                    return;
                }

                dgtGrid.DataSource = dtTemp;

                string sMessage = dgtGrid.Rows.Count + "행이 조회되었다네";

                MainForm.pu_MainForm.SetMessage(sMessage);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally { DoCloseDB(); }
        }

        private void btnRowAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = ((DataTable)dgtGrid.DataSource).NewRow();
            ((DataTable)dgtGrid.DataSource).Rows.Add(dr);
        }

        private void btnRowDelete_Click(object sender, EventArgs e)
        {
            if (dgtGrid.Rows.Count == 0) return;
            if (MessageBox.Show("행을 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                                                                        == DialogResult.No) return;
            try
            {
                DoOpenDB();

                string sUserId = dgtGrid.CurrentRow.Cells["USERID"].Value.ToString();
                string sDelete = $" DELETE FROM TB_USER WHERE USERID = '{sUserId}' ";

                ExecuteNonQuery(sDelete);

                MessageBox.Show("행이 삭제됐다네.");
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            { DoCloseDB(); }
        }

        private void btnRowSave_Click(object sender, EventArgs e)
        {
            if (dgtGrid.Rows.Count == 0) return;

            string sUserId   = Convert.ToString(dgtGrid.CurrentRow.Cells["USERID"].Value);
            string sUserName = Convert.ToString(dgtGrid.CurrentRow.Cells["USERNAME"].Value);
            string sPassWord = Convert.ToString(dgtGrid.CurrentRow.Cells["PW"].Value);
            string sDeptCode = Convert.ToString(dgtGrid.CurrentRow.Cells["DEPTCODE"].Value);
            string sMail     = Convert.ToString(dgtGrid.CurrentRow.Cells["MAIL"].Value);
            string sAddress  = Convert.ToString(dgtGrid.CurrentRow.Cells["ADDRESS"].Value);

            string sMessage = string.Empty;
            if (sUserId == "" && sUserName == "" && sPassWord == "") sMessage = "아이디와 이름, 비밀번호";
            else if (sUserId == "" && sUserName == "")   sMessage = "아이디와 이름";
            else if (sUserId == "" && sPassWord == "")   sMessage = "아이디와 비밀번호";
            else if (sUserName == "" && sPassWord == "") sMessage = "이름과 비밀번호";
            else if (sUserId == "") sMessage = "아이디";
            else if (sUserName == "") sMessage = "이름";
            else if (sPassWord == "") sMessage = "비밀번호";
            
            if (sMessage != "")
            {
                MessageBox.Show($"{sMessage}을(를) 입력해줘잉.");
                return;
            }
            if (MessageBox.Show("데이터를 저장하시겠습니까?", "데이터 갱신", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                DoOpenDB();

                string sSelect = $" SELECT * FROM TB_USER WHERE USERID = '{sUserId}' ";
                Adapter = new SqlDataAdapter(sSelect, sCon);
                dtGrid = new DataTable();
                Adapter.Fill(dtGrid);

                if (dtGrid.Rows.Count != 0)
                {
                    string sUpdate = string.Empty;
                    sUpdate +=  " UPDATE TB_User ";
                    sUpdate += $" SET USERNAME = '{sUserName}'      ";
                    sUpdate += $"    ,PW       = '{sPassWord}'      ";
                    sUpdate += $"    ,DEPTCODE = '{sDeptCode}'      ";
                    sUpdate += $"    ,MAIL     = '{sMail}'          ";
                    sUpdate += $"    ,ADDRESS  = '{sAddress}'       ";
                    sUpdate +=  "    ,EDITDATE =  REPLACE(CONVERT(VARCHAR(30),GETDATE(),120),'-','/') ";
                    sUpdate += $"    ,EDITOR   = '{Commons.UserId}' ";
                    sUpdate += $"  WHERE USERID = '{sUserId}'     "; // Update

                    ExecuteNonQuery(sUpdate);
                }
                else
                {
                    string sInsert = string.Empty;
                    sInsert +=  " INSERT INTO TB_User(USERID   ";
                    sInsert +=  "                    ,USERNAME ";
                    sInsert +=  "                    ,PW       ";
                    sInsert +=  "                    ,DEPTCODE ";
                    sInsert +=  "                    ,MAIL     ";
                    sInsert +=  "                    ,ADDRESS  ";
                    sInsert +=  "                    ,MAKEDATE ";
                    sInsert +=  "                    ,MAKER)   ";
                    sInsert += $" VALUES ('{sUserId}'          ";
                    sInsert += $"        ,'{sUserName}'        ";
                    sInsert += $"        ,'{sPassWord}'        ";
                    sInsert += $"        ,'{sDeptCode}'        ";
                    sInsert += $"        ,'{sMail}'            ";
                    sInsert += $"        ,'{sAddress}'         ";
                    sInsert +=  "        ,REPLACE(CONVERT(VARCHAR(30),GETDATE(),120),'-','/') ";
                    sInsert += $"        ,'{Commons.UserId}')  "; // Insert

                    ExecuteNonQuery(sInsert);
                }
                MessageBox.Show("저장완료.");
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            { DoCloseDB(); }
        }

        private void btnPicLoad_Click(object sender, EventArgs e)
        {
            if (dgtGrid.Rows.Count == 0) { return; }

            string sFilePath = string.Empty;

            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (Dialog.ShowDialog() != DialogResult.OK) return;

            sFilePath = Dialog.FileName;
            picUser.Tag = sFilePath;
            picUser.Image = Bitmap.FromFile(sFilePath);
        }

        private void btnPicSave_Click(object sender, EventArgs e)
        {
            if (dgtGrid.Rows.Count == 0) { return; }
            if (picUser.Image == null) { return; }
            if (Convert.ToString(picUser.Tag) == "") { return; }

            if (MessageBox.Show("선택한 이미지를 사용자 이미지로 등록하시겠습니까?", "이미지 등록", MessageBoxButtons.YesNo)
                                                                                        == DialogResult.No) { return; }
            try
            {

                FileStream stream = new FileStream(Convert.ToString(picUser.Tag)
                                                  , FileMode.Open
                                                 , FileAccess.Read);
                BinaryReader reader = new BinaryReader(stream);

                Byte[] bImage = reader.ReadBytes(Convert.ToInt32(stream.Length));

                reader.Close();
                stream.Close();

                string sUserId = Convert.ToString(dgtGrid.CurrentRow.Cells["USERID"].Value);

                DoOpenDB();
                sTran = sCon.BeginTransaction();
                
                string sUpdate  =  " UPDATE TB_USER                ";
                       sUpdate += $"    SET USERIMAGE = @USERIMAGE ";
                       sUpdate += $"  WHERE USERID = '{sUserId}'   ";

                Command.Parameters.Clear();
                Command.CommandText = sUpdate;
                Command.Parameters.Add("@USERIMAGE", bImage);
                Command.Transaction = sTran;
                Command.Connection = sCon;

                Command.ExecuteNonQuery();
                sTran.Commit();
                MessageBox.Show("등록 완료");
            }
            catch (Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            { DoCloseDB(); }
        }

        private void dgtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DoOpenDB();

                string sUserId = Convert.ToString(dgtGrid.CurrentRow.Cells["USERID"].Value);
                string sLoadImage  = " SELECT USERIMAGE            ";
                       sLoadImage += $"  FROM TB_User              ";
                       sLoadImage += $" WHERE USERID = '{sUserId}' ";

                Adapter = new SqlDataAdapter(sLoadImage, sCon);
                dtGrid = new DataTable();
                Adapter.Fill(dtGrid);

                if (dtGrid.Rows.Count == 0)
                {
                    picUser.Image = null;
                    return;
                }
                if (Convert.ToString(dtGrid.Rows[0]["USERIMAGE"]) == "")
                {
                    picUser.Image = null;
                    return;
                }
                Byte[] bImage = (byte[])dtGrid.Rows[0]["USERIMAGE"];
                if (bImage == null)
                {
                    MessageBox.Show("이미지 불러오기 실패");
                    return;
                }
                picUser.Image = new Bitmap(new MemoryStream(bImage));
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            { DoCloseDB(); }
        }

        private void btnPicDelete_Click(object sender, EventArgs e)
        {
            if (dgtGrid.Rows.Count == 0) { return; }
            if (MessageBox.Show("선택한 사용자 이미지를 삭제하시겠습니까?", "이미지 삭제", MessageBoxButtons.YesNo)
                                                                                        == DialogResult.No) { return; }
            try
            {
                string sUserId = Convert.ToString(dgtGrid.CurrentRow.Cells["USERID"].Value);
                string sUpdate  =  " UPDATE TB_User              ";
                       sUpdate += $"    SET USERIMAGE = NULL     ";
                       sUpdate += $"  WHERE USERID = '{sUserId}' ";

                DoOpenDB();
                ExecuteNonQuery(sUpdate);
                picUser.Image = null;
                MessageBox.Show("사용자 이미지 삭제완료.");
            }
            catch (Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            { DoCloseDB(); }
        }
    }
}
