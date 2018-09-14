using System;
using System.Linq;
using PamonhaAPI.Model;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;

namespace PamonhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get([FromServices] IDistributedCache cache, [FromServices] IHostingEnvironment host)
        {
            int numeroDeVisitas = 0;
            
            var obj = cache.GetString("numeroDeVisitas");

            if (!string.IsNullOrWhiteSpace(obj))                           
                numeroDeVisitas = Convert.ToInt32(obj); 
            
            numeroDeVisitas ++;
            
            cache.SetString("numeroDeVisitas", numeroDeVisitas.ToString());
            
            var retorno = new Retorno(numeroDeVisitas, host.EnvironmentName);

            return Ok(retorno);
        }       
    }
}
