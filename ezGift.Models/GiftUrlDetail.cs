using ezGift.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezGift.Models
{
    public class GiftUrlDetail
    {
        [Display(Name ="Gift URL ID")]
        public int GiftUrlId { get; set; }

        [Display(Name ="Gift ID")]
        public int GiftId { get; set; }

        [Display(Name ="Gift URL")]
        public string GiftUrl { get; set; }

        [Display(Name ="Gift Name")]
        public string GiftName { get; set; }

    }
}
