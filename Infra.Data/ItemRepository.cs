using Domain;
using System.Reflection.Metadata.Ecma335;

namespace Infra.Data
{
    public class ItemRepository
    {
        public static List<Item> Items()
        {
            var itens = new List<Item>();

            itens.Add(new Item{ Id = 1, Name = "Item 1", CreatedAt = DateTime.Now });
            itens.Add(new Item{ Id = 2, Name = "Item 2", CreatedAt = DateTime.Now });
            itens.Add(new Item{ Id = 3, Name = "Item 3", CreatedAt = DateTime.Now });
            itens.Add(new Item{ Id = 4, Name = "Item 4", CreatedAt = DateTime.Now });

            return itens;
        }
    }
}
