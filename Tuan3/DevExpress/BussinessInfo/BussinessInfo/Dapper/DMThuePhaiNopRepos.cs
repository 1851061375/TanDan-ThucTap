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
    public class DMThuePhaiNopRepos : BaseAPI
    {
        private string tableName = "DMThuePhaiNop", propName, propValue, propUpdate;

        public DMThuePhaiNopRepos()
        {
            PropertyInfo[] props = (new DMThuePhaiNop()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DMThuePhaiNop> GetAll()
        {
            List<DMThuePhaiNop> empList = this._db.Query<DMThuePhaiNop>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DMThuePhaiNop Find(int? id)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DMThuePhaiNop>(query).SingleOrDefault();
            }
            else
            {
                return new DMThuePhaiNop();
            }
        }

        public DMThuePhaiNop Find(string thue)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (!string.IsNullOrEmpty(thue))
            {
                string query = "SELECT Id FROM " + tableName + " WHERE Ten = N'" + thue + "'";
                var lstDM = this._db.Query<DMThuePhaiNop>(query);
                if (lstDM.Any())
                {
                    return lstDM.SingleOrDefault();
                }
                else return new DMThuePhaiNop();
            }
            else
            {
                return new DMThuePhaiNop();
            }
        }
        public DMThuePhaiNop Add(DMThuePhaiNop DMThuePhaiNop)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DMThuePhaiNopId = this._db.Query<int>(sqlQuery, DMThuePhaiNop).Single();
            DMThuePhaiNop.Id = DMThuePhaiNopId;
            return DMThuePhaiNop;
        }

        public DMThuePhaiNop Update(DMThuePhaiNop DMThuePhaiNop)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DMThuePhaiNop);
            return DMThuePhaiNop;
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
            return GetAll().Any(x => x.Ten == ten && x.Id != id);
        }
    }
}