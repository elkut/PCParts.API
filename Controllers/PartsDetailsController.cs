using Microsoft.AspNetCore.Mvc;
using PCParts.API.Models;

namespace PCParts.API.Controllers
{
    [Route("api/pcparts/{Id}/pcpartdetails")]
    [ApiController]
    public class PartsDetailsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PartDetailDTO>> GetPartsDetails(int partId)
        {
            var details = PCPartsDataStore.Parts.PCParts.FirstOrDefault(d => d.Id == partId);

            if (details == null)
            {
                return NotFound();
            }
            return Ok(details.PartDetails);
        }

        [HttpGet("{partdetailId}")]
        public ActionResult<PartDetailDTO> GetPartDetails(int pcPartId, int partdetailId)
        {
            var pcpart = PCPartsDataStore.Parts.PCParts.FirstOrDefault((part) => part.Id == pcPartId);

            if (pcpart == null)
            {
                return NotFound("Parts Not Found");
            }

            var pcPartDetail = pcpart.PartDetails.FirstOrDefault(p => p.Id == partdetailId);

            if (pcPartDetail == null)
            {
                return NotFound("Parts Not Found");
            }

            return Ok(pcPartDetail);
        }
    }
}
