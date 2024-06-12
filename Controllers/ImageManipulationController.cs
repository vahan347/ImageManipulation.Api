using ImageManipulation.Api.Models;
using ImageManipulation.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace ImageManipulation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageManipulationController : ControllerBase
    {
        private readonly IManipulation<Image> _manipulation;
        private readonly ILogger<ImageManipulationController> _logger;

        public ImageManipulationController(IManipulation<Image> manipulation, ILogger<ImageManipulationController> logger)
        {
            _manipulation = manipulation;
            _logger = logger;
        }

        [HttpPost("resize")]
        public ActionResult<Image> Resize([FromBody] Image image)
        {
            if (image == null)
            {
                return BadRequest();
            }

            Image resultImage = _manipulation.Resize(image);
            return Ok(resultImage);
        }

        [HttpPost("blur")]
        public ActionResult<Image> Blur(Image image)
        {
            if (image == null)
            {
                return BadRequest();
            }

            Image resultImage = _manipulation.Blur(image);
            return Ok(resultImage);
        }

        [HttpPost("applyeffect")]
        public ActionResult<Image> ApplyEffect(Image image)
        {
            if (image == null)
            {
                return BadRequest();
            }

            Image resultImage = _manipulation.ApplyEffect(image);
            return Ok(resultImage);
        }
    }
}
