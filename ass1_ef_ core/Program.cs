using ass1_ef__core.airlineModels;
using ass1_ef__core.DatabseContext;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace ass1_ef__core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AirlineDbContext();
            #region a
            //    Airline l1 = new Airline()
            //    {
            //        Name = "EgyptAir",
            //        ContactPerson = "ahmed ali",
            //        Address = "cairo",
            //        Phones = new List<Phone>
            //{
            //    new Phone { Number = "0123456789" },
            //    new Phone { Number = "0113654789" }
            //}





            //    };


            //   context.Airlines.Add(l1);

            //    context.SaveChanges();

            #endregion
            #region b
            //    var airline = context.Airlines.FirstOrDefault(a => a.Name == "EgyptAir");




            //    if (airline != null)
            //    {

            //        AirCraft craft1 = new AirCraft()
            //        {
            //            model = "model01",
            //            capacity = 180,
            //            airCraftLine = airline




            //        };
            //        context.AirCrafts.Add(craft1);
            //        context.SaveChanges(); 
            #endregion


            #region c
            //        var transaction = new Transaction
            //        {
            //            Description = "Tickets",
            //            amount = 50000,
            //            airlinetransaction = airline,
            //            date = "27-11-2025"
            //        };


            //        context.Transactions.Add(transaction);


            //        context.SaveChanges(); 
            #endregion



            //}
            // var emp01 = context.Employees.Where(e => e.airline.Name == "EgyptAir").ToList();



            #region e
            //var transactiond = context.Transactions.Where(t => t.airlinetransaction.Name == "EgyptAir")
            //         .Select(t => new
            //         {
            //             t.Id,
            //             t.Description,
            //             t.amount
            //         })
            //         .ToList(); 
            #endregion
            #region g
            //var aircraft = context.AirCrafts.FirstOrDefault(c => c.model == "model01");
            //if (aircraft != null)

            //{
            //    aircraft.capacity = 200;
            //    context.SaveChanges();
            //} 


            #endregion





            #region i
            //Route route = new Route()
            //{
            //    origin = "cairo",
            //    destination = "dubai",
            //    classification = "international",
            //    distance = 2400
            //};

            //context.Route.Add(route);
            //context.SaveChanges();
            #endregion

            #region j
            //var aircraft = context.AirCrafts.FirstOrDefault(a => a.model == "model01");
            //var route1 = context.Route.FirstOrDefault(r => r.origin == "cairo" && r.destination == "dubai");

            //AirCraftRoute AircraftRoute = new AirCraftRoute()
            //{
            //    Route = route1,
            //    AirCraft = aircraft,
            //    Duration = 4,
            //    Price = 3000


            //};

            //context.AirCraftRoutes.Add(AircraftRoute);
            //context.SaveChanges();

            #endregion

           





        }
    }
}