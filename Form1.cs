using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm1
{
    public partial class Form1 : Form
    {
        private readonly object historicalData;
        private readonly object forecastData;
        private readonly object textBoxIncrement;
        private List<SalesData> data;
        private object ForecastData;
        private string filePath;

        public object comboBoxYear { get; set; }
        public object ConfigurationHelper { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSeed_Click(object sender, EventArgs e)
        {
            int selectedYear = int.Parse(comboBoxYear.ToString());
            ForecastData = SeedForecastData(historicalData, selectedYear);
            BindDataToGrid(ForecastData);
        }

        private void BindDataToGrid(object forecastData)
        {
            throw new NotImplementedException();
        }

        private object SeedForecastData(object historicalData, int selectedYear)
        {
            throw new NotImplementedException();
        }

        private void buttonApplyForecast_Click(object sender, EventArgs e)
        {
            decimal incrementPercentage = decimal.Parse(textBoxIncrement.Text);
            ForecastIncrement(forecastData, incrementPercentage);
            BindDataToGrid(forecastData);
        }

        private void ForecastIncrement(object forecastData, decimal incrementPercentage)
        {
            throw new NotImplementedException();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportCSV(ForecastData, saveFileDialog.FileName);
            }
        }

        private void ExportCSV(object forecastData, string fileName)
        {
            var lines = new List<string> { "State,Year,SalesAmount,ForecastedSalesAmount" };
            lines.AddRange(data.Select(d => $"{d.State},{d.Year},{d.SalesValue},{d.ForecastedSalesPercentageIncrease}"));
            File.WriteAllLines(filePath, lines);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConnectToDatabase()
        {
            string connectionString = ConfigurationHelper.GetConnectionString("MyDbConnection");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection Successful!");
                    string query = "SELECT State, SUM(Sales) AS TotalSales FROM Orders WHERE Year = @year GROUP BY State";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@year", Year);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Process data
                            }
                        }
                        using (StreamWriter writer = new StreamWriter("forecasted_data.csv"))
                        {
                            writer.WriteLine("State,Percentage Increase,Sales Value");
                            foreach (var data in forecastedData)
                            {
                                writer.WriteLine($"{data.State},{data.PercentageIncrease},{data.SalesValue}");
                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }



        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectToDatabase();
        }
    }
}

