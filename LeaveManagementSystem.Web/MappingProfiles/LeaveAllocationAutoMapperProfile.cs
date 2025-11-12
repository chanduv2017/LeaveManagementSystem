using LeaveManagementSystem.Web.Models.LeaveAllocations;
using LeaveManagementSystem.Web.Models.LeaveTypes;
using LeaveManagementSystem.Web.Models.Periods;
using AutoMapper;

namespace LeaveManagementSystem.Web.MappingProfiles;

public class LeaveAllocationAutoMapperProfile :Profile
{
    public LeaveAllocationAutoMapperProfile() {
        CreateMap<LeaveAllocation, LeaveAllocationVM>();
        CreateMap<ApplicationUser, EmployeeListVM>();
        CreateMap<Period, PeriodVM>();
    }
}
