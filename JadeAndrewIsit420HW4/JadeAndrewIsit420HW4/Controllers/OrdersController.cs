using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JadeAndrewIsit420HW4.Controllers
{
    public class OrdersController : ApiController
    {
        NodeOrdersDBEntities myDB = new NodeOrdersDBEntities();

        List<OrderDto> myOrders = new List<OrderDto>();


        public IEnumerable<OrderDto> GetAllOrders()
        {
            foreach (Order ord in myDB.Orders)
            {
                OrderDto myOrder = new OrderDto(ord.ordersID, ord.storeID, ord.salesPersonID, ord.cdID, ord.pricePaid, ord.dayPurch, ord.hourPurch);
                myOrders.Add(myOrder);
            }
            
            return myOrders;
        }

    }

    public class OrderDto
    {
        public OrderDto(int pOrdersID, int pStoreID, int pSalesPersonID, int pCdID, int pPricePaid, int pDayPurch, int pHourPurch)
        {
            dtoOrdersID = pOrdersID;
            dtoStoreID = pStoreID;
            dtoSalesPersonID = pSalesPersonID;
            dtoCdID = pCdID;
            dtoPricePaid = pPricePaid;
            dtoDayPurch = pDayPurch;
            dtoHourPurch = pHourPurch;
        }
        public int dtoOrdersID { get; set; }
        public int dtoStoreID { get; set; }
        public int dtoSalesPersonID { get; set; }
        public int dtoCdID { get; set; }
        public int dtoPricePaid { get; set; }
        public int dtoDayPurch { get; set; }
        public int dtoHourPurch { get; set; }
    }
}

