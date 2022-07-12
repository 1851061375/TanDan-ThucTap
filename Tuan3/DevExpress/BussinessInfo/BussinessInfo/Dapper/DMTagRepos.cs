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
    public class DMTagRepos : BaseAPI
    {
        private string tableName = "DMTag", propName, propValue, propUpdate;

        public DMTagRepos()
        {
            PropertyInfo[] props = (new DMTag()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DMTag> GetAll()
        {
            List<DMTag> empList = this._db.Query<DMTag>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DMTag Find(int? id)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DMTag>(query).SingleOrDefault();
            }
            else
            {
                return new DMTag();
            }
        }
        public DMTag Find(string title)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (!string.IsNullOrEmpty(title))
            {
                string query = "SELECT Id FROM " + tableName + " WHERE Tag = N'" + title.Trim() + "'";
                var lstDMTag = this._db.Query<DMTag>(query);
                if (lstDMTag.Any())
                {
                    return lstDMTag.SingleOrDefault();
                }
                else return new DMTag();
            }
            else
            {
                return new DMTag();
            }
        }
        public DMTag Add(DMTag DMTag)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DMTagId = this._db.Query<int>(sqlQuery, DMTag).Single();
            DMTag.Id = DMTagId;
            return DMTag;
        }

        public DMTag Update(DMTag DMTag)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DMTag);
            return DMTag;
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
            return GetAll().Any(x => x.Tag == ten && x.Id != id);
        }
    }
}