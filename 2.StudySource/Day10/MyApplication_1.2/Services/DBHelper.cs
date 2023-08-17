using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    // 시스템에서 데이터베이스 관련 작업을 할 경우, 데이터베이스 작업을 도와줄 수 있는 로직이 포함되어 있는 클래스.

    public class DBHelper
    {
        // 프로시저 성공여부
        public string RS_CODE { get; set; }

        // 프로시저 메세지
        public string RS_MSG { get; set; } 

        // 1. 데이터베이스 접속 정보
        public SqlConnection sCon = new SqlConnection(Commons.strCon);



        // 3. 트랜잭션을 위한 객체 생성.
        public SqlTransaction Tran;
        public DBHelper(bool Transaction = false)
        {
            // DBHelper 클래스를 인스턴스화할 때의 시점.
            sCon.Open();
            if (Transaction)
            {
                Tran = sCon.BeginTransaction();
            }
        }

        public void Rollback()
        {
            if (Tran != null)
            {
                Tran.Rollback();
            }
        }

        public void Commit()
        {
            if (Tran != null)
            {
                Tran.Commit();
            }
        }

        /// <summary>
        /// 데이터베이스 조회하는 공통메서드(프로시저 방식)
        /// </summary> 
        /// <param name="sSpName"> 호출할 프로시저 이름 </param>
        /// <param name="ComType"> SQL 호출 유형 (text: Insql, SP: Stored Procedure </param>
        /// <param name="parameters"> 파라메터에 등록할 이름과 값</param>
        public DataTable FillTable(string sSpName, CommandType ComType, params Params_[] parameters)
        {
            // 데이터베이스 조회 및 결과 반환 Adapter 생성
            SqlDataAdapter Adapter;

            //저장프로시저를 실행할 SqlAdatper를 선언.
            Adapter = new SqlDataAdapter(sSpName, Commons.strCon);

            // 저장 프로시저 형태로 실행하는 것을 설정.
            Adapter.SelectCommand.CommandType = ComType;

            // Adapter가 프로시저에게 전달할 매개변수(파라메터) 등록.
            foreach (Params_ param in parameters)
            {
                Adapter.SelectCommand.Parameters.AddWithValue(param.ParamsName, param.ParamsValue);
            }


            Adapter.SelectCommand.Parameters.AddWithValue("@LANG", "");
            Adapter.SelectCommand.Parameters.AddWithValue("@RS_CODE", "").Direction = ParameterDirection.Output;
            Adapter.SelectCommand.Parameters.AddWithValue("@RS_MSG", "").Direction = ParameterDirection.Output;

            DataTable dttemp = new DataTable();
            Adapter.Fill(dttemp);
            return dttemp;
        }



        public void Close()
        {
            sCon.Close();
        }

        public Params_ CreateParameters(string sParamName, string sParamValue)
        {
            // 프로시저에 전달할 파라메터 이름과 값을 세팅할 메서드. 
            Params_ param = new Params_() { ParamsName = sParamName, ParamsValue = sParamValue };

            //param.ParamsName = sParamName;
            //param.ParamsValue = sParamValue;

            return param;
        }

        public void ExecuteNonQuery(string sSpName, CommandType ComType, params Params_[] parameters)
        {
            // 3. 커맨드 객체 생성
            SqlCommand Com = new SqlCommand();
            // 3-1. 트랜잭션 연결
            Com.Transaction = Tran;
            // 3-2. 접속정보 연결
            Com.Connection = sCon;
            // 3-3. 저장 프로시저 형태로 연결하는것을 선언
            Com.CommandType = ComType;

            Com.CommandText = sSpName;   // 프로시져 명

            foreach (Params_ param in parameters)
            {
                Com.Parameters.AddWithValue(param.ParamsName, param.ParamsValue);
            }


            Com.Parameters.AddWithValue("@LANG", "");
            Com.Parameters.AddWithValue("@RS_CODE", "").Direction = ParameterDirection.Output;
            Com.Parameters.AddWithValue("@RS_MSG", "").Direction = ParameterDirection.Output;

            Com.ExecuteNonQuery();

            RS_MSG = Convert.ToString(Com.Parameters["@RS_CODE"].Value);
            RS_CODE = Convert.ToString(Com.Parameters["@RS_MSG"].Value);
        }
    }




    // 데이터베이스에 전달할 인수 이름과 값을 저장할 클래스
    public class Params_
    {
        // 인수의 이름
        public string ParamsName { get; set; }

        // 인수가 전달할 값
        public string ParamsValue { get; set; }
    }

    
}
