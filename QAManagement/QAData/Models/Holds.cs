using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAData.Models
{
    public class Holds
    {
       public int Id {get; set;}

       public virtual QAAsset Asset {get; set;}
       public virtual QACard QACard {get; set;}
       public DateTime HoldPlaced {get; set;}

    }

}
