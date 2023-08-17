﻿using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************************
 * namespace ( = 클래스 라이브러리, 어셈블리, DLL, API, 프로젝트 )
 * 하나 이상의 앱에서 호출되는 형식 및 메서드 등을 정의하여 dll형식으로 제공
 * 단독으로는 실행되지 않음
 *  1. 배포 및 재사용성이 용이
 *  2. dll 파일 내부의 소스만 변경 및 배포가 가능하므로 유지보수가 용이
 *  3. dll 내부의 소스는 외부 환경에서 확인할 수 없으므로 보안성이 향상
 * *************************************************************************/
namespace Services
{
    // Service : 실제 프로그램이 실행되는 로직에는 크게 관여하지 않고
    //           도움을 주는 역할의 로직들이 있는 모듈 (Biz)
    // Common : 서비스 로직이 포함되어 있는 클래스
    public class Commons
    {// const(상수) : static 포함
        public const string strCon = "Server = localhost; Uid = sa; Pwd = 1234; database = AppDev";
        public static bool bLoginSF = false; // 로그인 성공여부

        // 시스템 사용자 ID
        public static string UserId = "admin";
    }
}
