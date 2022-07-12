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
    public class DMCoQuanRepos : BaseAPI
    {
        private string tableName = "DMCoQuan", propName, propValue, propUpdate;

        public DMCoQuanRepos()
        {
            PropertyInfo[] props = (new DMCoQuan()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DMCoQuan> GetAll()
        {
            List<DMCoQuan> empList = this._db.Query<DMCoQuan>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DMCoQuan Find(int? id)
        {
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DMCoQuan>(query).SingleOrDefault();
            }
            else
            {
                return new DMCoQuan();
            }
        }
        public DMCoQuan Find(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                string query = "SELECT * FROM " + tableName + " WHERE Ten like N'%" + title + "%'";
                return this._db.Query<DMCoQuan>(query).SingleOrDefault();
            }
            else
            {
                return new DMCoQuan();
            }
        }

        public DMCoQuan Add(DMCoQuan DMCoQuan)
        {
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DMCoQuanId = this._db.Query<int>(sqlQuery, DMCoQuan).Single();
            DMCoQuan.Id = DMCoQuanId;
            return DMCoQuan;
        }

        public DMCoQuan Update(DMCoQuan DMCoQuan)
        {
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DMCoQuan);
            return DMCoQuan;
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