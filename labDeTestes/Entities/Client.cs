using labDeTestes.Entities;
using System.Text;


namespace labDeTestes.Entities
{
    class Client
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public Client() { }

        public Client(string? name, string? email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name
                + " - "
                + Email;
        }
    }
        
}
