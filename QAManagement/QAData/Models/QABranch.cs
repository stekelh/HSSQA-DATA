﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QAData.Models
{
    public class QABranch
    {
        
        public int Id {get; set;}
        [Required]
        [StringLength(30, ErrorMessage= "Limit branch name to 30 Characters.")]
        public string Name {get; set;}
        [Required]
        public string Address {get; set;}

        [Required]
        public string Telephone {get; set;}
        public string Description {get; set;}
        public DateTime OpenDate {get; set;}


    public virtual IEnumerable<Patron> Patrons {get; set;}
    public virtual IEnumerable<QAAsset> QAAssets {get; set;}

    public string  GoogleUrl {get; set;}
    
    }
}
