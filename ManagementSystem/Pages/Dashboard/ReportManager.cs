using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using DocumentFormat.OpenXml.Office2016.Presentation.Command;

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
                    Sales s
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

        /// <summary>
        /// Gets the best seller of each month
        /// </summary>
        /// <returns>A list of type (month(string), best sellere(string))</returns>
        public static List<(string, string)> GetBestSellingBookByMonthData()
        {
            var bestSellerData = new List<(string, string)>();

            try
            {
                using (var conn = new MySqlConnection(connectionString))
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
                    ),
                    sales_data AS (
                        SELECT 
                            my.year,
                            my.month,
                            b.title AS best_seller,
                            SUM(i.quantity) AS best_seller_quantity,
                            ROW_NUMBER() OVER (PARTITION BY my.year, my.month ORDER BY SUM(i.quantity) DESC) AS rn
                        FROM 
                            months_years my
                        LEFT JOIN 
                            Sales s
                            ON YEAR(s.date) = my.year
                            AND MONTH(s.date) = my.month
                        LEFT JOIN Sales_items i 
                            ON s.id = i.sales_id
                        LEFT JOIN Books b
                            ON i.book_id = b.id
                        GROUP BY 
                            my.year,
                            my.month,
                            b.title
                    )
                    SELECT 
                        my.year,
                        my.month,
                        sd.best_seller,
                        sd.best_seller_quantity
                    FROM 
                        months_years my
                    LEFT JOIN (
                        SELECT 
                            year,
                            month,
                            best_seller,
                            best_seller_quantity
                        FROM 
                            sales_data
                        WHERE 
                            rn = 1
                    ) sd
                    ON my.year = sd.year
                    AND my.month = sd.month
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
                        string bestSeller = reader["best_seller"] != DBNull.Value ? reader["best_seller"].ToString() : null;
                        int? bestSellerQuantity = reader["best_seller_quantity"] != DBNull.Value ? (int?)Convert.ToInt32(reader["best_seller_quantity"]) : null;
                        if (bestSeller != null)
                        {
                            bestSeller += $" ( {bestSellerQuantity} )";
                        }
                        bestSellerData.Add((formattedDate, bestSeller));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return bestSellerData;
        }

        /// <summary>
        /// Gets the best genre of each month
        /// </summary>
        /// <returns>A list of type (month(string), best sellere(string))</returns>
        public static List<(string, string)> GetBestSellingGenreByMonthData()
        {
            var bestSellerData = new List<(string, string)>();

            try
            {
                using (var conn = new MySqlConnection(connectionString))
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
                    ),
                    sales_data AS (
                        SELECT 
                            my.year,
                            my.month,
                            b.genre AS best_genre,
                            SUM(i.quantity) AS best_genre_quantity,
                            ROW_NUMBER() OVER (PARTITION BY my.year, my.month ORDER BY SUM(i.quantity) DESC) AS rn
                        FROM 
                            months_years my
                        LEFT JOIN 
                            Sales s
                            ON YEAR(s.date) = my.year
                            AND MONTH(s.date) = my.month
                        LEFT JOIN Sales_items i 
                            ON s.id = i.sales_id
                        LEFT JOIN Books b
                            ON i.book_id = b.id
                        GROUP BY 
                            my.year,
                            my.month,
                            b.genre
                    )
                    SELECT 
                        my.year,
                        my.month,
                        sd.best_genre,
                        sd.best_genre_quantity
                    FROM 
                        months_years my
                    LEFT JOIN (
                        SELECT 
                            year,
                            month,
                            best_genre,
                            best_genre_quantity
                        FROM 
                            sales_data
                        WHERE 
                            rn = 1
                    ) sd
                    ON my.year = sd.year
                    AND my.month = sd.month
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
                        string bestGenre = reader["best_genre"] != DBNull.Value ? reader["best_genre"].ToString() : null;
                        int? bestGenreQuantity = reader["best_genre_quantity"] != DBNull.Value ? (int?)Convert.ToInt32(reader["best_genre_quantity"]) : null;
                        if (bestGenre != null)
                        {
                            bestGenre += $" ( {bestGenreQuantity} )";
                        }
                        bestSellerData.Add((formattedDate, bestGenre));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return bestSellerData;
        }

        /// <summary>
        /// Gets the best buying client of each month
        /// </summary>
        /// <returns>A list of type (month(string), best seller(string))</returns>
        public static List<(string, string)> GetBestBuyingClientByMonthData()
        {
            var bestSellerData = new List<(string, string)>();

            try
            {
                using (var conn = new MySqlConnection(connectionString))
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
                    ),
                    sales_data AS (
                        SELECT 
                            my.year,
                            my.month,
                            c.name AS client_name,
                            c.email AS client_email,
                            SUM(s.total_amount) AS client_amount,
                            ROW_NUMBER() OVER (PARTITION BY my.year, my.month ORDER BY SUM(s.total_amount) DESC) AS rn
                        FROM 
                            months_years my
                        LEFT JOIN 
                            Sales s
                            ON YEAR(s.date) = my.year
                            AND MONTH(s.date) = my.month
                        LEFT JOIN Sales_items i 
                            ON s.id = i.sales_id
                        LEFT JOIN Clients c
                            ON s.client_id = c.id
                        GROUP BY 
                            my.year,
                            my.month,
                            c.id
                    )
                    SELECT 
                        my.year,
                        my.month,
                        sd.client_name,
                        sd.client_email,
                        sd.client_amount
                    FROM 
                        months_years my
                    LEFT JOIN (
                        SELECT 
                            year,
                            month,
                            client_name,
                            client_email,
                            client_amount
                        FROM 
                            sales_data
                        WHERE 
                            rn = 1
                    ) sd
                    ON my.year = sd.year
                    AND my.month = sd.month
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
                        string clientName = reader["client_name"] != DBNull.Value ? reader["client_name"].ToString() : null;
                        string clientEmail = reader["client_email"] != DBNull.Value ? reader["client_email"].ToString() : null;
                        string baseClient = $"{clientName} ( {clientEmail} )";
                        string client = "";
                        int ? clientAmount = reader["client_amount"] != DBNull.Value ? (int?)Convert.ToInt32(reader["client_amount"]) : null;
                        if (baseClient != " (  )")
                        {
                            client = baseClient += $" ( {clientAmount}$ )";
                        }
                        bestSellerData.Add((formattedDate, client));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return bestSellerData;
        }

        /// <summary>
        /// Gets the monthly revenue
        /// </summary>
        /// <returns>A list of type (month(string), revenue(string))</returns>
        public static List<(string, string)> GetMonthlyRevenueData()
        {
            var monthRevenueData = new List<(string, string)>();

            try
            {
                using (var conn = new MySqlConnection(connectionString))
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
                    ),
                    sales_data AS (
                        SELECT 
                            my.year,
                            my.month,
                            SUM(s.total_amount) AS month_revenue,
                            ROW_NUMBER() OVER (PARTITION BY my.year, my.month ORDER BY SUM(s.total_amount) DESC) AS rn
                        FROM 
                            months_years my
                        LEFT JOIN 
                            Sales s
                            ON YEAR(s.date) = my.year
                            AND MONTH(s.date) = my.month
                        GROUP BY 
                            my.year,
                            my.month
                    )
                    SELECT 
                        my.year,
                        my.month,
                        sd.month_revenue
                    FROM 
                        months_years my
                    LEFT JOIN (
                        SELECT 
                            year,
                            month,
                            month_revenue
                        FROM 
                            sales_data
                        WHERE 
                            rn = 1
                    ) sd
                    ON my.year = sd.year
                    AND my.month = sd.month
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
                        string revenue = reader["month_revenue"] != DBNull.Value ? reader["month_revenue"].ToString() : null;
                        if (revenue != null) 
                        {
                            revenue += "$";
                        }
                        monthRevenueData.Add((formattedDate, revenue));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return monthRevenueData;
        }
    }
}