using MySql.Data.MySqlClient;

GetAllProduct();
 
static void GetAllProduct()
{
    using (var connection = GetMySqlConnection()) 
    {
        try
        {

            connection.Open();
            var sql = "select * from products";
            MySqlCommand command =new MySqlCommand(sql, connection);
            MySqlDataReader reader=command.ExecuteReader();

            while(reader.Read())
            {
                Console.WriteLine(reader.GetString(3));
                Console.WriteLine($"Price:{reader[6]}");
            }
            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
    }
}
static MySqlConnection GetMySqlConnection()
{
    string connectionString = @"server=localhost;port=3306;database=northwind;user=root;password=mysql1234";
    return new MySqlConnection(connectionString);
}