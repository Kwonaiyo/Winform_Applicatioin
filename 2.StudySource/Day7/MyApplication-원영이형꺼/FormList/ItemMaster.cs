using MainForms;
using Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
/*********************************
 * DATE   : 2023-05-02
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
    // 기준정보
    // 시스템에서 관리되는 주요 항목들을 관리하는 데이터, 시스템이 관리해야 하는 대상
    // 품목, 작업자, 사용자, 거래처, 공정, 작업장 등
    public partial class ItemMaster : Form
    {
        #region < 필드 멤버 변수 >
        // 1. 데이터베이스 접속 주소
        SqlConnection sCon = new SqlConnection(Commons.strCon);

        // 2. 조회를 위한 SQL 객체
        SqlDataAdapter Adapter;

        // 3. 데이터베이스의 갱신을 위한 변수
        SqlCommand Command = new SqlCommand(); // ExcuteNonQuery를 실행할 커맨드 객체
        SqlTransaction sTran;

        // 4. 그리드 세팅을 위한 DataTable
        DataTable dtGrid = new DataTable();
        #endregion
        public ItemMaster()
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
        private void ItemMaster_Load(object sender, EventArgs e)
        {
            // 1. 그리드 세팅
            dtGrid.Columns.Add("ITEMCODE", typeof(String));
            dtGrid.Columns.Add("ITEMNAME", typeof(String));
            dtGrid.Columns.Add("ITEMTYPE", typeof(String));
            dtGrid.Columns.Add("ITEMDESC", typeof(String));
            dtGrid.Columns.Add("ENDFLAG", typeof(String));
            dtGrid.Columns.Add("PRODDATE", typeof(String));
            dtGrid.Columns.Add("MAKEDATE", typeof(String));
            dtGrid.Columns.Add("MAKER", typeof(String));
            dtGrid.Columns.Add("EDITDATE", typeof(String));
            dtGrid.Columns.Add("EDITOR", typeof(String));

            // 빈 컬럼 테이블을 그리드에 매핑
            dgtGrid.DataSource = dtGrid;

            // 그리드 속성 세팅
            // 헤더의 명칭 선언
            dgtGrid.Columns["ITEMCODE"].HeaderText = "품목코드";
            dgtGrid.Columns["ITEMNAME"].HeaderText = "품목명";
            dgtGrid.Columns["ITEMTYPE"].HeaderText = "품목유형";
            dgtGrid.Columns["ITEMDESC"].HeaderText = "품목상세";
            dgtGrid.Columns["ENDFLAG"].HeaderText  = "단종여부";
            dgtGrid.Columns["PRODDATE"].HeaderText = "출시일자";
            dgtGrid.Columns["MAKEDATE"].HeaderText = "생성일시";
            dgtGrid.Columns["MAKER"].HeaderText    = "생성자";
            dgtGrid.Columns["EDITDATE"].HeaderText = "수정일시";
            dgtGrid.Columns["EDITOR"].HeaderText   = "수정자";

            // 컬럼의 폭 지정
            dgtGrid.Columns["ITEMCODE"].Width = 100; // 품목코드
            dgtGrid.Columns[1].Width          = 200; // 품목명
            dgtGrid.Columns["ITEMDESC"].Width = 250; // 생성일시
            dgtGrid.Columns["MAKEDATE"].Width = 250; // 생성일시
            dgtGrid.Columns["EDITDATE"].Width = 250; // 수정일시

            // 컬럼의 수정여부 지정
            dgtGrid.Columns["MAKEDATE"].ReadOnly = true;
            dgtGrid.Columns["MAKER"].ReadOnly    = true;
            dgtGrid.Columns["EDITDATE"].ReadOnly = true;
            dgtGrid.Columns["EDITOR"].ReadOnly   = true;

            // 2. 콤보박스에 데이터 세팅
            try
            {
                // DB 오픈
                DoOpenDB();

                // 콤보박스에 세팅할 데이터를 DB에서 가져오는 SQL구문 작성
                string sSqlSelect = string.Empty;
                sSqlSelect += " SELECT ''                               AS CODE_ID    ";
                sSqlSelect += "       ,'[ALL] 전체조회'                  AS CODE_NAME ";
                sSqlSelect += " UNION                                                 ";
                sSqlSelect += " SELECT MINORCODE                         AS CODE_ID   ";
                sSqlSelect += "       ,'[' + MINORCODE + '] ' + CODENAME AS CODE_NAME ";
                sSqlSelect += "   FROM TB_Standard                                    ";
                sSqlSelect += "  WHERE MAJORCODE = 'ITEMTYPE'                         ";
                sSqlSelect += "    AND MINORCODE <> '$'                               ";

                // 데이터베이스에 명령을 전달할 객체 선언
                Adapter = new SqlDataAdapter(sSqlSelect, sCon);

                // 데이터베이스 실행 및 결과 반환
                DataTable dtGrid = new DataTable();
                Adapter.Fill(dtGrid);

                // 데이터베이스에서 가져온 콤보박스 세팅 데이터를 배치(매핑)
                cboItemType.DataSource = dtGrid;
                cboItemType.ValueMember = "CODE_ID";
                cboItemType.DisplayMember = "CODE_NAME";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally { DoCloseDB(); }

            // 3. 달력 컨트롤에 현재일자 표시 및 지정일자 표시
            dtpStart.Text = string.Format("{0:yyyy-MM-01}", DateTime.Now);
            dtpEnd.Text   = string.Format("{0:yyyy-MM-dd}", DateTime.Now);

        }
        public void DoInquire()
        { btnSearch_Click(null, null); }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 조회 버튼을 클릭했을 때 조회되는 기능
            try
            {
                DoOpenDB();
                // 조회조건이 담기는 변수
                string sItemCode  = txtItemCode.Text;                            // 품목코드
                string sItemName  = txtItemName.Text;                            // 품목명
                string sStartDate = dtpStart.Text;                               // 출시 시작일자
                string sEndDate   = dtpEnd.Text;                                 // 출시 종료일자
                string sItemType  = Convert.ToString(cboItemType.SelectedValue); // 품목타입
                string sStopFlag  = "N";                                // 단종여부 (Y/N)
                if (rdbDiscontinued.Checked == true) sStopFlag = "Y"; // 단종여부 : Y
                if (chkOnlyName.Checked == true) sItemCode = "";

                // 조회조건에 맞는 품목데이터를 검색하는 SQL
                string sSqlSelect = string.Empty;
                sSqlSelect +=  " SELECT ITEMCODE                                         ";
                sSqlSelect +=  "       ,ITEMNAME                                         ";
                sSqlSelect +=  "       ,ITEMTYPE                                         ";
                sSqlSelect +=  "       ,ITEMDESC                                         ";
                sSqlSelect +=  "       ,ENDFLAG                                          ";
                sSqlSelect +=  "       ,PRODDATE                                         ";
                sSqlSelect +=  "       ,MAKEDATE                                         ";
                sSqlSelect +=  "       ,MAKER                                            ";
                sSqlSelect +=  "       ,EDITDATE                                         ";
                sSqlSelect +=  "       ,EDITOR                                           ";
                sSqlSelect +=  "   FROM TB_ItemMaster                                    ";
                sSqlSelect += $"  WHERE ITEMCODE LIKE '%{sItemCode}%'                    ";
                sSqlSelect += $"    AND ITEMNAME LIKE '%{sItemName}%'                    ";
                sSqlSelect += $"    AND PRODDATE BETWEEN '{sStartDate}' AND '{sEndDate}' ";
                sSqlSelect += $"    AND ITEMTYPE LIKE '%{sItemType}'                     ";
                sSqlSelect += $"    AND ENDFLAG = '{sStopFlag}'                          ";

                // 데이터베이스에 있는 조건에 맞는 품목데이터 가져오기
                Adapter = new SqlDataAdapter(sSqlSelect, sCon);
                dtGrid = new DataTable();
                Adapter.Fill(dtGrid);

                // 조회할 데이터가 없을 경우
                if (dtGrid.Rows.Count == 0)
                {
                    // dgtGrid.DataSource = dtGrid; // 1. 깡통 데이터 테이블을 매핑

                    ((DataTable)dgtGrid.DataSource).Rows.Clear();

                    MessageBox.Show("조건에 맞는 데이터가 없다네");
                    return;
                }
                // 데이터가 있을 경우
                dgtGrid.DataSource = dtGrid;

                // 조회되는 행의 수
                string sMessage = dgtGrid.Rows.Count + "행이 조회되었다네";
                
                MainForm.pu_MainForm.SetMessage(sMessage);
                }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            finally
            { DoCloseDB(); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 품목정보를 추가하기 위한 그리드 행 신규등록
            DataRow dr = ((DataTable)dgtGrid.DataSource).NewRow();
            ((DataTable)dgtGrid.DataSource).Rows.Add(dr);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 삭제버튼을 클릭했을 때의 기능
            if (dgtGrid.Rows.Count == 0) return;

            // 삭제여부 물어보기
            if (MessageBox.Show("행을 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            // 데이터 삭제 로직 실행
            try
            {
                // 현재 선택한 행의 품목코드
                string sItemCode = dgtGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();

                // 데이터베이스 Open()
                DoOpenDB();

                // 트랜잭션 선언
                sTran = sCon.BeginTransaction(); // Database가 Open이 된 상태에서 선언 가능

                Command.Transaction = sTran;     // 트랜잭션 정보를 가지고 실행
                Command.Connection = sCon;       // Command가 접속할 주소
                Command.CommandText = $" DELETE FROM TB_ItemMaster WHERE ITEMCODE = '{sItemCode}' ";        // 삭제를 위한 SQL 명령어 작성
                
                Command.ExecuteNonQuery();

                sTran.Commit();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 선택된 행의 데이터를 저장 ( UPDATE / INSERT )
            if (dgtGrid.Rows.Count == 0) return;

            // 등록 또는 수정될 데이터를 변수에 등록
            string sItemCode = Convert.ToString(dgtGrid.CurrentRow.Cells["ITEMCODE"].Value);
            string sItemName = Convert.ToString(dgtGrid.CurrentRow.Cells["ITEMNAME"].Value);
            string sItemType = Convert.ToString(dgtGrid.CurrentRow.Cells["ITEMTYPE"].Value);
            string sItemDesc = Convert.ToString(dgtGrid.CurrentRow.Cells["ITEMDESC"].Value);
            string sEndFlag  = Convert.ToString(dgtGrid.CurrentRow.Cells["ENDFLAG"].Value);
            string sProdDate = Convert.ToString(dgtGrid.CurrentRow.Cells["PRODDATE"].Value);

            // 단종여부 값을 등록하지 않았을 경우 디폴트 값으로 등록되도록 설정 ( N )
            if (sEndFlag == "Y" || sEndFlag == "y") sEndFlag = "Y";
            else sEndFlag = "N";
            // sEndFlag = sEndFlag == "" ? "N" : sEndFlag; // 삼항 연산자. inline if

            // 출시일자를 입력하지 않았을 경우 디폴트 값으로 오늘날짜로 설정
            sProdDate = sProdDate == "" ? string.Format("{0:yyyy-MM-dd}",DateTime.Now) : sProdDate;

            // 필수입력값 체크
            if (sItemCode == "")
            {
                MessageBox.Show("품목코드를 입력해줘잉");
                return;
            }

            if (MessageBox.Show("데이터를 저장하시겠습니까?", "데이터 갱신", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            // 데이터 등록 로직 수행

            // 1. UPDATE / INSERT 판단

            sCon.Open();
            try
            {
                // 1. 데이터베이스에 등록된 품목ID인지 체크
                string sSelect = $" SELECT * FROM TB_ItemMaster WHERE ITEMCODE = '{sItemCode}'";
                Adapter = new SqlDataAdapter(sSelect, sCon);
                DataTable dtGrid = new DataTable();
                Adapter.Fill(dtGrid);

                if (dtGrid.Rows.Count != 0)
                {
                    // Database가 Open이 된 상태에서 선언 가능

                    string sUpdate = "";
                    sUpdate += $" UPDATE TB_ItemMaster";
                    sUpdate +=    $" SET ITEMNAME = '{sItemName}' ";
                    sUpdate +=       $" ,ITEMTYPE = '{sItemType}' ";
                    sUpdate +=       $" ,ITEMDESC = '{sItemDesc}' ";
                    sUpdate +=       $" ,ENDFLAG  = '{sEndFlag}'  ";
                    sUpdate +=       $" ,PRODDATE = '{sProdDate}' ";
                    sUpdate +=       $" ,EDITDATE = REPLACE(CONVERT(VARCHAR(30),GETDATE(),120),'-','/') ";
                    sUpdate +=       $" ,EDITOR   = '{Commons.UserId}'";
                    sUpdate +=  $" WHERE ITEMCODE = '{sItemCode}' "; // Update를 위한 SQL 명령어 작성

                    ExecuteNonQuery(sUpdate);
                }
                else
                {
                    string sInsert = "";
                    sInsert += $" INSERT INTO TB_ItemMaster(ITEMCODE ";
                    sInsert +=                          $" ,ITEMNAME ";
                    sInsert +=                          $" ,ITEMTYPE ";
                    sInsert +=                          $" ,ITEMDESC ";
                    sInsert +=                          $" ,ENDFLAG  ";
                    sInsert +=                          $" ,PRODDATE ";
                    sInsert +=                          $" ,MAKEDATE ";
                    sInsert +=                          $" ,MAKER)   ";
                    sInsert +=      $" VALUES ('{sItemCode}' ";
                    sInsert +=             $" ,'{sItemName}' ";
                    sInsert +=             $" ,'{sItemType}' ";
                    sInsert +=             $" ,'{sItemDesc}' ";
                    sInsert +=             $" ,'{sEndFlag}' ";
                    sInsert +=             $" ,'{sProdDate}' ";
                    sInsert +=             $" ,REPLACE(CONVERT(VARCHAR(30),GETDATE(),120),'-','/') ";
                    sInsert +=             $" ,'{Commons.UserId}') "; // Insert를 위한 SQL 명령어 작성

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
            {
                if (sCon.State != ConnectionState.Open) sCon.Close();
            }

        }

        private void btnPicLoad_Click(object sender, EventArgs e)
        {
            // 파일 탐색기를 통해서 원하는 이미지를 가져와 픽쳐박스에 표현
            if (dgtGrid.Rows.Count == 0) { return; }

            string sFilePath = string.Empty; // 이미지 파일의 경로를 담을 변수
            
            // 파일 탐색기 호출
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (Dialog.ShowDialog() != DialogResult.OK) return;

            // 파일의 경로 받아오기
            sFilePath = Dialog.FileName;                // 선택한 파일의 물리적 위치(경로)를 포함
            picItem.Tag = sFilePath;                    // Tag에 이미지 경로 저장
            picItem.Image = Bitmap.FromFile(sFilePath); // 이미지 파일을 Bitmap으로 변경하여 picItem.Image에 등록
        }

        private void btnPicSave_Click(object sender, EventArgs e)
        {
            // Picture Box에 등록된 이미지를 데이터베이스에 저장
            if (dgtGrid.Rows.Count == 0) { return; }
            if (picItem.Image == null) { return; }
            if (Convert.ToString(picItem.Tag) == "") { return; }

            if (MessageBox.Show("선택한 이미지를 품목이미지로 등록하시겠습니까?","이미지 등록", MessageBoxButtons.YesNo)
                                                                                        == DialogResult.No) { return; }
            // 이미지 등록 로직 실행
            try
            {
                // 이미지 파일을 파일스트림으로 메모리에 등록 후 Byte[] 배열로 변경
                FileStream stream = new FileStream(Convert.ToString(picItem.Tag) // 파일의 위치정보로 접근하여
                                                  ,FileMode.Open                 // 읽기전용으로 가져오기
                                                 , FileAccess.Read);
                BinaryReader reader = new BinaryReader(stream); // 2진 데이터로 바이너리 데이터를 램으로 가져올 때

                Byte[] bImage = reader.ReadBytes(Convert.ToInt32(stream.Length)); // 2진 데이터를 Byte 형식으로 RAM에 패킹

                // 데이터를 메모리에 등록 완료하여
                // 바이너리 리더와 파일스트림 종료
                reader.Close();
                stream.Close();

                // 데이터베이스에 저장 시작 (bImage)

                // 이미지가 등록될 품목의 정보
                string sItemCode = Convert.ToString(dgtGrid.CurrentRow.Cells["ITEMCODE"].Value);

                // 데이터베이스 오픈
                DoOpenDB();
                sTran = sCon.BeginTransaction();

                // 데이터베이스에 등록할 SQL 구문
                string sUpdate  =  " UPDATE TB_ITEMMASTER ";        
                       sUpdate += $" SET ITEMIMAGE = @ITEMIMAGE ";  // 특정 파라매터를 받을 수 있는 SQL 구문
                       sUpdate += $" WHERE ITEMCODE = '{sItemCode}' ";

                // 0. 파라매터 초기화
                Command.Parameters.Clear();
                // 1. 명령어 전달
                Command.CommandText = sUpdate;
                // 2. 커맨드에 파라매터 연결
                Command.Parameters.Add("@ITEMIMAGE", bImage);
                // 3. 트랜잭션 연결
                Command.Transaction = sTran;
                // 4. 접속 주소 연결
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
            {
                DoCloseDB();
            }

        }

        private void dgtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 그리드에서 품목을 선택했을 경우 품목의 이미지를 Picture Box에 표현
            try
            {
                DoOpenDB();

                // 선택한 품목코드의 정보 변수 담기
                string sItemCode = Convert.ToString(dgtGrid.CurrentRow.Cells["ITEMCODE"].Value);
                string sLoadImage = " SELECT ITEMIMAGE ";
                sLoadImage += $" FROM TB_ItemMaster ";
                sLoadImage += $" WHERE ITEMCODE = '{sItemCode}' ";

                Adapter = new SqlDataAdapter(sLoadImage, sCon);
                DataTable dtGrid = new DataTable();
                Adapter.Fill(dtGrid);

                // dtGrid에 품목 이미지 16진수 파일 데이터를 받아옴
                if (dtGrid.Rows.Count == 0)
                {
                    picItem.Image = null;
                    return;
                }
                if (Convert.ToString(dtGrid.Rows[0]["ITEMIMAGE"]) == "")
                {
                    picItem.Image = null;
                    return;
                }
                // 이미지를 표현 (RAM -> Bitmap 형식으로 변형 -> Picture Box의 Image 속성에 대입)
                // MemoryStream : 메모리 안에 있는 파일 데이터를 접근하는 Stream
                Byte[] bImage = (byte[])dtGrid.Rows[0]["ITEMIMAGE"];
                if (bImage == null)
                {
                    MessageBox.Show("이미지 불러오기 실패");
                    return;
                }
                
                // 메모리에 등록된 byte[] 형식의 데이터를 Bitmap으로 변형하여 Image 속성에 등록
                // MemoryStream memorystream = new MemoryStream(bImage);
                // Bitmap mybitmap = new Bitmap(memorystream);
                // picItem.Image = mybitmap;
                picItem.Image = new Bitmap(new MemoryStream(bImage));

                // Image와 Bitmap
                // 픽셀 단위의 데이터로 정의된 이미지 작업 클래스 (JPG, PNG, BMP 등 다양한 이미지 파일 형식을 지원)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DoCloseDB();
            }
        }

        private void btnPicDelete_Click(object sender, EventArgs e)
        {
            if (dgtGrid.Rows.Count == 0) { return; }
            if (MessageBox.Show("선택한 품목이미지를 삭제하시겠습니까?", "이미지 삭제", MessageBoxButtons.YesNo)
                                                                                        == DialogResult.No) { return; }
            try
            {
                string sItemCode = Convert.ToString(dgtGrid.CurrentRow.Cells["ITEMCODE"].Value);
                string sUpdate  =  " UPDATE TB_ITEMMASTER ";
                       sUpdate += $" SET ITEMIMAGE = NULL ";
                       sUpdate += $" WHERE ITEMCODE = '{sItemCode}' ";

                DoOpenDB();
                ExecuteNonQuery(sUpdate);
                picItem.Image = null;
                MessageBox.Show("품목이미지 삭제완료.");
            }
            // 데이터베이스에 등록할 SQL 구문
            catch (Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DoCloseDB();
            }
        }
    }
}
