using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallenge2_4EndpointsMVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MiniChallenge24EndpointsMVC : ControllerBase
    {
        [HttpGet("/twoNumbers")]
        public string addSums(int firstNumber, int secondNumber){
            return "The sum of " + firstNumber + " and " + secondNumber + " is " + (firstNumber + secondNumber);
        }
        [HttpGet("/acceptStrings")]
        public string addStrings(string name, int time){
            return  name + " woke up at " + time + " o'clock";
        }

        [HttpGet("/compare")]
        public string toCompare(int num1, int num2){
            string result;
            if(num1 > num2)
    {
        result = num1 + " is greater than " + num2 + " so " + num2 + " is less than " + num1 + ".";
    }
    else if (num1 < num2){
        result = num1 + " is less than " + num2 + " so " + num2 + " is greater than " + num1 + ".";
    }
    else
    {
        result = num1 + " is equal to " + num2 + " so " + "both numbers are equal.";
    }
    return result;
           
        }

    }
}