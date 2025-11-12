using DocumentFormat.OpenXml.Wordprocessing;
using LeaveManagementSystem.Web.Data;

namespace LeaveManagementSystem.Web.Models.LeaveAllocations;

public class EmployeeAllocationVM : EmployeeListVM
{
    
    [Display(Name ="Date Of Birth")]
    [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}")]
    [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
    public DateOnly DateOfBirth { get; set; }
    public bool IsCompletedAllocation { get; set; }

   

    public List<LeaveAllocationVM> LeaveAllocations { get; set; }
}
