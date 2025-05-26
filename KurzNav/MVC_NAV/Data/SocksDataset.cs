using MVC_NAV.Models;

namespace MVC_NAV.Data
{
    public class SocksDataset
    {
        static string[] brands = { "icebreaker", "Nike", "Adidas", "Puma", "Reebok", "Under Armour" };

        public static IEnumerable<Socks> GetSocks()
        {
            return Enumerable.Range(1, 10).Select(index =>
                new Socks()
                {
                    Id = index,
                    Brand = brands[Random.Shared.Next(brands.Length)],
                    Size = (SocksSize)Random.Shared.Next(Enum.GetValues(typeof(SocksSize)).Length),
                    Price = (decimal)Math.Round(Random.Shared.Next(50, 500) / 10.0, 2), // Fixed rounding logic
                    OnStock = Random.Shared.Next(0, 20) // Ensure 'OnStock' exists in the 'Socks' class
                }
            );
        }
    }
}


