using System;
using System.Linq;
using PamonhaAPI.Model;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Distributed;

namespace PamonhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get([FromServices] IDistributedCache cache)
        {
            int numeroDeVisitas = 0;
            
            var obj = cache.GetString("numeroDeVisitas");

            if (!string.IsNullOrWhiteSpace(obj))                           
                numeroDeVisitas = Convert.ToInt32(obj); 
            
            numeroDeVisitas ++;
            
            cache.SetString("numeroDeVisitas", numeroDeVisitas.ToString());
            
            var retorno = new Retorno(numeroDeVisitas);

            return Ok(retorno);
        }       
    }
}
