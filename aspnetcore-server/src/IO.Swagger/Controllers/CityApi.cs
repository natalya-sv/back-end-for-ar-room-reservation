/*
 * Room Reservation API
 *
 * A Simple IP Address API
 *
 * OpenAPI spec version: 0.1.9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IO.Swagger.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CityApiController : ControllerBase
	{
		private readonly ProjectContext _context;
		public CityApiController(ProjectContext context)
		{
			_context = context;
		}
		/// <summary>
		/// Deletes a city
		/// </summary>
		/// <param name="cityId"></param>
		/// <response code="204">Deleted</response>
		/// <response code="404">City not found</response>
		[HttpDelete]
		[Route("/api/cities/{cityId}")]
		[ValidateModelState]
		[SwaggerOperation("CitiesCityIdDelete")]
		public async Task<IActionResult> CitiesCityIdDelete([FromRoute][Required] long cityId)
		{
			var city = await _context.Cities.FindAsync(cityId);
			if (city == null)
			{
				return NotFound();
			}

			_context.Cities.Remove(city);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		/// <summary>
		/// Returns a city by ID
		/// </summary>
		/// <param name="cityId">ID of a city</param>
		/// <response code="200">OK</response>
		/// <response code="404">City not found</response>
		[HttpGet]
		[Route("/api/cities/{cityId}")]
		[ValidateModelState]
		[SwaggerOperation("CitiesCityIdGet")]
		[SwaggerResponse(statusCode: 200, type: typeof(City), description: "OK")]
		public async Task<ActionResult<City>> CitiesCityIdGet([FromRoute][Required] int cityId)
		{
			var city = await _context.Cities.FindAsync(cityId);

			if (city == null)
			{
				return NotFound();
			}

			return city;
		}

		/// <summary>
		/// Update an existing room
		/// </summary>
		/// <param name="body"></param>
		/// <param name="cityId">ID of a city</param>
		/// <response code="204">Updated</response>
		/// <response code="400">Bad Request</response>
		/// <response code="404">City not found</response>
		[HttpPut]
		[Route("/api/cities/{cityId}")]
		[ValidateModelState]
		[SwaggerOperation("CitiesCityIdPut")]
		public async Task<IActionResult> CitiesCityIdPut([FromBody] City body, [FromRoute][Required] int cityId)
		{
			if (cityId != body.CityId)
			{
				return BadRequest();
			}

			_context.Entry(body).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!CityExists(cityId))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		/// <summary>
		/// Returns a list of cities
		/// </summary>
		/// <response code="200">A json array of cities</response>
		/// <response code="404">Cities not found</response>
		[HttpGet]
		[Route("/api/cities")]
		[ValidateModelState]
		[SwaggerOperation("CitiesGet")]
		[SwaggerResponse(statusCode: 200, type: typeof(List<City>), description: "A json array of cities")]
		public async Task<ActionResult<IEnumerable<City>>> CitiesGet()
		{
			return await _context.Cities.ToListAsync();
		}

		/// <summary>
		/// Creates a new city
		/// </summary>
		/// <param name="body"></param>
		/// <response code="201">Created</response>
		/// <response code="409">Conflict</response>
		[HttpPost]
		[Route("/api/cities")]
		[ValidateModelState]
		[SwaggerOperation("CitiesPost")]
		[SwaggerResponse(statusCode: 201, type: typeof(City), description: "Created")]
		public async Task<ActionResult<City>> CitiesPost([FromBody] City body)
		{
			_context.Cities.Add(body);
			await _context.SaveChangesAsync();

			return CreatedAtAction("CitiesCityIdGet", new { id = body.CityId }, body);
		}

		private bool CityExists(int id)
		{
			return _context.Cities.Any(e => e.CityId == id);
		}
	}
}