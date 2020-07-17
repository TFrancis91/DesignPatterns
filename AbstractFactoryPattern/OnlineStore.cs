namespace AbstractFactoryPattern{
    class OnlineStore{
        Package _package;
        Delivery _delivery;
        public OnlineStore(AbstractFactory abstractFactory){
            _package=abstractFactory.GetCreatePackageObject();
            _delivery=abstractFactory.CreateDeliveryObject();            
        }
    }
}