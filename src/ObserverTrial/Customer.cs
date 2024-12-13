namespace ObserverTrial
{
    internal class Customer : IObserver<string>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Thank you for your visit!");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"Error: {error.Message}");
        }

        public void OnNext(string coffeeType)
        {
            Console.WriteLine($"Your {coffeeType} is ready!");
        }
    }
}
