using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2n01572360.Controllers
{

    public class J1Controller : ApiController
    {
        /// <summary>
        /// When we choose each item from the different menu items it will calculate our total calories. 
        /// </summary>
        /// <param name="burger">4</param>
        /// <param name="drink">4</param>
        /// <param name="side">4</param>
        /// <param name="dessert">4</param>
        /// <returns>Your total calorie count is 0.</returns>
        /// GET: /api/J1/Menu/1/2/3/4  => Your total calorie count is 691.
        
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
             
            if (burger == 1)
            {
                burger = 461;
                
            }else if(burger == 2)
            {
                burger = 431;               

            }
            else if (burger == 3)
            {
                burger = 420;
            }
            else if (burger == 4)
            {
                burger = 0;
            }
            else
            {
                burger = 0;
            }
            // Burger if condition is done.

            if (drink == 1)
            {
                drink = 130;

            }
            else if (drink == 2)
            {
                drink = 160;

            }
            else if (drink == 3)
            {
                drink = 118;
            }
            else if (drink == 4)
            {
                drink = 0;
            }
            else
            {
                drink = 0;
            }
            // Drink if condition is done.
            if (side == 1)
            {
                side = 100;

            }
            else if (side == 2)
            {
                side = 57;

            }
            else if (side == 3)
            {
                side = 70;
            }
            else if (side == 4)
            {
                side = 0;
            }
            else
            {
                side = 0;
            }
            // Side if condition is done.
            if (dessert == 1)
            {
                dessert = 167;

            }
            else if (dessert == 2)
            {
                dessert = 266;

            }
            else if (dessert == 3)
            {
                dessert = 75;
            }
            else if (dessert == 4)
            {
                dessert = 0;
            }
            else
            {
                dessert = 0;
            }
            // Dessert if condition is done.

            string text = "Your total calorie count is ";
            int total= burger + drink + side + dessert;


            string grandTotal = text + total;


            return grandTotal;


        }


    }
}


 