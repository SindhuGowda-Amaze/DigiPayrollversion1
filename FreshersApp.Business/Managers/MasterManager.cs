using FreshersApp.Business.Entities;
using FreshersApp.Business.Interface;
using FreshersApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Business.Managers
{
    public class MasterManager : IMasterManager

    {
        private IMasterRepository IMasterRepository;

        public MasterManager(IMasterRepository IMasterRepository)
        {
            this.IMasterRepository = IMasterRepository;
        }

        public IEnumerable<dynamic> GetCostcenter()
        {
            try
            {
                return IMasterRepository.GetCostcenter<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetPhilHealth()
        {
            try
            {
                return IMasterRepository.GetPhilHealth<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertPhilHealth(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Monthly_Basic_Salary_Into_Five = entity.Monthly_Basic_Salary_Into_Five,
                    Monthly_Share = entity.Monthly_Share,
                    Personal_Share = entity.Personal_Share,
                    Employee_Share = entity.Employee_Share

                };
                return IMasterRepository.InsertPhilHealth(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdatePhilHealth(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Monthly_Basic_Salary_Into_Five = entity.Monthly_Basic_Salary_Into_Five,
                    Monthly_Share = entity.Monthly_Share,
                    Personal_Share = entity.Personal_Share,
                    Employee_Share = entity.Employee_Share
                };
                return IMasterRepository.UpdatePhilHealth(filter);
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
                return IMasterRepository.DeletePhilHealth(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetCompanyAdjustment()
        {
            try
            {
                return IMasterRepository.GetCompanyAdjustment<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<dynamic> GetDepartment()
        {
            try
            {
                return IMasterRepository.GetDepartment<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCompanyAdjustment(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Type = entity.Type,
                    Name = entity.Name,
                    Code = entity.Code,
                    Amount = entity.Amount,
                    Remarks = entity.Remarks,
                    BeforeTax = entity.BeforeTax,
                    Taxable = entity.Taxable,
                    MaxAccumulated = entity.MaxAccumulated

                };
                return IMasterRepository.InsertCompanyAdjustment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCompanyAdjustment(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Type = entity.Type,
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                    Amount = entity.Amount,
                    Taxable = entity.Taxable,
                    MaxAccumulated = entity.MaxAccumulated

                };
                return IMasterRepository.UpdateCompanyAdjustment(filter);
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
                return IMasterRepository.DeleteCompanyAdjustment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertDepartment(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                };
                return IMasterRepository.InsertDepartment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdateDepartment(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                };
                return IMasterRepository.UpdateDepartment(filter);
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
                return IMasterRepository.DeleteDepartment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public long InsertCostcenter(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,

                };
                return IMasterRepository.InsertCostcenter(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCostcenter(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                    Changes = entity.Changes,
                    ModifiedBy = entity.ModifiedBy

                };
                return IMasterRepository.UpdateCostcenter(filter);
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
                return IMasterRepository.DeleteCostcenter(filter);
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
                return IMasterRepository.DeleteCompanyProfile(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetCompanyProfile()
        {

            try
            {
                return IMasterRepository.GetCompanyProfile<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCompany_Profile(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Company_logo = entity.Company_logo,
                    Company_Name = entity.Company_Name,
                    Nature_Of_Business = entity.Nature_Of_Business,
                    Address1 = entity.Address1,
                    Address2 = entity.Address2,
                    Zipcode = entity.Zipcode,
                    RDO = entity.RDO,
                    Email = entity.Email,
                    Phone = entity.Phone,
                    Password = entity.Password,
                    Fax = entity.Fax,
                    Tin = entity.Tin,
                    SSN_No = entity.SSN_No,
                    PhilHealthNumber = entity.PhilHealthNumber,
                    HDMFNumber = entity.HDMFNumber,
                    Admin_AuthorisedPerson = entity.Admin_AuthorisedPerson,
                    Admin_PositionTitle = entity.Admin_PositionTitle,
                    HR_AuthorisedPerson = entity.HR_AuthorisedPerson,
                    HR_PositionTitle = entity.HR_PositionTitle,
                    Finance_AuthorisedPerson = entity.Finance_AuthorisedPerson,
                    Finance_PositionTitle = entity.Finance_PositionTitle,
                    E_Signatory = entity.E_Signatory,
                    Work_Days_Per_Year = entity.Work_Days_Per_Year,
                    Work_Days_Per_Day = entity.Work_Days_Per_Day,
                    Work_Months_Per_Year = entity.Work_Months_Per_Year,
                    Work_hour_Start = entity.Work_hour_Start,
                    Work_hour_End = entity.Work_hour_End,
                    Break_Hours = entity.Break_Hours,
                    Periods_Per_Month = entity.Periods_Per_Month,
                    Absent_Deduction = entity.Absent_Deduction,
                    Late_Deduction = entity.Late_Deduction,
                    OverTime_Comeptition_Optional = entity.OverTime_Comeptition_Optional,
                    OverTime_Comeptition_OTRates = entity.OverTime_Comeptition_OTRates,
                    RestDays = entity.RestDays,
                    thirteen_Month_Compuatation_Type = entity.thirteen_Month_Compuatation_Type,
                    thirteen_Month_Deduct_Absent = entity.thirteen_Month_Deduct_Absent,
                    thirteen_Month_Deduct_Late = entity.thirteen_Month_Deduct_Late,
                    thirteen_Month_Optional = entity.thirteen_Month_Optional,
                    FinalPay_Deduct_Absent = entity.FinalPay_Deduct_Absent,
                    FinalPay_Deduct_Late = entity.FinalPay_Deduct_Late,
                    Final_Pay_13th_Month = entity.Final_Pay_13th_Month,
                    NetPay_Threshold = entity.NetPay_Threshold,
                    SSS_Coverage = entity.SSS_Coverage,
                    SSS_Optional = entity.SSS_Optional,
                    PhilHealth_Coverage = entity.PhilHealth_Coverage,
                    PhilHealth_Optional = entity.PhilHealth_Optional,
                    HDMS = entity.HDMS,
                    HDMF_Employer_Contribution = entity.HDMF_Employer_Contribution,
                    PayRoll_Calender = entity.PayRoll_Calender,
                    Tax_Table = entity.Tax_Table,
                    Tax_Table_Starts_on = entity.Tax_Table_Starts_on,
                    Tax_Table_Including_13thmonth = entity.Tax_Table_Including_13thmonth,
                    Non_Tax_Essential_Sealing = entity.Non_Tax_Essential_Sealing,
                    Deminimis_Exemption = entity.Deminimis_Exemption
                };
                return IMasterRepository.InsertCompany_Profile(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetOTRates()
        {
            try
            {
                return IMasterRepository.GetOTRates<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertOTRates(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Day = entity.Day,
                    Normal = entity.Normal,
                    OT = entity.OT,
                    ND = entity.ND,
                    NDOT = entity.NDOT,


                };
                return IMasterRepository.InsertOTRates(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateOTRates(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    ProjectTypeID = entity.ProjectTypeID,
                    ProjectName = entity.ProjectName,
                    ProjectDescription = entity.ProjectDescription,
                    ClientName = entity.ClientName,
                    ClientLocation = entity.ClientLocation,
                    Highlights = entity.Highlights,
                    Photo = entity.PhotoURL
                };
                return IMasterRepository.UpdateOTRates(filter);
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
                return IMasterRepository.DeleteOTRates(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetBanks()
        {
            try
            {
                return IMasterRepository.GetBanks<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertBanks(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks
                };
                return IMasterRepository.InsertBanks(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateBanks(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks

                };
                return IMasterRepository.UpdateBanks(filter);
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
                return IMasterRepository.DeleteBanks(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetPayGroup()
        {
            try
            {
                return IMasterRepository.GetPayGroup<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertPayGroup(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    Description = entity.Description
                };
                return IMasterRepository.InsertPayGroup(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdatePayGroup(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Description = entity.Description

                };
                return IMasterRepository.UpdatePayGroup(filter);
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
                return IMasterRepository.DeletePayGroup(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetSSS()
        {
            try
            {
                return IMasterRepository.GetSSS<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertSSS(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Min_Range = entity.Min_Range,
                    Max_Range = entity.Max_Range,
                    Monthly_Salary_Creadited = entity.Monthly_Salary_Creadited,
                    SS_ER = entity.SS_ER,
                    SS_EE = entity.SS_EE,
                    SS_Total = entity.SS_Total,
                    MPF_ER = entity.MPF_ER,
                    MPF_EE = entity.MPF_EE,
                    EC_ER = entity.EC_ER,
                    Total_Contribution = entity.Total_Contribution

                };
                return IMasterRepository.InsertSSS(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public long InsertOTRates(MasterEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

        public long UpdateSSS(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    Min_Range = entity.Min_Range,
                    Max_Range = entity.Max_Range,
                    Monthly_Salary_Creadited = entity.Monthly_Salary_Creadited,
                    SS_ER = entity.SS_ER,
                    SS_EE = entity.SS_EE,
                    SS_Total = entity.SS_Total,
                    MPF_ER = entity.MPF_ER,
                    MPF_EE = entity.MPF_EE,
                    EC_ER = entity.EC_ER,
                    Total_Contribution = entity.Total_Contribution
                };
                return IMasterRepository.UpdateSSS(filter);
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
                return IMasterRepository.DeleteSSS(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetTaxtable()
        {
            {
                try
                {
                    return IMasterRepository.GetTaxtable<dynamic>();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public long UpdateTaxtable(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    ID = entity.ID,
                    Daily_Deduction1 = entity.Daily_Deduction1,
                    Daily_Deduction2 = entity.Daily_Deduction2,
                    Daily_Deduction3 = entity.Daily_Deduction3,
                    Daily_Deduction4 = entity.Daily_Deduction4,
                    Daily_Deduction5 = entity.Daily_Deduction5,
                    Daily_Deduction6 = entity.Daily_Deduction6,
                    Daily_TaxTable1 = entity.Daily_TaxTable1,
                    Daily_TaxTable2 = entity.Daily_TaxTable2,
                    Daily_TaxTable3 = entity.Daily_TaxTable3,
                    Daily_TaxTable4 = entity.Daily_TaxTable4,
                    Daily_TaxTable5 = entity.Daily_TaxTable5,
                    Daily_TaxTable6 = entity.Daily_TaxTable6,
                    Weekly_Deduction1 = entity.Weekly_Deduction1,
                    Weekly_Deduction2 = entity.Weekly_Deduction2,
                    Weekly_Deduction3 = entity.Weekly_Deduction3,
                    Weekly_Deduction4 = entity.Weekly_Deduction4,
                    Weekly_Deduction5 = entity.Weekly_Deduction5,
                    Weekly_Deduction6 = entity.Weekly_Deduction6,
                    Weekly_Taxtable1 = entity.Weekly_Taxtable1,
                    Weekly_Taxtable2 = entity.Weekly_Taxtable2,
                    Weekly_Taxtable3 = entity.Weekly_Taxtable3,
                    Weekly_Taxtable4 = entity.Weekly_Taxtable4,
                    Weekly_Taxtable5 = entity.Weekly_Taxtable5,
                    Weekly_Taxtable6 = entity.Weekly_Taxtable6,
                    Semi_Monthly_Deduction1 = entity.Semi_Monthly_Deduction1,
                    Semi_Monthly_Deduction2 = entity.Semi_Monthly_Deduction2,
                    Semi_Monthly_Deduction3 = entity.Semi_Monthly_Deduction3,
                    Semi_Monthly_Deduction4 = entity.Semi_Monthly_Deduction4,
                    Semi_Monthly_Deduction5 = entity.Semi_Monthly_Deduction5,
                    Semi_Monthly_Deduction6 = entity.Semi_Monthly_Deduction6,
                    Semi_Monthly_Taxtable1 = entity.Semi_Monthly_Taxtable1,
                    Semi_Monthly_Taxtable2 = entity.Semi_Monthly_Taxtable2,
                    Semi_Monthly_Taxtable3 = entity.Semi_Monthly_Taxtable3,
                    Semi_Monthly_Taxtable4 = entity.Semi_Monthly_Taxtable4,
                    Semi_Monthly_Taxtable5 = entity.Semi_Monthly_Taxtable5,
                    Semi_Monthly_Taxtable6 = entity.Semi_Monthly_Taxtable6,
                    Monthly_Deduction1 = entity.Monthly_Deduction1,
                    Monthly_Deduction2 = entity.Monthly_Deduction2,
                    Monthly_Deduction3 = entity.Monthly_Deduction3,
                    Monthly_Deduction4 = entity.Monthly_Deduction4,
                    Monthly_Deduction5 = entity.Monthly_Deduction5,
                    Monthly_Deduction6 = entity.Monthly_Deduction6,
                    Monthly_Taxtable1 = entity.Monthly_Taxtable1,
                    Monthly_Taxtable2 = entity.Monthly_Taxtable2,
                    Monthly_Taxtable3 = entity.Monthly_Taxtable3,
                    Monthly_Taxtable4 = entity.Monthly_Taxtable4,
                    Monthly_Taxtable5 = entity.Monthly_Taxtable5,
                    Monthly_Taxtable6 = entity.Monthly_Taxtable6,

                };
                return IMasterRepository.UpdateTaxtable(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetGovernmentRecords()
        {
            try
            {
                return IMasterRepository.GetGovernmentRecords<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertGovernmentRecords(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    SSS_Number = entity.SSS_Number,
                    SSS_DatePaid = entity.SSS_DatePaid,
                    SSSLoan_Number = entity.SSSLoan_Number,
                    SSSLoan_DatePaid = entity.SSSLoan_DatePaid,
                    SSSCalamityLoan_Number = entity.SSSCalamityLoan_Number,
                    SSSCalamityLoan_DatePaid = entity.SSSCalamityLoan_DatePaid,
                    PhilHealth_Number = entity.PhilHealth_Number,
                    PhilHealth_DatePaid = entity.PhilHealth_DatePaid,
                    HDMF_Number = entity.HDMF_Number,
                    HDMF_DatePaid = entity.HDMF_DatePaid,
                    HDMFLoan_Number = entity.HDMFLoan_Number,
                    HDMFLoan_DatePaid = entity.HDMFLoan_DatePaid,
                    HDMPCalamityLoan_Number = entity.HDMPCalamityLoan_Number,
                    HDMPCalamityLoan_DatePaid = entity.HDMPCalamityLoan_DatePaid

                };
                return IMasterRepository.InsertGovernmentRecords(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateGovernmentRecords(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    SSS_Number = entity.SSS_Number,
                    SSS_DatePaid = entity.SSS_DatePaid,
                    SSSLoan_Number = entity.SSSLoan_Number,
                    SSSLoan_DatePaid = entity.SSSLoan_DatePaid,
                    SSSCalamityLoan_Number = entity.SSSCalamityLoan_Number,
                    SSSCalamityLoan_DatePaid = entity.SSSCalamityLoan_DatePaid,
                    PhilHealth_Number = entity.PhilHealth_Number,
                    PhilHealth_DatePaid = entity.PhilHealth_DatePaid,
                    HDMF_Number = entity.HDMF_Number,
                    HDMF_DatePaid = entity.HDMF_DatePaid,
                    HDMFLoan_Number = entity.HDMFLoan_Number,
                    HDMFLoan_DatePaid = entity.HDMFLoan_DatePaid,
                    HDMPCalamityLoan_Number = entity.HDMPCalamityLoan_Number,
                    HDMPCalamityLoan_DatePaid = entity.HDMPCalamityLoan_DatePaid

                };
                return IMasterRepository.UpdateGovernmentRecords(filter);
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
                return IMasterRepository.DeleteGovernmentRecords(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetEmployeeInformation()
        {
            try
            {
                return IMasterRepository.GetEmployeeInformation<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertEmployeeInformation(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    EmployeeID = entity.EmployeeID,

                    LastName = entity.LastName,

                    FirstName = entity.FirstName,

                    MiddleName = entity.MiddleName,

                    Gender = entity.Gender,

                    DOB = entity.DOB,

                    CivilStatus = entity.CivilStatus,

                    ContactNo = entity.ContactNo,

                    HomeAddress = entity.HomeAddress,

                    Zipcode = entity.Zipcode,

                    Email = entity.Email,

                    Username = entity.Username,

                    Password = entity.Password,

                    LockUser = entity.LockUser,

                    TaxStatus = entity.TaxStatus,

                    MinimumWagesEarned = entity.MinimumWagesEarned,

                    COLA = entity.COLA,

                    WorkdaysPerYear = entity.WorkdaysPerYear,

                    BasicSalary = entity.basicSalary,

                    Deminimis = entity.Deminimis,

                    OT_ComputationTable = entity.OT_ComputationTable,

                    SSS_Contribution = entity.SSS_Contribution,

                    PhilHealth_Contribution = entity.PhilHealth_Contribution,

                    HDMF_Contribution = entity.HDMF_Contribution,

                    Additional_HDMF_Contibution = entity.Additional_HDMF_Contibution,

                    JobTitle = entity.JobTitle,

                    Department = entity.Department,

                    CostCenter = entity.CostCenter,

                    HireDate = entity.HireDate,

                    Employment_Status = entity.Employment_Status,

                    StatusDate = entity.StatusDate,

                    Work_Hours_Per_Day = entity.Work_Hours_Per_Day,

                    Pay_Group = entity.Pay_Group,

                    ROHQ = entity.ROHQ,

                    Consultant = entity.Consultant,

                    Consultant_Tax = entity.Consultant_Tax,

                    Consultant_TaxNum = entity.Consultant_TaxNum,

                    Tin = entity.Tin,

                    RDO = entity.RDO,

                    PhilHealth_No = entity.PhilHealth_No,

                    SSS_No = entity.SSS_No,

                    HDMF_No = entity.HDMF_No,

                    SL = entity.SL,

                    VL = entity.VL,

                    LeaveCredit = entity.LeaveCredit,

                    Dependent1 = entity.Dependent1,

                    Dependent1_DOB = entity.Dependent1_DOB,

                    Dependent2 = entity.Dependent2,

                    Dependent2_DOB = entity.Dependent2_DOB,

                    Dependent3 = entity.Dependent3,

                    Dependent3_DOB = entity.Dependent3_DOB,

                    Dependent4 = entity.Dependent4,

                    Dependent4_DOB = entity.Dependent4_DOB,

                    Bank = entity.bank,

                    Bank_AccountType = entity.bank_AccountType,

                    Bank_AccountNo = entity.bank_AccountNo,

                    HasPreviousEmployment = entity.HasPreviousEmployment,

                    NonTax_13thMonth = entity.NonTax_13thMonth,

                    NonTax_OtherBonus = entity.NonTax_OtherBonus,

                    NonTax_Salaries = entity.NonTax_Salaries,

                    ThirteenthMonth = entity.ThirteenthMonth,

                    OtherBonus = entity.OtherBonus,

                    TaxableGross = entity.TaxableGross,

                    Tax_Withheld = entity.Tax_Withheld,

                    GovernmentDeductions = entity.GovernmentDeductions,

                    PreviousEmployment_Deminimis = entity.PreviousEmployment_Deminimis,

                    TaxableCompensation = entity.TaxableCompensation,

                    MonetizedLeave = entity.MonetizedLeave


                };
                return IMasterRepository.InsertEmployeeInformation(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateEmployeeInformation(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    EmployeeID = entity.EmployeeID,

                    LastName = entity.LastName,

                    FirstName = entity.FirstName,

                    MiddleName = entity.MiddleName,

                    Gender = entity.Gender,

                    DOB = entity.DOB,

                    CivilStatus = entity.CivilStatus,

                    ContactNo = entity.ContactNo,

                    HomeAddress = entity.HomeAddress,

                    Zipcode = entity.Zipcode,

                    Email = entity.Email,

                    Username = entity.Username,

                    Password = entity.Password,

                    LockUser = entity.LockUser,

                    TaxStatus = entity.TaxStatus,

                    MinimumWagesEarned = entity.MinimumWagesEarned,

                    COLA = entity.COLA,

                    WorkdaysPerYear = entity.WorkdaysPerYear,

                    BasicSalary = entity.basicSalary,

                    Deminimis = entity.Deminimis,

                    OT_ComputationTable = entity.OT_ComputationTable,

                    SSS_Contribution = entity.SSS_Contribution,

                    PhilHealth_Contribution = entity.PhilHealth_Contribution,

                    HDMF_Contribution = entity.HDMF_Contribution,

                    Additional_HDMF_Contibution = entity.Additional_HDMF_Contibution,

                    JobTitle = entity.JobTitle,

                    Department = entity.Department,

                    CostCenter = entity.CostCenter,

                    HireDate = entity.HireDate,

                    Employment_Status = entity.Employment_Status,

                    StatusDate = entity.StatusDate,

                    Work_Hours_Per_Day = entity.Work_Hours_Per_Day,

                    Pay_Group = entity.Pay_Group,

                    ROHQ = entity.ROHQ,

                    Consultant = entity.Consultant,

                    Consultant_Tax = entity.Consultant_Tax,

                    Consultant_TaxNum = entity.Consultant_TaxNum,

                    Tin = entity.Tin,

                    RDO = entity.RDO,

                    PhilHealth_No = entity.PhilHealth_No,

                    SSS_No = entity.SSS_No,

                    HDMF_No = entity.HDMF_No,

                    SL = entity.SL,

                    VL = entity.VL,

                    LeaveCredit = entity.LeaveCredit,

                    Dependent1 = entity.Dependent1,

                    Dependent1_DOB = entity.Dependent1_DOB,

                    Dependent2 = entity.Dependent2,

                    Dependent2_DOB = entity.Dependent2_DOB,

                    Dependent3 = entity.Dependent3,

                    Dependent3_DOB = entity.Dependent3_DOB,

                    Dependent4 = entity.Dependent4,

                    Dependent4_DOB = entity.Dependent4_DOB,

                    Bank = entity.bank,

                    Bank_AccountType = entity.bank_AccountType,

                    Bank_AccountNo = entity.bank_AccountNo,

                    HasPreviousEmployment = entity.HasPreviousEmployment,

                    NonTax_13thMonth = entity.NonTax_13thMonth,

                    NonTax_OtherBonus = entity.NonTax_OtherBonus,

                    NonTax_Salaries = entity.NonTax_Salaries,

                    ThirteenthMonth = entity.ThirteenthMonth,

                    OtherBonus = entity.OtherBonus,

                    TaxableGross = entity.TaxableGross,

                    Tax_Withheld = entity.Tax_Withheld,

                    GovernmentDeductions = entity.GovernmentDeductions,

                    PreviousEmployment_Deminimis = entity.PreviousEmployment_Deminimis,

                    TaxableCompensation = entity.TaxableCompensation,

                    MonetizedLeave = entity.MonetizedLeave

                };
                return IMasterRepository.UpdateEmployeeInformation(filter);
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
                return IMasterRepository.DeleteEmployeeInformation(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetAdjustment()
        {
            try
            {
                return IMasterRepository.GetAdjustment<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertAdjustment(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Type = entity.Type,
                    Name = entity.Name,
                    Code = entity.Code,
                    Amount = entity.Amount,
                    Remarks = entity.Remarks,
                    Before = entity.Before,
                    Taxable = entity.Taxable,
                    MaxAccumulated = entity.MaxAccumulatedfloat

                };
                return IMasterRepository.InsertAdjustment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateAdjustment(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID=entity.ID,
                    Type = entity.Type,
                    Name = entity.Name,
                    Code = entity.Code,
                    Amount = entity.Amount,
                    Remarks = entity.Remarks,
                    Before = entity.Before,
                    Taxable = entity.Taxable,
                    MaxAccumulated = entity.MaxAccumulatedfloat

                };
                return IMasterRepository.UpdateAdjustment(filter);
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
                return IMasterRepository.DeleteAdjustment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetMyAttendenceDetails()
        {
            try
            {
                return IMasterRepository.GetMyAttendenceDetails<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertMyAttendenceDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    Date = entity.Date,
                    Shift = entity.Shift,
                    ExpectedInTime = entity.ExpectedInTime,
                    PunchInTime = entity.PunchInTime,
                    ExpectedOutTime = entity.ExpectedOutTime,
                    PunchOutTime = entity.PunchOutTime,
                    WorkHours = entity.WorkHours,
                    ExtraHours = entity.ExtraHours

                };
                return IMasterRepository.InsertMyAttendenceDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateMyAttendenceDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Date = entity.Date,
                    Shift = entity.Shift,
                    ExpectedInTime = entity.ExpectedInTime,
                    PunchInTime = entity.PunchInTime,
                    ExpectedOutTime = entity.ExpectedOutTime,
                    PunchOutTime = entity.PunchOutTime,
                    WorkHours = entity.WorkHours,
                    ExtraHours = entity.ExtraHours

                };
                return IMasterRepository.UpdateMyAttendenceDetails(filter);
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
                return IMasterRepository.DeleteMyAttendenceDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetMyOverTimeDetails()
        {
            try
            {
                return IMasterRepository.GetMyOverTimeDetails<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertMyOverTimeDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                 
                    Date = entity.Date,
                    Shift = entity.Shift,
                    OTHours=entity.OTHours,
                    Comments=entity.Comments,
                    Status=entity.Status

                };
                return IMasterRepository.InsertMyOverTimeDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateMyOverTimeDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Date = entity.Date,
                    Shift = entity.Shift,
                    OTHours = entity.OTHours,
                    Comments = entity.Comments,
                    Status = entity.Status

                };
                return IMasterRepository.UpdateMyOverTimeDetails(filter);
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
                return IMasterRepository.DeleteMyOverTimeDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetMyLeaveReport()
        {
            try
            {
                return IMasterRepository.GetMyLeaveReport<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertMyLeaveReport(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    FromDate = entity.FromDate,
                    TODate = entity.TODate,
                    LeaveType = entity.LeaveType,
                    LeaveReason = entity.LeaveReason,
                    LeaveDaysCount = entity.LeaveDaysCount,
                    LeaveStage = entity.LeaveStage,
                    LeaveStatus = entity.LeaveStatus


                };
                return IMasterRepository.InsertMyLeaveReport(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateMyLeaveReport(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    FromDate = entity.FromDate,
                    TODate = entity.TODate,
                    LeaveType = entity.LeaveType,
                    LeaveReason = entity.LeaveReason,
                    LeaveDaysCount = entity.LeaveDaysCount,
                    LeaveStage = entity.LeaveStage,
                    LeaveStatus = entity.LeaveStatus

                };
                return IMasterRepository.UpdateMyLeaveReport(filter);
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
                return IMasterRepository.DeleteMyLeaveReport(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetUserDetails()
        {
            try
            {
                return IMasterRepository.GetUserDetails<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertUserDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    UserName = entity.UserName,
                    Email = entity.Email,
                    Role = entity.Role,
                    DateAdded = entity.DateAdded,
                    IsActive=entity.IsActive,
                    IsTotal=entity.IsTotal,
                    IsLocked=entity.IsLocked

                };
                return IMasterRepository.InsertUserDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateUserDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    UserName = entity.UserName,
                    Email = entity.Email,
                    Role = entity.Role,
                    DateAdded = entity.DateAdded,

                };
                return IMasterRepository.UpdateUserDetails(filter);
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
                return IMasterRepository.DeleteUserDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetMyWeeklyShift()
        {
            try
            {
                return IMasterRepository.GetMyWeeklyShift<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertMyWeeklyShift(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    ShiftDate = entity.ShiftDate,
                    ShiftName = entity.ShiftName,
                    StartTime = entity.StartTime,
                    EndTime = entity.EndTime,
                   

                };
                return IMasterRepository.InsertMyWeeklyShift(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateMyWeeklyShift(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    ShiftDate = entity.ShiftDate,
                    ShiftName = entity.ShiftName,
                    StartTime = entity.StartTime,
                    EndTime = entity.EndTime,

                };
                return IMasterRepository.UpdateMyWeeklyShift(filter);
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
                return IMasterRepository.DeleteMyWeeklyShift(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetRegularization()
        {
            try
            {
                return IMasterRepository.GetRegularization<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertRegularization(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    Date = entity.Date,
                    Shift = entity.Shift,
                    ExpectedInTime = entity.ExpectedInTime,
                    PunchInTime = entity.PunchInTime,
                    ExpectedOutTime = entity.ExpectedOutTime,
                    PunchOutTime = entity.PunchOutTime,
                    WorkHours = entity.WorkHours,
                    ExtraHours = entity.ExtraHours

                };
                return IMasterRepository.InsertRegularization(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateRegularization(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Date = entity.Date,
                    Shift = entity.Shift,
                    ExpectedInTime = entity.ExpectedInTime,
                    PunchInTime = entity.PunchInTime,
                    ExpectedOutTime = entity.ExpectedOutTime,
                    PunchOutTime = entity.PunchOutTime,
                    WorkHours = entity.WorkHours,
                    ExtraHours = entity.ExtraHours

                };
                return IMasterRepository.UpdateRegularization(filter);
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
                return IMasterRepository.DeleteRegularization(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetPayroll()
        {
            try
            {
                return IMasterRepository.GetPayroll<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPayroll(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    Year = entity.Year,
                    Month = entity.Month,
                    Period = entity.Period,
                    Pay_Roll_Run_Type = entity.Pay_Roll_Run_Type,
                    Pay_Group = entity.Pay_Group,
                    Description = entity.Description,
                    Transaction_Date = entity.Transaction_Date,
                    Status= entity.Status

                };
                return IMasterRepository.InsertPayroll(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdatePayroll(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Year = entity.Year,
                    Month = entity.Month,
                    Period = entity.Period,
                    Pay_Roll_Run_Type = entity.Pay_Roll_Run_Type,
                    Pay_Group = entity.Pay_Group,
                    PunchOutTime = entity.PunchOutTime,
                    Transaction_Date = entity.Transaction_Date,
                 

                };
                return IMasterRepository.UpdatePayroll(filter);
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
                return IMasterRepository.DeletePayroll(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<dynamic> GetPositionDetails()
        {
            try
            {
                return IMasterRepository.GetPositionDetails<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPositionDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    EmployeeCode = entity.EmployeeCode,
                    OfficialEmail = entity.OfficialEmail,
                    Band = entity.Band,
                    Grade = entity.Grade,
                    JobRole = entity.JobRole,
                    Manager = entity.Manager,
                    EmployeeType = entity.EmployeeType,
                    EmployeeStatus = entity.EmployeeStatus,
                    NoticePeriod = entity.NoticePeriod,
                    ProbationPeriod = entity.ProbationPeriod,
                    ConfirmationDueDate = entity.ConfirmationDueDate,
                    ConfirmationStatus = entity.ConfirmationStatus,
                    EmployeeName = entity.EmployeeName

                };
                return IMasterRepository.InsertPositionDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long UpdatePositionDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    EmployeeCode = entity.EmployeeCode,
                    OfficialEmail = entity.OfficialEmail,
                    Band = entity.Band,
                    Grade = entity.Grade,
                    JobRole = entity.JobRole,
                    Manager = entity.Manager,
                    EmployeeType = entity.EmployeeType,
                    EmployeeStatus = entity.EmployeeStatus,
                    NoticePeriod = entity.NoticePeriod,
                    ProbationPeriod = entity.ProbationPeriod,
                    ConfirmationDueDate = entity.ConfirmationDueDate,
                    ConfirmationStatus = entity.ConfirmationStatus,
                    EmployeeName = entity.EmployeeName

                };
                return IMasterRepository.UpdatePositionDetails(filter);
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
                return IMasterRepository.DeletePositionDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<dynamic> GetEmployementDetails()
        {
            try
            {
                return IMasterRepository.GetEmployementDetails<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertEmployementDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    ComapanyName = entity.ComapanyName,
                    Title = entity.Title,
                    StartDate = entity.StartDate,
                    EndDate = entity.EndDate,
                    Salary = entity.Salary,
                    CurrentEmployer = entity.CurrentEmployer

                };
                return IMasterRepository.InsertEmployementDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long UpdateEmployementDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    ComapanyName = entity.ComapanyName,
                    Title = entity.Title,
                    StartDate = entity.StartDate,
                    EndDate = entity.EndDate,
                    Salary = entity.Salary,
                    CurrentEmployer = entity.CurrentEmployer

                };
                return IMasterRepository.UpdateEmployementDetails(filter);
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
                return IMasterRepository.DeleteEmployementDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetEducationDetails()
        {
            try
            {
                return IMasterRepository.GetEducationDetails<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertEducationDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    EducationType = entity.EducationType,
                    Qualification = entity.Qualification,
                    NameOfQualification = entity.NameOfQualification,
                    Branch = entity.Branch,
                    InstitutionName = entity.InstitutionName,
                    Country = entity.Country,
                    ScoreType = entity.ScoreType,
                    Grade = entity.Grade,
                    StartDateMonth = entity.StartDateMonth,
                    StartDateYear = entity.StartDateYear,
                    EndDateMonth = entity.EndDateMonth,
                    EndDateYear = entity.EndDateYear

                };
                return IMasterRepository.InsertEducationDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long UpdateEducationDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    EducationType = entity.EducationType,
                    Qualification = entity.Qualification,
                    NameOfQualification = entity.NameOfQualification,
                    Branch = entity.Branch,
                    InstitutionName = entity.InstitutionName,
                    Country = entity.Country,
                    ScoreType = entity.ScoreType,
                    Grade = entity.Grade,
                    StartDateMonth = entity.StartDateMonth,
                    StartDateYear = entity.StartDateYear,
                    EndDateMonth = entity.EndDateMonth,
                    EndDateYear = entity.EndDateYear

                };
                return IMasterRepository.UpdateEducationDetails(filter);
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
                return IMasterRepository.DeleteEducationDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetMyDetails()
        {
            try
            {
                return IMasterRepository.GetMyDetails<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertMyDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    Title = entity.Title,
                    Name = entity.Name,
                    Middle_Name = entity.Middle_Name,
                    Last_Name = entity.Last_Name,
                    PlaceO_f_Birth = entity.PlaceO_f_Birth,
                    Country_Of_Birth = entity.Country_Of_Birth,
                    Age = entity.Age,
                    Gender = entity.Gender,
                    Status = entity.Status,
                    Date_Of_Marriage = entity.Date_Of_Marriage,
                    Personal_Email = entity.Personal_Email,
                    Mobile = entity.Mobile,
                    Religion = entity.Religion,
                    Citizen_Ship = entity.Citizen_Ship,
                    Ethnicity = entity.Ethnicity,
                    Nationality = entity.Nationality,
                    Is_Disabled = entity.Is_Disabled,
                    Blood_Group = entity.Blood_Group,
                    Height = entity.Height,
                    Weight = entity.Weight,
                    MajorIllness = entity.MajorIllness,
                    IS_Night_Blind = entity.IS_Night_Blind,
                    Is_Color_Blind = entity.Is_Color_Blind

                };
                return IMasterRepository.InsertMyDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateMyDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    Title = entity.Title,
                    Name = entity.Name,
                    Middle_Name = entity.Middle_Name,
                    Last_Name = entity.Last_Name,
                    PlaceO_f_Birth = entity.PlaceO_f_Birth,
                    Country_Of_Birth = entity.Country_Of_Birth,
                    Age = entity.Age,
                    Gender = entity.Gender,
                    Status = entity.Status,
                    Date_Of_Marriage = entity.Date_Of_Marriage,
                    Personal_Email = entity.Personal_Email,
                    Mobile = entity.Mobile,
                    Religion = entity.Religion,
                    Citizen_Ship = entity.Citizen_Ship,
                    Ethnicity = entity.Ethnicity,
                    Nationality = entity.Nationality,
                    Is_Disabled = entity.Is_Disabled,
                    Blood_Group = entity.Blood_Group,
                    Height = entity.Height,
                    Weight = entity.Weight,
                    MajorIllness = entity.MajorIllness,
                    IS_Night_Blind = entity.IS_Night_Blind,
                    Is_Color_Blind = entity.Is_Color_Blind

                };
                return IMasterRepository.UpdateMyDetails(filter);
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
                return IMasterRepository.DeleteMyDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetSalaryDetails()
        {
            try
            {
                return IMasterRepository.GetSalaryDetails<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertSalaryDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    EmployeeName = entity.EmployeeName,
                    Grade = entity.Grade,
                    Designation = entity.Designation,
                    PayRateType = entity.PayRateType,
                    PayStructure = entity.PayStructure,
                    EffectiveFromDate = entity.EffectiveFromDate,
                    Reason = entity.Reason

                };
                return IMasterRepository.InsertSalaryDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateSalaryDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    EmployeeName = entity.EmployeeName,
                    Grade = entity.Grade,
                    Designation = entity.Designation,
                    PayRateType = entity.PayRateType,
                    PayStructure = entity.PayStructure,
                    EffectiveFromDate = entity.EffectiveFromDate,
                    Reason = entity.Reason

                };
                return IMasterRepository.UpdateSalaryDetails(filter);
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
                return IMasterRepository.DeleteSalaryDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetBankDetails()
        {
            try
            {
                return IMasterRepository.GetBankDetails<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertBankDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    NameOfBank = entity.NameOfBank,
                    AccountHolderName = entity.AccountHolderName,
                    BankAccountNumber = entity.BankAccountNumber

                };
                return IMasterRepository.InsertBankDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateBankDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    NameOfBank = entity.NameOfBank,
                    AccountHolderName = entity.AccountHolderName,
                    BankAccountNumber = entity.BankAccountNumber

                };
                return IMasterRepository.UpdateBankDetails(filter);
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
                return IMasterRepository.DeleteBankDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetVisaDetails()
        {
            try
            {
                return IMasterRepository.GetVisaDetails<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertVisaDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    VisaType = entity.VisaType,
                    VisaNumber = entity.VisaNumber,
                    VisaIssueDate = entity.VisaIssueDate,
                    VisaExpiryDate = entity.VisaExpiryDate

                };
                return IMasterRepository.InsertVisaDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateVisaDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,

                    VisaType = entity.VisaType,
                    VisaNumber = entity.VisaNumber,
                    VisaIssueDate = entity.VisaIssueDate,
                    VisaExpiryDate = entity.VisaExpiryDate

                };
                return IMasterRepository.UpdateVisaDetails(filter);
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
                return IMasterRepository.DeleteVisaDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetID_Details()
        {
            try
            {
                return IMasterRepository.GetID_Details<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertID_Details(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    IDType=entity.IDType,
                    Number = entity.Number,
                    NameOnDocument = entity.NameOnDocument,
                    IssueDate = entity.IssueDate,
                    ExpiryDate = entity.ExpiryDate,
                    IssuingAuthority = entity.IssuingAuthority,
                    PlaceOfIssue = entity.PlaceOfIssue
                };
                return IMasterRepository.InsertID_Details(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateID_Details(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    IDType = entity.IDType,
                    Number = entity.Number,
                    NameOnDocument = entity.NameOnDocument,
                    IssueDate = entity.IssueDate,
                    ExpiryDate = entity.ExpiryDate,
                    IssuingAuthority = entity.IssuingAuthority,
                    PlaceOfIssue = entity.PlaceOfIssue
                };
                return IMasterRepository.UpdateID_Details(filter);
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
                return IMasterRepository.DeleteID_Details(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetNomination()
        {
            try
            {
                return IMasterRepository.GetNomination<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertNomination(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Dependent = entity.Dependent,
                    Percentage = entity.Percentage,
                    NomineeType = entity.NomineeType,
                    GuardianName = entity.GuardianName,
                    GuardianRelationship = entity.GuardianRelationship
                };
                return IMasterRepository.InsertNomination(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateNomination(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Dependent = entity.Dependent,
                    Percentage = entity.Percentage,
                    NomineeType = entity.NomineeType,
                    GuardianName = entity.GuardianName,
                    GuardianRelationship = entity.GuardianRelationship
                 
                };
                return IMasterRepository.UpdateNomination(filter);
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
                return IMasterRepository.DeleteNomination(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetDependentDetails()
        {
            try
            {
                return IMasterRepository.GetDependentDetails<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertDependentDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    DependentName = entity.DependentName,
                    Relationship = entity.Relationship,
                    Gender = entity.Gender,
                    DateOfBirth = entity.DateOfBirth,
                    Address = entity.Address,
                    Mobile = entity.Mobile,
                    Is_Dependent = entity.Is_Dependent,
                    Id_Number = entity.Id_Number,
                    Is_Child_Adopted = entity.Is_Child_Adopted,
                    Race = entity.Race,
                    CitizenShip = entity.CitizenShip,
                    Country_Of_Birth = entity.Country_Of_Birth,
                    Religion = entity.Religion,
                    Working_Status = entity.Working_Status,
                    Request_Type = entity.Request_Type
                };
                return IMasterRepository.InsertDependentDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateDependentDetails(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    DependentName = entity.DependentName,
                    Relationship = entity.Relationship,
                    Gender = entity.Gender,
                    DateOfBirth = entity.DateOfBirth,
                    Address = entity.Address,
                    Mobile = entity.Mobile,
                    Is_Dependent = entity.Is_Dependent,
                    Id_Number = entity.Id_Number,
                    Is_Child_Adopted = entity.Is_Child_Adopted,
                    Race = entity.Race,
                    CitizenShip = entity.CitizenShip,
                    Country_Of_Birth = entity.Country_Of_Birth,
                    Religion = entity.Religion,
                    Working_Status = entity.Working_Status,
                    Request_Type = entity.Request_Type

                };
                return IMasterRepository.UpdateDependentDetails(filter);
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
                return IMasterRepository.DeleteDependentDetails(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetCityMaster()
        {
            try
            {
                return IMasterRepository.GetCityMaster<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCityMaster(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    CityName=entity.CityName,
                    ProvinceID=entity.ProvinceID
                };
                return IMasterRepository.InsertCityMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long UpdateCityMaster(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID=entity.ID,
                    CityName = entity.CityName,
                    ProvinceID = entity.ProvinceID
                };
                return IMasterRepository.InsertCityMaster(filter);
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
                return IMasterRepository.DeleteCityMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetCountryMaster()
        {
            try
            {
                return IMasterRepository.GetCountryMaster<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCountryMaster(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    CountryName=entity.CountryName
                };
                return IMasterRepository.InsertCountryMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCountryMaster(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    CountryName = entity.CountryName
                };
                return IMasterRepository.InsertCityMaster(filter);
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
                return IMasterRepository.DeleteCountryMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetProvinceMaster()
        {
            try
            {
                return IMasterRepository.GetProvinceMaster<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertProvinceMaster(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    ProvinceName = entity.ProvinceName,
                    CoutryID = entity.CoutryID

                };
                return IMasterRepository.InsertProvinceMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateProvinceMaster(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    CountryName = entity.CountryName
                };
                return IMasterRepository.UpdateProvinceMaster(filter);
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
                return IMasterRepository.DeleteProvinceMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCompany_Profile(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Company_logo = entity.Company_logo,
                    Company_Name = entity.Company_Name,
                    Nature_Of_Business = entity.Nature_Of_Business,
                    Address1 = entity.Address1,
                    Address2 = entity.Address2,
                    Zipcode = entity.Zipcode,
                    RDO = entity.RDO,
                    Email = entity.Email,
                    Phone = entity.Phone,
                    Password = entity.Password,
                    Fax = entity.Fax,
                    Tin = entity.Tin,
                    SSN_No = entity.SSN_No,
                    PhilHealthNumber = entity.PhilHealthNumber,
                    HDMFNumber = entity.HDMFNumber,
                    Admin_AuthorisedPerson = entity.Admin_AuthorisedPerson,
                    Admin_PositionTitle = entity.Admin_PositionTitle,
                    HR_AuthorisedPerson = entity.HR_AuthorisedPerson,
                    HR_PositionTitle = entity.HR_PositionTitle,
                    Finance_AuthorisedPerson = entity.Finance_AuthorisedPerson,
                    Finance_PositionTitle = entity.Finance_PositionTitle,
                    E_Signatory = entity.E_Signatory,
                    Work_Days_Per_Year = entity.Work_Days_Per_Year,
                    Work_Days_Per_Day = entity.Work_Days_Per_Day,
                    Work_Months_Per_Year = entity.Work_Months_Per_Year,
                    Work_hour_Start = entity.Work_hour_Start,
                    Work_hour_End = entity.Work_hour_End,
                    Break_Hours = entity.Break_Hours,
                    Periods_Per_Month = entity.Periods_Per_Month,
                    Absent_Deduction = entity.Absent_Deduction,
                    Late_Deduction = entity.Late_Deduction,
                    OverTime_Comeptition_Optional = entity.OverTime_Comeptition_Optional,
                    OverTime_Comeptition_OTRates = entity.OverTime_Comeptition_OTRates,
                    RestDays = entity.RestDays,
                    thirteen_Month_Compuatation_Type = entity.thirteen_Month_Compuatation_Type,
                    thirteen_Month_Deduct_Absent = entity.thirteen_Month_Deduct_Absent,
                    thirteen_Month_Deduct_Late = entity.thirteen_Month_Deduct_Late,
                    thirteen_Month_Optional = entity.thirteen_Month_Optional,
                    FinalPay_Deduct_Absent = entity.FinalPay_Deduct_Absent,
                    FinalPay_Deduct_Late = entity.FinalPay_Deduct_Late,
                    Final_Pay_13th_Month = entity.Final_Pay_13th_Month,
                    NetPay_Threshold = entity.NetPay_Threshold,
                    SSS_Coverage = entity.SSS_Coverage,
                    SSS_Optional = entity.SSS_Optional,
                    PhilHealth_Coverage = entity.PhilHealth_Coverage,
                    PhilHealth_Optional = entity.PhilHealth_Optional,
                    HDMS = entity.HDMS,
                    HDMF_Employer_Contribution = entity.HDMF_Employer_Contribution,
                    PayRoll_Calender = entity.PayRoll_Calender,
                    Tax_Table = entity.Tax_Table,
                    Tax_Table_Starts_on = entity.Tax_Table_Starts_on,
                    Tax_Table_Including_13thmonth = entity.Tax_Table_Including_13thmonth,
                    Non_Tax_Essential_Sealing = entity.Non_Tax_Essential_Sealing,
                    Deminimis_Exemption = entity.Deminimis_Exemption
                };
                return IMasterRepository.UpdateCompany_Profile(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetTaxtableAnnual()
        {
            try
            {
                return IMasterRepository.GetTaxtableAnnual<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertTaxtableAnnual(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    From = entity.From,
                    To = entity.To,
                    Fix = entity.Fix,
                    Rate = entity.Rate


                };
                return IMasterRepository.InsertTaxtableAnnual(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdateTaxtableAnnual(MasterEntity Entity)
        {
            try
            {
                var filter = new
                {
                    ID = Entity.ID,
                    From = Entity.From,
                    To = Entity.To,
                    Fix = Entity.Fix,
                    Rate = Entity.Rate
                };

                return IMasterRepository.UpdateTaxtableAnnual(filter);
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
                return IMasterRepository.DeleteTaxtableAnnual(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetLeaveBalance()
        {
            try
            {
                return IMasterRepository.GetLeaveBalance<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertLeaveBalance(MasterEntity entity)
        {
            try
            {
                var filter = new
                {

                    SL_No = entity.SL_No,
                    EmployeeID = entity.EmployeeID,
                    LeaveType = entity.LeaveType,
                    AnnualQuota = entity.AnnualQuota,
                    CarriedForward = entity.CarriedForward,
                    EntitlementTillDate = entity.EntitlementTillDate,
                    AvailedTillDate = entity.AvailedTillDate,
                    CurrentBalance = entity.CurrentBalance

                };
                return IMasterRepository.InsertLeaveBalance(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateLeaveBalance(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    SL_No = entity.SL_No,
                    EmployeeID = entity.EmployeeID,
                    LeaveType = entity.LeaveType,
                    AnnualQuota = entity.AnnualQuota,
                    CarriedForward = entity.CarriedForward,
                    EntitlementTillDate = entity.EntitlementTillDate,
                    AvailedTillDate = entity.AvailedTillDate,
                    CurrentBalance = entity.CurrentBalance


                };
                return IMasterRepository.UpdateLeaveBalance(filter);
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
                return IMasterRepository.DeleteLeaveBalance(filter);
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
                return IMasterRepository.DeleteCityType(filter);
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
                return IMasterRepository.DeleteCountryType(filter);
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
                return IMasterRepository.DeleteHolidays(filter);
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
                return IMasterRepository.DeleteLeaveType(filter);
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
                return IMasterRepository.DeleteShiftMaster(filter);
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
                return IMasterRepository.DeleteStateType(filter);
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
                return IMasterRepository.DeleteTransportRequestType(filter);
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
                return IMasterRepository.DeleteWorkStationType_Master(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetEntitlementMaster()
        {
            try
            {
                return IMasterRepository.GetEntitlementMaster<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertEntitlementMaster(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Short = entity.Short,
                    AnnualQuota = entity.AnnualQuota,
                    CarriedForward = entity.CarriedForward,
                    EntitlementTillDate = entity.EntitlementTillDate,
                    AvailedTillDate = entity.AvailedTillDate,
                    Current_Balance = entity.Current_Balance,
                    Description = entity.Description
                };
                return IMasterRepository.InsertEntitlementMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateEntitlementMaster(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Short = entity.Short,
                    AnnualQuota = entity.AnnualQuota,
                    CarriedForward = entity.CarriedForward,
                    EntitlementTillDate = entity.EntitlementTillDate,
                    AvailedTillDate = entity.AvailedTillDate,
                    Current_Balance = entity.Current_Balance,
                    Description = entity.Description
                };
                return IMasterRepository.UpdateEntitlementMaster(filter);
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
                return IMasterRepository.DeleteEntitlementMaster(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

