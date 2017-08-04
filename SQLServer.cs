using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConcurrentTransSimulator
{
    class SQLServer
    {
        public void ConnectToServer(Simulator simulator)
        {
            Simulator Simulator = simulator;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=" + txbServer.Text + "," + cbPort.Text + ";Network Library=DBMSSOCN;Initial Catalog=" + txbDatabase.Text.Trim() + ";User Id=" + txbLogin.Text + ";Password=" + txbPassword.Text;
                addLine(string.Format("Starting connect to SQL Server database: {0} .......", txbServer.Text));
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    addLine(string.Format("Failed Connect to SQL Server database: {0} .......", ex.Message));
                }

                addLine(string.Format("Starting connect to SQL Server database: {0} .......", txbServer.Text));
                //start a local transaction.
                SqlTransaction sqltran = conn.BeginTransaction();

                //enlist a command in the current transaction.
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.Transaction = sqltran;

                try
                {
                    //Execute two separate commands.
                    command.CommandText = "Insert into dbo.Jack values(1,'jack',2000,'wrong size')";
                    addLine(string.Format("Insert into first record: {0}", "Insert into product.scrapReason values('wrong size')"));
                    command.ExecuteNonQuery();
                    addLine(string.Format("Execute......"));
                    command.CommandText = "Insert into dbo.Jack values(2,'jack',2000,'wrong color')";
                    addLine(string.Format("Insert into second record: {0}", "the second"));
                    command.ExecuteNonQuery();
                    addLine(string.Format("Execute......"));

                    //Commit the transaction.
                    sqltran.Commit();

                    addLine("Both records were written to database", Color.Blue, true);
                }
                catch
                    (Exception ex)
                {
                    //Handle the exception if the transaction fails to commit.
                    addLine(string.Format("Execution failed: {0}", ex.Message), Color.Red, true);

                    try
                    {
                        //Attempt to roll back the transaction.
                        sqltran.Rollback();
                    }
                    catch (Exception exrollback)
                    {
                        //Throws an InvalidOperationException if the connection is closed or the transaction has already been
                        //Rolled back on the server.
                        addLine(string.Format("Roll back failed: {0}", exrollback.Message), Color.Red, true);
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
