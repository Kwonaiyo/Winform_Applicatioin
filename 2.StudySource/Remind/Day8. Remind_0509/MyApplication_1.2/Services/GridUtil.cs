﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Services
{
    public class GridUtil
    {
        DataTable dtTemp = new DataTable();
        public void InitColumnGridUtil(DataGridView dgv, string ColumnID, string ColumnName, Type ColumnType, int ColumnWidth, bool editable, bool visible)
        {
            // DataTable에 컬럼 키 등록.
            dtTemp.Columns.Add(ColumnID, ColumnType);
            dgv.DataSource = dtTemp;                            // 그리드에 컬럼의 Key 등록
            dgv.Columns[ColumnID].HeaderText = ColumnName;      // 컬럼 Key의 컬럼 명칭
            dgv.Columns[ColumnID].Width = ColumnWidth;          // 컬럼의 넓이
            dgv.Columns[ColumnID].ReadOnly = !editable;          // 수정가능 여부
            dgv.Columns[ColumnID].Visible = visible;            // visible 여부
        }
    }
}
