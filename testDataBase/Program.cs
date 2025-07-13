using System;
using Npgsql;

class Program
{
    static void Main()
    {
        // اتصال بقاعدة البيانات
        var connString = "Host=localhost;Username=postgres;Password=1907;Database=testdb";

        using var conn = new NpgsqlConnection(connString);
        conn.Open();

        Console.WriteLine("✔️ Connected to PostgreSQL successfully!\n");

        // تنفيذ استعلام
        using var cmd = new NpgsqlCommand("SELECT id, name, age, grade, number FROM students", conn);
        using var reader = cmd.ExecuteReader();

        // قراءة النتائج
        Console.WriteLine("ID\tName\tAge\tGrade\tNumber");
        Console.WriteLine("-------------------------------------");

        while (reader.Read())
        {
            Console.WriteLine($"{reader.GetInt32(0)}\t{reader.GetString(1)}\t{reader.GetInt32(2)}\t{reader.GetString(3)}\t{reader.GetInt32(4)}");
        }
    }
}       