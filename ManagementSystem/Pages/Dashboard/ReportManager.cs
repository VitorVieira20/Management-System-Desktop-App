using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace ManagementSystem.Pages.Dashboard
{
    public static class ReportManager
    {
        private static string connectionString = Configuration.ConnectionString;

        /// <summary>
        /// Set the header of the ListView
        /// </summary>
        /// <param name="chReportHeader1"></param>
        /// <param name="header1Text"></param>
        /// <param name="chReportHeader2"></param>
        /// <param name="header2Text"></param>
        public static void SetColumnsHeaders(ColumnHeader chReportHeader1, string header1Text, ColumnHeader chReportHeader2, string header2Text)
        {
            chReportHeader1.Text = header1Text;
            chReportHeader2.Text = header2Text;
        }

        /// <summary>
        /// Populates the listView with the given data
        /// </summary>
        /// <param name="data"> Data to use the listView</param>
        /// <param name="listView">ListView to populate with data</param>
        public static void PopulateReport(List<(string, string)> data, ListView listView)
        {
            listView.Items.Clear();
            foreach (var item in data)
            {
                var listViewItem = new ListViewItem(item.Item1);
                listViewItem.SubItems.Add(item.Item2);
                listView.Items.Add(listViewItem);
            }
        }

        /// <summary>
        /// Gets the total revenue (sales) by month
        /// </summary>
        /// <returns>A list of type (month(string), revenue(string))</returns>
        public static List<(string, string)> GetMonthlySalesData()
        {
            var salesData = new List<(string, string)>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                WITH RECURSIVE months_years AS (
                    SELECT 
                        YEAR(CURRENT_DATE) AS year,
                        MONTH(CURRENT_DATE) AS month
                    UNION ALL
                    SELECT 
                        CASE 
                            WHEN month = 1 THEN year - 1 
                            ELSE year 
                        END AS year,
                        CASE 
                            WHEN month = 1 THEN 12 
                            ELSE month - 1 
                        END AS month
                    FROM 
                        months_years
                    WHERE 
                        (year > 2022) OR (year = 2022 AND month >= 1)  -- Ajuste o intervalo conforme necessário
                )
                SELECT 
                    my.year,
                    my.month,
                    COALESCE(SUM(s.total_amount), 0) AS total_sales
                FROM 
                    months_years my
                LEFT JOIN 
                    systemmanagement.sales s
                    ON YEAR(s.date) = my.year
                    AND MONTH(s.date) = my.month
                GROUP BY 
                    my.year,
                    my.month
                ORDER BY 
                    my.year,
                    my.month;
            ";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int year = Convert.ToInt32(reader["year"]);
                        int month = Convert.ToInt32(reader["month"]);

                        string formattedDate = $"{month:D2}/{year}";

                        string totalSales = reader["total_sales"].ToString();

                        salesData.Add((formattedDate, totalSales));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return salesData;
        }
    }
}
