using System;
using System.Xml.Schema;

namespace Cqrs.Hotel.Domain.Model
{
    public class Cliente : AggregateRoot
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Cliente(string name, string lastName)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
    }
}
