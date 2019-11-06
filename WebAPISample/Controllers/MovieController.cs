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
        // GET api/movie
        ApplicationDbContext db;
        public MovieController()
        {
            db = new ApplicationDbContext();
        }
        public IEnumerable<Movie> Get()
        {
            // Retrieve all movies from db logic
            return db.Movies.ToList();
        }
        public IHttpActionResult Get(int id)
        {
            // Retrieve movie by id from db logic
            var movie = db.Movies.FirstOrDefault(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        // POST api/movie
        public void Post([FromBody]Movie value)
        {
            // Create movie in db logic
            Movie movie = new Movie();
            movie.Title = value.Title;
            movie.Genre = value.Genre;
            movie.Director = value.Director;
            db.Movies.Add(movie);
            db.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Movie movie)
        {
            // Update movie in db logic
            var movies = db.Movies.FirstOrDefault(m => m.MovieId == id);
            movies.Director = movie.Director;
            movies.Genre = movie.Genre;
            movies.Title = movie.Title;
            db.SaveChanges();
        }

        // DELETE api/movie/5
        public void Delete(int id)
        {
            Movie movie = db.Movies.FirstOrDefault(m => m.MovieId == id);
            db.Movies.Remove(movie);
            db.SaveChanges();
        }
    }

}