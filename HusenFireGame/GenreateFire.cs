using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusenFireGame
{
   public class GenreateFire
    {
        // random class object used to generate random no.
        Random rd = new Random();
        //method to generate a random no and return 
        public int fire() {
            return rd.Next(3, 5);
        }

    }
}
