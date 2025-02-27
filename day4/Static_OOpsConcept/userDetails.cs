using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_OOpsConcept
{
    internal class userDetails {
       
        static int userCount = 0;
        
        public userDetails()
        {
            userCount++;
        }

        public static void returnUserLoginCount()
        {
            Console.WriteLine("Total user login count is : "+userCount);
        }
    }
}
