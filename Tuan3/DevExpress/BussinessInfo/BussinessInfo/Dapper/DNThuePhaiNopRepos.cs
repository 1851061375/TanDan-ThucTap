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
    public class DNThuePhaiNopRepos : BaseAPI
    {
        private string tableName = "DNThuePhaiNop", propName, propValue, propUpdate;

        public DNThuePhaiNopRepos()
        {
            PropertyInfo[] props = (new DNThuePhaiNop()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DNThuePhaiNop> GetAll()
        {
            List<DNThuePhaiNop> empList = this._db.Query<DNThuePhaiNop>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DNThuePhaiNop Find(int? id)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DNThuePhaiNop>(query).SingleOrDefault();
            }
            else
            {
                return new DNThuePhaiNop();
            }
        }
        public DNThuePhaiNop Find(int? dnID, int? thueID)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (dnID.HasValue && thueID.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE DoanhNghiepId = " + dnID + " And ThuePhaiNopId = " + thueID;
                return this._db.Query<DNThuePhaiNop>(query).SingleOrDefault();
            }
            else
            {
                return new DNThuePhaiNop();
            }
        }
        public DNThuePhaiNop Add(DNThuePhaiNop DNThuePhaiNop)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DNThuePhaiNopId = this._db.Query<int>(sqlQuery, DNThuePhaiNop).Single();
            DNThuePhaiNop.Id = DNThuePhaiNopId;
            return DNThuePhaiNop;
        }

        public DNThuePhaiNop Update(DNThuePhaiNop DNThuePhaiNop)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DNThuePhaiNop);
            return DNThuePhaiNop;
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