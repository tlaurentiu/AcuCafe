namespace AcuCafe
{
    public interface IWater
    {
        bool Hot(int quantity);
        bool Cold(int quantity);
        bool Ice(int quantity);
    }
}
