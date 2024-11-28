using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTemplate
{
    public class Customer
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Customer(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentNullException(nameof(email));

            Name = name;
            Email = email;
        }
    }

}
