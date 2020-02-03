using ApplianceRepair.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplianceRepair.Controllers.Api
{
    public class MyMessagesController : ApiController
    {
        private ApplicationDbContext _context;

        public MyMessagesController()
        {
            _context = new ApplicationDbContext();
        }


        //GET /api/mymessages
        public IEnumerable<MyMessage> GetMyMessages()
        {

            return _context.MyMessages.ToList();
        }

        //GET /api/mymessages/1
        public IHttpActionResult GetMyMessage(int id)
        {
            var mymessage = _context.MyMessages.SingleOrDefault(m => m.Id == id);

            if (mymessage == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Ok(mymessage);
        }

        //POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateMessage(MyMessage mymessage)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.MyMessages.Add(mymessage);
            _context.SaveChanges();
            return Ok(mymessage);

        }

        //DELETE /api/mymessages/1
        [HttpDelete]
        public IHttpActionResult DeleteMyMessages(int id)
        {
            var mymessageInDb = _context.MyMessages.SingleOrDefault(m => m.Id == id);

            if (mymessageInDb == null)
                return NotFound();

            _context.MyMessages.Remove(mymessageInDb);
            _context.SaveChanges();

            return Ok();
        }

    }
}
