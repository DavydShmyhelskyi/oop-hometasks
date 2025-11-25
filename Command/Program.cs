using Command;

var chef = new Chef();
var waiter = new Waiter();

waiter.TakeOrder(new PizzaOrder(chef));
waiter.SendToKitchen();


waiter.TakeOrder(new PastaOrder(chef));
waiter.SendToKitchen();
