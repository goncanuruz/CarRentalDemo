using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        { 
        }

            //UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Delete(new User { Id=3});

            //CarList();

            //AddCarTest();

            //CarDeleteTest();

            //CarUpdateTest();

            //ValidationTest();

            //GetByIdTest();

            //AddUserTest();

            //UserList();

            //CustomerList();

            //RentalList();

            //RentalDetailsList();
            //CarBrand();


        

//        private static void RentalDetailsList()
//        {
//            EfRentalDal efRentalDal = new EfRentalDal();

//            var result = efRentalDal.GetRentalDetails();
//            foreach (var rentaldto in result)
//            {
//                Console.WriteLine("{0} / {1} / {2} / {3} / {4}",
//                    rentaldto.CarId,rentaldto.CarName,
//                 rentaldto.CarName,
//                   rentaldto.RentDate,rentaldto.ReturnDate);
//            }

//        }


//        private static void RentalList()
//        {
//            RentalManager rentalManager = new RentalManager(new EfRentalDal());
//            foreach (var rental in rentalManager.GetAll().Data)
//            {
//                Console.WriteLine("{0} / {1} / {2} / {3} ",rental.Id,rental.CarId,rental.CustomerId,rental.RentDate);
//            }
//        }

//        private static void CustomerList()
//        {
//            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
//            foreach (var customer in customerManager.GetAll().Data)
//            {
//                Console.WriteLine(customer.CompanyName);
//            }
//        }

//        private static void UserList()
//        {
//            UserManager userManager = new UserManager(new EfUserDal());
//            var result = userManager.GetAll();
//            foreach (var user in result.Data)
//            {
//                Console.WriteLine(user.FirstName);
//            }

//        }

//        private static void GetByIdTest()
//        {
//            BrandManager brandManager = new BrandManager(new EfBrandDal());
//            var result = brandManager.GetById(1);
//            Console.WriteLine(result.Data.Name);
//        }

//        private static void ValidationTest()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            var result= carManager.Add(new Car
//            {
//                BrandId = 2,
//                ColorId = 1,
//                Name = "To",
//                Description = "Otomatik",
//                ModelYear = 2014,
//                DailyPrice = 0
//            });
//            if (result.Success == true)
//            {
//                Console.WriteLine(result.Message);
//                Console.WriteLine("--");
//                CarList();
//            }
//            else
//            {
//                Console.WriteLine(result.Message);
//            }

//        }

//        private static void CarUpdateTest()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            carManager.Update(new Car { Id = 5, DailyPrice = 300, BrandId = 5, Description = "Otomatik", Name = "Hyundai Accent", ModelYear = 2015, ColorId = 1 });
//            CarList();
//        }

//        private static void CarBrand()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            var result =carManager.GetByBrandId(2);
//            foreach (var car in result.Data)
//            {
//                Console.WriteLine(car.BrandId);
//            }
//        }

//        private static void AddCarTest()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            carManager.Add(new Car
//            {
//                BrandId = 2,
//                ColorId = 1,
//                Name = "Volkswagen Polo",
//                Description = "Otomatik",
//                ModelYear = 2014,
//                DailyPrice = 300
//            });
//            CarList();
//        }

//        private static void CarList()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());
//            var result = carManager.GetCarDetails();
//            foreach (var c in result.Data)
//            {
//                Console.WriteLine("{0} / {1} / {2} / {3} / {4}",c.Id, c.BrandName, c.ColorName, c.ModelYear, c.Name);
//            }
//        }
    }
}
