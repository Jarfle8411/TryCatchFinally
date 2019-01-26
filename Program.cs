using System; 

using System.Collections.Generic; 

using System.Data.SqlClient; 

using System.Linq; 

using System.Text; 

 

namespace YELLOW 

{ 

    class Program 

    { 

        static void Main(string[] args) 

        { 

            //create a SWL Connection with required connection string 

            SqlConnection myConnection = new SqlConnection( 

                "Trusted_Connection = ues;" + 

                "Server=localhost;" + 

                "Database = xyz;" + 

                "connection timeout = 10"); 

            try 

            { 

                myConnection.Open(); 

                Console.WriteLine("myConnection to Database Sucessful...."); 

            } 

            catch (Exception e) 

            { 

                Console.WriteLine("There are connection errors..... \n=============================\n"); 

                Console.WriteLine(e.Message); 

            } 

 

            finally 

            { 

                Console.WriteLine("Closing connection to data base....."); 

                myConnection.Close(); 

            } 

 

        } 

    } 

} 

 