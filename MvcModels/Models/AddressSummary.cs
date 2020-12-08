using System.Web.Mvc;

namespace MvcModels.Models
{

    //only citywill be included in binding process
    //Bind(Include = "City")]
    public class AddressSummary
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}