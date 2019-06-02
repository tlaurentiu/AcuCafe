using AcuCafe.Ingredients;

namespace AcuCafe
{
    public class Topping
    {
        public ToppingType Type { get; set; }
        public int Quantity { get; set; }

        public Topping(int quantity, ToppingType type) {
            this.Quantity = quantity;
            this.Type = type;
        }
    }
}
