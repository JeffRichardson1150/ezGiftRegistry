using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezGift.Data
{
    public class GiftRetailerUrl
    {
        [Key]
        public int GiftUrlId { get; set; }
        public string GiftUrl { get; set; }
        public int GiftId { get; set; }

        [ForeignKey(nameof(GiftId))]
        public virtual Gift Gift { get; set; }

    }
}
