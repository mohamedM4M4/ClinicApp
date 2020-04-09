using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Model
{
   public class Persone
    {
        [Key]
        public string UserName { get; set; }
        [DataType(DataType.Password)]

        public string PassWord { get; set; }

    }
}
