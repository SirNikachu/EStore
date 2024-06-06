using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data;

public static class DbInitializer
{
    public static async Task Initialize(StoreContext context, UserManager<User> userManager)
    {
        if (!userManager.Users.Any())
        {
            var user = new User
            {
                UserName = "bob",
                Email = "bob@test.com"
            };

            await userManager.CreateAsync(user, "Pa$$w0rd");
            await userManager.AddToRoleAsync(user, "Member");

            var admin = new User
            {
                UserName = "admin",
                Email = "admin@test.com"
            };

            await userManager.CreateAsync(admin, "Pa$$w0rd");
            await userManager.AddToRolesAsync(admin, new[] { "Admin", "Member" });
        }

        if (context.Products.Any()) return;

        var products = new List<Product>
            {
                new Product
                {
                    Name = "IPhone 15 Pro Max",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/picture1.jpg",
                    Category = "Smartphone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "IPhone 14 Pro Max",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/picture2.jpg",
                    Category = "Smartphone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung Galaxy S24",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/picture3.jpg",
                    Category = "Smartphone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "LG G7 Thinq",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/picture4.jpg",
                    Category = "Smartphone",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Macbook Pro 17",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/picture5.jpg",
                    Category = "Laptop",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Macbook Pro M2",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/picture6.jpg",
                    Category = "Laptop",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Asus Zenbook",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/picture7.jpg",
                    Category = "Laptop",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "HP Victus",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/picture8.jpg",
                    Category = "Laptop",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Coral Shimmer",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/picture9.jpg",
                    Category = "Fish",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Wave Rider",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/picture10.jpg",
                    Category = "Fish",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Sea Sparkle",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/picture11.jpg",
                    Category = "Fish",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Reef Runner",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/picture12.jpg",
                    Category = "Fish",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Carrot Crunch",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/picture13.jpg",
                    Category = "Vegetable",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Spinach Splash",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/picture14.jpg",
                    Category = "Vegetable",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tomato Tango",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/picture15.jpg",
                    Category = "Vegetable",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Broccoli Burst",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "/images/products/picture16.jpg",
                    Category = "Vegetable",
                    QuantityInStock = 100
                }
            };

        foreach (var product in products)
        {
            context.Products.Add(product);
        }

        context.SaveChanges();
    }
}
