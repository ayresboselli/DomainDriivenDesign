using Domain;
using Infra.Data;

namespace Application
{
    public class ItemService
    {
        public static List<Item> List()
        {
            return ItemRepository.Items();
        }
    }
}
