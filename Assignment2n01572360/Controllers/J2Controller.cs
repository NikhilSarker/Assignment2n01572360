using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2n01572360.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// How many ways we can make 10 by addition.
        /// </summary>
        /// <param name="m">6</param>
        /// <param name="n">8</param>
        /// <returns>There are 5 way to get the sum 10.</returns>
        /// GET: api/J2/DiceGame/
        /// <example>
        /// /api/J2/DiceGame/5/5  =>There are 1 way to get the sum 10. 
        /// </example>


        [HttpGet]
        [Route("api/J2/diceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {

            if (m < 4 && n < 4)
            {
                m = 0;
            }
            else if (m > 9 && n > 9)
            {
                m = 9;
            }

            else if (m == 5 && n == 5 || m == 5 && n == 5)
            {
                m = 1;
            }
            else if (m == 5 && n == 6 || m == 6 && n == 5)
            {
                m = 2;
            }
            else if (m == 5 && n == 7 || m == 7 && n == 5)
            {
                m = 3;
            }
            else if (m == 5 && n == 8 || m == 8 && n == 5)
            {
                m = 4;
            }
            else if (m == 5 && n >= 9 || m >= 9 && n == 5)
            {
                m = 5;
            }
            else if (m == 6 && n == 4 || m == 4 && n == 6)
            {
                m = 1;
            }

            else if (m == 6 && n == 6 || m == 6 && n == 6)
            {
                m = 3;
            }
            else if (m == 6 && n == 7 || m == 7 && n == 6)
            {
                m = 4;
            }
            else if (m == 6 && n == 8 || m == 8 && n == 6)
            {
                m = 5;
            }
            else if (m == 6 && n >= 9 || m >= 9 && n == 6)
            {
                m = 6;
            }
            else if (m == 7 && n == 3 || m == 3 && n == 7)
            {
                m = 1;
            }
            else if (m == 7 && n == 4 || m == 4 && n == 7)
            {
                m = 2;
            }
            else if (m == 7 && n == 5 || m == 5 && n == 7)
            {
                m = 3;
            }
            else if (m == 7 && n == 7 || m == 7 && n == 7)
            {
                m = 5;
            }
            else if (m == 7 && n == 8 || m == 8 && n == 7)
            {
                m = 6;
            }
            else if (m == 7 && n >= 9 || m >= 9 && n == 7)
            {
                m = 7;
            }
            else if (m == 8 && n == 2 || m == 2 && n == 8)
            {
                m = 1;
            }
            else if (m == 8 && n == 3 || m == 3 && n == 8)
            {
                m = 2;
            }
            else if (m == 8 && n == 4 || m == 4 && n == 8)
            {
                m = 3;
            }
            else if (m == 8 && n == 5 || m == 5 && n == 8)
            {
                m = 4;
            }

            else if (m == 8 && n >= 9 || m >= 9 && n == 8)
            {
                m = 8;
            }
            else if (m == 9 && n == 1 || m == 1 && n == 9)
            {
                m = 1;
            }
            else if (m == 9 && n == 2 || m == 2 && n == 9)
            {
                m = 2;
            }
            else if (m == 9 && n == 3 || m == 3 && n == 9)
            {
                m = 3;
            }
            else if (m == 9 && n == 4 || m == 4 && n == 9)
            {
                m = 4;
            }
            else if (m == 9 && n == 9 || m == 9 && n == 9)
            {
                m = 9;
            }
            else if (m == 1 && n >= 9 || m >= 9 && n == 1)
            {
                m = 1;
            }
            else if (m == 2 && n >= 9 || m >= 9 && n == 2)
            {
                m = 2;
            }
            else if (m == 3 && n >= 9 || m >= 9 && n == 3)
            {
                m = 3;
            }
            else if (m == 4 && n >= 9 || m >= 9 && n == 4)
            {
                m = 4;
            }
            else
            {
                m = 0;
            }
           
            
            string text1 = "There are  ";
            string text2 = " ways to get the sum 10.";
            
           
            string grandTotal = text1 + m + text2;

            return grandTotal;
        }

        
        
    }
}