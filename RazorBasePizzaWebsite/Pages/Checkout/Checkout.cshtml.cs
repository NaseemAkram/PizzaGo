using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorBasePizzaWebsite.Pages.Checkout
{
    //[BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {

        //public string PizzaName { get; set; }
        //public int PizzaPrice { get; set; }
        //public string ImageTitle { get; set; }
        public void OnGet()
        {
            //if (string.IsNullOrWhiteSpace(PizzaName))
            //{
            //    PizzaName = "custom";

            //}
            //if (string.IsNullOrWhiteSpace(ImageTitle))
            //{
            //    ImageTitle = "create";
            //}

        }
    }
   
    
}
