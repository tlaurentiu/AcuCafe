namespace AcuCafe
{
    public class Coffee
    {
        public int Milk { get; set; }
        public int Quantity { get; set; }
        public int Water { get; set; }
        public int Topping { get; set; }
        public int Ice { get; set; }
        public int Time { get; set; }

        public decimal Price { get; set; }

        public Coffee(int milk, int water, int topping, int coffee, int ice)
        {
            this.Milk = milk;
            this.Water = water;
            this.Topping = topping;
            this.Quantity = coffee;
            this.Ice = ice;

            this.Time = (milk + water + topping + coffee + ice) / 5;
        }
    }
}
