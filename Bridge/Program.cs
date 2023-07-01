using Bridge;

Console.Title = "Bridge";

var noCoupon = new NoCoupon();
var oneEuroCoupon = new OneEuroCoupon();

var meatMenu = new MeatMenu(noCoupon);
Console.WriteLine($"Meat based menu, no coupon : {meatMenu.CalculatePrice()} euro");

meatMenu = new MeatMenu(oneEuroCoupon);
Console.WriteLine($"Meat based menu, one euro coupon : {meatMenu.CalculatePrice()} euro");

var vegMenu = new VegeterianMenu(noCoupon);
Console.WriteLine($"Veg based menu, no coupon : {vegMenu.CalculatePrice()} euro");

vegMenu = new VegeterianMenu(oneEuroCoupon);
Console.WriteLine($"Veg based menu, no coupon : {vegMenu.CalculatePrice()} euro");

Console.ReadLine();