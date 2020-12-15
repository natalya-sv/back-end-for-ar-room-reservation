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
    public class UsersApiController : ControllerBase
    {
        private readonly ProjectContext _context;
        public UsersApiController(ProjectContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Returns user by email
        /// </summary>
        /// <param name="userEmail">email of a user</param>
        /// <response code="200">successful operation</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [Route("/api/users/email/{userEmail}")]
        [ValidateModelState]
        [SwaggerOperation("UsersEmailUserEmailGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(User), description: "successful operation")]
        public async Task<ActionResult<User>> UsersEmailUserEmailGet([FromRoute][Required]string userEmail)
        {
            var user = await _context.Users
                .Include(j => j.Job)
                .AsNoTracking().FirstOrDefaultAsync(u => u.Email == userEmail);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        /// <summary>
        /// Returns user by email and passw
        /// </summary>
        /// <param name="userEmail">email of a user</param>
        /// <param name="password">password of a user</param>
        /// <response code="200">successful operation</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [Route("/api/users/email/{userEmail}/password/{password}")]
        [ValidateModelState]
        [SwaggerOperation("UsersEmailUserEmailPasswordPasswordGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(User), description: "successful operation")]
        public async Task<ActionResult<User>> UsersEmailUserEmailPasswordPasswordGet([FromRoute][Required]string userEmail, [FromRoute][Required]string password)
        {
            var user = await _context.Users
                .AsNoTracking()
                .Include(j => j.Job)
                .FirstOrDefaultAsync(u => u.Email == userEmail && u.Password == password);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        /// <summary>
        /// Returns a list of users
        /// </summary>
        /// <response code="200">An array of users</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [Route("/api/users")]
        [ValidateModelState]
        [SwaggerOperation("UsersGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<User>), description: "An array of users")]
        public async Task<ActionResult<IEnumerable<User>>> UsersGet()
        {
            var users = await _context.Users
                .Include(j => j.Job)
                .AsNoTracking().ToListAsync();

            if (users == null)
            {
                return NotFound();
            }

            return users;
        }

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="body"></param>
        /// <response code="201">Created</response>
        /// <response code="409">Conflict</response>
        [HttpPost]
        [Route("/api/users")]
        [ValidateModelState]
        [SwaggerOperation("UsersPost")]
        [SwaggerResponse(statusCode: 201, type: typeof(User), description: "Created")]
        public async Task<ActionResult<User>> UsersPost([FromBody]User body)
        {
            var user = await _context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Email == body.Email);

            if (user != null)
            {
                return Conflict();
            }

            var job = await _context.Jobs.AsNoTracking().FirstOrDefaultAsync(job => job.JobId == 3);

            var newUser = new User
            {
                Surname = body.Surname,
                Name = body.Name,
                Email = body.Email,
                JobId = job.JobId,
                Password = body.Password
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(UsersUserIdGet), new { userId = newUser.UserId }, newUser);
        }

        /// <summary>
        /// Deletes a user
        /// </summary>
        /// <param name="userId"></param>
        /// <response code="204">Deleted</response>
        /// <response code="404">User not found</response>
        [HttpDelete]
        [Route("/api/users/{userId}")]
        [ValidateModelState]
        [SwaggerOperation("UsersUserIdDelete")]
        public async Task<IActionResult> UsersUserIdDelete([FromRoute][Required]int userId)
        {
            var user = await _context.Users
               .AsNoTracking()
               .FirstOrDefaultAsync(u => u.UserId == userId);

            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// Returns user by ID
        /// </summary>
        /// <param name="userId">ID of a user</param>
        /// <response code="200">successful operation</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [Route("/api/users/{userId}")]
        [ValidateModelState]
        [SwaggerOperation("UsersUserIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(User), description: "successful operation")]
        public async Task<ActionResult<User>> UsersUserIdGet([FromRoute][Required]int userId)
        {
            if (userId == 0)
            {
                return BadRequest();
            }

            var user = await _context.Users.AsNoTracking()
                 .Include(j => j.Job)
                 .FirstOrDefaultAsync(u => u.UserId == userId);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        /// <summary>
        /// Updates an existing user
        /// </summary>
        /// <param name="body"></param>
        /// <param name="userId">ID of a user</param>
        /// <response code="204">Updated</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">User not found</response>
        [HttpPut]
        [Route("/api/users/{userId}")]
        [ValidateModelState]
        [SwaggerOperation("UsersUserIdPut")]
        public async Task<IActionResult> UsersUserIdPut([FromBody]User body, [FromRoute][Required]int userId)
        {
            if (userId != body.UserId)
            {
                return BadRequest();
            }

            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.UserId == userId);

            if (user == null)
            {
                return NotFound();
            }

            _context.Entry(body).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(userId))
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
        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}