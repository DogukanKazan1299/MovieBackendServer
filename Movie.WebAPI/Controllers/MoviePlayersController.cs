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
    public class MoviePlayersController : ControllerBase
    {
        IMoviePlayerService _moviePlayerService;
        public MoviePlayersController(IMoviePlayerService moviePlayerService)
        {
            _moviePlayerService = moviePlayerService;
        }

        [HttpGet(template: "getall")]
        public IActionResult GetAll()
        {
            var result = _moviePlayerService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int moviePlayerId)
        {
            var result = _moviePlayerService.GetById(moviePlayerId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(MoviePlayer moviePlayer)
        {
            var result = _moviePlayerService.Add(moviePlayer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(MoviePlayer moviePlayer)
        {
            var result = _moviePlayerService.Delete(moviePlayer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(MoviePlayer moviePlayer)
        {
            var result = _moviePlayerService.Update(moviePlayer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbydto")]
        public IActionResult GetByDto()
        {
            var result = _moviePlayerService.GetMoviePlayersDetailDtos();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
