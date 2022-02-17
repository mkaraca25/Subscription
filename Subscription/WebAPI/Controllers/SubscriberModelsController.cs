using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberModelsController : ControllerBase
    {
        ISubscriberModelService _subscriberModelService;
        public SubscriberModelsController(ISubscriberModelService subscriberModelService)
        {
            _subscriberModelService = subscriberModelService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            
            var result=_subscriberModelService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {

            var result = _subscriberModelService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAllBySubscriberNo")]
        public IActionResult GetAllBySubscriberNo(int SubscriberNo)
        {

            var result = _subscriberModelService.GetAllBySubscriberNo(SubscriberNo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(SubscriberModel subscriberModel)
        {

            var result = _subscriberModelService.Add(subscriberModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(SubscriberModel subscriberModel)
        {

            var result = _subscriberModelService.Add(subscriberModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
