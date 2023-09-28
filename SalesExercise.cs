// See https://aka.ms/new-console-template for more information
Console.WriteLine("The sale is on!");

static void PrintAllSales(IEnumerable<Sale> selectedSales)
{
    foreach (Sale s in selectedSales)
        Console.WriteLine(s.Item + "," + s.Customer + "," + s.PricePerItem + "," + s.Quantity + "," + s.ExpeditedShipping);
    Console.WriteLine();
}
static void PrintAllStrings(IEnumerable<string> selectedStrings)
{
    foreach (string s in selectedStrings)
        Console.WriteLine(s);
    Console.WriteLine();
}

// ChatGPT for examples
Sale sale1 = new Sale("Widget A", "John Doe", 10.99, 2, "123 Main St", true);
Sale sale2 = new Sale("Gadget X", "Jane Smith", 19.95, 1, "456 Elm St", false);
Sale sale3 = new Sale("Widget B", "Bob Johnson", 8.49, 5, "789 Oak St", true);
Sale sale4 = new Sale("Tech Gizmo", "Alice Brown", 49.99, 3, "101 Pine St", false);
Sale sale5 = new Sale("Toy Robot", "David Lee", 29.99, 4, "202 Cedar St", true);
Sale sale6 = new Sale("Book: Mystery", "Eva Davis", 14.99, 1, "303 Birch St", false);
Sale sale7 = new Sale("Apparel: T-shirt", "Michael Wilson", 9.95, 2, "404 Maple St", true);
Sale sale8 = new Sale("Electronics: Smartphone", "Sophia White", 599.99, 1, "505 Redwood St", false);
Sale sale9 = new Sale("Home Decor: Lamp", "Olivia Harris", 34.99, 2, "606 Walnut St", true);
Sale sale10 = new Sale("Groceries: Milk", "Liam Taylor", 2.49, 3, "707 Cedar St", false);
Sale sale11 = new Sale("Furniture: Sofa", "Ava Martinez", 499.95, 1, "808 Oak St", true);
Sale sale12 = new Sale("Beauty: Perfume", "William Anderson", 79.99, 1, "909 Elm St", false);
Sale sale13 = new Sale("Sports: Tennis Racket", "Isabella Adams", 69.99, 1, "1010 Birch St", true);
Sale sale14 = new Sale("Tools: Power Drill", "Mia Hernandez", 79.95, 1, "1111 Pine St", false);
Sale sale15 = new Sale("Toys: Board Game", "Ethan Hall", 24.99, 2, "1212 Redwood St", true);
Sale sale16 = new Sale("Kitchen: Blender", "Sofia Miller", 39.95, 1, "1313 Cedar St", false);
Sale sale17 = new Sale("Clothing: Jeans", "Jackson Young", 29.99, 3, "1414 Walnut St", true);
Sale sale18 = new Sale("Electronics: Headphones", "Avery Turner", 59.99, 1, "1515 Elm St", false);
Sale sale19 = new Sale("Tea", "Scarlett LLC Moore", 12.95, 5, "1616 Oak St", true);
Sale sale20 = new Sale("Tea", "James llc Scott", 8.99, 4, "1717 Maple St", false);


Sale[] sales = {sale1, sale2, sale3, sale4, sale5, sale6, sale7, sale8, sale9, sale10,
                sale11, sale12, sale13, sale14, sale15, sale16, sale17, sale18, sale19, sale20};

var over10List = from sale in sales
                 where sale.PricePerItem > 10
                 select sale;
PrintAllSales(over10List);

var quantity1 = from sale in sales
                where sale.Quantity == 1
                orderby sale.PricePerItem descending
                select sale;
PrintAllSales(quantity1); 

var tea = from sale in sales
                where sale.Item == "Tea" 
                && sale.ExpeditedShipping == false  
                select sale;
PrintAllSales(tea);

var addresses =  from sale in sales
                 where sale.PricePerItem * sale.Quantity > 100
                 select sale.Address;
PrintAllStrings(addresses);

var anonymous = from sale in sales
                where sale.Customer.ToUpper().Contains("LLC")
                select new
                {
                    TotalPrice = sale.PricePerItem * sale.Quantity,
                    Shipping = sale.ExpeditedShipping ? sale.Address + " EXPIDITE!" : sale.Address,
                };
foreach (var address in anonymous)
    Console.WriteLine(address);
