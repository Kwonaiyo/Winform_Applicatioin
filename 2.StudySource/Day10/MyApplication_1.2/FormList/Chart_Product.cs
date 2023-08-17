using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormList
{
    public partial class Chart_Product : Services.BaseChildForm
    {
        public Chart_Product()
        {
            InitializeComponent();
        }

        private void Chart_Product_Load(object sender, EventArgs e)
        {
            // 그리드 셋팅.
            GridUtil _GridUtil = new GridUtil();
            _GridUtil.InitColumnGridUtil(myGrid1, "PRODDATE", "생산일자", typeof(string), DataGridViewContentAlignment.MiddleLeft, 150, false, true);
            
            _GridUtil.InitColumnGridUtil(myGrid1, "SEQ", "순번", typeof(int), DataGridViewContentAlignment.MiddleRight, 70, false, true);
            
            _GridUtil.InitColumnGridUtil(myGrid1, "ITEMCODE", "품번", typeof(string), DataGridViewContentAlignment.MiddleLeft, 100, false, true);
            
            _GridUtil.InitColumnGridUtil(myGrid1, "ITEMNAME", "품명", typeof(string), DataGridViewContentAlignment.MiddleLeft, 300, false, true);
            
            _GridUtil.InitColumnGridUtil(myGrid1, "PRODQTY", "생산수량", typeof(int), DataGridViewContentAlignment.MiddleRight, 200, false, true);


            // 콤보박스 셋팅. (From 품목마스터)
            Commons.GetCombo_ItemCode(null, cboItem);

        }

        public override void DoInquire()
        {
            DBHelper helper = new DBHelper();
            try
            {
                // 행 초기화
                ((DataTable)myGrid1.DataSource).Rows.Clear();  

                // 데이터 게더링
                DataTable dttemp = helper.FillTable("SP_ChartGrid_S1", CommandType.StoredProcedure
                                                   , helper.CreateParameters("@ITEMCODE", Convert.ToString(cboItem.SelectedValue)));
                
                // 없을경우
                if(dttemp.Rows.Count == 0)
                {
                    MessageBox.Show("조회할 데이터가 없습니다.");
                    return;
                }

                // 데이터 등록
                myGrid1.DataSource = dttemp;

                // 차트에 데이터 표현하기
                SetChartData(helper);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                helper.Close();
            }

        }

        private void SetChartData(DBHelper helper2)
        {
            // 데이터 게더링
            DataTable dttemp = helper2.FillTable("SP_ChartGrid_S2", CommandType.StoredProcedure
                                               , helper2.CreateParameters("@ITEMCODE", Convert.ToString(cboItem.SelectedValue)));

            if ( dttemp.Rows.Count == 0 )
            {
                return;
            }
            chart1.Series.Clear();

            if (Convert.ToString(cboItem.SelectedValue) != "")
            {
                // 품목을 정해서 하나 선택했을 경우
                chart1.DataSource = dttemp;
                chart1.Series.Add(dttemp.Rows[0]["ITEMCODE"].ToString());                // 시리즈 명칭..
                chart1.Series[0].XValueMember  = "PRODDATE";                             // X축
                chart1.Series[0].YValueMembers = "PRODQTY";                              // Y축
                chart1.Series[0].Name          = dttemp.Rows[0]["ITEMNAME"].ToString();  // 시리즈 범례
                chart1.Series[0].Color         = Color.LightSalmon;                      // 차트의 색상
                chart1.Series[0].IsValueShownAsLabel = true;                             // 차트와 함께 수치도 같이 표현(true)
            }
            else
            {
                // 전체 품목을 선택했을 경우
                // dttemp.DeafultView : 데이터테이블을 정렬, 그룹화할 수 있도록 해주는 클래스(DataView).
                chart1.DataBindCrossTable(dttemp.DefaultView, "ITEMNAME", "PRODDATE", "PRODQTY", "");

                // 차트 위에 데이터를 표현하는 로직.
                for (int i = 0; i < chart1.Series.Count; i++ )
                {
                    chart1.Series[i].IsValueShownAsLabel = true;    // 차트와 함께 수치도 같이 표현(true)
                }
            }

        }
    }
}
