using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPISample.Models;

namespace WebAPISample.Controllers
{
    public class MovieController : ApiController
    {
        ApplicationDbContext db;
        public MovieController()
        {
            db = new ApplicationDbContext();
        }

        //reference- player tracker for seed data
        // GET api/values
        public IEnumerable<Movie> Get()
        {
            var movieInfoList = new List<MovieInfo>();
            for (int i = 0; i < 5; i++)
            {
                var movieInfo = new MovieInfo
                {
                    Title = $"Title {i}",
                    Director = $"Director {i}",
                    Genre = $"Genre {i}",
                    
                };
                movieInfoList.Add(movieInfoList);
            }
            // Retrieve all movies from db logic
            return new string[] { "movie1 string", "movie2 string" };
        }

        // GET api/values/5 - To read or get values from DB
        public string Get(int id)
        {
            return new MovieInfo
            {
                Title = $"Title {id}",
                Director = $"Director {id}",
                Genre = $"Genre {id}",

            };
            // Retrieve movie by id from db logic
            return "value";
        }

        // POST api/values - Submit new information or add new customer to DB
        public void Post([FromBody]Movie value)
        {
            // Create movie in db logic
        }

        // PUT api/values/5 - Edit
        public void Put(int id, [FromBody]string value)
        {
            // Update movie in db logic
        }

        // DELETE api/values/5 - Removing values
        public void Delete(int id)
        {
            // Delete movie from db logic
        }
    }

}