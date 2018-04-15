using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace QAData.Models
{
    public class Checkouts
    {
      public int Id {get; set;}
      
    [Required]
    public QAAsset Asset {get; set;}
    public QACard QACard {get; set;}
    public DateTime LastUpdated {get; set;}
    public DateTime RecentUse {get; set;}
    }
}
