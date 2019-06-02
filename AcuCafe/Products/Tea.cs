using System;

namespace AcuCafe
{
     public class Tea
    {
        public int Milk { get; set; }
        public int Water { get; set; }
        public int Ice { get; set; }
        public TeaType Type { get; set; }
        public int Time { get; set; }

        public decimal Price { get; set; }


        public Tea(int milk, int water, int ice, TeaType type)
        {
            this.Milk = milk;
            this.Water = water;
            this.Ice = ice;
            this.Type = type;

            this.Time = (milk + water + ice) / 3;
        }
    }
}
