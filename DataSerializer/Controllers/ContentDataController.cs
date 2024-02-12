using DataSerializer.Models.DtoModels;
using DataSerializer.Service;
using Microsoft.AspNetCore.Mvc;

namespace DataSerializer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContentDataController : ControllerBase
    {
        private readonly IContentDataService _service;
        public ContentDataController(IContentDataService service)
        {
            _service = service;
        }

        [Route("add")]
        [HttpPost]
        public async Task<ActionResult<IContentDataReadDtoModel>> AdddNew([FromBody]ContentDataCreateDtoModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newId = await _service.AddContentDataAsync(model);
            var result = await _service.GetContentDataByIdAsync(newId);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IContentDataReadDtoModel>> GetById(int id)
        {
            var result = await _service.GetContentDataByIdAsync(id);
            return Ok(result);
        }
    }
}
