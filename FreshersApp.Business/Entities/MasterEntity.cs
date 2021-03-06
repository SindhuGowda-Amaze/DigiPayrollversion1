using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Business.Entities
{
    public class MasterEntity
    {

		public string Changes { get; set; }
		public string ModifiedBy { get; set; }
		public string Monthly_Basic_Salary_Into_Five { get; set; }
		public string Monthly_Share { get; set; }
		public string Personal_Share { get; set; }
		public string Employee_Share { get; set; }
		public bool BeforeTax { get; set; }
		public float Amount { get; set; }
		public bool Taxable { get; set; }
		public string MaxAccumulated { get; set; }
		public string Type { get; set; }
		public string Code { get; set; }
		public string Remarks { get; set; }




		public string Name { get; set; }
		public string EmailID { get; set; }
		public string PhoneNumber { get; set; }
		public string Message { get; set; }
		public Int64 ID { get; set; }
		public string TrainerName { get; set; }
		public string ProjectType { get; set; }
		public Int64? YearsOfExperience { get; set; }
		public string TrainerDescription { get; set; }
		public string BlogName { get; set; }
		public string Author { get; set; }
		public string Tags { get; set; }
		public string Description { get; set; }
		public string PhotoURL { get; set; }
		public string VideoURL { get; set; }
		public string BannerURL { get; set; }
		public string Status { get; set; }
		public Int64 CategoryID { get; set; }
		public string TrainerType { get; set; }
		public DateTime Date { get; set; }
		public Int64 ProjectID { get; set; }
		public Int64 ProjectTypeID { get; set; }
		public string ProjectName { get; set; }
		public string ProjectDescription { get; set; }
		public string ClientName { get; set; }
		public string ClientLocation { get; set; }
		public string Highlights { get; set; }
		public string Desgination { get; set; }
		public string WorkPlace { get; set; }
		public string Testimonial { get; set; }
		public string Action { get; set; }


		public string Company_logo { get; set; }
		public string Company_Name { get; set; }
		public string Nature_Of_Business { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string Zipcode { get; set; }
		public Int64 RDO { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Password { get; set; }
		public string Fax { get; set; }
		public string Tin { get; set; }
		public string SSN_No { get; set; }
		public string PhilHealthNumber { get; set; }
		public string HDMFNumber { get; set; }
		public string Admin_AuthorisedPerson { get; set; }
		public string Admin_PositionTitle { get; set; }
		public string HR_AuthorisedPerson { get; set; }
		public string HR_PositionTitle { get; set; }
		public string Finance_AuthorisedPerson { get; set; }
		public string Finance_PositionTitle { get; set; }
		public string E_Signatory { get; set; }
		public Int64 Work_Days_Per_Year { get; set; }
		public Int64 Work_Days_Per_Day { get; set; }
		public Int64 Work_Months_Per_Year { get; set; }
		public DateTime Work_hour_Start { get; set; }
		public DateTime Work_hour_End { get; set; }
		public DateTime Break_Hours { get; set; }
		public string Periods_Per_Month { get; set; }
		public string Absent_Deduction { get; set; }
		public string Late_Deduction { get; set; }
		public string OverTime_Comeptition_Optional { get; set; }
		public string OverTime_Comeptition_OTRates { get; set; }
		public string RestDays { get; set; }
		public string thirteen_Month_Compuatation_Type { get; set; }
		public bool thirteen_Month_Deduct_Absent { get; set; }
		public bool thirteen_Month_Deduct_Late { get; set; }
		public string thirteen_Month_Optional { get; set; }
		public bool FinalPay_Deduct_Absent { get; set; }
		public bool FinalPay_Deduct_Late { get; set; }
		public bool Final_Pay_13th_Month { get; set; }
		public bool NetPay_Threshold { get; set; }
		public string SSS_Coverage { get; set; }
		public string SSS_Optional { get; set; }
		public string PhilHealth_Coverage { get; set; }
		public string PhilHealth_Optional { get; set; }
		public string HDMS { get; set; }
		public string HDMF_Employer_Contribution { get; set; }
		public bool PayRoll_Calender { get; set; }
		public string Tax_Table { get; set; }
		public string Tax_Table_Starts_on { get; set; }
		public bool Tax_Table_Including_13thmonth { get; set; }
		public string Non_Tax_Essential_Sealing { get; set; }
		public string Deminimis_Exemption { get; set; }
		public string Day { get; set; }
		public string Normal { get; set; }
		public string OT { get; set; }
		public string ND { get; set; }
		public string NDOT { get; set; }



		public float Min_Range { get; set; }
		public float Max_Range { get; set; }
		public float Monthly_Salary_Creadited { get; set; }
		public float SS_ER { get; set; }
		public float SS_EE { get; set; }
		public float SS_Total { get; set; }
		//public float MPF_ER { get; set; }
		//public float MPF_EE { get; set; }
		//public float EC_ER { get; set; }
		public float Total_Contribution { get; set; }


		public string Range_Of_Compensastion { get; set; }
		public string MSCRSS_EC { get; set; }
		public string MSC_MPF { get; set; }
		public string MSC_Total { get; set; }
		public string RSS_ER { get; set; }
		public string RSS_EE { get; set; }
		public string RSS_Total { get; set; }
		public string EC_ER { get; set; }
		public string EC_EE { get; set; }
		public string EE_Total { get; set; }
		public string MPF_ER { get; set; }
		public string MPF_EE { get; set; }
		public string MPF_Total { get; set; }
		public string ER { get; set; }
		public string EE { get; set; }
		public string Total { get; set; }















		public string EmployeeID { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string Gender { get; set; }
		public DateTime DOB { get; set; }
		public string CivilStatus { get; set; }
		public string ContactNo { get; set; }
		public string HomeAddress { get; set; }

		public string Username { get; set; }

		public bool LockUser { get; set; }
		public string TaxStatus { get; set; }
		public bool MinimumWagesEarned { get; set; }
		public float COLA { get; set; }
		public float WorkdaysPerYear { get; set; }
		public float basicSalary { get; set; }
		public float Deminimis { get; set; }
		public string OT_ComputationTable { get; set; }
		public string SSS_Contribution { get; set; }
		public string PhilHealth_Contribution { get; set; }
		public string HDMF_Contribution { get; set; }
		public float Additional_HDMF_Contibution { get; set; }
		public string JobTitle { get; set; }
		public string Department { get; set; }
		public string CostCenter { get; set; }
		public DateTime HireDate { get; set; }
		public DateTime StatusDate { get; set; }
		public string Employment_Status { get; set; }
		public float Work_Hours_Per_Day { get; set; }
		public string Pay_Group { get; set; }
		public bool ROHQ { get; set; }
		public bool Consultant { get; set; }
		public string Consultant_Tax { get; set; }
		public string Consultant_TaxNum { get; set; }

		public string PhilHealth_No { get; set; }
		public string SSS_No { get; set; }
		public string HDMF_No { get; set; }
		public float SL { get; set; }
		public float VL { get; set; }
		public float LeaveCredit { get; set; }
		public string Dependent1 { get; set; }
		public DateTime Dependent1_DOB { get; set; }
		public string Dependent2 { get; set; }
		public DateTime Dependent2_DOB { get; set; }
		public string Dependent3 { get; set; }
		public DateTime Dependent3_DOB { get; set; }
		public string Dependent4 { get; set; }
		public DateTime Dependent4_DOB { get; set; }
		public string bank { get; set; }
		public string bank_AccountType { get; set; }
		public string bank_AccountNo { get; set; }
		public bool HasPreviousEmployment { get; set; }
		public float NonTax_13thMonth { get; set; }
		public float NonTax_OtherBonus { get; set; }
		public float NonTax_Salaries { get; set; }
		public float ThirteenthMonth { get; set; }
		public float OtherBonus { get; set; }
		public float TaxableGross { get; set; }
		public float Tax_Withheld { get; set; }
		public float GovernmentDeductions { get; set; }
		public float PreviousEmployment_Deminimis { get; set; }
		public float TaxableCompensation { get; set; }
		public float MonetizedLeave { get; set; }

		public string SSS_Number { get; set; }
		public DateTime SSS_DatePaid { get; set; }
		public string SSSLoan_Number { get; set; }
		public DateTime SSSLoan_DatePaid { get; set; }
		public string SSSCalamityLoan_Number { get; set; }
		public DateTime SSSCalamityLoan_DatePaid { get; set; }
		public string PhilHealth_Number { get; set; }
		public DateTime PhilHealth_DatePaid { get; set; }
		public string HDMF_Number { get; set; }
		public DateTime HDMF_DatePaid { get; set; }
		public string HDMFLoan_Number { get; set; }
		public DateTime HDMFLoan_DatePaid { get; set; }
		public string HDMPCalamityLoan_Number { get; set; }
		public DateTime HDMPCalamityLoan_DatePaid { get; set; }
		public float Daily_Deduction1 { get; set; }
		public float Daily_Deduction2 { get; set; }
		public float Daily_Deduction3 { get; set; }
		public float Daily_Deduction4 { get; set; }
		public float Daily_Deduction5 { get; set; }
		public float Daily_Deduction6 { get; set; }
		public float Daily_TaxTable1 { get; set; }
		public float Daily_TaxTable2 { get; set; }
		public float Daily_TaxTable3 { get; set; }
		public float Daily_TaxTable4 { get; set; }
		public float Daily_TaxTable5 { get; set; }
		public float Daily_TaxTable6 { get; set; }
		public float Weekly_Deduction1 { get; set; }
		public float Weekly_Deduction2 { get; set; }
		public float Weekly_Deduction3 { get; set; }
		public float Weekly_Deduction4 { get; set; }
		public float Weekly_Deduction5 { get; set; }
		public float Weekly_Deduction6 { get; set; }
		public float Weekly_Taxtable1 { get; set; }
		public float Weekly_Taxtable2 { get; set; }
		public float Weekly_Taxtable3 { get; set; }
		public float Weekly_Taxtable4 { get; set; }
		public float Weekly_Taxtable5 { get; set; }
		public float Weekly_Taxtable6 { get; set; }
		public float Semi_Monthly_Deduction1 { get; set; }
		public float Semi_Monthly_Deduction2 { get; set; }
		public float Semi_Monthly_Deduction3 { get; set; }
		public float Semi_Monthly_Deduction4 { get; set; }
		public float Semi_Monthly_Deduction5 { get; set; }
		public float Semi_Monthly_Deduction6 { get; set; }
		public float Semi_Monthly_Taxtable1 { get; set; }
		public float Semi_Monthly_Taxtable2 { get; set; }
		public float Semi_Monthly_Taxtable3 { get; set; }
		public float Semi_Monthly_Taxtable4 { get; set; }
		public float Semi_Monthly_Taxtable5 { get; set; }
		public float Semi_Monthly_Taxtable6 { get; set; }
		public float Monthly_Deduction1 { get; set; }
		public float Monthly_Deduction2 { get; set; }
		public float Monthly_Deduction3 { get; set; }
		public float Monthly_Deduction4 { get; set; }
		public float Monthly_Deduction5 { get; set; }
		public float Monthly_Deduction6 { get; set; }
		public float Monthly_Taxtable1 { get; set; }
		public float Monthly_Taxtable2 { get; set; }
		public float Monthly_Taxtable3 { get; set; }
		public float Monthly_Taxtable4 { get; set; }
		public float Monthly_Taxtable5 { get; set; }
		public float Monthly_Taxtable6 { get; set; }
		public bool Before { get; set; }
		public float MaxAccumulatedfloat { get; set; }
		public String Shift { get; set; }
		public DateTime ExpectedInTime { get; set; }
		public DateTime PunchInTime { get; set; }
		public DateTime ExpectedOutTime { get; set; }
		public DateTime PunchOutTime { get; set; }
		public DateTime WorkHours { get; set; }
		public String ExtraHours { get; set; }
		public String OTHours { get; set; }
		public String Comments { get; set; }
		public DateTime FromDate { get; set; }
		public DateTime TODate { get; set; }
		public DateTime ShiftDate { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public String LeaveDaysCount { get; set; }
		public String LeaveTypeAndReason { get; set; }
		public String ShiftName { get; set; }
		public String UserName { get; set; }
		public String Role { get; set; }
		public DateTime DateAdded { get; set; }
		public String Year { get; set; }
		public String Month { get; set; }
		public Int64 Period { get; set; }
		public String Pay_Roll_Run_Type { get; set; }
		public DateTime Transaction_Date { get; set; }



		public Int64 EmployeeCode { get; set; }
		public String OfficialEmail { get; set; }
		public Int64 Band { get; set; }
		public Int64 Grade { get; set; }
		public String JobRole { get; set; }
		public String Manager { get; set; }
		public String EmployeeType { get; set; }
		public String EmployeeStatus { get; set; }
		public Int64 NoticePeriod { get; set; }
		public Int64 ProbationPeriod { get; set; }
		public DateTime ConfirmationDueDate { get; set; }
		public String ConfirmationStatus { get; set; }
		public String EmployeeName { get; set; }
		public String Holiday { get; set; }
		public String HolidayDescription { get; set; }
		public DateTime HolidayDate { get; set; }
		public String Attachment { get; set; }
		public String ComapanyName { get; set; }
		public String Title { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public float Salary { get; set; }
		public bool CurrentEmployer { get; set; }
		public String EducationType { get; set; }
		public String Qualification { get; set; }
		public String NameOfQualification { get; set; }
		public String Branch { get; set; }
		public String InstitutionName { get; set; }
		public String Country { get; set; }
		public String ScoreType { get; set; }
		public DateTime StartDateMonth { get; set; }
		public DateTime StartDateYear { get; set; }
		public DateTime EndDateMonth { get; set; }
		public DateTime EndDateYear { get; set; }
		public String Middle_Name { get; set; }
		public String Last_Name { get; set; }
		public String PlaceO_f_Birth { get; set; }
		public String Country_Of_Birth { get; set; }
		public String Age { get; set; }
		public DateTime Date_Of_Marriage { get; set; }
		public String Personal_Email { get; set; }
		public String Mobile { get; set; }
		public String Religion { get; set; }
		public String Citizen_Ship { get; set; }
		public String Ethnicity { get; set; }
		public String Nationality { get; set; }
		public bool Is_Disabled { get; set; }
		public String Blood_Group { get; set; }
		public float Height { get; set; }
		public float Weight { get; set; }
		public String MajorIllness { get; set; }
		public bool IS_Night_Blind { get; set; }
		public bool Is_Color_Blind { get; set; }
		public String Designation { get; set; }
		public String PayRateType { get; set; }
		public String PayStructure { get; set; }
		public DateTime EffectiveFromDate { get; set; }
		public String Reason { get; set; }
		public String NameOfBank { get; set; }
		public String AccountHolderName { get; set; }
		public String BankAccountNumber { get; set; }
		public String VisaType { get; set; }
		public String VisaNumber { get; set; }
		public DateTime VisaIssueDate { get; set; }
		public DateTime VisaExpiryDate { get; set; }
		public String IDType { get; set; }
		public String Number { get; set; }
		public String NameOnDocument { get; set; }
		public DateTime IssueDate { get; set; }
		public DateTime ExpiryDate { get; set; }
		public String IssuingAuthority { get; set; }
		public String PlaceOfIssue { get; set; }
		public String Dependent { get; set; }
		public String Percentage { get; set; }
		public String NomineeType { get; set; }
		public String GuardianName { get; set; }
		public String GuardianRelationship { get; set; }
		public String DependentName { get; set; }
		public String Relationship { get; set; }
		public DateTime DateOfBirth { get; set; }
		public String Address { get; set; }
		public bool Is_Dependent { get; set; }
		public String Id_Number { get; set; }
		public bool Is_Child_Adopted { get; set; }
		public String Race { get; set; }
		public String CitizenShip { get; set; }
		public String Working_Status { get; set; }
		public String Request_Type { get; set; }
		public String CityName { get; set; }
		public Int64 ProvinceID { get; set; }
		public String CountryName { get; set; }
		public String ProvinceName { get; set; }
		public String IsActive { get; set; }
		public String IsTotal { get; set; }
		public String IsLocked { get; set; }
		public String Short { get; set; }
		public String AnnualQuota { get; set; }
		public String CarriedForward { get; set; }
		public String EntitlementTillDate { get; set; }
		public String AvailedTillDate { get; set; }
		public String Current_Balance { get; set; }
		public Int64 CoutryID { get; set; }
		public String From { get; set; }
		public String To { get; set; }
		public String Fix { get; set; }
		public String Rate { get; set; }

		public Int64 SL_No { get; set; }
		public String LeaveType { get; set; }
		//public Int64 AnnualQuota { get; set; }
		//public Int64 CarriedForward { get; set; }
		//public Int64 EntitlementTillDate { get; set; }
		//public Int64 AvailedTillDate { get; set; }
		public Int64 CurrentBalance { get; set; }
		public String LeaveReason { get; set; }
		public String LeaveStage { get; set; }
		public String LeaveStatus { get; set; }

	}
}