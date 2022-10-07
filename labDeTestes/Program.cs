using labDeTestes.Entities;
using labDeTestes.Entities.Enums;

string? sourcepath = @"C:\Users\felli\Documents\minhasfita\testecsfile";

Console.WriteLine("Enter Client data");

Console.Write("Name: ");
string? clientname = Console.ReadLine();

Console.Write("Email: ");
string? clientemail = Console.ReadLine();

Client client = new Client(clientname, clientemail);




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

Order order = new Order(DateTime.Now, client);

order.Items.Add(orderitem);

Console.WriteLine(order);




try
{
    string? targetFolderPath = sourcepath + $@"\{client.Name.ToLower().Trim()}";
    Directory.CreateDirectory(targetFolderPath);
    string? targetFilePath = targetFolderPath + @"\Purchase_History";
    using (StreamWriter sw = new StreamWriter(targetFilePath))
    {
        sw.WriteLine(order);
    }


}
catch (IOException io)
{
    Console.WriteLine(io.Message);
}
finally
{

}