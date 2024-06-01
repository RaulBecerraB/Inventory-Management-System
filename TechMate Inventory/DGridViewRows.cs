using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMate_Inventory
{
    internal class DGridViewRows
    {
        public static bool isSelectedRowAHeader(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                return true;
            }

            return false;
        }

        public static int ReturnSelectedRowID(DataGridViewCellEventArgs e, string lookForID, DataGridView vw)
        {
            DataGridViewRow clickedRow = vw.Rows[e.RowIndex];

            //selected row ID
            return (int)clickedRow.Cells[lookForID].Value;
        }
    }
}
