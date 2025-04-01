using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LinqDemo
{
    public class LinqToArray
    {
        public static void Main(String[] a)
        {
            //int[] numbers = { 10, 25, 17, 5, 30, 22 };

            //var evenNumbers = from num in numbers
            //                  where num % 2 == 0
            //                  select num;

            //Console.WriteLine("Even Numbers in Array:");
            //foreach (var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}


            //Linq with sql

            string connectionString = "Data Source=KRUSHNA;Initial Catalog=StudentDB1;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID, Name, Age FROM Students";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                var students = from DataRow row in table.Rows
                               where Convert.ToInt32(row["Age"]) > 20
                               select new
                               {
                                   ID = row["ID"],
                                   Name = row["Name"],
                                   Age = row["Age"]
                               };

                Console.WriteLine("Students older than 20:");
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.ID}: {student.Name} - {student.Age} years old");
                }
                Console.WriteLine();
            }
        }
    }
}