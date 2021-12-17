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
    public class MovieCategoriesController : ControllerBase
    {
        IMovieCategoryService _movieCategoryService;

        public MovieCategoriesController(IMovieCategoryService movieCategoryService)
        {
            _movieCategoryService = movieCategoryService;
        }
        [HttpGet(template: "getall")]
        public IActionResult GetAll()
        {
            var result = _movieCategoryService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int moviecategoryId)
        {
            var result = _movieCategoryService.GetById(moviecategoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(MovieCategory movieCategory)
        {
            var result = _movieCategoryService.Add(movieCategory);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(MovieCategory movieCategory)
        {
            var result = _movieCategoryService.Delete(movieCategory);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(MovieCategory movieCategory)
        {
            var result = _movieCategoryService.Update(movieCategory);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbydto")]
        public IActionResult GetDetails()
        {
            var result = _movieCategoryService.GetMovieCategoriesDetailDtos();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
