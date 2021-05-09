using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JadeAndrewIsit420HW4.Controllers
{
    public class Query1Controller : ApiController
    {
        NodeOrdersDBEntities myDB = new NodeOrdersDBEntities();

        List<OrderDto> myOrders = new List<OrderDto>();

        List<OrderDto> myMarkups = new List<OrderDto>();

        public IHttpActionResult GetMarkupOverThirteen()
        {
            foreach (Order ord in myDB.Orders)
            {
                OrderDto myOrder = new OrderDto(ord.ordersID, ord.storeID, ord.salesPersonID, ord.cdID, ord.pricePaid, ord.dayPurch, ord.hourPurch);
                if(myOrder.dtoPricePaid > 13)
                {
                    myOrders.Add(myOrder);
                }
            }

            var query1 = from eachOrder in myOrders
                         group eachOrder by eachOrder.dtoStoreID;

            List<MyMarkupData> myMarkupList = new List<MyMarkupData>();

            foreach (var group in query1)
            {
                myMarkupList.Add(new MyMarkupData(group.Key, group.Count()));
            }

            myMarkupList.Sort(delegate (MyMarkupData a, MyMarkupData b)
            {
                if (a.Count > b.Count) return -1;
                else if (a.Count < b.Count) return 1;
                else return 0;
            });

            return Json(myMarkupList);
        }
    }

    class MyMarkupData
    {
        public MyMarkupData (int pStoreID, int pCount)
        {
            StoreID = pStoreID;
            Count = pCount;
        }
        public int StoreID { get; set; }
        public int Count { get; set; }
    }
}
