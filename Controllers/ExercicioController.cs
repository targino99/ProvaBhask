using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExBhaskara.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class ExercicioController : ControllerBase
    {
    

        [HttpGet]
       
        [Route("Calculo/{a:float}/{b:float}/{c:float}")]
        public int Calculo(float a, float b, float c)
        {
            Exercicio Exercicio = new Exercicio();
            return Exercicio.Calculo(a, b, c);
        }
    
    }
}
