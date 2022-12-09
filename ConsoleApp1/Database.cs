using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    internal class Database
    {
        static string connectionString = @"Data Source=LAPTOP-2CTM7RH1\SHTEPSILL;Initial Catalog=stationery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection connection = new SqlConnection(connectionString);

        public bool TryConect()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("connect");
                   
                } 
                return true;
            }
            catch
            { 
                return false;
               
            }

        }


        public  void GetOll()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select id,name,(select type.type from type where id=  stationery.type ) as type,[count],(select managers.manager from managers where id= stationery.meneger ) as manager,selfcost,(select byerfirm.byerfirm from byerfirm where id=  stationery.byerfirm ) as byerfirm, (select managers.manager from managers where id= stationery.soldmeneger) as soldmeneger,statsold,cost,solddate from stationery";
            SqlDataReader Reader = cmd.ExecuteReader();
            for (int i = 0; i < Reader.FieldCount; i++)
            {


                Console.Write($"{Reader.GetName(i)}         ");
            }
            Console.WriteLine();
            while (Reader.Read())
            {


                for (int i = 0; i < Reader.FieldCount; i++)
                    try
                    {
                        Console.Write($"{(object)Reader.GetString(i)}     ");
                    }
                    catch
                    {
                        try
                        {
                            Console.Write($"{(int)Reader.GetInt32(i)}              ");
                            }
                        catch
                        {
                            Console.Write($"{(DateTime)Reader.GetDateTime(i)}");
                        }
                    }

                Console.WriteLine();
            }

            connection.Close();

        }
        public  void GetOllType()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select DISTINCT (select type.type from type where id=  stationery.type ) as type from stationery";
            SqlDataReader Reader = cmd.ExecuteReader();
            for (int i = 0; i < Reader.FieldCount; i++)
            {


                Console.Write($"{Reader.GetName(i)}         ");
            }
            Console.WriteLine();
            while (Reader.Read())
            {


                for (int i = 0; i < Reader.FieldCount; i++)
                    try
                    {
                        Console.Write($"{(object)Reader.GetString(i)}     ");
                    }
                    catch
                    {
                        try
                        {
                            Console.Write($"{(int)Reader.GetInt32(i)}              ");
                        }
                        catch
                        {
                            Console.Write($"{(DateTime)Reader.GetDateTime(i)}");
                        }
                    }
                Console.WriteLine();
            }

            connection.Close();

        }

        public void GetMenegers()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select DISTINCT (select managers.manager from managers where id= stationery.meneger ) as manager from stationery";
            SqlDataReader Reader = cmd.ExecuteReader();
            for (int i = 0; i < Reader.FieldCount; i++)
            {


                Console.Write($"{Reader.GetName(i)}         ");
            }
            Console.WriteLine();
            while (Reader.Read())
            {


                for (int i = 0; i < Reader.FieldCount; i++)
                  try
                {
                    Console.Write($"{(object)Reader.GetString(i)}     ");
                }
                catch
                {
                    try
                    {
                        Console.Write($"{(int)Reader.GetInt32(i)}              ");
                    }
                    catch
                    {
                        Console.Write($"{(DateTime)Reader.GetDateTime(i)}");
                    }
                }
                Console.WriteLine();
            }

            connection.Close();

        }



        public void GetMaxCount()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select max(count) from stationery";
            SqlDataReader Reader = cmd.ExecuteReader();
            for (int i = 0; i < Reader.FieldCount; i++)
            {


                Console.Write($"{Reader.GetName(i)}         ");
            }
            Console.WriteLine();
            while (Reader.Read())
            {


                for (int i = 0; i < Reader.FieldCount; i++)
                    try
                    {
                        Console.Write($"{(object)Reader.GetString(i)}     ");
                    }
                    catch
                    {
                        try
                        {
                            Console.Write($"{(int)Reader.GetInt32(i)}              ");
                        }
                        catch
                        {
                            Console.Write($"{(DateTime)Reader.GetDateTime(i)}");
                        }
                    }
                Console.WriteLine();
            }

            connection.Close();

        }
        public void GetMinCount()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select min(count) from stationery";
            SqlDataReader Reader = cmd.ExecuteReader();
            for (int i = 0; i < Reader.FieldCount; i++)
            {


                Console.Write($"{Reader.GetName(i)}         ");
            }
            Console.WriteLine();
            while (Reader.Read())
            {


                for (int i = 0; i < Reader.FieldCount; i++)
                    try
                    {
                        Console.Write($"{(object)Reader.GetString(i)}     ");
                    }
                    catch
                    {
                        try
                        {
                            Console.Write($"{(int)Reader.GetInt32(i)}              ");
                        }
                        catch
                        {
                            Console.Write($"{(DateTime)Reader.GetDateTime(i)}");
                        }
                    }
                Console.WriteLine();
            }

            connection.Close();

        }


        public void GetMinSelfCost()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select min([selfcost]) from stationery";
            SqlDataReader Reader = cmd.ExecuteReader();
            for (int i = 0; i < Reader.FieldCount; i++)
            {


                Console.Write($"{Reader.GetName(i)}         ");
            }
            Console.WriteLine();
            while (Reader.Read())
            {


                for (int i = 0; i < Reader.FieldCount; i++)
                    try
                    {
                        Console.Write($"{(object)Reader.GetString(i)}     ");
                    }
                    catch
                    {
                        try
                        {
                            Console.Write($"{(int)Reader.GetInt32(i)}              ");
                        }
                        catch
                        {
                            Console.Write($"{(DateTime)Reader.GetDateTime(i)}");
                        }
                    }
                Console.WriteLine();
            }

            connection.Close();

        }
        public void GetMaxSelfCost()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select max([selfcost]) from stationery";
            SqlDataReader Reader = cmd.ExecuteReader();
            for (int i = 0; i < Reader.FieldCount; i++)
            {


                Console.Write($"{Reader.GetName(i)}         ");
            }
            Console.WriteLine();
            while (Reader.Read())
            {


                for (int i = 0; i < Reader.FieldCount; i++)
                    try
                    {
                        Console.Write($"{(object)Reader.GetString(i)}     ");
                    }
                    catch
                    {
                        try
                        {
                            Console.Write($"{(int)Reader.GetInt32(i)}              ");
                        }
                        catch
                        {
                            Console.Write($"{(DateTime)Reader.GetDateTime(i)}");
                        }
                    }
                Console.WriteLine();
            }

            connection.Close();

        }
















    }
}
