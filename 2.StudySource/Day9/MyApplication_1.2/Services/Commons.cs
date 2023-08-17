using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* namespace 
 *   = (클래스 라이브러리, 어셈블리, DLL , API, 프로젝트)
 *  하나 이상의 앱 에서 호출되는 형식 및 메서드 등을 정의하여 dll 형식으로 제공
 *  단독으로는 실행 되지 않는다. 
 *  
 *  1. 배포및 재사용성이 용이
 *  2. dll 파일 내부의 소스 만 변경 및 배포가 가능 하므로 유지보수 가 용이
 *  2. dll 내부의 소스 는 외부 환경에서 확인 할 수 없으므로 보안성이 향상.
 */

namespace Services
{

    // Services , Common 
    // Services : 실제 프로그램이 실행되는 로직에는 관여하지 않고 
    //            도움을 주는 역활 의 로직들이 있는 모듈 (Biz)
    // Common   : 서비스 로직 이 포함되어 있는 클래스.

    public class Commons
    {
        public const string strCon = "Server = localhost ; Uid = sa ; Pwd = 1234 ; database = AppDev";

        //로그인 성공 여부
        public static bool bLoginSF = false;

        // 시스템에 로그인한 사용자의 ID
        public static string UserId = "ADMIN";
        

        static public void GetCombo_Standard(string sMajorcode, ComboBox TempCombo)
        {
            SqlConnection sCon = new SqlConnection(Commons.strCon);
            try
            {
                sCon.Open();
                string sSqlSelect = string.Empty;
                sSqlSelect = " SELECT ''                                  AS CODE        ";
                sSqlSelect += "        ,'전체조회'                        AS CODE_NAME   ";
                sSqlSelect += "    FROM TB_User                                          ";
                sSqlSelect += "    UNION                                                 ";
                sSqlSelect += "    SELECT MINORCODE                       AS CODE        ";
                sSqlSelect += "    	   ,'[' + MINORCODE + ']' + CODENAME  AS CODE_NAME   ";
                sSqlSelect += "      FROM TB_Standard                                    ";
                sSqlSelect += $"     WHERE MAJORCODE = '{sMajorcode}'                    ";
                sSqlSelect += "       AND MINORCODE<> '$'                                ";

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter = new SqlDataAdapter(sSqlSelect, sCon);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                //콤보박스에 데이터 등록하기
                TempCombo.DataSource    = dtTemp;
                TempCombo.ValueMember   = "CODE";
                TempCombo.DisplayMember = "CODE_NAME";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sCon.Close();
            }
        }


        static public DataTable GetCombo_Standard_Grid(string sMajorcode)
        {
            SqlConnection sCon = new SqlConnection(Commons.strCon);
            DataTable dtTemp = new DataTable();

            try
            {
                sCon.Open();
                string sSqlSelect = string.Empty;
                sSqlSelect = " SELECT ''                                  AS CODE        ";
                sSqlSelect += "        ,'전체조회'                        AS CODE_NAME   ";
                sSqlSelect += "    FROM TB_User                                          ";
                sSqlSelect += "    UNION                                                 ";
                sSqlSelect += "    SELECT MINORCODE                       AS CODE        ";
                sSqlSelect += "    	   ,'[' + MINORCODE + ']' + CODENAME  AS CODE_NAME   ";
                sSqlSelect += "      FROM TB_Standard                                    ";
                sSqlSelect += $"     WHERE MAJORCODE = '{sMajorcode}'                    ";
                sSqlSelect += "       AND MINORCODE<> '$'                                ";

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter = new SqlDataAdapter(sSqlSelect, sCon);
                
                adapter.Fill(dtTemp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sCon.Close();
            }
            return dtTemp;
        }


        public static void SetGridComboBox(DataGridView dgv, string sMajorcode, string sColumnID = null, bool AfterSearch = true)
        {
            if (sColumnID == null)
            {
                sColumnID = sMajorcode;
            }
            // 1. 그리드 콤보박스에 세팅할 공통기준정보의 sMajorcode 데이터 가져오기
            DataTable dtTemp = GetCombo_Standard_Grid(sMajorcode);

            // 2. 가져온 정보를 콤보박스화 해주기.
            if (dtTemp.Rows.Count == 0)
            { return; }

            if (AfterSearch == true)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    // 생성한 콤보박스 유형의 그리드 콤보박스 컨트롤을 부서 컬럼에 매핑.
                    dgv.Rows[i].Cells[sColumnID] = _MakeGridComboBox(dtTemp);
                }
            }
            else            // AfterSearch 값이 false일 때 -> 신규 행이 추가될 때 콤보박스 세팅하기 ..
            {
                // 생성한 콤보박스 유형의 그리드 콤보박스 컨트롤을 부서 컬럼에 매핑.
                dgv.Rows[dgv.Rows.Count-1].Cells[sColumnID] = _MakeGridComboBox(dtTemp);
            }
        }

        private static DataGridViewCell _MakeGridComboBox(DataTable dttemp)
        {
            // Combobox유형의 셀을 생성.
            DataGridViewComboBoxCell CellC = new DataGridViewComboBoxCell();
            // 콤보박스 셀의 유형을 콤보박스로 선택.
            CellC.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            // 콤보박스에 데이터 등록
            CellC.DataSource    = dttemp;
            CellC.DisplayMember = "CODE_NAME";
            CellC.ValueMember   = "CODE";
            return CellC;
        }
    }
   
}
