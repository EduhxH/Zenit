public static class DatabaseHelper
{
    private static string _conn =
        @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Zenit.accdb;";

    public static OleDbConnection GetConnection()
        => new OleDbConnection(_conn);
}
