using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QAData.Models
{
    public class Status
    {
        public int Id {get; set;}

        [Required]
        public string Name {get; set;}
        [Required]
        public string Description {get; set;}
    }
}
