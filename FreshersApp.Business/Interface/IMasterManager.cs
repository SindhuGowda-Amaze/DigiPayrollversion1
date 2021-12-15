using FreshersApp.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Business.Interface
{
    public interface IMasterManager
    {
        IEnumerable<dynamic> GetCostcenter();

        Int64 InsertCostcenter(MasterEntity entity);

        Int64 UpdateCostcenter(MasterEntity entity);
        Int64 DeleteCostcenter(object filter);

        IEnumerable<dynamic> GetDepartment();
        Int64 InsertDepartment(MasterEntity entity);
        Int64 UpdateDepartment(MasterEntity entity);
        Int64 DeleteDepartment(object filter);
        IEnumerable<dynamic> GetCompanyAdjustment();
        Int64 InsertCompanyAdjustment(MasterEntity entity);
        Int64 UpdateCompanyAdjustment(MasterEntity entity);
        Int64 DeleteCompanyAdjustment(object filter);

        IEnumerable<dynamic> GetPhilHealth();
        Int64 InsertPhilHealth(MasterEntity entity);
        Int64 UpdatePhilHealth(MasterEntity entity);
        Int64 DeletePhilHealth(object filter);


        Int64 InsertOTRates(MasterEntity entity);
        Int64 UpdateOTRates(MasterEntity entity);
        Int64 DeleteOTRates(object filter);




        IEnumerable<dynamic> GetCompanyProfile();
        Int64 InsertCompany_Profile(MasterEntity entity);
        Int64 DeleteCompanyProfile(object filter);


        IEnumerable<dynamic> GetSSS();

        Int64 InsertSSS(MasterEntity entity);

        Int64 UpdateSSS(MasterEntity entity);

        Int64 DeleteSSS(object filter);


        IEnumerable<dynamic> GetBanks();

        Int64 InsertBanks(MasterEntity entity);

        Int64 UpdateBanks(MasterEntity entity);

        Int64 DeleteBanks(object filter);


        IEnumerable<dynamic> GetPayGroup();

        Int64 InsertPayGroup(MasterEntity entity);

        Int64 UpdatePayGroup(MasterEntity entity);

        Int64 DeletePayGroup(object filter);

        IEnumerable<dynamic> GetOTRates(); 
        IEnumerable<dynamic> GetTaxtable();
        Int64 UpdateTaxtable(MasterEntity entity);

        IEnumerable<dynamic> GetGovernmentRecords();

        Int64 InsertGovernmentRecords(MasterEntity entity);

        Int64 UpdateGovernmentRecords(MasterEntity entity);

        Int64 DeleteGovernmentRecords(object filter);

        IEnumerable<dynamic> GetEmployeeInformation();

        Int64 InsertEmployeeInformation(MasterEntity entity);

        Int64 UpdateEmployeeInformation(MasterEntity entity);

        Int64 DeleteEmployeeInformation(object filter);


        IEnumerable<dynamic>GetAdjustment();

        Int64 InsertAdjustment(MasterEntity entity);

        Int64 UpdateAdjustment(MasterEntity entity);

        Int64 DeleteAdjustment(object filter);

        IEnumerable<dynamic> GetMyAttendenceDetails();

        Int64 InsertMyAttendenceDetails(MasterEntity entity);

        Int64 UpdateMyAttendenceDetails(MasterEntity entity);

        Int64 DeleteMyAttendenceDetails(object filter);

        IEnumerable<dynamic> GetMyOverTimeDetails();

        Int64 InsertMyOverTimeDetails(MasterEntity entity);

        Int64 UpdateMyOverTimeDetails(MasterEntity entity);

        Int64 DeleteMyOverTimeDetails(object filter);

        IEnumerable<dynamic> GetMyLeaveReport();

        Int64 InsertMyLeaveReport(MasterEntity entity);

        Int64 UpdateMyLeaveReport(MasterEntity entity);

        Int64 DeleteMyLeaveReport(object filter);

        IEnumerable<dynamic> GetUserDetails();

        Int64 InsertUserDetails(MasterEntity entity);

        Int64 UpdateUserDetails(MasterEntity entity);

        Int64 DeleteUserDetails(object filter);

        IEnumerable<dynamic> GetMyWeeklyShift();

        Int64 InsertMyWeeklyShift(MasterEntity entity);

        Int64 UpdateMyWeeklyShift(MasterEntity entity);

        Int64 DeleteMyWeeklyShift(object filter);

        IEnumerable<dynamic> GetRegularization();

        Int64 InsertRegularization(MasterEntity entity);

        Int64 UpdateRegularization(MasterEntity entity);

        Int64 DeleteRegularization(object filter);

        IEnumerable<dynamic> GetPayroll();

        Int64 InsertPayroll(MasterEntity entity);

        Int64 UpdatePayroll(MasterEntity entity);

        Int64 DeletePayroll(object filter);
    }
    
}

