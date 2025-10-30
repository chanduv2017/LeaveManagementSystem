using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Web.Data
{
    public class LeaveType
    {
        public int Id { get; set; }
        //[Column(TypeName = "nvarchar(150")]
        [MaxLength(150)]

        public string Name { get; set; }=String.Empty;

        public int NumberOfDays { get; set; }



    }
}


// dotnet ef migrations add migration_name
// dotnet ef migrations remove
// dotnet ef database update

//add-migration migration_name
//Remove-Migration
//update-database