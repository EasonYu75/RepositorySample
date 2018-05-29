using Sample.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.MVC.Controllers
{
    public class PlayersController : Controller
    {
        public JsonResult Get(int? page, int? limit, string sortBy, string direction, string name, string nationality, string placeOfBirth)
        {
            List<Player> records = new List<Player>() ;
            int total;

            records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });
            //records.Add(new Player { ID = 1, Name = "Hristo Stoichkov", PlaceOfBirth = "Plovdiv, Bulgaria", DateOfBirth = new System.DateTime(1966, 02, 08), OrderNumber = 1, CountryID = 18, IsActive = false });
            //records.Add(new Player { ID = 2, Name = "Ronaldo Luís Nazário de Lima", PlaceOfBirth = "Rio de Janeiro, Brazil", DateOfBirth = new System.DateTime(1976, 09, 18), OrderNumber = 2, CountryID = 12, IsActive = false });
            //records.Add(new Player { ID = 3, Name = "David Platt", PlaceOfBirth = "Chadderton, Lancashire, England", DateOfBirth = new System.DateTime(1966, 06, 10), OrderNumber = 3, CountryID = 16, IsActive = false });

            total = records.Count();

            var query = records.Select(p => new Player
            {
                ID = p.ID,
                Name = p.Name,
                PlaceOfBirth = p.PlaceOfBirth,
                DateOfBirth = p.DateOfBirth,
                CountryID = p.CountryID,
                //CountryName = p.Country != null ? p.Country.Name : "",
                IsActive = p.IsActive,
                OrderNumber = p.OrderNumber
            });

            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(q => q.Name.Contains(name));
            }

            if (!string.IsNullOrWhiteSpace(nationality))
            {
                query = query.Where(q => q.CountryName != null && q.CountryName.Contains(nationality));
            }

            if (!string.IsNullOrWhiteSpace(placeOfBirth))
            {
                query = query.Where(q => q.PlaceOfBirth != null && q.PlaceOfBirth.Contains(placeOfBirth));
            }

            if (!string.IsNullOrEmpty(sortBy) && !string.IsNullOrEmpty(direction))
            {
                if (direction.Trim().ToLower() == "asc")
                {
                    switch (sortBy.Trim().ToLower())
                    {
                        case "name":
                            query = query.OrderBy(q => q.Name);
                            break;
                        case "countryname":
                            query = query.OrderBy(q => q.CountryName);
                            break;
                        case "placeOfBirth":
                            query = query.OrderBy(q => q.PlaceOfBirth);
                            break;
                        case "dateofbirth":
                            query = query.OrderBy(q => q.DateOfBirth);
                            break;
                    }
                }
                else
                {
                    switch (sortBy.Trim().ToLower())
                    {
                        case "name":
                            query = query.OrderByDescending(q => q.Name);
                            break;
                        case "countryname":
                            query = query.OrderByDescending(q => q.CountryName);
                            break;
                        case "placeOfBirth":
                            query = query.OrderByDescending(q => q.PlaceOfBirth);
                            break;
                        case "dateofbirth":
                            query = query.OrderByDescending(q => q.DateOfBirth);
                            break;
                    }
                }
            }
            else
            {
                query = query.OrderBy(q => q.OrderNumber);
            }

            total = query.Count();
            if (page.HasValue && limit.HasValue)
            {
                int start = (page.Value - 1) * limit.Value;
                records = query.Skip(start).Take(limit.Value).ToList();
            }
            else
            {
                records = query.ToList();
            }




            

            return this.Json(new { records, total }, JsonRequestBehavior.AllowGet);
        }

    }
}