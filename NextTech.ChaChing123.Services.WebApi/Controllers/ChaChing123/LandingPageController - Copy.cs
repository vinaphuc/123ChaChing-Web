﻿/// <summary>
/// <author>Ngô Tấn Phúc</author>
/// <description>Created date: </description>
/// <revision history>Version: 1.0.1</revision history>
/// </summary>
using System.Web.UI;
namespace NextTech.ChaChing123.Services.WebApi.Controllers
{
    using NextTech.ChaChing123.Common.Models;
    using NextTech.ChaChing123.Core.Models;
    using NextTech.ChaChing123.Data.Infrastructure;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using NextTech.ChaChing123.Entities;
    using NextTech.ChaChing123.Services.WebApi.Infrastructure.Core;
    using NextTech.ChaChing123.Business;
    using NextTech.ChaChing123.Core.Filters;
    using NextTech.ChaChing123.Core.Filters.ErrorHelper;
    using Common.Constants;
    using NextTech.ChaChing123.Business.Utilities;
    using System.Web;
    using System;
    using Newtonsoft.Json;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json.Linq;
    using System.Web.Script.Serialization;
    using System.Net.Http.Headers;

    /// <summary>
    /// Class LandingPageController.
    /// </summary>
    /// <seealso cref="NextTech.ChaChing123.Services.WebApi.Infrastructure.Core.ApiControllerBase" />
    [SSLClientCertificateActionWebApiFilter]
    [RoutePrefix("api/LandingPage")]
    public class LandingPageController : ApiControllerBase
    {

        /// <summary>
        /// The service
        /// </summary>
        private readonly ILandingPageService _service;

        /// <summary>
        /// Initializes a new instance of the <see cref="LandingPageController"/> class.
        /// </summary>
        /// <param name="interfaceService">The interface service.</param>
        /// <param name="_unitOfWork">The unit of work.</param>
        public LandingPageController(ILandingPageService interfaceService, IUnitOfWork _unitOfWork)
            : base(_unitOfWork)
        {
            _service = interfaceService;
        }


        [AllowAnonymous]
        [Route("GetSoloInfoByShareCode")]
        [HttpPost]
        public HttpResponseMessage GetSoloInfoByShareCode(HttpRequestMessage request, RequestSoloByShareCodeDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;
                ResultDTO result = _service.GetSoloInfoByShareCode(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }


        [AllowAnonymous]
        [Route("GetDetailSoloPage")]
        [HttpPost]
        public HttpResponseMessage GetDetailSoloPage(HttpRequestMessage request, RequestViewDetaiDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response;

                ResultDTO result = _service.GetDetailSoloPage(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }

        [AllowAnonymous]
        [Route("GetDetailSoloPageByID")]
        [HttpPost]
        public HttpResponseMessage GetDetailSoloPageByID(HttpRequestMessage request, RequestDetailByIDDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response;

                ResultDTO result = _service.GetDetailSoloPageByID(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }
        [AllowAnonymous]
        [Route("GetFunnalDetailByReivew")]
        [HttpPost]
        public HttpResponseMessage GetFunnalDetailByReivew(HttpRequestMessage request, RequestNextSoloDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response;

                ResultDTO result = _service.GetFunnalDetailByReivew(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }
        [AllowAnonymous]
        [Route("GetFunnalDetailByPublic")]
        [HttpPost]
        public HttpResponseMessage GetFunnalDetailByPublic(HttpRequestMessage request, RequestNextSoloDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response;

                ResultDTO result = _service.GetFunnalDetailByPublic(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }
        
        [AllowAnonymous]
        [Route("GetAllSoloPage")]
        [HttpPost]
        public HttpResponseMessage GetAllSoloPage(HttpRequestMessage request, RequestDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;

                ResultDTO result = _service.GetAllSoloPage(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }

        [AllowAnonymous]
        [Route("GetAllPublicSoloPage")]
        [HttpPost]
        public HttpResponseMessage GetAllPublicSoloPage(HttpRequestMessage request, RequestDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;

                ResultDTO result = _service.GetAllPublicSoloPage(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }
        [AllowAnonymous]
        [Route("AddSoloPage")]
        [HttpPost]
        public HttpResponseMessage AddSoloPage(HttpRequestMessage request, SolaPageDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;

                ResultDTO result = _service.AddSoloPage(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }

        [AllowAnonymous]
        [Route("EditSoloPage")]
        [HttpPost]
        public HttpResponseMessage EditSoloPage(HttpRequestMessage request, SolaPageDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;

                ResultDTO result = _service.EditSoloPage(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }

        [AllowAnonymous]
        [Route("DeleteSoloPage")]
        [HttpPost]
        public HttpResponseMessage DeleteSoloPage(HttpRequestMessage request, RequestViewDetaiDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;

                ResultDTO result = _service.DeleteSoloPage(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }

        [AllowAnonymous]
        [Route("GetDetailFunnalPage")]
        [HttpPost]
        public HttpResponseMessage GetDetailFunnalPage(HttpRequestMessage request, RequestViewDetaiDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response;
                ResultDTO result = _service.GetDetailFunnalPage(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }

        [AllowAnonymous]
        [Route("GetAllFunnalPage")]
        [HttpPost]
        public HttpResponseMessage GetAllFunnalPage(HttpRequestMessage request, RequestDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;

                ResultDTO result = _service.GetAllFunnalPage(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }

        [AllowAnonymous]
        [Route("AddFunnalPage")]
        [HttpPost]
        public HttpResponseMessage AddFunnalPage(HttpRequestMessage request, RequestFunnalPageDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;

                ResultDTO result = _service.AddFunnalPage(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }

        [AllowAnonymous]
        [Route("EditFunnalPage")]
        [HttpPost]
        public HttpResponseMessage EditFunnalPage(HttpRequestMessage request, RequestFunnalPageDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;

                ResultDTO result = _service.EditFunnalPage(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }

        [AllowAnonymous]
        [Route("DeleteFunnalPage")]
        [HttpPost]
        public HttpResponseMessage DeleteFunnalPage(HttpRequestMessage request, RequestViewDetaiDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;

                ResultDTO result = _service.DeleteFunnalPage(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }

        [AllowAnonymous]
        [Route("GetDetailFunnalPageByID")]
        [HttpPost]
        public HttpResponseMessage GetDetailFunnalPageByID(HttpRequestMessage request, RequestDetailByIDDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response;

                ResultDTO result = _service.GetDetailFunnalPageByID(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }
        [AllowAnonymous]
        [Route("RegisterLeadBySoloPage")]
        [HttpPost]
        public HttpResponseMessage RegisterLeadBySoloPage(HttpRequestMessage request, RegisterLeadBySoloPageDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response;

                ResultDTO result = _service.RegisterLeadBySoloPage(obj);
                if (result.Details != null)
                {
                    MailChimpResponse1DTO objOlala = (MailChimpResponse1DTO)result.Details;
                    AddSubscribe(objOlala.APIKey, objOlala.DataCenter, objOlala.ListID, obj.Email, objOlala.PageName, obj.Name,obj.Phone, obj.SessionKey);
                }
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });

        }
        public void AddSubscribe(string apiKey, string dataCenter, string listID, string email, string PageName, string name,string phone, string sessionKey)
        {
            ResultDTO result = new ResultDTO();
            string content = apiKey + "/" + dataCenter + "/" + listID + "/" + email + "/" + PageName + "/" + name + ".";
            Business.Utilities.AppLog.WriteLog("AddSubscribe", ActionType.Add, content, sessionKey);
            try
            {
                SubscribeClassCreatedByMe subscribeRequest = new SubscribeClassCreatedByMe
                {
                    email_address = email,
                    status = PageName
                };
                subscribeRequest.merge_fields = new MergeFieldClassCreatedByMe();
                subscribeRequest.merge_fields.FNAME = name;
                subscribeRequest.merge_fields.LNAME = "123";
                subscribeRequest.merge_fields.PHONE = phone;

                using (HttpClient client = new HttpClient())
                {
                    var uri = "https://" + dataCenter + ".api.mailchimp.com/";
                    var endpoint = "3.0/lists/" + listID + "/members";

                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.Default.GetBytes("anystring" + ":" + apiKey)));
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    client.BaseAddress = new Uri(uri);

                    HttpResponseMessage response = client.PostAsJsonAsync(endpoint, subscribeRequest).Result;
                    var errorResponse = response.Content.ReadAsStringAsync();
                    if ((response.IsSuccessStatusCode))
                    {
                        //TODO       
                    }
                }

            }
            catch (Exception ex)
            {
                result.StatusCode = 9999;
                result.Details = ex.Message;
                result.SetContentMsg();
            }
        }

        [AllowAnonymous]
        [Route("GetAllTitleTemplate")]
        [HttpPost]
        public HttpResponseMessage GetAllTitleTemplate(HttpRequestMessage request, RequestDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;

                ResultDTO result = _service.GetTitleTemplate(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }

        [AllowAnonymous]
        [Route("GetAllSubTitleTemplate")]
        [HttpPost]
        public HttpResponseMessage GetAllSubTitleTemplate(HttpRequestMessage request, RequestDTO obj)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response;

                ResultDTO result = _service.GetSubTitleTemplate(obj);
                response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("UploadFile")]
        public HttpResponseMessage UploadFile(HttpRequestMessage request)
        {
            ResultDTO result = new ResultDTO();
            try
            {
                var requestContext = HttpContext.Current.Request;
                var pathFolder = System.Web.Hosting.HostingEnvironment.MapPath(Common.GetConfigValue("PathFileOfLandingPage"));
                string sessionKey = requestContext.Form.Get("SessionKey");

                result = Common.CheckLogin(sessionKey);
                if (result.StatusCode != 0)
                {
                    return CreateHttpResponse(request, () =>
                    {
                        var response = request.CreateResponse(HttpStatusCode.OK, result);
                        return response;
                    });
                }
                if (requestContext.Files.Count < 1)
                {
                    result.StatusCode = int.Parse(RetCodeMsg.ECS0028, 0);
                    result.SetContentMsg();
                }
                else
                {
                    string fileName = requestContext.Files[0].FileName;
                    string ext = System.IO.Path.GetExtension(fileName);
                    string originalFileName = System.IO.Path.GetFileName(fileName);
                    // Save to file temp
                    var tempFileName = Guid.NewGuid() + ext;
                    //To save file, use SaveAs method
                    if (System.IO.File.Exists(pathFolder + tempFileName))
                    {
                        System.IO.File.Delete(pathFolder + tempFileName);
                    }
                    //File will be saved in application root
                    requestContext.Files[0].SaveAs(pathFolder + tempFileName);
                    result.StatusCode = 0;
                    result.SetContentMsg();
                    result.Details = (ConfigSystem.LandingPagePath + tempFileName);
                }
            }
            catch (Exception ex)
            {
                result.StatusCode = 9999;
                result.Details = ex.Message;

                return CreateHttpResponse(request, () =>
                {
                    var response = request.CreateResponse(HttpStatusCode.OK, result);
                    return response;
                });
            }

            return CreateHttpResponse(request, () =>
            {
                var response = request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            });
        }       
    }
}

