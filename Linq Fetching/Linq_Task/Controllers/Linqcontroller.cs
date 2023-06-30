using BLL.Interface;
using BLL.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Linq_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Linqcontroller : ControllerBase
    {
        private readonly IBusinesssample _IBusinesssample;
        public Linqcontroller(IBusinesssample IBusinesssample)
        {
            _IBusinesssample = IBusinesssample;
        }
        [HttpGet("GetJson")]
        public IActionResult GetJson()
        {
            var res = _IBusinesssample.GetJson();
            return Ok(res);
        }

        [HttpGet("NumofTransaction")]
        public IActionResult NumofTransaction()
        {
            var res= _IBusinesssample.NumofTransaction();
            return Ok(res);
        }

        [HttpGet("SumofTransaction")]
        public IActionResult SumofTransaction()
        {
            var res = _IBusinesssample.SumofTransaction();
            return Ok(res);
        }


        [HttpGet("AverageOgTransaction")]
        public IActionResult AverageOgTransaction()
        {
            var res = _IBusinesssample.AverageOgTransaction();
            return Ok(res);
        }

        [HttpGet("Highestquantity")]
        public IActionResult Highestquantity()
        {
            var res = _IBusinesssample.Highestquantity();
            return Ok(res);
        }

        [HttpGet("HighestAmount")]
        public IActionResult HighestAmount()
        {
            var res = _IBusinesssample.HighestAmount();
            return Ok(res);
        }
    }
}
