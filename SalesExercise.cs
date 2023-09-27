// See https://aka.ms/new-console-template for more information
Console.WriteLine("The sale is on!");

Sale sale1 = new Sale();
    sale1.Item = "Guitar"; sale1.Customer = "Avi"; sale1.PricePerItem = 100; 
    sale1.Quantity = 6; sale1.Address = "Lander's"; sale1.ExpeditedShipping = true;
Sale sale2 = new Sale();
    sale2.Item = "Piano"; sale2.Customer = "Chaim"; sale2.PricePerItem = 150; 
    sale2.Quantity = 2; sale2.Address = "Home"; sale2.ExpeditedShipping = false;

Sale[] sales = new Sale[2];
sales[0] = sale1;
sales[1] = sale2;

var over10List = from sale in sales
                 where sale.PricePerItem > 10
                 select sale;
var quantity1 = from sale in sales
                where sale.Quantity == 1
                orderby sale.PricePerItem descending
                select sale;
var tea = from sale in sales
                where sale.Item == "Tea" 
                && sale.ExpeditedShipping == false  
                select sale;
var addresses =  from sale in sales
                 where sale.PricePerItem * sale.Quantity > 100
                 select sale.Address;
var anonymous = from sale in sales
                where sale.Customer.ToUpper().Contains("LLC")
                select new
                {
                    TotalPrice = sale.PricePerItem * sale.Quantity,
                    Shipping = sale.ExpeditedShipping ? sale.Address + " EXPIDITE!" : sale.Address,
                };