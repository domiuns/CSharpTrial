//让我们用一个生活中的实际例子来说明 IObservable 和 IObserver 的使用：
//假设你是一个咖啡店的顾客，你想要在咖啡准备好的时候得到通知。
//在这个场景中，咖啡店可以被视为一个被观察对象（IObservable），而你则是一个观察者（IObserver）。

//场景设定
//咖啡店（被观察对象）：负责制作咖啡，并在咖啡准备好时通知所有等待的顾客。
//顾客（观察者）：希望在咖啡准备好时得到通知。

using ObserverTrial;

CoffeeShop coffeeShop = new CoffeeShop();
Customer customer = new Customer();

// 顾客订阅咖啡店的通知
using (coffeeShop.Subscribe(customer))
{
    // 假设咖啡店制作了一杯美式咖啡并通知顾客
    coffeeShop.CoffeeReady("Americano");

    // 顾客完成服务，取消订阅
    customer.OnCompleted();
}