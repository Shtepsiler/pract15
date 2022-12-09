using System;
using System.Text;
using System.Data.SqlClient;







namespace практична_15
{
    internal class Program
    {
        static string connectionString = @"Data Source=LAPTOP-2CTM7RH1\SHTEPSILL;Initial Catalog=Stud_Grad;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection connection = new SqlConnection(connectionString);

        //Відображення всієї інформації з таблиці зі студентами та оцінками;
        public static void GetOll()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = Program.connection;
            cmd.CommandText = "select * from Stud_Grad";
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
                        Console.Write($"{(int)Reader.GetInt32(i)}              ");
                    }
                Console.WriteLine();
            }

            connection.Close();

        }


        static void TryConect()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString)) { 
                conn.Open(); 
                    Console.WriteLine("connect");
            }
            }
            catch
            {
                throw new Exception("can not connect");
            }

        }

        //Відображення ПІБ усіх студентів
        public static void Getpib()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = Program.connection;
            cmd.CommandText = "select Name,Surname,[Group] from Stud_Grad";
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
                        Console.Write($"{(int)Reader.GetInt32(i)}              ");
                    }
                Console.WriteLine();
            }

            connection.Close();

        }
        //Відображення всіх середніх оцінок
        public static void Getavg()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = Program.connection;
            cmd.CommandText = "select AwgOll from Stud_Grad";
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
                        Console.Write($"{(int)Reader.GetInt32(i)}              ");
                    }
                Console.WriteLine(  );
            }

            connection.Close();

        }

        //Показати ПІБ всіх студентів з мінімальною оцінкою, більше, ніж зазначена
        public static void GetMinThen(string numb)
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = Program.connection;
            SqlParameter sqlParameter = new SqlParameter("@numb",numb);
            cmd.Parameters.Add(sqlParameter);
            cmd.CommandText = $"select Name,Surname from Stud_Grad where AwgMin> @numb";
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
                        Console.Write($"{(int)Reader.GetInt32(i)}              ");
                    }
                Console.WriteLine();
            }

            connection.Close();

        }

        //Показати ПІБ всіх студентів з середньою оцінкою, більше за серевню зі всіх
        public static void GetMinGrad()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = Program.connection;
            cmd.CommandText = $"select AwgMin from Stud_Grad where AwgOll >(select avg(AwgOll)from Stud_Grad ) ";
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
                        Console.Write($"{(int)Reader.GetInt32(i)}              ");
                    }
                Console.WriteLine();
            }

            connection.Close();

        }

        public static void GetMin()
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = Program.connection;
            cmd.CommandText = $"select  DISTINCT AwgMin from Stud_Grad";
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
                        Console.Write($"{(int)Reader.GetInt32(i)}              ");
                    }
                Console.WriteLine();
            }

            connection.Close();

        }


        public static void Get(string comand)
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = Program.connection;
            cmd.CommandText = comand;
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
                        Console.Write($"       {(int)Reader.GetInt32(i)}         ");
                    }
                Console.WriteLine();
            }

            connection.Close();
        }

        public static void Min()
        {
            Get("select min(AwgOll) from Stud_Grad");
        }
        public static void Max()
        {
            Get("select max(AwgOll) from Stud_Grad");
        }

        public static void CountMathStud()
        {
            Get("select count(*) from Stud_Grad where [AwgMin] = 'math'");
        }

        public static void CountMinperSubg(string subg)
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = Program.connection;
            SqlParameter sqlParameter = new SqlParameter("@subg", subg);
            cmd.Parameters.Add(sqlParameter);
            cmd.CommandText = $"select count(*) from Stud_Grad where [AwgMin] = @subg";
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
                        Console.Write($"{(int)Reader.GetInt32(i)}              ");
                    }
                Console.WriteLine();
            }

            connection.Close();

        }
        public static void CountMaxperSubg(string subg)
        {
            connection.Open();
            var cmd = new SqlCommand();
            cmd.Connection = Program.connection;
            SqlParameter sqlParameter = new SqlParameter("@subg", subg);
            cmd.Parameters.Add(sqlParameter);
            cmd.CommandText = $"select count(*) from Stud_Grad where [AwgMax] = @subg";
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
                        Console.Write($"{(int)Reader.GetInt32(i)}              ");
                    }
                Console.WriteLine();
            }

            connection.Close();

        }
       
  public static void CountInGroup()
        {
            Get("select [Group] , count(*) as count from Stud_Grad group by[Group]");
        }












        public static void Main(string[] args)
        {
            GetOll();
            Console.WriteLine();
            TryConect();
            Console.WriteLine();
            Getpib();
            Console.WriteLine();
            Getavg();
            Console.WriteLine();
            GetMinThen("1");
            Console.WriteLine();
            GetMinGrad();
            Console.WriteLine();
            GetMin();
            Console.WriteLine();
            Min();
            Console.WriteLine();
            Max();
            Console.WriteLine();
            CountMathStud();
            Console.WriteLine();
            CountMinperSubg("math");
            Console.WriteLine();
            CountMaxperSubg("math");
            Console.WriteLine();
            CountInGroup();





        }
    }
}
