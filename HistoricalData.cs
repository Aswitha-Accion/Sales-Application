using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm1
{
    public class HistoricalData
    {
       

        private static List<SalesData> SeedForecastData(List<SalesData> historicalData, int year)
        {
            var forecastData = historicalData.Where(data => data.Year == year)
                                              .Select(data => new SalesData
                                              {
                                                  State = data.State,
                                                  Year = data.Year,
                                                  SalesValue = data.SalesValue,
                                                  ForecastedSalesPercentageIncrease = data.ForecastedSalesPercentageIncrease
                                              }).ToList();
            return forecastData;
        }
    }
}
