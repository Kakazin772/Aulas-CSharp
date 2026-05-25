using System;
using System.Collections.Generic;
using System.Text;

namespace PortaoDoCareca.Entities
{
    abstract class ItemJogo
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public ItemJogo(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void UsarItem();
    }
}
