﻿using blashop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blashop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
     
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Category>().HasData(
                
                new Category { Id = 1, Name = "Salads", Url = "salads", Icon = "salad" },
                new Category { Id = 2, Name = "Seafood", Url = "seafood", Icon = "shrimp" },
                new Category { Id = 3, Name = "Fish", Url = "fish", Icon = "fish" }
            
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Paleo Salmon Bowl",
                    Description = "Battered Fish & Breaded Calamari, both breaded in-house and quick-fried.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/1C8A0579_x250.jpg?v=1589925654",
                    Price = 35m,
                    OriginalPrice = 50m,
                    DiscontScore = 0
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Keto Shrimp Salad",
                    Description = "Seasoned shrimp, mixed greens, fresh mint, red onion, tomato & green goddess dressing.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/1C8A0742_x250.jpg?v=1589925879",
                    Price = 40m,
                    OriginalPrice = 40m,
                    DiscontScore = 0
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Dynamite Tofu Bowl",
                    Description = "Quick-fried tofu, white rice, dynamite sauce, cilantro, daikon sprouts, green onion, tomato, cabbage, sesame soy sauce.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/1C8A0647_x250.jpg?v=1589925782",
                    Price = 35m,
                    OriginalPrice = 35m,
                    DiscontScore = 0
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Breaded Shrimp",
                    Description = "Hand-breaded juicy shrimp paired with crispy battered fish, some days you have to indulge.  We don't judge.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/1C8A9573_x250.jpg?v=1578520499",
                    Price = 50m,
                    OriginalPrice = 50m,
                    DiscontScore = 1
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Shrimp & Battered Fish",
                    Description = "Battered Fish & Breaded Calamari, both breaded in-house and quick-fried.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/Battered_Fish_and_Shrimp_copy_x250.jpg?v=1578529826",
                    Price = 40m,
                    OriginalPrice = 40m,
                    DiscontScore = 1
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Chicken Breast",
                    Description = "Seasoned shrimp, mixed greens, fresh mint, red onion, tomato & green goddess dressing.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/CFG_MenuPhotos_ChickenBreast_x250.jpg?v=1578521513",
                    Price = 40m,
                    OriginalPrice = 40m,
                    DiscontScore = 1
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Shrimp and Swai Combo",
                    Description = "Quick-fried tofu, white rice, dynamite sauce, cilantro, daikon sprouts, green onion, tomato, cabbage, sesame soy sauce.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/CFG_ShrimpSwai_Menu_1280x853_v1_x250.jpg?v=1582591368",
                    Price = 35m,
                    OriginalPrice = 35m,
                    DiscontScore = 1
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Sea Bass (Branzino)",
                    Description = "Hand-breaded juicy shrimp paired with crispy battered fish, some days you have to indulge.  We don't judge.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/Capture_f40f0135-235d-4c2d-8edc-9d87351e8614_2048xcopy_x250.jpg?v=1619460797",
                    Price = 50m,
                    OriginalPrice = 50m,
                    DiscontScore = 1
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Title = "Louisiana Delta Catfish",
                    Description = "Battered Fish & Breaded Calamari, both breaded in-house and quick-fried.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/Catfish_2019_x250.png?v=1578529300",
                    Price = 40m,
                    OriginalPrice = 40m,
                    DiscontScore = 1
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 3,
                    Title = "Dynamite Shrimp Bowl",
                    Description = "Seasoned shrimp, mixed greens, fresh mint, red onion, tomato & green goddess dressing.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/Dynamite_Shrimp_Bowl_1_1_x250.jpg?v=1582150014",
                    Price = 40m,
                    OriginalPrice = 40m,
                    DiscontScore = 1
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 3,
                    Title = "4 Person Family Meal",
                    Description = "Quick-fried tofu, white rice, dynamite sauce, cilantro, daikon sprouts, green onion, tomato, cabbage, sesame soy sauce.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/FamilyMeal_IMG_2683_2_09ffff95-9dfd-495f-baf7-2514f8678704_x250.jpg?v=1595270179",
                    Price = 35m,
                    OriginalPrice = 35m,
                    DiscontScore = 1
                },
                new Product
                {
                    Id = 12,
                    CategoryId = 2,
                    Title = "Breaded Shrimp Plate",
                    Description = "Hand-breaded juicy shrimp paired with crispy battered fish, some days you have to indulge.  We don't judge.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/IMG_5983_x250.png?v=1578520517",
                    Price = 50m,
                    OriginalPrice = 50m,
                    DiscontScore = 1
                },
                new Product
                {
                    Id = 13,
                    CategoryId = 2,
                    Title = "Calamari & Battered Fish",
                    Description = "Hand-breaded juicy shrimp paired with crispy battered fish, some days you have to indulge.  We don't judge.",
                    Image = "https://cdn.shopify.com/s/files/1/0101/4765/9827/products/battered_fish_and_calamari_copy2_1_x250.jpg?v=1578521387",
                    Price = 50m,
                    OriginalPrice = 50m,
                    DiscontScore = 1
                }
            );

        

            
        }
    }
}