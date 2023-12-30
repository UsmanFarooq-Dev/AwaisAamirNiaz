using System.Data.SQLite;
using System.Data;
using Dapper;

namespace AwaisAamirNiaz.Blazor.Database;

public class DataAccess
{
    public static List<DiseaseModel> GetDiseases(string connectionString)
    {
        using (IDbConnection con = new SQLiteConnection(connectionString))
        {
            //var employees = con.Query<Employee>("Select Id, Name EmpName, Age from Employees;");
            var diseases = con.Query<DiseaseModel>("SELECT Id, Part, Color, Appearance, WheatDisease FROM Disease;").AsList();
            return diseases;
        }

    }

    //public static int AddEmployee(string connectionString, DiseaseModel employee)
    //{
    //    using (IDbConnection con = new SQLiteConnection(connectionString))
    //    {
    //        string qry = $"Insert into Employees (Name, Age) Values('{employee.Name}', {employee.Age})";

    //        var result = con.Execute(qry);
    //        return result;
    //    }

    //}
}
