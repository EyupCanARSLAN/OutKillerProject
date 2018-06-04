using ServiceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public ServiceResult<IEnumerable<string>> Get()
        {
            return ServiceResult<IEnumerable<string>>.SuccessResponse(new string[] { "value1", "value2" });
        }

        // GET api/values/5
        public ServiceResult<dynamic> Get(int id)
        {
            return ServiceResult<dynamic>.FailResponse("Unexpected error occured.");
        }
    }
}
