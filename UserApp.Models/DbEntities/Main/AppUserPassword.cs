using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserApp.Models.Main
{
    public partial class AppUser
    {
        [NotMapped]
        public string userPassword { get; set; }
        [NotMapped]
        public string token { get; set; }

    }
}
