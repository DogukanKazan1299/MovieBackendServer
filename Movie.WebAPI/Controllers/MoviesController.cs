using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie.Business.Abstract;
using Movie.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        IMovieeService _movieService;
        public MoviesController(IMovieeService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet(template:"getall")]
        public IActionResult GetAll()
        {
            var result = _movieService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int movieId)
        {
            var result = _movieService.GetById(movieId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Moviee moviee)
        {
            var result = _movieService.Add(moviee);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Moviee moviee)
        {
            var result = _movieService.Delete(moviee);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Moviee moviee)
        {
            var result = _movieService.Update(moviee);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getmoviedetails")]
        public IActionResult GetMovieDetails()
        {
            var result = _movieService.GetMovieDetails();
            if (result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
