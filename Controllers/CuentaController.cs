using ChellengeRemitee.DTOs;
using ChellengeRemitee.Services;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ChellengeRemitee.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CuentaController : ControllerBase
    {

        ICuentaService _cuentaService;
        public CuentaController(ICuentaService cuentaService)
        {
            _cuentaService = cuentaService;
        }



        [HttpGet(Name = "GetSaldo")]
        public async Task<ActionResult<GetSaldoResponse>> GetSaldo(int id)
        {

            var ctaResult = await _cuentaService.GetSaldoById(id);
            if(ctaResult.Success)
            {
                return Ok(ctaResult); //200

            }
            return NotFound(); //404
        }

        [HttpPut(Name = "ExtraerSaldo")]
        public async Task<ActionResult<GetSaldoResponse>> PutExtraerSaldo(int id, decimal cantidad)
        {

            var ctaResult = await _cuentaService.ExtraerSaldo(id,cantidad);
            if (ctaResult.Success)
            {
                return Ok(ctaResult); //200

            }
            return NotFound(); //404
        }

    }
}
