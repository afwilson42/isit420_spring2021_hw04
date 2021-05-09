using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JadeAndrewIsit420HW4.Controllers
{
    public class Query2Controller : ApiController
    {
        NodeOrdersDBEntities myDB = new NodeOrdersDBEntities();

        List<SalesPersonDto> mySalesPeople = new List<SalesPersonDto>();

        public IHttpActionResult GetSalesPeople()
        {
            foreach (SalesPersonTable sp in myDB.SalesPersonTables)
            {
                SalesPersonDto mySP = new SalesPersonDto(sp.salesPersonID, sp.FirstName, sp.LastName, sp.Age, sp.storeID);
                mySalesPeople.Add(mySP);
            }

            return Json(mySalesPeople);
        }

        // Rework this so that it returns sum total sales rather than a list of them.
        public IHttpActionResult GetSalesBySalesperson(int id)
        {
            int spSales = 0;

            foreach (Order ord in myDB.Orders)
            {
                if (ord.salesPersonID == id)
                {
                    spSales += ord.pricePaid;
                }
            }

            return Json(spSales);
        }
    }


    public class SalesPersonDto
    {
        public SalesPersonDto(int pSalesPersonID, string pFirstName, string pLastName, int pAge, int pStoreID)
        {
            dtoSalesPersonID = pSalesPersonID;
            dtoFirstName = pFirstName;
            dtoLastName = pLastName;
            dtoAge = pAge;
            dtoStoreID = pStoreID;
        }
        public int dtoSalesPersonID { get; set; }
        public string dtoFirstName { get; set; }
        public string dtoLastName { get; set; }
        public int dtoAge { get; set; }
        public int dtoStoreID { get; set; }
    }
}
