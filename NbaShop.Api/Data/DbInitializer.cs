using NbaShop.Api.Entities;

namespace NbaShop.Api.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Los Angeles Lakers LeBron Jersey",
                    Description = "Show your team spirit with this authentic Los Angeles Lakers LeBron James jersey. Made with quality materials, perfect for game days.",
                    Price = 120,
                    PictureUrl = "/images/products/jersey-lakers-lebron.png",
                    Brand = "Nike",
                    Type = "Jerseys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Golden State Warriors Curry T-shirt",
                    Description = "A comfortable Golden State Warriors t-shirt showcasing Stephen Curry's name and number.",
                    Price = 100,
                    PictureUrl = "/images/products/tshirt-warriors-curry.png",
                    Brand = "Nike",
                    Type = "T-Shirts",
                    QuantityInStock = 80
                },
                new Product
                {
                    Name = "Brooklyn Nets Kevin Durant Shoes",
                    Description = "Step into the game with the Brooklyn Nets Kevin Durant signature shoes. Suitable for indoor and outdoor courts.",
                    Price = 200,
                    PictureUrl = "/images/products/shoes-nets-durant.png",
                    Brand = "Jordan",
                    Type = "Shoes",
                    QuantityInStock = 50
                },
                new Product
                {
                    Name = "Official NBA Game Ball",
                    Description = "Experience the feel and quality of the official NBA game ball used by professionals during matches.",
                    Price = 150,
                    PictureUrl = "/images/products/ball-nba-official.png",
                    Brand = "NBA",
                    Type = "Balls",
                    QuantityInStock = 200
                },
                new Product
                {
                    Name = "Chicago Bulls Red Shorts",
                    Description = "Authentic Chicago Bulls red shorts, perfect for playing or as casual wear.",
                    Price = 80,
                    PictureUrl = "/images/products/shorts-bulls-red.png",
                    Brand = "Jordan",
                    Type = "Shorts",
                    QuantityInStock = 70
                },
                new Product
                {
                    Name = "Miami Heat Wade Retro Jersey",
                    Description = "Relive the glorious moments with this retro Miami Heat Dwyane Wade jersey.",
                    Price = 110,
                    PictureUrl = "/images/products/jersey-heat-wade.png",
                    Brand = "Nike",
                    Type = "Jerseys",
                    QuantityInStock = 40
                },
                new Product
                {
                    Name = "Boston Celtics Hat",
                    Description = "A classic Boston Celtics hat suitable for all occasions.",
                    Price = 50,
                    PictureUrl = "/images/products/hat-celtics.png",
                    Brand = "Adidas",
                    Type = "Hats",
                    QuantityInStock = 150
                },
                new Product
                {
                    Name = "Houston Rockets Harden Socks",
                    Description = "Comfortable socks themed after the Houston Rockets star, James Harden.",
                    Price = 30,
                    PictureUrl = "/images/products/socks-rockets-harden.png",
                    Brand = "Adidas",
                    Type = "Socks",
                    QuantityInStock = 200
                },
                new Product
                {
                    Name = "Philadelphia 76ers Embiid T-shirt",
                    Description = "Show your support with this Philadelphia 76ers Joel Embiid t-shirt.",
                    Price = 75,
                    PictureUrl = "/images/products/tshirt-76ers-embiid.png",
                    Brand = "Nike",
                    Type = "T-Shirts",
                    QuantityInStock = 90
                },
                new Product
                {
                    Name = "Phoenix Suns Devin Booker Shoes",
                    Description = "Elevate your game with these Phoenix Suns Devin Booker signature shoes.",
                    Price = 190,
                    PictureUrl = "/images/products/shoes-suns-booker.png",
                    Brand = "Nike",
                    Type = "Shoes",
                    QuantityInStock = 60
                }
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}