namespace RazorBasePizzaWebsite.Models
{
    public class PizzasModel
    {
        public string? ImageTittle { get; set; }
        public string? PizzaName { get; set; }
        public float BasePrice { get; set; }  = 2;

        public bool TomatoSouse { get; set; }
        public bool Cheese { get; set; }
        public bool Ham { get; set; }
        public bool Mushroom { get; set; }
        public bool Pineapple { get; set; }
        public bool Beef { get; set; }
        public bool Peperoni { get; set; }
        public float FinalPrice { get; set; }


    }
}
