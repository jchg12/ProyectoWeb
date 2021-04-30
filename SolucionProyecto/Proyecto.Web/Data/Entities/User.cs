using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Web.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }

        [Required,EmailAddress]
        public string Address { get; set; }

        [Required ,Phone]
        public string Phone { get; set; }

        public string NickName { get; set; }

        [Required,MinLength(8)]
        public string Password { get; set; }
        [Required]
        public bool StatusLog { get; set; }

    }


}
