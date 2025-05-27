using MVC_NAV.Models;
using System.Drawing;

namespace MVC_NAV.Data
{
    public class SocksDataset
    {
        static string[] brands = { "icebreaker", "Nike", "Adidas", "Puma", "Reebok", "Under Armour" };

        public static List<Socks> data = null;

        public static IEnumerable<Socks> GetSocks()
        {
            if (data == null)
            {
                Console.WriteLine("Generating new data set ...");

                data = Enumerable.Range(1, 10).Select(index =>
                    new Socks()
                    {
                        Id = index,
                        Brand = brands[Random.Shared.Next(brands.Length)],
                        Size = (SocksSize)Random.Shared.Next(4),
                        Price = Random.Shared.Next(50, 500),
                        OnStock = Random.Shared.Next(0, 20)
                    }).ToList();
            }
            return data;
        }
    }
}


