using labDeTestes.Entities;
using labDeTestes.Entities.Enums;

Console.WriteLine("Enter Client data");

Console.Write("Name: ");
string? clientname = Console.ReadLine();

Console.Write("Email: ");
string? clientemail = Console.ReadLine();

Client client = new Client(clientname, clientemail);

char continuar = 'y';
while (continuar == 'y')
{
    Console.WriteLine("Enter Product");

    Console.Write("Name: ");
    string? prodname = Console.ReadLine();

    Console.Write("Price: ");
    double prodprice = Convert.ToDouble(Console.ReadLine());

    Console.Write("Category: ");
    string? prodcategory = Console.ReadLine();

    Product product = new Product(prodname, Enum.Parse<Category>(prodcategory), prodprice);

    Console.Write("Quantity: ");
    int orditemquant = Convert.ToInt32(Console.ReadLine());

    OrderItem orderitem = new OrderItem(orditemquant, product);

    Order order = new Order(DateTime.Now);

    order.Items.Add(orderitem);

    continuar = Convert.ToChar(Console.ReadLine());
}
