namespace AbstractFactoryPattern{
    //Standard factory implementation
    class StandardFactory : AbstractFactory
    {
        public override Delivery CreateDeliveryObject() => new Post();

        public override Package GetCreatePackageObject() => new Standard();
    }
}