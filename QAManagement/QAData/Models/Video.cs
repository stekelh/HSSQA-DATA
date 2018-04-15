using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace QAData.Models
{
    public class Video : QAAsset
    {
        [Required]
        public string Director {get; set;}
    }
}
