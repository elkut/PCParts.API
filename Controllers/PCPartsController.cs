using Microsoft.AspNetCore.Mvc;
using PCParts.API.Models;

namespace PCParts.API.Controllers
{
    [Route("api/pcparts")]
    [ApiController]
    public class PCPartsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PartsSummaryDto>> GetPCParts()
        {
            var pcparts = PCPartsDataStore.Parts.PCParts;

            return Ok(pcparts);
        }

    }
}
