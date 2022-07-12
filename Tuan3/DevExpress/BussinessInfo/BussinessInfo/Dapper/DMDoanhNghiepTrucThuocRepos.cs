using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using BussinessInfo.Models;
using System.Reflection;

namespace BussinessInfo.Dapper
{
    public class DMDoanhNghiepTrucThuocRepos : BaseAPI
    {
        private string tableName = "DMDoanhNghiepTrucThuoc", propName, propValue, propUpdate;

        public DMDoanhNghiepTrucThuocRepos()
        {
            PropertyInfo[] props = (new DMDoanhNghiepTrucThuoc()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DMDoanhNghiepTrucThuoc> GetAll()
        {
            List<DMDoanhNghiepTrucThuoc> empList = this._db.Query<DMDoanhNghiepTrucThuoc>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DMDoanhNghiepTrucThuoc Find(int? id)
        {
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DMDoanhNghiepTrucThuoc>(query).SingleOrDefault();
            }
            else
            {
                return new DMDoanhNghiepTrucThuoc();
            }
        }
        public DMDoanhNghiepTrucThuoc Find(string dntt)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (!string.IsNullOrEmpty(dntt))
            {
                dntt = dntt.Trim();
                string query = "SELECT Id FROM " + tableName + " WHERE Title = N'" + dntt + "'";
                return this._db.Query<DMDoanhNghiepTrucThuoc>(query).SingleOrDefault();
            }
            else
            {
                return new DMDoanhNghiepTrucThuoc();
            }
        }

        public DMDoanhNghiepTrucThuoc Add(DMDoanhNghiepTrucThuoc DMDoanhNghiepTrucThuoc)
        {
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DMDoanhNghiepTrucThuocId = this._db.Query<int>(sqlQuery, DMDoanhNghiepTrucThuoc).Single();
            DMDoanhNghiepTrucThuoc.Id = DMDoanhNghiepTrucThuocId;
            return DMDoanhNghiepTrucThuoc;
        }

        public DMDoanhNghiepTrucThuoc Update(DMDoanhNghiepTrucThuoc DMDoanhNghiepTrucThuoc)
        {
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DMDoanhNghiepTrucThuoc);
            return DMDoanhNghiepTrucThuoc;
        }

        public void Delete(int id)
        {
            var sqlQuery = ("Delete From " + tableName + " Where Id = " + id + "");
            this._db.Execute(sqlQuery);
        }

        public void DeleteItems(string ids)
        {
            var sqlQuery = "";
            foreach (var id in ids.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (string.IsNullOrEmpty(sqlQuery))
                    sqlQuery = "Id = " + id;
                else
                    sqlQuery += " or Id = " + id;
            }
            sqlQuery = "Delete From " + tableName + " Where " + sqlQuery;
            this._db.Execute(sqlQuery);
        }

        public bool IsExisted(string ten, int id)
        {
            return GetAll().Any(x => x.Title == ten && x.Id != id);
        }
    }
}