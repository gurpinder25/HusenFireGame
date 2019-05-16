using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusenFireGame
{
   public  class Image
    {
        
        //string method to return loading the image using string return method
        public String loadImage() {
            return "pic /3rd.jpg";
        }
        
        //generate the shot image to fire
        public String Shot() {
            return "pic/shot.jpg";
        }

        public String plyAgain() {
            return "pic/empty.jpg";
        }

        //generate the spinning image
        public String spinImage() {
            return "pic/8th.jpg";
        }
    }
}
