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
    public class DNTagRepos : BaseAPI
    {
        private string tableName = "DNTag", propName, propValue, propUpdate;

        public DNTagRepos()
        {
            PropertyInfo[] props = (new DNTag()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DNTag> GetAll()
        {
            List<DNTag> empList = this._db.Query<DNTag>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DNTag Find(int? id)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (id.HasValue)
            {
                string query = "SELECT Id FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DNTag>(query).SingleOrDefault();
            }
            else
            {
                return new DNTag();
            }
        }
        public DNTag Find(int? dnID, int? tagID)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (dnID.HasValue && tagID.HasValue)
            {
                string query = "SELECT Id FROM " + tableName + " WHERE DoanhNghiepId = " + dnID + " And TagId = " + tagID;
                return this._db.Query<DNTag>(query).SingleOrDefault();
            }
            else
            {
                return new DNTag();
            }
        }

        public DNTag Add(DNTag DNTag)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DNTagId = this._db.Query<int>(sqlQuery, DNTag).Single();
            //DNTag.Id = DNTagId;
            return DNTag;
        }

        public DNTag Update(DNTag DNTag)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DNTag);
            return DNTag;
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