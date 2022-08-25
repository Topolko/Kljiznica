using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    class LUser
    {
        static int ID;
        static string Uname;
        public static string uname
        {
            get
            {
                return Uname;
            }
            set
            {
                Uname = value;
            }

        }
        public static int id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
    }
}
