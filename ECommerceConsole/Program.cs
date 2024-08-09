using Business.Concrete;
using DataAccess.EF.Concrete;
using Entities.Concrete;







TravelManager travelManager = new(new EfTravelDal());

Travel travel1 = new() { TravelName = "Spain", Description = "desc", Price = 1000, ImageUrl = "image" };

var result = travelManager.Add(travel1);


Console.WriteLine(result.Message);