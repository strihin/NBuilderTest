using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzWare.NBuilder;
using Microsoft.AspNet.Identity.EntityFramework;
using PencilJoyTests.Data;

namespace NBuilderTest
{
    public class Customer
{
    public string EmailAddress { get; set; }
    public string FirstName { get; set; }
    public int Id { get; set; }
    public string LastName { get; set; }
    public string TelephoneNumber { get; set; }
}

public class Order
{
    public Customer Customer { get; set; }
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
}

public class Product
{
    public string Description { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
}

public class OrderItem
{
    public int Id { get; set; }
    public Order Order { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
}
    class Program
    {
        static void Main(string[] args)
        {
            /*
              var customer = Builder<Customer>.CreateListOfSize(10)
                  .All()
                  .With(c => c.EmailAddress = Faker.Internet.Email())
                  .With(c => c.FirstName = Faker.Name.First())
                  .With(c => c.LastName = Faker.Name.Last())
                  .With(c => c.TelephoneNumber = Faker.Phone.Number())
                  .Build();
              var qwer = customer.ToList();

              var createBookData = Builder<CreateBookData>.CreateListOfSize(10).All();
              createBookData.With(c => c.Username = Faker.Name.First());
              createBookData.With(c => c.NumberCharacter = Faker.RandomNumber.Next(0, 1));
              createBookData.With(c => c.NumberDay = Faker.RandomNumber.Next(1, 29));
              createBookData.With(c => c.NumberMonth = Faker.RandomNumber.Next(1, 12));
              createBookData.Build();

              var createMessageData = Builder<MessageData>.CreateListOfSize(10)
                  .All()
                  .With(c => c.CustomerName = Faker.Name.FullName())
                  .With(c => c.CustomerEmail = Faker.Internet.Email())
                  .Build();

              var checkoutAddressData = Builder<CheckoutAddressData>.CreateListOfSize(10)
                  .All()
                  .With(c => c.Username = Faker.Name.Last())
                  .With(c => c.City = Faker.Address.City())
                  .With(c => c.Street = Faker.Address.StreetAddress())
                  .With(c => c.ZipCode = Faker.Address.ZipCode())
                  .With(c => c.Phone = Faker.Phone.Number())
                  .Build();

              CreateBookData objCreateBookData = new CreateBookData(
                  createBookData[0].Username, createBookData[0].NumberMonth,
                  createBookData[0].NumberDay, createBookData[0].NumberSex,
                  createBookData[0].NumberSex
                  );
              objCreateBookData.Username = "";*/
           
            var ObjFullData = Builder<FullData>.CreateListOfSize(10).All();
            ObjFullData.With(c => c.Username = Faker.Name.First());
            ObjFullData.With(c => c.createBookData.Username = Faker.Name.First());
            ObjFullData.With(c => c.createBookData.NumberCharacter = Faker.RandomNumber.Next(0, 1));
            ObjFullData.With(c => c.createBookData.NumberDay = Faker.RandomNumber.Next(1, 29));
            ObjFullData.With(c => c.createBookData.NumberMonth = Faker.RandomNumber.Next(1, 12));

            ObjFullData.With(c => c.messageData.CustomerName = Faker.Name.FullName());
            ObjFullData.With(c => c.messageData.CustomerEmail = Faker.Internet.Email());

            ObjFullData.With(c => c.checkoutAddressData.Username = Faker.Name.Last());
            ObjFullData.With(c => c.checkoutAddressData.City = Faker.Address.City());
            ObjFullData.With(c => c.checkoutAddressData.Street = Faker.Address.StreetAddress());
            ObjFullData.With(c => c.checkoutAddressData.ZipCode = Faker.Address.ZipCode());
            ObjFullData.With(c => c.checkoutAddressData.Phone = Faker.Phone.Number());

            ObjFullData.Build();
        }
    }
}
