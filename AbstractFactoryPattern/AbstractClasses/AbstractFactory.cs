namespace AbstractFactoryPattern
{
    // Abstract factory class for the concrete factory classes
    public abstract class AbstractFactory
    {
        public abstract Package GetCreatePackageObject();
        public abstract Delivery CreateDeliveryObject();
    }
}