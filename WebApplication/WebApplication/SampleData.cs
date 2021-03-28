using System.Linq;
using WebApplication.Models;


namespace WebApplication.Controllers
{
    public class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.Flowers.Any())
            {
                context.Flowers.AddRange(
                    new Flower
                    {
                        Name = "Rose",
                        Price = 5
                    },
                    new Flower
                    {
                        Name = "Tulip",
                        Price = 3
                    },
                    new Flower
                    {
                        Name = "Narcissus",
                        Price = 4
                    }
                );
                context.SaveChanges();
            }
        }
    }
}