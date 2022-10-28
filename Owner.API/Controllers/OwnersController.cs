using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Owner.API.Data;
using Owner.API.Model;
using System.Linq;

namespace Owner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        [Route("All")]
        [HttpGet]
        public IActionResult GelAllOwner()
        {
            var result = new OwnerData().GelAllOwner();
            return Ok(result);
        }

        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OwnerModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Add(OwnerModel owner)
        {
            var result = new OwnerData().GelAllOwner();

            if (owner.Description.Contains("hack"))
            {
                return BadRequest("Invalid description");
            }

            result.Add(owner);
            return Ok(result);
        }

        [Route("Update")]
        [HttpPut]
        public IActionResult Update(int id, OwnerModel owner)
        {
            if (id != owner.Id)
                return BadRequest("owner id numbers did not match");

            var result = new OwnerData().GelAllOwner();
            var ownerToUpdate = result.FirstOrDefault(x => x.Id == id);

            ownerToUpdate.Name=owner.Name;
            ownerToUpdate.LastName = owner.LastName;
            ownerToUpdate.Description=owner.Description;
            ownerToUpdate.Date = owner.Date;
            ownerToUpdate.Description = owner.Description;
            ownerToUpdate.Type = owner.Type;

            return Ok(ownerToUpdate);
        }

        [Route("Delete")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = new OwnerData().GelAllOwner();  
            var ownerToDelete = result.FirstOrDefault(x => x.Id == id);

            if (ownerToDelete == null)
                return NotFound($"Owner {id} not found.");

            result.Remove(ownerToDelete);
            return Ok("owner deleted");
        }
    }
}
