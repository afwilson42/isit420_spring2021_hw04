using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace isit420hw04JadeAndrew.Controllers
{
    public class OrdersController : ApiController
    {
        // Define the database
        NodeOrders500Entities myDB = new NodeOrders500Entities();

        // Get all the orders.
        public IEnumerable<Order> GetAllOrders()
        {
            return myDB.Orders;
        }

        /*public IHttpActionResult GetOrder(string id)
        {
            Order note = myDB.Orders.FirstOrDefault((p) => p. == id);
            if (note == null)
            {
                return NotFound();
            }
            return Ok(note);
        }*/
    }
}
