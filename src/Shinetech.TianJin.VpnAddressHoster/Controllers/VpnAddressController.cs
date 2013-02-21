using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Shinetech.TianJin.VpnAddressHoster.Controllers
{
    public class VpnAddressController : ApiController
    {
        public string Get() {
            return "10.10.10.98";
        }

        public void Add([FromBody]string value) {
        }
    }
}