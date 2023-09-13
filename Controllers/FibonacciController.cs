using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fibonacci.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        [HttpGet(Name = "GetFibonacciIndex")]
        public int GetFibonacciValueByIndex(int index)
        {
            int x1 = 0;
            int x2 = 1;


            //generamos las "n" sucesiones del código Fibonacci
            for (int i = 0; i < index; i++)
            {
                //almacenamos el primer valor en una variable temporal
                int temp = x1;

                //El primer valor se convierte en el segundo valor.
                x1 = x2;

                //Sumamos los valores.
                x2 = temp + x1;

               
            }

            return x1;
        }
    }
}
