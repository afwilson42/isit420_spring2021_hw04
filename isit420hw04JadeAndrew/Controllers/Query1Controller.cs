using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace isit420hw04JadeAndrew.Controllers
{
    // Which stores are selling CDs for better markups?
    // Displays order count for each store, for all orders over $13, sorted from high to low based on count.
    public class Query1Controller : ApiController
    {
        // Define the database
        NodeOrders500Entities myDB = new NodeOrders500Entities();

        // Get all the orders.
        public IEnumerable<Order> GetAllOrders()
        {
            return myDB.Orders;
        }

        public IEnumerable<StoreTable> GetStores()
        {
            return myDB.StoreTables;
        }
    }
}
