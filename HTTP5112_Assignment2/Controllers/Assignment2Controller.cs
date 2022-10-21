using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Http;

namespace HTTP5112_Assignment2.Controllers
{
    public class Assignment2Controller : ApiController
    {

        /// <summary>
        /// Determines if you entered the special date which is 2/18
        /// </summary>
        /// <param name="months"></param>
        /// <param name="days"></param>
        /// <returns>The date that you entered would return a string which indicate if you typed before or after the intended date. </returns>
        /// <example>
        /// GET: api/5/10 --> "After"
        /// GET: api/1/23 --> "Before"
        /// GET: api/2/18 --> "Special"
        /// </example>
        [Route("api/{months}/{days}")]
        [HttpGet]

        public string SpecialDays(int months, int days)
        {
            if (months > 2)
            {
                return "After";
            }
            else if (months < 2)
            {
                return "Before";
            }
            else if (days > 18)
            {
                return "After";
            }
            else if (days < 18)
            {
                return "Before";
            }
            else
            {
                return "Special";
            }
        }



        /// <summary>
        /// Determines user emotions
        /// </summary>
        /// <param name="Happy"></param>
        /// <param name="Sad"></param>
        /// <returns> Returns a emoticon depending on user input</returns>
        /// <example>
        /// GET: api/emotions/:-) --> "Happy"
        /// GET: api/emotions/:-( --> "Sad"
        /// GET: api/emotions/:-)/:-( --> "None"
        /// </example>

        [Route("api/emotions/{Happy}/{Sad}")]
        [HttpGet]
        public string YourEmotion(string Happy, string Sad)
        {
            Happy = "1";
            Sad = "2";

            if (string.Compare(Happy, Sad) == 0)
            {
                return "None";
            }

            else if (string.Compare(Happy, Sad) < 0)
            {
                return "Happy";
            }
            else if (string.Compare(Happy, Sad) > 0)
            {
                return "Sad";
            }
            else
            {
                return "None";
            }




        }

        /*
        [HttpGet]
        [Route("api/loop/whileloop")]
        public string Whileloop()
        {
            string message = "" + "steps";
            int Starts = 0;
            string delimiter = ",";
            int limit = 40;
            int Moves = 1;

            while (Starts <= limit)

            {
                if (Starts == limit)
                {

                    delimiter = "";
                }
                message = message + Starts + delimiter;

                Starts = Starts + Moves;
            }
            return message;
        } 
                I was trying to create a whileloop to give the userinput the words and makeit calculate the movemements that
                was needed in order to create said word, but I couldn't find out how to incorparate it together as it C# is 
                something that is brand new to me. I think i was on the right track for the question I just don't know where I 
                lost it.
         
         */
    } 
}
