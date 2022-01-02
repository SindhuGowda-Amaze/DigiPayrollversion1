using Dapper;
using FreshersApp.Data;
using FreshersApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Data.Repositories
{
    public class MasterRepository : Repository, IMasterRepository, IDisposable
    {

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetPhilHealth<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetPhilHealth]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertPhilHealth(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertPhilHealth]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdatePhilHealth(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdatePhilHealth]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long DeletePhilHealth(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeletePhilHealth]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public IEnumerable<T> GetDepartment<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetDepartment]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertDepartment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertDepartment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdateDepartment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateDepartment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long DeleteDepartment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteDepartment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public IEnumerable<T> GetCostcenter<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetCostcenter]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCostcenter(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertCostcenter]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCostcenter(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateCostcenter]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long DeleteCostcenter(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteCostcenter]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetCompanyAdjustment<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetCompanyAdjustment]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCompanyAdjustment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertCompanyAdjustment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCompanyAdjustment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateCompanyAdjustment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteCompanyAdjustment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteCompanyAdjustment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertOTRates(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertOTRates]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdateOTRates(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateOTRates]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long DeleteOTRates(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteOTRates]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetCompanyProfile<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetCompanyProfile]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCompany_Profile(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertCompany_Profile]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteCompanyProfile(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteCompanyProfile]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetOTRates<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetOTRates]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetBanks<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetBanks]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertBanks(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertBanks]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdateBanks(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateBanks]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long DeleteBanks(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteBanks]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetPayGroup<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetPayGroup]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertPayGroup(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertPayGroup]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdatePayGroup(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdatePayGroup]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long DeletePayGroup(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeletePayGroup]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetSSS<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetSSS]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertSSS(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertSSS]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateSSS(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateSSS]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteSSS(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteSSS]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetTaxtable<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetTaxtable]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateTaxtable(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateTaxtable]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetGovernmentRecords<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetGovernmentRecords]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertGovernmentRecords(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertGovernmentRecords]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateGovernmentRecords(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateGovernmentRecords]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteGovernmentRecords(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteGovernmentRecords]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetEmployeeInformation<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetEmployeeInformation]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertEmployeeInformation(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertEmployeeInformation]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateEmployeeInformation(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateEmployeeInformation]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteEmployeeInformation(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteEmployeeInformation]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetAdjustment<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetAdjustment]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertAdjustment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertAdjustment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateAdjustment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateAdjustment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteAdjustment(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteAdjustment]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetMyAttendenceDetails<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetMyAttendenceDetails]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertMyAttendenceDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertMyAttendenceDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateMyAttendenceDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateMyAttendenceDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteMyAttendenceDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteMyAttendenceDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetMyOverTimeDetails<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetMyOverTimeDetails]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertMyOverTimeDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertMyOverTimeDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateMyOverTimeDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateMyOverTimeDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteMyOverTimeDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteMyOverTimeDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetMyLeaveReport<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetMyLeaveReport]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertMyLeaveReport(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertMyLeaveReport]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateMyLeaveReport(object filter)
        {

            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateMyLeaveReport]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteMyLeaveReport(object filter)
        {

            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteMyLeaveReport]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetUserDetails<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetUserDetails]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertUserDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertUserDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateUserDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateUserDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteUserDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteUserDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetMyWeeklyShift<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetMyWeeklyShift]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertMyWeeklyShift(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertMyWeeklyShift]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateMyWeeklyShift(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateMyWeeklyShift]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteMyWeeklyShift(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteMyWeeklyShift]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetRegularization<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetRegularization]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertRegularization(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertRegularization]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateRegularization(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateRegularization]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteRegularization(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteRegularization]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetPayroll<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetPayroll]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPayroll(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertPayroll]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdatePayroll(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdatePayroll]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeletePayroll(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeletePayroll]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<T> GetPositionDetails<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetPositionDetails]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPositionDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertPositionDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdatePositionDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdatePositionDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeletePositionDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeletePositionDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<T> GetEmployementDetails<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetEmployementDetails]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertEmployementDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertEmployementDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateEmployementDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateEmployementDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteEmployementDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteEmployementDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetEducationDetails<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetEducationDetails]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertEducationDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertEducationDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateEducationDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateEducationDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteEducationDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteEducationDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetMyDetails<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetMyDetails]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertMyDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertMyDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateMyDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateMyDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteMyDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteMyDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetSalaryDetails<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetSalaryDetails]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertSalaryDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertSalaryDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateSalaryDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateSalaryDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteSalaryDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteSalaryDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetBankDetails<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetBankDetails]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertBankDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertBankDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateBankDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateBankDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteBankDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteBankDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetVisaDetails<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetVisaDetails]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertVisaDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertVisaDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateVisaDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateVisaDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteVisaDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteVisaDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetID_Details<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetID_Details]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertID_Details(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertID_Details]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateID_Details(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateID_Details]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteID_Details(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteID_Details]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetNomination<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetNomination]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertNomination(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertNomination]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateNomination(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateNomination]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteNomination(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteNomination]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetDependentDetails<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetDependentDetails]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertDependentDetails(object filter)
        {

            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertDependentDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateDependentDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateDependentDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteDependentDetails(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteDependentDetails]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetCityMaster<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetCityMaster]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCityMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertCityMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCityMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateCityMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteCityMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteCityMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetCountryMaster<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetCountryMaster]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCountryMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertCountryMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCountryMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateCountryMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteCountryMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteCountryMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetProvinceMaster<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetProvinceMaster]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertProvinceMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertProvinceMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateProvinceMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateProvinceMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteProvinceMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteProvinceMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCompany_Profile(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateCompany_Profile]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetTaxtableAnnual<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetTaxtableAnnual]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertTaxtableAnnual(object filter)
        {
            try
            {
                return db.Query<Int64>("SProc_InsertTaxtableAnnual", filter, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateTaxtableAnnual(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateTaxtableAnnual]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long DeleteTaxtableAnnual(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteTaxtableAnnual]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetLeaveBalance<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetLeaveBalance]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertLeaveBalance(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertLeaveBalance]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateLeaveBalance(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateLeaveBalance]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteLeaveBalance(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteLeaveBalance]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





















        //Digiofficeversion4//

        public long DeleteCityType(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteCityType]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteCountryType(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteCountryType]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteHolidays(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteHolidays]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteLeaveType(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteLeaveType]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteShiftMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteShiftMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteStateType(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteStateType]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteTransportRequestType(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteTransportRequestType]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteWorkStationType_Master(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteProvinceMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetEntitlementMaster<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetEntitlementMaster]", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertEntitlementMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_InsertEntitlementMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateEntitlementMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_UpdateEntitlementMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteEntitlementMaster(object filter)
        {
            try
            {
                return db.Query<Int64>("[dbo].[SProc_DeleteEntitlementMaster]", filter, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}