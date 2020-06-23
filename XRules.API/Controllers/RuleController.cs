using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using XRules.BRE;

namespace XRules.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RuleController : ControllerBase
    {

		[HttpGet]
		[Route("Run")]
		public ActionResult<string> Run()
        {
			XRuleEngine xre = new XRuleEngine();

			var x = xre.Run();

			return Ok(x.ToString());
		}

		[HttpGet]
		[Route("BasicTest")]
		public ActionResult<string> BasicTest( )
        {
			XRuleEngine xre = new XRuleEngine();

			var x = xre.TestIt();

			return Ok(x.ToString());
		}
	}

}