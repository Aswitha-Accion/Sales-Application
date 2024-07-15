using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm1
{
    public  class ForecastIncrementData
    {
        

        private void ApplyForecastIncrement(List<SalesData> forecastData, decimal incrementPercentage, int dataSalesValue)
        {
            foreach (var data in forecastData)
            {
                data.ForecastedSalesPercentageIncrease = (float)((dataSalesValue * 1) + (incrementPercentage / 100));
            }
        }
    }
}
