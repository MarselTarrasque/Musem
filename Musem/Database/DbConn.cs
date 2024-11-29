using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musem.Database
{
    internal class DbConn
    {
        public static МузейEntities6 DbConnect = new МузейEntities6();
        public static User User;
        public static Authors Author;
        public static Types Types;
        public static Conditions Conditions;
    }
}
