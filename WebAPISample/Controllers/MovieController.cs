using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Cala_Jobs.Models;

namespace WebAPI_Cala_Jobs.Controllers
{
    public class MovieController : ApiController
    {
        // GET api/values
        public IEnumerable<MovieInfo> Get()
        {
            var movieInfoList = new List<MovieInfo>();
            for (int i = 0; i < 5; i++)
            {
                var movieInfo = new MovieInfo
                {
                    Title = $"Title {i}",
                    Director = $"Direcotr {i}",
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
                Director = $"Direcotr {id}",
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