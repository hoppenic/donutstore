﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using donutstore.Models;

namespace donutstore
{
    internal static class DbInitializer
    {
        internal static void Initialize(this DonutStoreDbContext db)
        {
            db.Database.Migrate();

            if (db.Products.Count() == 0)
            {
                db.Products.Add(new Product
                {
                    Name = "Sprinkles Donut",
                    Description = "Homer Simpson Style Donut",
                    Image = "/images/donut1.jpeg",
                    Price = 1.99m

                });
                db.Products.Add(new Product
                {
                    Name = "Mix and Match",
                    Description = "Various Donuts",
                    Image = "/images/donut3.jpeg",
                    Price = 2.99m

                });

                db.SaveChanges();
            }

        }


    }
}
