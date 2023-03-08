using System.Data.SqlClient;




var connStr = "";

try
{
    //wypisać na konsolę liczbę użytkowników - count()
    using (var conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFTestDb;Integrated Security=True"))
    {
        conn.Open();

        SqlCommand command = new SqlCommand();
        command.CommandText = "SELECT Count(*) FROM USERS";

        int count = (int)command.ExecuteScalar();
        Console.WriteLine(count);

    }

    //wypisać na konsolę liczbę użytkowników - count()
    //wypisać na konsolę użytkowników z ich rolami w formacie user.Name : group.Name
    using (var conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFTestDb;Integrated Security=True"))
    {
        conn.Open();
        SqlCommand command = conn.CreateCommand();
        command.CommandText = @"select U.Name, g.Name as 'GroupName'
                                from USERS u  
                                LEFT join UserGroups ug 
                                    on ug.UserId = u.Id 
                                LEFT join Groups g 
                                    on ug.GroupId = g.Id";

        SqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {
            string userName = dataReader["Name"].ToString();
            string groupName = dataReader["GroupName"]?.ToString();
            Console.WriteLine(userName + " : " + groupName);

        }
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex);
}