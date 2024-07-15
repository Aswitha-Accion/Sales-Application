using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm1
{
    public class ExportCSV
    {

        private void ExportToCsv(List<SalesData> data, string filePath)
        {
            var lines = new List<string> { "State,Year,SalesAmount,ForecastedSalesAmount" };
            lines.AddRange(data.Select(d => $"{d.State},{d.Year},{d.SalesValue},{d.ForecastedSalesPercentageIncrease}"));
            File.WriteAllLines(filePath, lines);
        }


    }
}
