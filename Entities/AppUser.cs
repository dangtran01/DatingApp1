using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.Entities
{
    public class AppUser
    {
        public int Id {set; get;}
        public required string UserName { set; get; }
    }
}