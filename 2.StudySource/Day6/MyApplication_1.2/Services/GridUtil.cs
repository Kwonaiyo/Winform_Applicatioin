using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Services
{
    public class GridUtil
    {
        DataTable dtGrid = new DataTable();

        public void InitColumnGridUtil(DataGridView dgv, string ColumnID, string ColumnName, Type ColumnType, DataGridViewContentAlignment align, int ColumnWidth, bool editable, bool visible)
        {
            dtGrid.Columns.Add(ColumnID, ColumnType);
            dgv.DataSource = dtGrid;
            dgv.Columns[ColumnID].HeaderText                 = ColumnName;
            dgv.Columns[ColumnID].Width                      = ColumnWidth;
            dgv.Columns[ColumnID].ReadOnly                   = !editable;
            dgv.Columns[ColumnID].Visible                    = visible;
            dgv.Columns[ColumnID].DefaultCellStyle.Alignment = align; 

        }

        
    }
}
