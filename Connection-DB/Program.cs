using Connection_DB;
using Npgsql;


string db = "Host=localhost;Port=5455;Username=postgres;Password=postgres;Database=myDB";

await using var myDB = NpgsqlDataSource.Create(db);

await using (var table = myDB.CreateCommand("CREATE TABLE IF NOT EXISTS Users (ID SERIAL PRIMARY KEY, FullName VARCHAR(100), Username VARCHAR(20) UNIQUE, Password VARCHAR(20), Email varchar(100) UNIQUE, DoB Date);"))
{
    await table.ExecuteNonQueryAsync();
}

Users user = new Users();

user.RegisterUser();

await using (var users = myDB.CreateCommand("INSERT INTO Users (FullName, Username, Password, Email, DoB) VALUES (@Fullname, @Username, @Password, @Email, @DoB) "))
{
    users.Parameters.AddWithValue("@Fullname", user.fullname);
    users.Parameters.AddWithValue("@Username", user.username);
    users.Parameters.AddWithValue("@Password", user.password);
    users.Parameters.AddWithValue("@Email", user.email);
    users.Parameters.AddWithValue("@DoB", DateTime.Parse(user.DoB));
    await users.ExecuteNonQueryAsync();
}






