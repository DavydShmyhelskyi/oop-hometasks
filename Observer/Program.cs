using Observer;

Brand lenovo = new Brand("Lenovo");
Brand msi = new Brand("MSI");
Brand asus = new Brand("ASUS");

Shop rozetka = new Shop("Rozetka");
Shop prom = new Shop("Prom");
Shop foxtrot = new Shop("Foxtrot");

lenovo.Subscribe(rozetka);
lenovo.Subscribe(prom);

msi.Subscribe(rozetka);
msi.Subscribe(foxtrot);

asus.Subscribe(foxtrot);

lenovo.ReleaseProduct("Super laptop LENOVO");
Console.WriteLine();
msi.ReleaseProduct("Super laptop MSI");
Console.WriteLine();
asus.ReleaseProduct("Super laptop ASUS");

Console.WriteLine();
Console.WriteLine("// msi.Unsubscribe(foxtrot);");

msi.Unsubscribe(foxtrot);
msi.ReleaseProduct("New laptop MSI");
