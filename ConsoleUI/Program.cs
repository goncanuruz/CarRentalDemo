using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //Veri Tabanımızdaki kayıtlı arabaları listeler.
            //CarList();
            Console.WriteLine("-------------------------");
            //AddCarTest();
            Console.WriteLine("-------------------------");
            //CarDeleteTest();
            Console.WriteLine("-------------------------");
            //CarUpdateTest();
            Console.WriteLine("-------------------------");
            //ValidationTest();
            //GetByIdTest();

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand{Name="Volkswagen" });
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.Id+" / "+brand.Name);
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {

                Console.WriteLine("{0} / {1} / {2} / {3} / ",car.Id,car.BrandName,car.ColorName,car.DailyPrice);
            }

        }

        private static void GetByIdTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetById(1);
            Console.WriteLine(result.Name);
        }

        private static void ValidationTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 1,
                Name = "To",
                Description = "Otomatik",
                ModelYear = 2014,
                DailyPrice = 0
            });
        }

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { Id = 5, DailyPrice = 260, BrandId = 5, Description = "Otomatik", Name = "Hyundai Accent", ModelYear = 2015, ColorId = 1 });
            CarList();
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { Id = 8 });
            CarList();
        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 1,
                Name = "Volkswagen Polo",
                Description = "Otomatik",
                ModelYear = 2014,
                DailyPrice = 300
            });
            CarList();
        }

        private static void CarList()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2} / {3} / {4}",c.Id, c.Name, c.Description, c.ModelYear, c.DailyPrice);
            }
        }
    }
}
