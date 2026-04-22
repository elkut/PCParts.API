using Microsoft.AspNetCore.Mvc;
using PCParts.API.Models;

namespace PCParts.API.Controllers
{
    [Route("api/pcparts/{Id}/pcpartdetails")]
    [ApiController]
    public class PartsDetailsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PartDetailDTO>> GetPartDetail(int partId)
        {
            var details = PCPartsDataStore.Parts.PCParts.FirstOrDefault(d => d.Id == partId);

            if (details == null)
            {
                return NotFound();
            }
            return Ok(details.PartDetails);
        }
    }
}
