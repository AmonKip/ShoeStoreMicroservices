using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogApi.Data
{
    public class CatalogSeed
    {
        public static async Task SeedAsync(CatalogContext context)
        {
            context.Database.Migrate();
            if(!context.CatalogBrands.Any())
            {
                context.CatalogBrands.AddRange(GetPreConfiguredCatalogBrands());
                await context.SaveChangesAsync();
            }

            if (!context.CatalogTypes.Any())
            {
                context.CatalogTypes.AddRange(GetPreConfiguredCatalogTypes());
                await context.SaveChangesAsync();
            }

            if (!context.CatalogItems.Any())
            {
                context.CatalogItems.AddRange(GetPreconfiguredCatalogItems());
               await context.SaveChangesAsync();
            }
        }
        static IEnumerable<CatalogBrand> GetPreConfiguredCatalogBrands()
        {
            return new List<CatalogBrand>()
            {
                new CatalogBrand() {Brand = "Adidas"},
                new CatalogBrand() {Brand = "Puma"},
                new CatalogBrand() {Brand = "Nike"}
            };
        }

        static IEnumerable<CatalogType> GetPreConfiguredCatalogTypes()
        {
            return new List<CatalogType>()
            {
                new CatalogType() {Type = "Running"},
                new CatalogType() {Type = "Basketball"},
                new CatalogType() {Type = "Tennis"}
            };
        }

        static IEnumerable<CatalogItem> GetPreconfiguredCatalogItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=3, Description = "Shoes for next century", Name = "World Star", Price = 199.5M, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/1" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=2, Description = "will make you world champions", Name = "White Line", Price= 88.50M, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/2" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=3, Description = "You have already won gold medal", Name = "Prism White Shoes", Price = 129, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/3" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=2, Description = "Olympic runner", Name = "Foundation Hitech", Price = 12, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/4" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=1, Description = "Roslyn Red Sheet", Name = "Roslyn White", Price = 188.5M, ImageUrl = "http://externalcatalogbaseurltobereplaced/image/5" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=2, Description = "Lala Land", Name = "Blue Star", Price = 112, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/6" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=1, Description = "High in the sky", Name = "Roslyn Green", Price = 212, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/7"  },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Light as carbon", Name = "Deep Purple", Price = 238.5M, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/8" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=2, Description = "High Jumper", Name = "Addidas<White> Running", Price = 129, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/9" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=3, Description = "Dunker", Name = "Elequent", Price = 12, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/10" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=2, Description = "All round", Name = "Inredeible", Price = 248.5M, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/11" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=1, Description = "Pricesless", Name = "London Sky", Price = 412, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/12" },
                new CatalogItem() { CatalogTypeId=3,CatalogBrandId=3, Description = "Tennis Star", Name = "Elequent", Price = 123, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/13" },
                new CatalogItem() { CatalogTypeId=3,CatalogBrandId=2, Description = "Wimbeldon", Name = "London Star", Price = 218.5M, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/14" },
                new CatalogItem() { CatalogTypeId=3,CatalogBrandId=1, Description = "Rolan Garros", Name = "Paris Blues", Price = 312, ImageUrl = "http://externalcatalogbaseurltobereplaced/api/image/15" }

            };
        }
    }
}
