namespace StudentRecordManagementSystem.Utility
{
    public static class ConnectionString
    {
        private static string cName = @"Data Source=LAPTOP-QSRD0QRC\SQLEXPRESS; Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        
        public static string CName
        {
            get => cName;
        }
    }
}
