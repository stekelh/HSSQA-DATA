using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;



namespace QAData.Models
{
    public abstract class QAAsset
    {
      public int Id {get; set;}

      [Required]
      public string DbName {get; set;}

      [Required]
      public DateTime CreatedDate {get; set;} /* ?Storeing DateTime when dataset was create */

     [Required]
     public string Status {get; set;}
     
     [Required]
     public string TcId {get; set;}

     public string LocUrl {get; set;}

     public int NumberOfDataSets {get; set;}

     public virtual QAAsset Asset { get; set; }



    }
}
