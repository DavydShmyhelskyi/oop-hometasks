
var support = new CustomerSupportFacade(
    new OrderSystem(),
    new PaymentSystem(),
    new DeliveryService()
);

support.MakeOrder(
    productName: "Навушники",
    price: 1500m,
    cardNumber: "1234567812345678",
    address: "м. Львів, вул. Зелена, 15"
);
