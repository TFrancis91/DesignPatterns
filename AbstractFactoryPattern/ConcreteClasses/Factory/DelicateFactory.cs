namespace AbstractFactoryPattern{
    //Delicate factory implementation
    class DelicateFactory : AbstractFactory
    {
        public override Delivery CreateDeliveryObject() => new Courier();

        public override Package GetCreatePackageObject() => new ShockProof();
    }
}