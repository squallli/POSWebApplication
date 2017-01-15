using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Models
{
    public class User
    {
        [Key]
        public string username { set; get; }
        public string password { set; get; }
    }
}
