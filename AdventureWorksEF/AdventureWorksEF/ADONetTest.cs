using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdventureWorksEF
{
    public class ADONetTest
    {
        public static void Select()
        {
            var connectString = "Server=(local);Database=AdventureWorks2012;Trusted_Connection=True;";

            DbConnection conn;
            DbDataReader dbReader;


            using (conn = new SqlConnection(connectString))
            {
                conn.Open();

                try
                {
                    DbCommand cmd = conn.CreateCommand();
                    cmd.Connection = conn;

                    try
                    {
                        cmd.CommandText = "SELECT s.Name, c.AccountNumber FROM sales.Store s LEFT JOIN Sales.Customer c ON c.StoreID = s.BusinessEntityID ORDER BY s.Name";
                        dbReader = cmd.ExecuteReader();

                        var storeName = "";
                        while (dbReader.Read())
                        {
                            if (storeName != dbReader[0].ToString())
                            {
                                storeName = dbReader[0].ToString();
                                Console.WriteLine(dbReader[0].ToString());
                            }
                            Console.WriteLine("  " + dbReader[1].ToString());
 
                        }
                    }
                    catch (DbException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        cmd.Dispose();
                    }
                }
                finally
                {
                    conn.Close();
                }

            }

        }
    }
}
