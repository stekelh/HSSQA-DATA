using System.ComponentModel.DataAnnotations;

using System;

namespace QAData.Models
{
    public class DataSets : QAAsset
    
     {
       
        [Required]
        public string QATCI { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string DataLoc { get; set; }


    }
    }

