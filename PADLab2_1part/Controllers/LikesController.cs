using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PADLab2_1part.Models;

namespace PADLab2_1part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<LikeCount> getLikes(int id)
        {
            var likeCount = new LikeCount();
            likeCount.Count = 10;
            return Ok(likeCount);
        }

        [HttpGet("{id}/users")]
        public ActionResult<IEnumerable<User>> getLikesUsers()
        {
            var user = new User();
            user.UserId = "123";
            user.FirstName = "Alex";
            user.SecondName = "Cobl";
            user.ImageURL = "https://someURL.com";
            var list = new List<User>();
            list.Add(user);
            return Ok(list);
        }

        [HttpPost]
        public ActionResult addLike(int _pictureId, int userId)
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult removeLike(int _pictureId, int _userId)
        {
            return NoContent();
        }
    }
}
