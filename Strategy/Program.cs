var traveler = new Traveler();

traveler.SetStrategy(new BusStrategy());
traveler.Travel();

traveler.SetStrategy(new TaxiStrategy());
traveler.Travel();

traveler.SetStrategy(new BikeStrategy());
traveler.Travel();
