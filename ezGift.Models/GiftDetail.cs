using ezGift.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ezGift.Models
{
    public class GiftDetail
    {
        [Display(Name = "Gift ID")]
        public int GiftId { get; set; }

        [Display(Name = "Event ID")]
        public int RegistryEventId { get; set; }

        [Display(Name = "Event")]
        public virtual RegistryEvent RegistryEvent { get; set; }

        [Display(Name = "Gift Name")]
        public string GiftName { get; set; }

        [Display(Name = "Gift Description")]
        public string GiftDescription { get; set; }

    }

    public static class HtmlHelper
    {

        // per https://www.codeproject.com/Questions/864248/How-can-I-add-links-to-external-web-sites-in-mvc
        // Trying to create a method I can call with a URL and a Title for the URL and have that URL called
        public static string ExternalLink( HtmlHelper<GiftDetail> helper, string url, string text)
        {
            //return String.Format("<a href='http://{0}' target="_blank">{1}</a>", url, text);
            return String.Format("<a href='http://{0}' target=_blank>{1}</a>", url, text);
        }
    }


}
