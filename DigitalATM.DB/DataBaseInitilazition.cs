using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalATM.DB
{
    public class DataBaseInitilazition
    {
        private string _connectionString { get; set; } = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=DigitalATM;Integrated Security=True";
        public static void InitDB()
        {
            DataBaseInitilazition init = new DataBaseInitilazition();
            init.CheckBank();
            init.CheckClient();
            init.CheckAccount();


        }
        private void CheckBank()
        {

            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "USE DigitalATM;" + "SELECT * FROM Bank;";
            cmd.Connection = con;
            con.Open();

            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               if(reader.GetValue(0) == null)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT Bank(BankName)" +
                        " VALUES " +
                        "('Leumi')";
                    cmd.CommandText = "INSERT Bank(BankName)" +
                        "VALUES " +
                        "('Bank-Yahav')";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
            reader.Close();
            con.Close();
            con.Dispose();

           
        }
         private void CheckClient()
        {

            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "USE DigitalATM;" + "SELECT * FROM Clients;";
            cmd.Connection = con;
            con.Open();

            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            var i = 0;
            while (reader.Read())
            {

                if (reader.GetValue(0) == null)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT Clients(FirstName,LastName)" +
                                   "VALUES('or', 'shani')";

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            reader.Close();
            con.Close();
            con.Dispose();

        }
        private void CheckAccount()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=DigitalATM;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "USE DigitalATM;" + "SELECT * FROM Account;";
            cmd.Connection = con;
            con.Open();

            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
      
            while (reader.Read())
            {
                if (reader.GetValue(0) == null)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT Account(UserName,Password,Balance,BankAccNumber,BankId,ClientId)" +
                        " VALUES " +
                        "('ORSHANI1','ORSHANI1',10000,1000,1,1)";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }


            }
            reader.Close();
            con.Close();
            con.Dispose();

        }

    }
}

