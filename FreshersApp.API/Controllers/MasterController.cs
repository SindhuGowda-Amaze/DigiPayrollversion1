using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Http;
using System.Net.Mail;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using System.Web;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Web.Http;
using ExcelDataReader;
using FastMember;
using System.Data.SqlClient;
using FreshersApp.Business.Interface;
using FreshersApp.Business.Entities;


namespace FreshersApp.API.Controllers
{
    public class MasterController : ApiController
    {
        private IMasterManager IMasterManager;
        public MasterController(IMasterManager IMasterManager)
        {
            this.IMasterManager = IMasterManager;
        }

        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [HttpGet]
        [Route("Master/GetTaxtable")]
        public HttpResponseMessage GetTaxtable()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetTaxtable();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetTaxtable + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/UpdateTaxtable")]
        public HttpResponseMessage UpdateTaxtable(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateTaxtable(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateTaxtable + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }




        [HttpGet]
        [Route("Master/GetPhilHealth")]
        public HttpResponseMessage GetPhilHealth()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetPhilHealth();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetPhilHealth + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertPhilHealth")]
        public HttpResponseMessage InsertPhilHealth(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertPhilHealth(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertPhilHealth + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }
        [HttpPost]
        [Route("Master/UpdatePhilHealth")]
        public HttpResponseMessage UpdatePhilHealth(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdatePhilHealth(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdatePhilHealth + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/DeletePhilHealth")]
        public HttpResponseMessage DeletePhilHealth(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeletePhilHealth(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeletePhilHealth + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteCompanyAdjustment")]
        public HttpResponseMessage DeleteCompanyAdjustment(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteCompanyAdjustment(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteCompanyAdjustment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/GetDepartment")]
        public HttpResponseMessage GetDepartment()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetDepartment();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetDepartment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertDepartment")]
        public HttpResponseMessage InsertDepartment(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertDepartment(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertDepartment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/UpdateDepartment")]
        public HttpResponseMessage UpdateDepartment(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateDepartment(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateDepartment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteDepartment")]
        public HttpResponseMessage DeleteDepartment(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteDepartment(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteDepartment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/GetOTRates")]
        public HttpResponseMessage GetOTRates()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetOTRates();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetOTRates + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertOTRates")]
        public HttpResponseMessage InsertOTRates(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertOTRates(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertOTRates + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }
        [HttpGet]
        [Route("Master/GetCompanyAdjustment")]
        public HttpResponseMessage GetCompanyAdjustment()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetCompanyAdjustment();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetCompanyAdjustment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/UpdateOTRates")]
        public HttpResponseMessage UpdateOTRates(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateOTRates(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateOTRates + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteOTRates")]
        public HttpResponseMessage DeleteOTRates(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteOTRates(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteOTRates + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/GetBanks")]
        public HttpResponseMessage GetBanks()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetBanks();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetBanks + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertBanks")]
        public HttpResponseMessage InsertBanks(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertBanks(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertBanks + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/UpdateBanks")]
        public HttpResponseMessage UpdateBanks(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateBanks(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateBanks + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteBanks")]
        public HttpResponseMessage DeleteBanks(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteBanks(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteBanks + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/GetPayGroup")]
        public HttpResponseMessage GetPayGroup()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetPayGroup();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetPayGroup + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertPayGroup")]
        public HttpResponseMessage InsertPayGroup(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertPayGroup(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertPayGroup + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/UpdatePayGroup")]
        public HttpResponseMessage UpdatePayGroup(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdatePayGroup(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdatePayGroup + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeletePayGroup")]
        public HttpResponseMessage DeletePayGroup(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeletePayGroup(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeletePayGroup + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/GetGovernmentRecords")]
        public HttpResponseMessage GetGovernmentRecords()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetGovernmentRecords();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetGovernmentRecords + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertGovernmentRecords")]
        public HttpResponseMessage InsertGovernmentRecords(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertGovernmentRecords(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertGovernmentRecords + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/UpdateGovernmentRecords")]
        public HttpResponseMessage UpdateGovernmentRecords(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateGovernmentRecords(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateGovernmentRecords + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteGovernmentRecords")]
        public HttpResponseMessage DeleteGovernmentRecords(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteGovernmentRecords(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteGovernmentRecords + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }




        [HttpGet]
        [Route("Master/GetCostcenter")]
        public HttpResponseMessage GetCostcenter()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetCostcenter();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetCostcenter + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/InsertCostcenter")]
        public HttpResponseMessage InsertCostcenter(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertCostcenter(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertCostcenter + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/UpdateCostcenter")]
        public HttpResponseMessage UpdateCostcenter(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateCostcenter(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateCostcenter + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteCostcenter")]
        public HttpResponseMessage DeleteCostcenter(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteCostcenter(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteCostcenter + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/GetCompanyProfile")]
        public HttpResponseMessage GetCompanyProfile()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetCompanyProfile();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetCompanyProfile + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertCompany_Profile")]
        public HttpResponseMessage InsertCompany_Profile(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertCompany_Profile(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertCompany_Profile + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteCompanyProfile")]
        public HttpResponseMessage DeleteCompanyProfile(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteCompanyProfile(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteCompanyProfile + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }
        //[HttpPost]
        //[Route("Master/UpdateFoodSenseProject")]
        //public HttpResponseMessage UpdateFoodSenseProject(MasterEntity entity)
        //{
        //    HttpResponseMessage response;
        //    try
        //    {
        //        object res = IMasterManager.UpdateFoodSenseProject(entity);
        //        response = Request.CreateResponse(HttpStatusCode.OK, res);
        //    }
        //    catch (Exception ex)
        //    {
        //        if (log.IsErrorEnabled)
        //        {
        //            log.Error("Error in UpdateFoodSenseProject + ex");
        //        }
        //        response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //    return response;
        //}


        [HttpGet]
        [Route("Master/GetSSS")]
        public HttpResponseMessage GetSSS()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetSSS();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetSSS + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertSSS")]
        public HttpResponseMessage InsertSSS(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertSSS(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertSSS + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteSSS")]
        public HttpResponseMessage DeleteSSS(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteSSS(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteSSS + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/UpdateSSS")]
        public HttpResponseMessage UpdateSSS(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateSSS(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateSSS + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/GetEmployeeInformation")]
        public HttpResponseMessage GetEmployeeInformation()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetEmployeeInformation();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetEmployeeInformation + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertEmployeeInformation")]
        public HttpResponseMessage InsertEmployeeInformation(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertEmployeeInformation(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertEmployeeInformation + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteEmployeeInformation")]
        public HttpResponseMessage DeleteEmployeeInformation(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteEmployeeInformation(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteEmployeeInformation + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/UpdateEmployeeInformation")]
        public HttpResponseMessage UpdateEmployeeInformation(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateEmployeeInformation(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateEmployeeInformation + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetMyAttendenceDetails")]
        public HttpResponseMessage GetMyAttendenceDetails()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetMyAttendenceDetails();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetMyAttendenceDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertMyAttendenceDetails")]
        public HttpResponseMessage InsertMyAttendenceDetails(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertMyAttendenceDetails(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertMyAttendenceDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteMyAttendenceDetails")]
        public HttpResponseMessage DeleteMyAttendenceDetails(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteMyAttendenceDetails(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteMyAttendenceDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/UpdateMyAttendenceDetails")]
        public HttpResponseMessage UpdateMyAttendenceDetails(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateMyAttendenceDetails(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateMyAttendenceDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetAdjustment")]
        public HttpResponseMessage GetAdjustment()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetAdjustment();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetAdjustment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertAdjustment")]
        public HttpResponseMessage InsertAdjustment(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertAdjustment(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertAdjustment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteAdjustment")]
        public HttpResponseMessage DeleteAdjustment(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteAdjustment(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteAdjustment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/UpdateAdjustment")]
        public HttpResponseMessage UpdateAdjustment(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateAdjustment(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateAdjustment + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/GetMyOverTimeDetails")]
        public HttpResponseMessage GetMyOverTimeDetails()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetMyOverTimeDetails();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetMyOverTimeDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertMyOverTimeDetails")]
        public HttpResponseMessage InsertMyOverTimeDetails(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertMyOverTimeDetails(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertMyOverTimeDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteMyOverTimeDetails")]
        public HttpResponseMessage DeleteMyOverTimeDetails(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteMyOverTimeDetails(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteMyOverTimeDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/UpdateMyOverTimeDetails")]
        public HttpResponseMessage UpdateMyOverTimeDetails(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateMyOverTimeDetails(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateMyOverTimeDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/GetMyLeaveReport")]
        public HttpResponseMessage GetMyLeaveReport()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetMyLeaveReport();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetMyLeaveReport + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertMyLeaveReport")]
        public HttpResponseMessage InsertMyLeaveReport(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertMyLeaveReport(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertMyLeaveReport + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteMyLeaveReport")]
        public HttpResponseMessage DeleteMyLeaveReport(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteMyLeaveReport(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteMyLeaveReport + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/UpdateMyLeaveReport")]
        public HttpResponseMessage UpdateMyLeaveReport(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateMyLeaveReport(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateMyLeaveReport + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpGet]
        [Route("Master/GetUserDetails")]
        public HttpResponseMessage GetUserDetails()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetUserDetails();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetUserDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertUserDetails")]
        public HttpResponseMessage InsertUserDetails(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertUserDetails(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertUserDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteUserDetails")]
        public HttpResponseMessage DeleteUserDetails(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteUserDetails(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteUserDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/UpdateUserDetails")]
        public HttpResponseMessage UpdateUserDetails(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateUserDetails(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateUserDetails + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetMyWeeklyShift")]
        public HttpResponseMessage GetMyWeeklyShift()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetMyWeeklyShift();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetMyWeeklyShift + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertMyWeeklyShift")]
        public HttpResponseMessage InsertMyWeeklyShift(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertMyWeeklyShift(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertMyWeeklyShift + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteMyWeeklyShift")]
        public HttpResponseMessage DeleteMyWeeklyShift(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteMyWeeklyShift(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteMyWeeklyShift + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/UpdateMyWeeklyShift")]
        public HttpResponseMessage UpdateMyWeeklyShift(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateMyWeeklyShift(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateMyWeeklyShift + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        [HttpGet]
        [Route("Master/GetRegularization")]
        public HttpResponseMessage GetRegularization()
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.GetRegularization();
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in GetRegularization + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpPost]
        [Route("Master/InsertRegularization")]
        public HttpResponseMessage InsertRegularization(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.InsertRegularization(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in InsertRegularization + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [HttpGet]
        [Route("Master/DeleteRegularization")]
        public HttpResponseMessage DeleteRegularization(Int64 ID)
        {
            HttpResponseMessage response;
            try
            {
                var filter = new { ID = ID };
                Int64 res = IMasterManager.DeleteRegularization(filter);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in DeleteRegularization + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }


        [HttpPost]
        [Route("Master/UpdateRegularization")]
        public HttpResponseMessage UpdateRegularization(MasterEntity entity)
        {
            HttpResponseMessage response;
            try
            {
                object res = IMasterManager.UpdateRegularization(entity);
                response = Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Error in UpdateRegularization + ex");
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }



        //Important!!!
        [HttpPost]
        [Route("Master/UploadImages/")]
        public HttpResponseMessage UploadImages()
        {
            HttpResponseMessage response;
            try
            {
                string result = string.Empty;
                var httpRequest = HttpContext.Current.Request;
                if (httpRequest.Files.Count > 0)
                {
                    foreach (string file in httpRequest.Files)
                    {
                        var postedFile = httpRequest.Files[file];
                        var Name = postedFile.FileName.Split('\\').LastOrDefault().Split('/').LastOrDefault().Replace(" ", null);
                        var fn = Name.Split('.').FirstOrDefault();
                        var ext = Name.Split('.').LastOrDefault();
                        var time = DateTime.Now.ToString("yyyyMMddHHmmss");
                        //var fileName = time + Name;
                        var fileName = fn + '-' + time + '.' + ext;
                        Directory.CreateDirectory(HostingEnvironment.MapPath("~/Images/"));
                        string filePath = HostingEnvironment.MapPath("~/Images/" + fileName);
                        postedFile.SaveAs(filePath);
                        result = filePath;
                    }
                }
               response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled)
                {
                    log.Error("Master/UploadTestimonialImages/Error:" + ex);
                }
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Uploadimage Error " + ex.Message);
            }
            return response;
        }
    }
}