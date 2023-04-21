using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBasePizzaWebsite.Models;

namespace RazorBasePizzaWebsite.Pages.Forms
{
    public class CustompizzaModel : PageModel
    {


        [BindProperty]  // This is the property that will be binded to the form
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public RedirectToPageResult OnGet()
        {

            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSouse) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.Beef) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;


            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });


        }
    }
}
