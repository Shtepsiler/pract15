using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Database database = new Database();

                if( database.TryConect()){
                database.GetOll();
                Console.WriteLine();
                database.GetOllType();
                Console.WriteLine();
                database.GetMenegers();
                Console.WriteLine();
                database.GetMaxCount();
                Console.WriteLine();
                database.GetMinCount();
                Console.WriteLine();
                database.GetMinSelfCost();
                Console.WriteLine();
                database.GetMaxSelfCost();
            }
            else Console.WriteLine("can`t connect");
          




            
        }
    }
}
