using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public ITEMMASTER()
        {
            InitializeComponent();
        }



        private void ITEMMASTER_Load(object sender, EventArgs e)
        {
            // 화면이 오픈될 때 기본 세팅.

            // 1. 그리드 세팅.
            DataTable dtGrid = new DataTable(); // 그리드 세팅을 위한 DataTable 생성.
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

        }
    }
}
