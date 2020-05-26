using System;
using System.Collections.Generic;
using System.Text;

namespace EqualsEGetHashCode
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Client(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Client))
            {
                throw new ArgumentException("Argumento passado é incompatível");
            }

            Client c = obj as Client;

            return Email.Equals(c.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
