using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmeKhanoom
{
    static class RandomCode
    {
        public static int DeliveryCodeGenerator()
        {
            Random random = new Random();
            return random.Next();
        }
    }
}
