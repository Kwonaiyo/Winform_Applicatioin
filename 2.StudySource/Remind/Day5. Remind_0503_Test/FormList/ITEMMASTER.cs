using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

/************************************************************
 * NAME   : ITEMMASTER.cs
 * DESC   : 품목 관리
 * DATE   : 2023-05-02
 * AUTHOR : 권문규
 * DESC   : 최초 프로그램 작성
 * 
 * 
 * DATE   : 2023-**-**
 * EDITOR : 홍길동
 * DESC   : 프로그램이 뭐 같아서 어떻게 수정했음 ㅍㅋㅍㅋ
 * 
 * *********************************************************/

namespace FormList
{
    // 기준정보
    // 시스템에서 관리되는 주요 항목들을 관리하는 데이터, 시스템이 관리해야하는 대상.
    // 품목, 작업자, 사용자, 거래처, 공정, 작업장, ... 
    public partial class ITEMMASTER : Form
    {
        #region < 필드 멤버 변수 >
        // 데이터베이스 공통 변수
        // 1. 데이터베이스 접속 주소.
        SqlConnection sCon = new SqlConnection(Commons.strCon);

        // 조회용 데이터베이스 객체 변수
        // 2. 조회를 위한 SQL 객체 생성.
        SqlDataAdapter adapter;

        // 3. 데이터베이스의 갱신을 위한 변수.
        // 그리드 세팅을 위한 DataTable 생성.
        DataTable dtGrid = new DataTable();
        // ExecuteNonQuery를 실행할 커맨드객체 생성.
        SqlCommand Command = new SqlCommand();

        SqlTransaction sTran;

        #endregion


        public ITEMMASTER()
        {
            InitializeComponent();
        }



        private void ITEMMASTER_Load(object sender, EventArgs e)
        {
            // 화면이 오픈될 때 기본 세팅.

            // 1. 그리드 세팅.
           
            dtGrid.Columns.Add("ITEMCODE", typeof(string));
            dtGrid.Columns.Add("ITEMNAME", typeof(string));
            dtGrid.Columns.Add("ITEMTYPE", typeof(string));
            dtGrid.Columns.Add("ITEMDESC", typeof(string));
            dtGrid.Columns.Add("ENDFLAG", typeof(string));
            dtGrid.Columns.Add("PRODDATE", typeof(string));
            dtGrid.Columns.Add("MAKEDATE", typeof(string));
            dtGrid.Columns.Add("MAKER", typeof(string));
            dtGrid.Columns.Add("EDITDATE", typeof(string));
            dtGrid.Columns.Add("EDITOR", typeof(string));

            // 빈 컬럼 테이블을 그리드에 매핑.
            dgtGrid.DataSource = dtGrid;

            // 그리드 속성 세팅
            // 헤더의 명칭 선언
            dgtGrid.Columns["ITEMCODE"].HeaderText = "품목코드";
            dgtGrid.Columns["ITEMNAME"].HeaderText = "품목명";
            dgtGrid.Columns["ITEMTYPE"].HeaderText = "품목유형";
            dgtGrid.Columns["ITEMDESC"].HeaderText = "품목상세";
            dgtGrid.Columns["ENDFLAG"].HeaderText = "단종여부";
            dgtGrid.Columns["PRODDATE"].HeaderText = "출시일자";
            dgtGrid.Columns["MAKEDATE"].HeaderText = "생성일시";
            dgtGrid.Columns["MAKER"].HeaderText = "생성자";
            dgtGrid.Columns["EDITDATE"].HeaderText = "수정일시";
            dgtGrid.Columns["EDITOR"].HeaderText = "수정자";

            // 컬럼의 폭 지정.
            dgtGrid.Columns["ITEMCODE"].Width = 100;    // 품목코드의 Width를 100으로 하겠다. 
            dgtGrid.Columns[1].Width = 200;             // 1번 인덱스(품목명)의 Width를 200으로 하겠다.
            dgtGrid.Columns["MAKEDATE"].Width = 250;    // 생성일시
            dgtGrid.Columns["EDITDATE"].Width = 250;    // 수정일시

            // 컬럼의 수정가능 여부 지정.
            dgtGrid.Columns["MAKEDATE"].ReadOnly = true;
            dgtGrid.Columns["MAKER"].ReadOnly    = true;
            dgtGrid.Columns["EDITDATE"].ReadOnly = true;
            dgtGrid.Columns["EDITOR"].ReadOnly   = true;


            // 2. 콤보박스에 데이터 세팅.

            try
            {

                // DB 오픈
                sCon.Open();

                // 콤보박스에 세팅할 데이터를 DB에서 가져오는 SQL 구문 작성.
                string sSqlSelect = string.Empty;
                sSqlSelect += "  SELECT ''                         AS CODE_ID   ";
                sSqlSelect += "        ,'전체조회'                 AS CODE_NAME ";
                sSqlSelect += " UNION                                           ";
                sSqlSelect += " SELECT MINORCODE                   AS CODE_ID   ";
                sSqlSelect += " ,'[' + MINORCODE + '] ' + CODENAME AS CODE_NAME ";
                sSqlSelect += " FROM TB_Standard                                ";
                sSqlSelect += " WHERE MAJORCODE = 'ITEMTYPE'                    ";
                sSqlSelect += " AND MINORCODE <> '$'                            ";

                // 데이터베이스에 명령을 전달할 객체 선언.
                adapter = new SqlDataAdapter(sSqlSelect, sCon);

                // 데이터베이스 실행 및 결과 반환.
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                // 데이터베이스에서 가져온 콤보박스 세팅 데이터를 배치(매핑).
                cboItemType.DataSource = dtTemp;
                cboItemType.ValueMember = "CODE_ID";
                cboItemType.DisplayMember = "Code_Name";


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sCon.Close();
            }


            // 3. 달력 컨트롤에 현재일자 표시 및 지정일자 표시하기.
            dtpStart.Text = string.Format("{0:yyyy-MM-01}", DateTime.Now);
            dtpEnd.Text = string.Format("{0:yyyy-MM-dd}", DateTime.Now);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 조회 버튼을 클릭했을 때 조회되는 기능을 구현.
            try
            {
                if (sCon.State == ConnectionState.Closed)
                {
                    sCon.Open();
                }

                //조회조건이 담기는 변수
                string sItemCode = txtItemCode.Text;                               // 품목코드
                string sItemName = txtItemName.Text;                               // 품목명
                string sStartDate = dtpStart.Text;                                 // 출시 시작 일자
                string sEndDate = dtpEnd.Text;                                     // 출시 종료 일자
                string sItemType = Convert.ToString(cboItemType.SelectedValue);    // 콤보박스의 선택한 값.
                string sStopFlag = "N";     // 생산이 선택된 경우(deafult 값 - "N" // 단종여부("Y" 또는 "N")
                if(rdbClose.Checked)        // 단종을 선택했을 경우
                    sStopFlag = "Y";
                if(chkOnlyName.Checked)
                {
                    sItemCode = "";
                }

                // 조회 조건에 맞는 데이터를 검색하는 SQL
                string sSqlSelect = string.Empty;
                sSqlSelect += " SELECT ITEMCODE                                          ";
                sSqlSelect += "       ,ITEMNAME                                          ";
                sSqlSelect += "       ,ITEMTYPE                                          ";
                sSqlSelect += "       ,ITEMDESC                                          ";
                sSqlSelect += "       ,ENDFLAG                                           ";
                sSqlSelect += "       ,PRODDATE                                          ";
                sSqlSelect += "       ,MAKEDATE                                          ";
                sSqlSelect += "       ,MAKER                                             ";
                sSqlSelect += "       ,EDITDATE                                          ";
                sSqlSelect += "       ,EDITOR                                            ";
                sSqlSelect += "   FROM TB_ItemMaster                                     ";
                sSqlSelect += $"  WHERE ITEMCODE LIKE '%{sItemCode}%'                    ";
                sSqlSelect += $"    AND ITEMNAME LIKE '%{sItemName}%'                    ";
                sSqlSelect += $"    AND PRODDATE BETWEEN '{sStartDate}' AND '{sEndDate}' "; 
                sSqlSelect += $"    AND ITEMTYPE LIKE '%{sItemType}%'                    "; 
                sSqlSelect += $"    AND ENDFLAG = '{sStopFlag}'                          ";

                // 데이터베이스에 있는 조건에 맞는 품목 데이터 가져오기.
                adapter = new SqlDataAdapter(sSqlSelect, sCon);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                // 조회조건에 맞는 데이터가 없는 경우(dtTemp가 안나올경우)
                if (dtTemp.Rows.Count == 0)
                {
                    //dgtGrid.DataSource = dtGrid;    // dgtGrid를 클리어시킴 <- 깡통 데이터테이블(dtGrid)를 매핑
                    ((DataTable)dgtGrid.DataSource).Rows.Clear();   // dgtGrid의 데이터소스를 DataTable 형식으로 강제 형변한 한 뒤 row를 클리어
                    
                    MessageBox.Show("조회조건에 맞는 데이터가 없습니다.");
                    return;
                }

                // 데이터가 있을경우
                dgtGrid.DataSource = dtTemp;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // 데이터베이스의 연결상태가 OPEN일 경우 종료.
                if(sCon.State == ConnectionState.Open)
                    sCon.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 품목 정보를 추가하기 위한 그리드 행 신규등록.
            DataRow dr = ((DataTable)dgtGrid.DataSource).NewRow();
            ((DataTable)dgtGrid.DataSource).Rows.Add(dr);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 삭제버튼 클릭시의 기능 구현.
            if (dgtGrid.Rows.Count == 0)
            {
                return;
            }

            // 삭제 여부 물어보기..
            if (MessageBox.Show("데이터를 삭제할까요?", "데이터삭제", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // 데이터 삭제 로직 실행하기 .. 
            // 데이터베이스 오픈
            try
            {
                // 현재 선택한 행의 품목 코드
                string sitemcode = dgtGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();

                // 데이터베이스 open()
                sCon.Open();

                // 트랜잭션 선언
                sTran = sCon.BeginTransaction();    // Database가 Open된 상태에서 선언 가능.

                Command.Transaction = sTran;        // 트랜잭션 정보를 가지고 실행
                Command.Connection = sCon;          // Command가 접속할 주소 정보

                // 삭제를 위한 SQL 명령어 작성.
                Command.CommandText = $"DELETE TB_ItemMaster WHERE ITEMCODE = '{sitemcode}'";

                Command.ExecuteNonQuery();          // 커맨드가 실행.

                sTran.Commit();
                MessageBox.Show("데이터가 정상적으로 삭제되었습니다.");
                btnSearch_Click(null, null);
                
            }
            catch(Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // 데이터베이스 open상태이면 close();
                if(sCon.State == ConnectionState.Open)
                {
                    sCon.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 선택된 행의 데이터를 저장( update / insert )
            if (dgtGrid.Rows.Count == 0)
            { return; }

            // 등록 또는 수정될 데이터를 변수에 등록.
            string sItemCode = Convert.ToString(dgtGrid.CurrentRow.Cells["ITEMCODE"].Value);
            string sItemName = Convert.ToString(dgtGrid.CurrentRow.Cells["ITEMNAME"].Value);
            string sItemType = Convert.ToString(dgtGrid.CurrentRow.Cells["ITEMTYPE"].Value);
            string sItemDesc = Convert.ToString(dgtGrid.CurrentRow.Cells["ITEMDESC"].Value);
            string sEndFlag = Convert.ToString(dgtGrid.CurrentRow.Cells["ENDFLAG"].Value);
            string sProdDate = Convert.ToString(dgtGrid.CurrentRow.Cells["PRODDATE"].Value);

            // 단종여부 값을 등록하지 않았을경우 디폴트 값으로 되도록 설정 ("N")
            sEndFlag = sEndFlag == "" ? "N" : sEndFlag;  // 삼항연산자(inline if)

            // 출시일자를 입력하지 않았을 경우, 디폴트값으로 오늘 일자로 설정.
            sProdDate = sProdDate == "" ? String.Format("{0:yyyy-MM-dd}", DateTime.Now) : sProdDate;

            // 필수 입력값 체크
            if (sItemCode == "" )
            {
                MessageBox.Show("품목코드를 입력하지 않았습니다!");
                return;
            }

            if (MessageBox.Show("데이터를 저장하시겠습니까?", "데이터 갱신", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // 데이터 등록 로직 수행
            // update인지 insert인지 판단..?
            sCon.Open();

            try
            {
                // 1. 데이터베이스에 등록된 품목 ID인지 체크
                string sSelect = $"SELECT * FROM TB_ItemMaster WHERE ITEMCODE = '{sItemCode}'";
                adapter = new SqlDataAdapter(sSelect, sCon);

                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                if(dtTemp.Rows.Count != 0)
                {
                    // update
                    string sUpdate  =  "UPDATE TB_ItemMaster               ";
                           sUpdate += $"   SET ITEMNAME = '{sItemName}'    ";
                           sUpdate += $"      ,ITEMTYPE = '{sItemType}'    ";
                           sUpdate += $"      ,ITEMDESC = '{sItemDesc}'    ";
                           sUpdate += $"      ,ENDFLAG  = '{sEndFlag}'     ";
                           sUpdate += $"      ,PRODDATE = '{sProdDate}'    ";
                           sUpdate += $" WHERE ITEMCODE = '{sItemCode}'    ";
                    
                    ExecuteNonQuery(sUpdate);

                }
                else
                {
                    // insert
                    string sInsert = "";
                    sInsert += " INSERT INTO TB_ItemMaster(ITEMCODE     , ITEMNAME     , ITEMDESC     , ITEMTYPE     , ENDFLAG     , PRODDATE) ";
                    sInsert += $"                   VALUES('{sItemCode}', '{sItemName}', '{sItemDesc}', '{sItemType}', '{sEndFlag}', '{sProdDate}') ";

                    ExecuteNonQuery(sInsert);

                }

                MessageBox.Show("정상적으로 등록을 완료했습니다.");

            }
            catch(Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sCon.Close();
            }
        }

        private void ExecuteNonQuery(string sSqlstring)
        {
                sTran = sCon.BeginTransaction();
                Command.Transaction = sTran;
                Command.Connection = sCon;
                Command.CommandText = sSqlstring;

                Command.ExecuteNonQuery();
                sTran.Commit();
        }
    }
}
