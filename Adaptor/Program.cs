//using Adaptor;
using ClassAdaptor;

Console.Title = "Adaptor";

ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.FullName}, {city.Inhabitants}");
