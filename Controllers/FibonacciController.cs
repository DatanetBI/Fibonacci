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
            int v1 = 0;
            int v2 = 1;


            //En este caso generamos 30 sucesiones del código Fibonacci.
            for (int i = 0; i < index; i++)
            {
                //Almacenamos el valor v1 en una variable temporal para no perderlo.
                int temp = v1;

                //El valor 1 se convierte en el valor 2.
                v1 = v2;

                //Sumamos los valores.
                v2 = temp + v1;

               
            }

            return v1;
        }
    }
}
