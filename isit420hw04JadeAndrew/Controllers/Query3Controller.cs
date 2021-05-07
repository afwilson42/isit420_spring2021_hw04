using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace isit420hw04JadeAndrew.Controllers
{
    // I want to check on the performance of a store.
    // Select a store from the dropdown. Display total amount this salesperson has sold for the year.

    public class Query3Controller : ApiController
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
