using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
     class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Client)) {
                throw new ArgumentException("Not equals obj");
            }
            Client other = obj as Client;
           return Email.Equals(other.Email);// true email e outro email são iguals
        }
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
