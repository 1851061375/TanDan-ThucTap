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
    public class DNDoanhNghiepTrucThuocRepos : BaseAPI
    {
        private string tableName = "DNDoanhNghiepTrucThuoc", propName, propValue, propUpdate;

        public DNDoanhNghiepTrucThuocRepos()
        {
            PropertyInfo[] props = (new DNDoanhNghiepTrucThuoc()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DNDoanhNghiepTrucThuoc> GetAll()
        {
            List<DNDoanhNghiepTrucThuoc> empList = this._db.Query<DNDoanhNghiepTrucThuoc>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DNDoanhNghiepTrucThuoc Find(int? id)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DNDoanhNghiepTrucThuoc>(query).SingleOrDefault();
            }
            else
            {
                return new DNDoanhNghiepTrucThuoc();
            }
        }
        public DNDoanhNghiepTrucThuoc Find(int? dnID, int? dnttID)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (dnID.HasValue && dnttID.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE DoanhNghiepId = " + dnID + " And DoanhNghiepTrucThuocId = " + dnttID;
                return this._db.Query<DNDoanhNghiepTrucThuoc>(query).SingleOrDefault();
            }
            else
            {
                return new DNDoanhNghiepTrucThuoc();
            }
        }
        public DNDoanhNghiepTrucThuoc Find(int? dnID, int? dnttID,string qh)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (dnID.HasValue && dnttID.HasValue)
            {
                string query = "SELECT Id FROM " + tableName + " WHERE DoanhNghiepId = " + dnID + " And DoanhNghiepTrucThuocId = " + dnttID + " And QuanHe like N'%" + qh + "%'";
                return this._db.Query<DNDoanhNghiepTrucThuoc>(query).SingleOrDefault();
            }
            else
            {
                return new DNDoanhNghiepTrucThuoc();
            }
        }
        public DNDoanhNghiepTrucThuoc Add(DNDoanhNghiepTrucThuoc DNDoanhNghiepTrucThuoc)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DNDoanhNghiepTrucThuocId = this._db.Query<int>(sqlQuery, DNDoanhNghiepTrucThuoc).Single();
            DNDoanhNghiepTrucThuoc.Id = DNDoanhNghiepTrucThuocId;
            return DNDoanhNghiepTrucThuoc;
        }

        public DNDoanhNghiepTrucThuoc Update(DNDoanhNghiepTrucThuoc DNDoanhNghiepTrucThuoc)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DNDoanhNghiepTrucThuoc);
            return DNDoanhNghiepTrucThuoc;
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
    }
}