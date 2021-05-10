using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JadeAndrewIsit420HW4.Controllers
{
    public class Query3Controller : ApiController
    {
        NodeOrdersDBEntities myDB = new NodeOrdersDBEntities();

        List<OrderDto> myOrders = new List<OrderDto>();
        List<StoreDto> myStores = new List<StoreDto>();

        /* populates the dropdown menu at app launch */
        public IHttpActionResult GetStores()
        {
            foreach (StoreTable s in myDB.StoreTables)
            {
                StoreDto myStore = new StoreDto(s.storeID, s.City, s.State, s.NumberEmployees);
                myStores.Add(myStore);
            }

            return Json(myStores);
        }

        /* finds the sum of sales in year for selected store */ 
        public IHttpActionResult GetSalesByStore(int id)
        {
            int storeSalesTotal = 0;
            foreach (Order ord in myDB.Orders)
            {
                if (ord.storeID == id)
                {
                    storeSalesTotal += ord.pricePaid;
                }
            }
            return Json(storeSalesTotal);
        }
    }

    public class StoreDto
    {
        public StoreDto(int pStoreID, string pCity, string pState, int pNumberEmployees)
        {
            dtoStoreID = pStoreID;
            dtoCity = pCity;
            dtoState = pState;
            dtoNumberEmployees = pNumberEmployees;
        }
        public int dtoStoreID { get; set; }
        public string dtoCity { get; set; }
        public string dtoState { get; set; }
        public int dtoNumberEmployees { get; set; }
    }
}
