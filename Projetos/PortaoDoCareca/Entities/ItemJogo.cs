using PortaoDoCareca.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortaoDoCareca.Entities
{
    abstract class ItemJogo
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        
        public Raridade RaridadeItem { get; private set; }

        public ItemJogo(int id, string name, Raridade raridadeItem)
        {
            Id = id;
            Name = name;
            RaridadeItem = raridadeItem;
        }

        public abstract void UsarItem();
    }
}
