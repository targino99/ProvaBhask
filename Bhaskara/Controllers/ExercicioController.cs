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
       
        [Route("Calculo/{a:int}/{b:int}/{c:int}")]
        public int Calculo(int a, int b, int c)
        {
            Exercicio Exercicio = new Exercicio();
            return Exercicio.Calculo(a, b, c);
        }
    
    }
