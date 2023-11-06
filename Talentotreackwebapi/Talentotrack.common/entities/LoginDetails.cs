using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talentotrack.common.entities
{
    public class LoginDetails
    {
        public int Id { get; set; }
        public int userid { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public bool isblocked { get; set; }

        [ForeignKey("userid")]
        public User?  user { get; set; }
    }
}
