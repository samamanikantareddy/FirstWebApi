using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace calculator_api.Controllers
{
    [Route("[controller]/[action]")]
    public class c : Controller
    {
        // GET: api/values

        [HttpGet]
        public double add(int leftNumber, int rightNumber)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return cccalculator.Class1.Add(leftNumber, rightNumber);
        }
        [HttpGet]
        public double substract(int leftNumber, int rightNumber)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return cccalculator.Class1.Subtract(leftNumber, rightNumber);

        }
        [HttpGet]
        public double divide(float leftNumber, float rightNumber)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");

            double result = 0;

            try
            {
                result = cccalculator.Class1.Division(leftNumber, rightNumber);
            }
            catch (DivideByZeroException)
            {
                Response.StatusCode = 400;
            }

            return result;
        }
        [HttpGet]
        public double multiply(int leftNumber, int rightNumber)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return cccalculator.Class1.Multiply(leftNumber, rightNumber);
        }
    }
}

