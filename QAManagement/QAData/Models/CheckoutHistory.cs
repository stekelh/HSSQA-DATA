using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace QAData.Models
{
    public class CheckoutHistory
    {
        public int Id { get; set; }

        [Required]
        public QAAsset Asset { get; set; }
        [Required]
        public QACard QACard { get; set; }
        [Required]
        public DateTime NoUse { get; set; }
        public DateTime? InUse { get; set; }
    }

 }

