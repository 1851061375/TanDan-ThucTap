using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class CarDetailsController : ApiController
    {
        [HttpGet]
        public IEnumerable<CarsStock> Get(int id)
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();
            List<CarsStock> li = new List<CarsStock>();
            if (id == 1)
            {
                ST.Name = "Maruti Waganor";
                ST.Price = "4 Lakh";
                ST.Model = "VXI";
                ST.Color = "Brown";
                li.Add(ST);
            }
            else
            {
                ST1.Name = "Maruti Swift";
                ST1.Price = "5 Lakh";
                ST1.Model = "VXI";
                ST1.Color = "RED";
                li.Add(ST1);
            }
            return li;
        }

        [HttpGet]
        public IEnumerable<CarsStock> GetAllcarDetails()
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();
            List<CarsStock> li = new List<CarsStock>();

            ST.Name = "Maruti Waganor";
            ST.Price = "4 Lakh";
            ST.Model = "VXI";
            ST.Color = "Brown";

            ST1.Name = "Maruti Swift";
            ST1.Price = "5 Lakh";
            ST1.Model = "VXI";
            ST1.Color = "RED";

            li.Add(ST);
            li.Add(ST1);
            return li;
        }

        [HttpPut]
        public void Put(int id, string value)
        {

        }
        [HttpPost]
        public void Post(string value)
        {

        }
        [HttpDelete]
        public void Delete(int id)
        {

        }
    }
}
