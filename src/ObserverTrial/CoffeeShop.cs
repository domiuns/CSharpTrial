namespace ObserverTrial
{
    internal class CoffeeShop : IObservable<string>
    {
        private List<IObserver<string>> customers= new List<IObserver<string>>();

        public IDisposable Subscribe(IObserver<string> customer)
        {
            customers.Add(customer);

            return new Unsubscriber(customers, customer);
        }

        public void CoffeeReady(string coffeeType)
        {
            foreach (var customer in customers) 
            {
                customer.OnNext(coffeeType);
            }
        }

        private class Unsubscriber : IDisposable 
        { 
            private List<IObserver<string>> _customers;

            private IObserver<string> _customer;

            public Unsubscriber(List<IObserver<string>> customers,IObserver<string> customer)
            {
                _customers = customers;
                _customer = customer;
            }

            public void Dispose()
            {
                Console.WriteLine("Dispose");
                _customers.Remove(_customer);
            }
        }
    }
}
