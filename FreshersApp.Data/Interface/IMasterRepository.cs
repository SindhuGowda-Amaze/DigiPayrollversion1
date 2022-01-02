using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Data.Interface
{
    public interface IMasterRepository
    {
        IEnumerable<T> GetCostcenter<T>();
        Int64 InsertCostcenter(object filter);
        Int64 UpdateCostcenter(object filter);
        Int64 DeleteCostcenter(object filter);
        IEnumerable<T> GetDepartment<T>();
        Int64 InsertDepartment(object filter);
        Int64 UpdateDepartment(object filter);
        Int64 DeleteDepartment(object filter);

        IEnumerable<T> GetCompanyAdjustment<T>();
        Int64 InsertCompanyAdjustment(object filter);
        Int64 UpdateCompanyAdjustment(object filter);
        Int64 DeleteCompanyAdjustment(object filter);

        IEnumerable<T> GetPhilHealth<T>();
        Int64 InsertPhilHealth(object filter);
        Int64 UpdatePhilHealth(object filter);
        Int64 DeletePhilHealth(object filter);

        IEnumerable<T> GetCompanyProfile<T>();
        Int64 InsertCompany_Profile(object filter);
        Int64 UpdateCompany_Profile(object filter);
        Int64 DeleteCompanyProfile(object filter);

        IEnumerable<T> GetOTRates<T>();
        Int64 InsertOTRates(object filter);
        Int64 UpdateOTRates(object filter);
        Int64 DeleteOTRates(object filter);

        IEnumerable<T> GetBanks<T>();
        Int64 InsertBanks(object filter);
        Int64 UpdateBanks(object filter);
        Int64 DeleteBanks(object filter);


        IEnumerable<T> GetPayGroup<T>();
        Int64 InsertPayGroup(object filter);
        Int64 UpdatePayGroup(object filter);
        Int64 DeletePayGroup(object filter);


        IEnumerable<T> GetSSS<T>();
        Int64 InsertSSS(object filter);
        Int64 UpdateSSS(object filter);
        Int64 DeleteSSS(object filter);

         IEnumerable<T> GetTaxtable<T>();
        Int64 UpdateTaxtable(object filter);

        IEnumerable<T> GetGovernmentRecords<T>();
        Int64 InsertGovernmentRecords(object filter);
        Int64 UpdateGovernmentRecords(object filter);
        Int64 DeleteGovernmentRecords(object filter);


        IEnumerable<T> GetEmployeeInformation<T>();
        Int64 InsertEmployeeInformation(object filter);
        Int64 UpdateEmployeeInformation(object filter);
        Int64 DeleteEmployeeInformation(object filter);

        IEnumerable<T> GetAdjustment<T>();
        Int64 InsertAdjustment(object filter);
        Int64 UpdateAdjustment(object filter);
        Int64 DeleteAdjustment(object filter);

        IEnumerable<T> GetMyAttendenceDetails<T>();
        Int64 InsertMyAttendenceDetails(object filter);
        Int64 UpdateMyAttendenceDetails(object filter);
        Int64 DeleteMyAttendenceDetails(object filter);

        IEnumerable<T> GetMyOverTimeDetails<T>();
        Int64 InsertMyOverTimeDetails(object filter);
        Int64 UpdateMyOverTimeDetails(object filter);
        Int64 DeleteMyOverTimeDetails(object filter);

        IEnumerable<T> GetMyLeaveReport<T>();
        Int64 InsertMyLeaveReport(object filter);
        Int64 UpdateMyLeaveReport(object filter);
        Int64 DeleteMyLeaveReport(object filter);

        IEnumerable<T> GetUserDetails<T>();
        Int64 InsertUserDetails(object filter);
        Int64 UpdateUserDetails(object filter);
        Int64 DeleteUserDetails(object filter);

        IEnumerable<T> GetMyWeeklyShift<T>();
        Int64 InsertMyWeeklyShift(object filter);
        Int64 UpdateMyWeeklyShift(object filter);
        Int64 DeleteMyWeeklyShift(object filter);

        IEnumerable<T> GetRegularization<T>();
        Int64 InsertRegularization(object filter);
        Int64 UpdateRegularization(object filter);
        Int64 DeleteRegularization(object filter);

        IEnumerable<T> GetPayroll<T>();
        Int64 InsertPayroll(object filter);
        Int64 UpdatePayroll(object filter);
        Int64 DeletePayroll(object filter);

        IEnumerable<T> GetPositionDetails<T>();
        Int64 InsertPositionDetails(object filter);
        Int64 UpdatePositionDetails(object filter);
        Int64 DeletePositionDetails(object filter);


        IEnumerable<T> GetEmployementDetails<T>();
        Int64 InsertEmployementDetails(object filter);
        Int64 UpdateEmployementDetails(object filter);
        Int64 DeleteEmployementDetails(object filter);

        IEnumerable<T> GetEducationDetails<T>();
        Int64 InsertEducationDetails(object filter);
        Int64 UpdateEducationDetails(object filter);
        Int64 DeleteEducationDetails(object filter);

        IEnumerable<T> GetMyDetails<T>();
        Int64 InsertMyDetails(object filter);
        Int64 UpdateMyDetails(object filter);
        Int64 DeleteMyDetails(object filter);

        IEnumerable<T> GetSalaryDetails<T>();
        Int64 InsertSalaryDetails(object filter);
        Int64 UpdateSalaryDetails(object filter);
        Int64 DeleteSalaryDetails(object filter);

        IEnumerable<T> GetBankDetails<T>();
        Int64 InsertBankDetails(object filter);
        Int64 UpdateBankDetails(object filter);
        Int64 DeleteBankDetails(object filter);


        IEnumerable<T> GetVisaDetails<T>();
        Int64 InsertVisaDetails(object filter);
        Int64 UpdateVisaDetails(object filter);
        Int64 DeleteVisaDetails(object filter);


        IEnumerable<T> GetID_Details<T>();
        Int64 InsertID_Details(object filter);
        Int64 UpdateID_Details(object filter);
        Int64 DeleteID_Details(object filter);

        IEnumerable<T> GetNomination<T>();
        Int64 InsertNomination(object filter);
        Int64 UpdateNomination(object filter);
        Int64 DeleteNomination(object filter);

        IEnumerable<T> GetDependentDetails<T>();
        Int64 InsertDependentDetails(object filter);
        Int64 UpdateDependentDetails(object filter);
        Int64 DeleteDependentDetails(object filter);

        IEnumerable<T> GetCityMaster<T>();
        Int64 InsertCityMaster(object filter);
        Int64 UpdateCityMaster(object filter);
        Int64 DeleteCityMaster(object filter);

        IEnumerable<T> GetCountryMaster<T>();
        Int64 InsertCountryMaster(object filter);
        Int64 UpdateCountryMaster(object filter);
        Int64 DeleteCountryMaster(object filter);

        IEnumerable<T> GetProvinceMaster<T>();
        Int64 InsertProvinceMaster(object filter);
        Int64 UpdateProvinceMaster(object filter);
        Int64 DeleteProvinceMaster(object filter);

        IEnumerable<T> GetTaxtableAnnual<T>();
        Int64 InsertTaxtableAnnual(object filter);
        Int64 UpdateTaxtableAnnual(object filter);
        Int64 DeleteTaxtableAnnual(object filter);

        IEnumerable<T> GetLeaveBalance<T>();
        Int64 InsertLeaveBalance(object filter);
        Int64 UpdateLeaveBalance(object filter);
        Int64 DeleteLeaveBalance(object filter);























        //Digiofficeversion4//
        Int64 DeleteCityType(object filter);
        Int64 DeleteCountryType(object filter);
        Int64 DeleteHolidays(object filter);
        Int64 DeleteLeaveType(object filter);
        Int64 DeleteShiftMaster(object filter);
        Int64 DeleteStateType(object filter);
        Int64 DeleteTransportRequestType(object filter);
        Int64 DeleteWorkStationType_Master(object filter);


        IEnumerable<T> GetEntitlementMaster<T>();
        Int64 InsertEntitlementMaster(object filter);
        Int64 UpdateEntitlementMaster(object filter);
        Int64 DeleteEntitlementMaster(object filter);

    }

}