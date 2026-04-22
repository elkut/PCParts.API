using Microsoft.AspNetCore.Mvc;
using PCParts.API.Models;

namespace PCParts.API.Controllers
{
    [Route("api/pcparts")]
    [ApiController]
    public class PCPartsController : ControllerBase
    {

        // Returns single object
        //[HttpGet]
        //public ActionResult<PartsSummaryDto> GetPCParts()
        //{
        //    var pcparts = PCPartsDataStore.Parts.PCParts;

        //    return Ok(pcparts);
        //}

        // Tells consumers (Swagger, clients, other devs) to expect an array, not a single object
        [HttpGet]
        public ActionResult<IEnumerable<PartsSummaryDto>> GetPCParts()
        {
            var pcparts = PCPartsDataStore.Parts.PCParts;

            return Ok(pcparts);
        }

        [HttpGet("{id}")]
        public ActionResult<PartsSummaryDto> GetPCPart(int id)
        {
            var pcpart = PCPartsDataStore.Parts.PCParts.FirstOrDefault(part => part.Id == id);

            if (pcpart == null)
            {
                return NotFound("Parts Not Found");
            }
            return Ok(pcpart);
        }

    }
}
