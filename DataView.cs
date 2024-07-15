using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm1
{
    public class DataView
    {
        private static List<SalesData> DataSource;
        private void BindDataToGrid(List<SalesData> data)
        {
            DataView.DataSource = data;
        }
    }
}
