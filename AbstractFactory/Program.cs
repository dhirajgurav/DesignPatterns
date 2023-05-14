using AbstractFactory;

Console.Title = "Abstract Factory";

var belgiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
var shoppingCartForBelgium = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
shoppingCartForBelgium.CalculateCosts();

var fraceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var shoppingCartForFrance = new ShoppingCart(fraceShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCosts();

Console.ReadKey();
