using ProductServiceApi.DataAccess;
using ProductServiceApi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Extensions.Migration.MigrationSeeds
{
    public class ProductContextSeed
    {
        public static async Task SeedAsync(ProductContext productContext)
        {
            if (productContext.Brands.Count()==0)
            {
                productContext.Brands.AddRange(GetDefaultBrands());
                await productContext.SaveChangesAsync();
            }
            if (productContext.UpCategories.Count() == 0)
            {
                productContext.UpCategories.AddRange(GetDefaultUpCategories());
                await productContext.SaveChangesAsync();
            }

            if (productContext.DownCategories.Count() == 0)
            {
                productContext.DownCategories.AddRange(GetDefaultDownCategories(productContext));
                await productContext.SaveChangesAsync();
            }

            if (productContext.Products.Count() == 0)
            {
                productContext.Products.AddRange(GetDefaultProducts(productContext));
                await productContext.SaveChangesAsync();
            }

            if (productContext.Pictures.Count() == 0)
            {
                productContext.Pictures.AddRange(GetDefaultPictures(productContext));
                await productContext.SaveChangesAsync();
            }

        }

        private static IEnumerable<Picture> GetDefaultPictures(ProductContext productContext)
        {
            IEnumerable<Picture> pictures = new List<Picture>()
            {
                new Picture()
                {
                    //Id=1,
                    ProductId=productContext.Products.FirstOrDefault(p=>p.Name=="Ray-Ban RB 3025 002").Id,
                    Date=DateTime.Now,
                    ImagePath="\\images\\30f274f9-f546-41da-b477-0bdf88f0e45a.png"
                },
                new Picture()
                {
                    //Id=2,
                    ProductId=productContext.Products.FirstOrDefault(p=>p.Name=="SMASH V2").Id,
                    Date=DateTime.Now,
                    ImagePath="\\images\\866758ca-a6b1-4f60-8758-9227e997d1ed.png"
                },                
                new Picture()
                {
                    //Id=3,
                    ProductId=productContext.Products.FirstOrDefault(p=>p.Name=="Versatil Tikky").Id,
                    Date=DateTime.Now,
                    ImagePath="\\images\\e780ebdc-6e03-4b6c-b82f-f113185d6d7c.png"
                },             
                new Picture()
                {
                    //Id=4,
                    ProductId=productContext.Products.FirstOrDefault(p=>p.Name=="Gotik Desenli Kapüşonlu").Id,
                    Date=DateTime.Now,
                    ImagePath="\\images\\af31b584-3a85-464d-a6e6-fa75b7ef4b34.png"
                },
                new Picture()
                {
                    //Id=5,
                    ProductId=productContext.Products.FirstOrDefault(p=>p.Name=="Siyah Tişört").Id,
                    Date=DateTime.Now,
                    ImagePath="\\images\\dec9870d-af61-4e1a-a460-c7b00363e84e.png"
                },               
                new Picture()
                {
                    //Id=6,
                    ProductId=productContext.Products.FirstOrDefault(p=>p.Name=="Emporio Armani").Id,
                    Date=DateTime.Now,
                    ImagePath="\\images\\c5a85acd-13be-41ae-8950-6b9b539abd1e.png"
                },             
                new Picture()
                {
                    //Id=7,
                    ProductId=productContext.Products.FirstOrDefault(p=>p.Name=="Calvin Klein Euphoria").Id,
                    Date=DateTime.Now,
                    ImagePath="\\images\\33ced0c6-2ce7-42a0-af8c-0e6328e093f0.png"
                },               
                new Picture()
                {
                    //Id=8,
                    ProductId=productContext.Products.FirstOrDefault(p=>p.Name=="Calvin Klein Be EDT").Id,
                    Date=DateTime.Now,
                    ImagePath="\\images\\c7da9f3c-61fc-42f0-859a-2e5a59e10ec3.png"
                },
                new Picture()
                {
                    //Id=9,
                    ProductId=productContext.Products.FirstOrDefault(p=>p.Name=="Marcus Siyah Kadife Pantolon").Id,
                    Date=DateTime.Now,
                    ImagePath="\\images\\c34bb2af-8d85-4837-a056-d562b8e71b99.png"
                },
                new Picture()
                {
                    //Id=10,
                    ProductId=productContext.Products.FirstOrDefault(p=>p.Name=="Jakarlı Siyah Beyaz Elbise").Id,
                    Date=DateTime.Now,
                    ImagePath="\\images\\58506fe4-bd7c-424a-9f10-27e905d90093.png"
                }

            };
            return pictures;
        }

        private static IEnumerable<Product> GetDefaultProducts(ProductContext productContext)
        {
            IEnumerable<Product> products = new List<Product>()
            {
                new Product()
                {
                    //Id=1,
                    Name="Ray-Ban RB 3025 002",
                    Description="Mükkemmel bir gözlük",
                    Price=2600,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryId=productContext.DownCategories.FirstOrDefault(p=>p.DownCategoryName=="Gözlük").Id,
                    //Category={
                    //    Id=1,
                    //    CategoryName="Gözlük"
                    //},
                    BrandId=productContext.Brands.FirstOrDefault(p=>p.BrandName=="Ray-Ban").Id
                    //Brand =
                    //{
                    //    Id=6,
                    //    BrandName="Ray-Ban"
                    //}
                },
                new Product()
                {
                    //Id=2,
                    Name="SMASH V2",
                    Description="En sevdiğim ayakkabı",
                    Price=617,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryId=productContext.DownCategories.FirstOrDefault(p=>p.DownCategoryName=="Ayakkabı").Id,
                    //Category={
                    //    Id=3,
                    //    CategoryName="Ayakkabı"
                    //},
                    BrandId=productContext.Brands.FirstOrDefault(p=>p.BrandName=="Puma").Id
                    //Brand = {
                    //    Id=5,
                    //    BrandName="Puma"
                    //}
                },
                new Product()
                {
                    //Id=3,
                    Name="Versatil Tikky",
                    Description="0.7 Uçlu Kalem Beyaz",
                    Price=58,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Kırtasiye").Id,
                    DownCategoryId=productContext.DownCategories.FirstOrDefault(p=>p.DownCategoryName=="Kalem").Id,
                    //Category={
                    //    Id=4,
                    //    CategoryName="Kırtasiye"
                    //},
                    BrandId=productContext.Brands.FirstOrDefault(p=>p.BrandName=="Rotring").Id
                    //Brand = {
                    //    Id=3,
                    //    BrandName="Rotring"
                    //}
                },
                new Product()
                {
                    //Id=4,
                    Name="Gotik Desenli Kapüşonlu",
                    Description="Mükkemmel bir kapüşonlu",
                    Price=400,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryId=productContext.DownCategories.FirstOrDefault(p=>p.DownCategoryName=="Sweatshirt").Id,
                    //Category={
                    //    Id=2,
                    //    CategoryName="Giyim"
                    //},
                    BrandId=productContext.Brands.FirstOrDefault(p=>p.BrandName=="Bershka").Id
                    //Brand =
                    //{
                    //    Id=11,
                    //    BrandName="Bershka"
                    //}
                },
                new Product()
                {
                    //Id=5,
                    Name="Siyah Tişört",
                    Description="Batman Baskılı Reflektör Detaylı Siyah Tişört",
                    Price=200,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryId=productContext.DownCategories.FirstOrDefault(p=>p.DownCategoryName=="Tişört").Id,
                    //Category={
                    //    Id=3,
                    //    CategoryName="Ayakkabı"
                    //},
                    BrandId=productContext.Brands.FirstOrDefault(p=>p.BrandName=="Mavi").Id
                    //Brand =
                    //{
                    //    Id=1,
                    //    BrandName="Mavi"
                    //}
                },
                new Product()
                {
                    //Id=6,
                    Name="Emporio Armani",
                    Description="Emporio Armani Kadın Sweatshirt 6Ltm15-Tjgq",
                    Price=4379,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryId=productContext.DownCategories.FirstOrDefault(p=>p.DownCategoryName=="Ceket").Id,
                    //Category={
                    //    Id=2,
                    //    CategoryName="Giyim"
                    //},
                    BrandId=productContext.Brands.FirstOrDefault(p=>p.BrandName=="Armani").Id
                    //Brand =
                    //{
                    //    Id=10,
                    //    BrandName="Armani"
                    //}
                },
                new Product()
                {
                    //Id=7,
                    Name="Calvin Klein Euphoria",
                    Description="Euphoria Woman EDP 100 ml Kadın Parfüm",
                    Price=2027,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Aksesuar").Id,
                    DownCategoryId=productContext.DownCategories.FirstOrDefault(p=>p.DownCategoryName=="Parfüm").Id,
                    //Category={
                    //    Id=5,
                    //    CategoryName="Parfüm"
                    //},
                    BrandId=productContext.Brands.FirstOrDefault(p=>p.BrandName=="Calvin Klein").Id
                    //Brand =
                    //{
                    //    Id=4,
                    //    BrandName="Calvin Klein"
                    //},
                },
                new Product()
                {
                    //Id=8,
                    Name="Calvin Klein Be EDT",
                    Description="Be EDT 200 ml Erkek Parfüm",
                    Price=916,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Aksesuar").Id,
                    DownCategoryId=productContext.DownCategories.FirstOrDefault(p=>p.DownCategoryName=="Parfüm").Id,
                    //Category={
                    //    Id=5,
                    //    CategoryName="Parfüm"
                    //},
                    BrandId=productContext.Brands.FirstOrDefault(p=>p.BrandName=="Calvin Klein").Id
                    //Brand =
                    //{
                    //    Id=4,
                    //    BrandName="Calvin Klein"
                    //}
                },
                new Product()
                {
                    //Id=9,
                    Name="Marcus Siyah Kadife Pantolon",
                    Description="Mükkemmel bir Pantolon",
                    Price=500,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryId=productContext.DownCategories.FirstOrDefault(p=>p.DownCategoryName=="Pantolon").Id,
                    //Category={
                    //    Id=2,
                    //    CategoryName="Giyim"
                    //},
                    BrandId=productContext.Brands.FirstOrDefault(p=>p.BrandName=="Mavi").Id
                    //Brand =
                    //{
                    //    Id=1,
                    //    BrandName="Mavi"
                    //}
                },
                new Product()
                {
                    //Id=10,
                    Name="Jakarlı Siyah Beyaz Elbise",
                    Description="Mavi nin Kadın Koleksiyonundan Jakarlı Gri Elbise",
                    Price=280,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryId=productContext.DownCategories.FirstOrDefault(p=>p.DownCategoryName=="Elbise").Id,
                    //Category={
                    //    Id=2,
                    //    CategoryName="Giyim"
                    //},
                    BrandId=productContext.Brands.FirstOrDefault(p=>p.BrandName=="Mavi").Id
                    //Brand =
                    //{
                    //    Id=1,
                    //    BrandName="Mavi"
                    //}
                }

            };
            return products;
        }


        private static IEnumerable<UpCategory> GetDefaultUpCategories()
        {
            IEnumerable<UpCategory> upCategories = new List<UpCategory>()
            {
                new UpCategory()
                {
                    //Id=1,
                    UpCategoryName="Giyim"
                },
                new UpCategory()
                {
                    //Id=2,
                    UpCategoryName="Aksesuar"
                },
                new UpCategory()
                {
                    //Id=2,
                    UpCategoryName="Elektronik"
                },
                new UpCategory()
                {
                    //Id=3,
                    UpCategoryName="Kırtasiye"
                }
            };
            return upCategories;
        }
        private static IEnumerable<DownCategory> GetDefaultDownCategories(ProductContext productContext)
        {
            var x = productContext.UpCategories.FirstOrDefault(p => p.UpCategoryName == "Giyim").Id;
            IEnumerable<DownCategory> downCategories = new List<DownCategory>()
            {
                new DownCategory()
                {
                    //Id=1,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryName="Ceket"
                },
                new DownCategory()
                {
                    //Id=2,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryName="Tişört"
                },
                new DownCategory()
                {
                    //Id=3,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryName="Süveter"
                },
                new DownCategory()
                {
                    //Id=4,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryName="Pantolon"
                },

                new DownCategory()
                {
                    //Id=5,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryName="Şort"
                },
                new DownCategory()
                {
                    //Id=6,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryName="Pijama"
                },
                new DownCategory()
                {
                    //Id=7,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Aksesuar").Id,
                    DownCategoryName="Çanta"
                },
                new DownCategory()
                {
                    //Id=8,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Aksesuar").Id,
                    DownCategoryName="Güneş Gözlüğü"
                },
                new DownCategory()
                {
                    //Id=9,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Aksesuar").Id,
                    DownCategoryName="Cüzdan"
                },
                new DownCategory()
                {
                    //Id=10,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Aksesuar").Id,
                    DownCategoryName="Parfüm"
                },
                new DownCategory()
                {
                    //Id=11,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Elektronik").Id,
                    DownCategoryName="Monitör"
                },
                new DownCategory()
                {
                    //Id=12,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Elektronik").Id,
                    DownCategoryName="Kasa"
                },
                new DownCategory()
                {
                    //Id=13,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Elektronik").Id,
                    DownCategoryName="Laptop"
                },
                new DownCategory()
                {
                    //Id=14,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Kırtasiye").Id,
                    DownCategoryName="Kalem"
                },
                new DownCategory()
                {
                    //Id=15,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Kırtasiye").Id,
                    DownCategoryName="Silgi"
                },
                new DownCategory()
                {
                    //Id=16,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Kırtasiye").Id,
                    DownCategoryName="Kalem Kutusu"
                },
                new DownCategory()
                {
                    //Id=17,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryName="Elbise"
                },
                new DownCategory()
                {
                    //Id=18,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Giyim").Id,
                    DownCategoryName="Sweatshirt"
                },
                new DownCategory()
                {
                    //Id=19,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Aksesuar").Id,
                    DownCategoryName="Gözlük"
                },
                new DownCategory()
                {
                    //Id=20,
                    UpCategoryId=productContext.UpCategories.FirstOrDefault(p=>p.UpCategoryName=="Aksesuar").Id,
                    DownCategoryName="Ayakkabı"
                }
            };
            return downCategories;
        }


        private static IEnumerable<Brand> GetDefaultBrands()
        {
            IEnumerable<Brand> brands = new List<Brand>()
            {
                new Brand()
                {
                    //Id=1,
                    BrandName="Mavi"
                },
                new Brand()
                {
                    //Id=2,
                    BrandName="Lacoste"
                },
                new Brand()
                {
                    //Id=3,
                    BrandName="Rotring"
                },
                new Brand()
                {
                    //Id=4,
                    BrandName="Calvin Klein"
                },
                new Brand()
                {
                    //Id=5,
                    BrandName="Puma"
                },
                new Brand()
                {
                    //Id=6,
                    BrandName="Ray-Ban"
                },
                new Brand()
                {
                    //Id=7,
                    BrandName="Tom Ford"
                },
                new Brand()
                {
                    //Id=8,
                    BrandName="LC Waikiki"
                },
                new Brand()
                {
                    //Id=9,
                    BrandName="Berluti"
                },
                new Brand()
                {
                    //Id=10,
                    BrandName="Armani"
                },
                new Brand()
                {
                    //Id=11,
                    BrandName="Bershka"
                }
            };
            return brands;
        }
    }
}
