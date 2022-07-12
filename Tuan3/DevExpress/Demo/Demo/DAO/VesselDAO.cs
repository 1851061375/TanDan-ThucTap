using Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAO
{
    public class VesselDAO
    {
        private MyDbContext db = null;
        public VesselDAO() { db = new MyDbContext(); }

        public long checkExist(Vessel entity)
        {
            Vessel vessel = null;
            if (!String.IsNullOrEmpty(entity.IMOID) && entity.IMOID != "&nbsp;")
                vessel = db.Vessels.Where(t => t.IMOID == entity.IMOID).FirstOrDefault();
            else if (!String.IsNullOrEmpty(entity.MMSI))
                vessel = db.Vessels.Where(t => t.MMSI == entity.MMSI).FirstOrDefault();
            else if (!String.IsNullOrEmpty(entity.RegistrationNumber))
                vessel = db.Vessels.Where(t => t.RegistrationNumber == entity.RegistrationNumber).FirstOrDefault();
            else
                vessel = db.Vessels.Where(t => t.Name == entity.Name).FirstOrDefault();
            return (vessel != null) ? vessel.ID : -1;
        }

        public long insertToDB(Vessel entity)
        {
            db.Vessels.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public long updateToDB(Vessel entity)
        {
            Vessel vessel = db.Vessels.Where(t => t.IMOID == entity.IMOID ||
                                                  t.MMSI == entity.MMSI).
                                                  FirstOrDefault();
            vessel.Name = entity.Name;
            vessel.CallSign = entity.CallSign;
            vessel.MMSI = entity.MMSI;
            vessel.IMOID = entity.IMOID;
            vessel.Flag = entity.Flag;
            vessel.Length = entity.Length;
            vessel.Beam = entity.Beam;
            vessel.DeadWeightTonnage = entity.DeadWeightTonnage;
            vessel.VesselType = entity.VesselType;
            vessel.Images = entity.Images;
            vessel.LatestPort = entity.LatestPort;
            vessel.Url = processUrl(vessel.Url, entity.Url);
            
            db.SaveChanges();
            return vessel.ID;

        }
        // Xử lý Url
        public string processUrl(string oldUrl, string newUrl)
        {
            string result = "";
            List<string> urlList = new List<string>();
            urlList = oldUrl.Split(';').ToList();

            if (!urlList.Any(s => s.Contains(newUrl)))
                urlList.Add(newUrl);

            for (int i = 0; i < urlList.Count - 1; i++)
                result += urlList[i] + ";";
            result += urlList[urlList.Count - 1];
            return result;
        }
    }
}
