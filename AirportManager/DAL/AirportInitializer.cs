using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Data.Entity;
using Zarządzanie_Lotniskiem.Models;
using AirportManager.Models;

namespace Zarządzanie_Lotniskiem.DAL
{
    public class AirportInitializer : DropCreateDatabaseIfModelChanges<AirportContext>
    {
        protected override void Seed(AirportContext context)
        {
            var citiesPL = new List<City>
            {
                new City{Name = "Warszawa"},
                new City{Name = "Kraków"},
                new City{Name = "Sokołów"},
            };

            citiesPL.ForEach(city => context.Cities.Add(city));
            context.SaveChanges();

            var citiesDE = new List<City>
            {
                new City{Name = "Berlin"},
                new City{Name = "Hamburg"},
            };

            citiesDE.ForEach(city => context.Cities.Add(city));
            context.SaveChanges();

            var citiesUSA = new List<City>
            {
                new City{Name = "Nowy Jork"},
                new City{Name = "Los Angeles"},
            };

            citiesUSA.ForEach(city => context.Cities.Add(city));
            context.SaveChanges();

            var countries = new List<Country>
            {
                new Country { Name = "Polska", Cities = citiesPL },
                new Country { Name = "Niemcy", Cities = citiesDE },
                new Country { Name = "Stany Zjednoczone", Cities = citiesUSA },
            };

            countries.ForEach(country => context.Countries.Add(country));
            context.SaveChanges();

            var airliners = new List<AircraftType> { AircraftType.Airliner };
            var airinerCommuters = new List<AircraftType> { AircraftType.Airliner, AircraftType.CommuterAircraft };
            var helicopters = new List<AircraftType> { AircraftType.Helicopter };
            var militaryHelicopters = new List<AircraftType> { AircraftType.MilitaryPlane, AircraftType.Helicopter };

            var boeings = new List<Aircraft>
            {
                new Aircraft{Name = "Boeing 747 8", Types = airliners, Seats = 660, LuggageSpace = 160000},
                new Aircraft{Name = "Boeing 747 400", Types = airliners, Seats = 500, LuggageSpace = 130000},
                new Aircraft{Name = "Boeing 747 300", Types = airliners, Seats = 400, LuggageSpace = 100000},
            };

            var airbuses = new List<Aircraft>
            {
                new Aircraft{Name = "Airbus A320 100", Types = airinerCommuters, Seats = 140, LuggageSpace = 30000},
                new Aircraft{Name = "Airbus A320 200", Types = airinerCommuters, Seats = 160, LuggageSpace = 40000},
                new Aircraft{Name = "Airbus A320 300", Types = airinerCommuters, Seats = 180, LuggageSpace = 50000},
            };

            var military = new List<Aircraft>
            {
                new Aircraft{Name = "Boeing CH-47 Chinook", Types = militaryHelicopters, Seats = 33, LuggageSpace = 10800},
            };

            var lightHelicopters = new List<Aircraft>
            {
                new Aircraft{Name = "Agusta A109", Types = helicopters, Seats = 8, LuggageSpace = 1000},
            };

            boeings.ForEach(aircraft => context.Aircrafts.Add(aircraft));
            airbuses.ForEach(aircraft => context.Aircrafts.Add(aircraft));
            military.ForEach(aircraft => context.Aircrafts.Add(aircraft));
            lightHelicopters.ForEach(aircraft => context.Aircrafts.Add(aircraft));
            context.SaveChanges();

            var airports = new List<Airport>
            {
                new Airport{Name = "Lotnisko Chopina", Country = countries[0].Name, City = citiesPL[0].Name, Type = AirportType.Airport, Aircrafts = airbuses},
                new Airport{Name = "Lotnisko Kraków", Country = countries[0].Name, City = citiesPL[1].Name, Type = AirportType.CityAirport},
                new Airport{Name = "Lotnisko Sokołów", Country = countries[0].Name, City = citiesPL[2].Name, Type = AirportType.LandingStrip},
                new Airport{Name = "Lotnisko Berlin", Country = countries[1].Name, City = citiesDE[0].Name, Type = AirportType.Airport, Aircrafts = boeings},
                new Airport{Name = "Lotnisko Hamburg", Country = countries[1].Name, City = citiesDE[1].Name, Type = AirportType.MilitaryAirport, Aircrafts = military},
                new Airport{Name = "Lotnisko Nowy Jork", Country = countries[2].Name, City = citiesUSA[0].Name, Type = AirportType.Airport},
                new Airport{Name = "Lotnisko Los Angeles", Country = countries[2].Name, City = citiesUSA[0].Name, Type = AirportType.Heliport, Aircrafts = lightHelicopters},
            };

            airports.ForEach(airport => context.Airports.Add(airport));
            context.SaveChanges();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            roleManager.Create(new IdentityRole("Admin"));
            roleManager.Create(new IdentityRole("User"));

            var admin = new ApplicationUser { UserName = "admin@admin.pl" };
            userManager.Create(admin, "Admin!23");
            userManager.AddToRole(admin.Id, "Admin");

            var user = new ApplicationUser { UserName = "user@user.pl" };
            userManager.Create(user, "User!23");
            userManager.AddToRole(user.Id, "User");
        }
    }
}
