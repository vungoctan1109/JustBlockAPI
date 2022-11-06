using JustBlog.Model.Post;
using JustBlog.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JustBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService postServices;
        public PostController(IPostService postServices)
        {
            this.postServices = postServices;
        }

        [HttpGet]
        [Authorize(Roles = "User, Blog Owner, Contributor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<PostVM>>> Get([FromQuery] int? page, [FromQuery] int? pageSize)
        {
            IEnumerable<PostVM> categories = await postServices.GetAsync(page, pageSize);
            return Ok(categories);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "User, Blog Owner, Contributor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<PostVM>>> GetById(Guid id)
        {
            PostVM? categories = await postServices.FirstOrDefaultAsync(c => c.Id == id);
            return categories == null ? (ActionResult<List<PostVM>>)BadRequest() : (ActionResult<List<PostVM>>)Ok(categories);
        }

        [HttpPost]
        [Authorize(Roles = "Blog Owner, Contributor")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Create([FromBody] PostCM PostCM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await postServices.AddAsync(PostCM);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest("Create Error");
            }
        }

        [HttpPut]
        [Authorize(Roles = "Blog Owner, Contributor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Update([FromBody] PostUM PostUM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await postServices.UpdateAsync(PostUM);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest("Update Error");
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Blog Owner")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                await postServices.DeleteAsync(id);
                return Ok();
            }
            catch (ArgumentException ex)
            {

                return BadRequest(ex.Message);
            }
            catch (Exception)
            {

                return BadRequest("Delete Error");
            }
        }

        [HttpGet("Latest")]
        [Authorize(Roles = "User, Blog Owner, Contributor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<PostVM>>> Latest([FromQuery] int page, [FromQuery] int pageSize)
        {
            IEnumerable<PostVM> categories = await postServices.LatestAsync(page, pageSize);
            return Ok(categories);
        }

        [HttpGet("Most-interesting")]
        [Authorize(Roles = "User, Blog Owner, Contributor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<PostVM>>> MostInteresting([FromQuery] int page, [FromQuery] int pageSize)
        {
            IEnumerable<PostVM> categories = await postServices.MostInterestingAsync(page, pageSize);
            return Ok(categories);
        }

        [HttpGet("Most-viewed")]
        [Authorize(Roles = "User, Blog Owner, Contributor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<PostVM>>> MostViewed([FromQuery] int page, [FromQuery] int pageSize)
        {
            IEnumerable<PostVM> categories = await postServices.MostViewedAsync(page, pageSize);
            return Ok(categories);
        }

        [HttpGet("Published")]
        [Authorize(Roles = "User, Blog Owner, Contributor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<PostVM>>> Published([FromQuery] int page, [FromQuery] int pageSize)
        {
            IEnumerable<PostVM> categories = await postServices.PublishedAsync(page, pageSize);
            return Ok(categories);
        }

        [HttpGet("UnPublished")]
        [Authorize(Roles = "User, Blog Owner, Contributor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<PostVM>>> UnPublished([FromQuery] int page, [FromQuery] int pageSize)
        {
            IEnumerable<PostVM> categories = await postServices.UnPublishedAsync(page, pageSize);
            return Ok(categories);
        }

        [HttpGet("Category")]
        [Authorize(Roles = "User, Blog Owner, Contributor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<PostVM>>> GetCategory([FromQuery] string name)
        {
            IEnumerable<PostVM> categories = await postServices.CategoryNameAsync(name);
            return Ok(categories);
        }
    }
}
