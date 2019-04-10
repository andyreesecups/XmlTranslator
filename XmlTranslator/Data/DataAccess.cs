using System;
using System.Data.SqlClient;
using XmlTranslator.Models;

namespace XmlTranslator.Data
{
    public static class DataAccess
    {
        private static string reportConnectionString = "Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=";

        public static bool InsertDataToDatabase(Invoice invoice, out string Message)
        {
            Message = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(reportConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = System.Data.CommandType.Text;

                        command.CommandText = @"INSERT INTO TABLENAME (COLUMN1, COLUMN2, COLUMN3, COLUMN4)
                                                VALUES (@PARAM1, @PARAM2, @PARAM3, @PARAM4);";

                        // Add parameters 
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@PARAM1", invoice.InvoiceNumber);
                        command.Parameters.AddWithValue("@PARAM2", invoice.InvoiceAmount);
                        command.Parameters.AddWithValue("@PARAM3", invoice.LocalNetAmount);
                        command.Parameters.AddWithValue("@PARAM4", invoice.InvoiceType);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception exc)
            {
                Message = exc.ToString();
                return false;
            }
        }
    }
}
