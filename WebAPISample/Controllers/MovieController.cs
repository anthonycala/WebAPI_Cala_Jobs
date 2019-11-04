using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPISample.Models;

namespace MovieLibrary.Controllers
{

    public class MovieController : ApiController
    {
        ApplicationDbContext db;
        public MovieController()
        {
            db = new ApplicationDbContext();
        }
        public IHttpActionResult Get()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                try
                {
                    var movies = context.Movies.ToList();

                    return Ok(movies);
                }
                catch
                {
                    return BadRequest();
                }
            }
        }

<<<<<<< HEAD
        public IHttpActionResult Get(int MovieId)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                try
                {
                    var movies = context.Movies.Where(m => m.MovieId == MovieId).FirstOrDefault();

                    return Ok(movies);
                }
                catch
                {
                    return BadRequest();
                }
            }

        }

        public IHttpActionResult Get(string searchType, string searchText)
        {
            try
            {
                searchText = searchText.ToLower();
                searchType = searchType.ToLower();
                if (searchType == "Title")
                {
                    var results = db.Movies.Where(m => m.Title.Contains(searchText)).ToList();

                    return Ok(results);
                }
                else if (searchType == "Director")
                {
                    var results = db.Movies.Where(m => m.Director.Contains(searchText)).ToList();

                    return Ok(results);
                }
                else if (searchType == "Genre")
                {
                    var results = db.Movies.Where(m => m.Genre.Contains(searchText)).ToList();

                    return Ok(results);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody]Movie value)
=======
        //reference- player tracker for seed data
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
>>>>>>> ef09e5db26e5c34af96173b2a0ffd52dba10c196
        {
            try
            {
                if (value.Title != null && value.Genre != null && value.Director != null)
                {
                    db.Movies.Add(value);
                    db.SaveChangesAsync();
                    return Ok(value);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch
            {
                return BadRequest();
            }
        }

<<<<<<< HEAD
        [HttpPut]

        public IHttpActionResult Put(int id, [FromBody]Movie movie)
=======
        // PUT api/values/5 - Edit
        public void Put(int id, [FromBody]string value)
>>>>>>> ef09e5db26e5c34af96173b2a0ffd52dba10c196
        {

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                try
                {
                    var movies = context.Movies.FirstOrDefault(m => m.MovieId == id);

                    movies.Title = movie.Title;
                    movies.Genre = movie.Genre;
                    movies.Director = movie.Director;
                    context.SaveChanges();
                    return Ok();
                }
                catch
                {
                    return BadRequest();
                }
            }
        }

<<<<<<< HEAD
        public IHttpActionResult Delete(int id)
=======
        // DELETE api/values/5 - Removing values
        public void Delete(int id)
>>>>>>> ef09e5db26e5c34af96173b2a0ffd52dba10c196
        {
            try
            {
                Movie movie = db.Movies.Where(m => m.MovieId == id).Single();
                db.Movies.Remove(movie);
                db.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}