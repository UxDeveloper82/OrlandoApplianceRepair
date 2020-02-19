using ApplianceRepair.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplianceRepair.Controllers.Api
{
    public class MyBlogsController : ApiController
    {
        private ApplicationDbContext _context;

        public MyBlogsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/myblogs
        public IEnumerable<MyBlog> GetMyBlogs() 
        {
            return _context.MyBlogs.ToList();
        }

        //GET /api/myblogs/1
        public IHttpActionResult GetMyBlog(int id)
        {
            var myblog = _context.MyBlogs.SingleOrDefault(b => b.Id == id);

            if (myblog == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Ok(myblog);
        
        }




    }
}
