using System;
using Microsoft.Data.SqlClient;

Console.WriteLine($"Runtime Version: {Environment.Version}");

string connectionString = @"Server=localhost\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

try
{
    using SqlConnection connection = new SqlConnection(connectionString);
    connection.Open();

    string query = "SELECT COUNT(*) FROM Studentet";
    using SqlCommand command = new SqlCommand(query, connection);

    int nrRreshta = Convert.ToInt32(command.ExecuteScalar());
    Console.WriteLine($"Nr i rreshtave ne tabelen Studentet: {nrRreshta}");
}
catch (Exception ex)
{
    Console.WriteLine($"Gabim gjate lidhjes me databazen: {ex.Message}");
}