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
    public class DMNganhNgheRepos : BaseAPI
    {
        private string tableName = "DMNganhNghe", propName, propValue, propUpdate;

        public DMNganhNgheRepos()
        {
            PropertyInfo[] props = (new DMNganhNghe()).GetType().GetProperties().ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DMNganhNghe> GetAll()
        {
            List<DMNganhNghe> empList = this._db.Query<DMNganhNghe>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DMNganhNghe Find(int? id)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (id.HasValue)
            {
                string query = "SELECT Id FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DMNganhNghe>(query).SingleOrDefault();
            }
            else
            {
                return new DMNganhNghe();
            }
        }
        public DMNganhNghe Find(string nn)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (!string.IsNullOrEmpty(nn))
            {
                nn = nn.Trim();
                string query = "SELECT Id FROM " + tableName + " WHERE Ten like N'%" + nn + "%'";
                return this._db.Query<DMNganhNghe>(query).SingleOrDefault();
            }
            else
            {
                return new DMNganhNghe();
            }
        }
        public DMNganhNghe Add(DMNganhNghe DMNganhNghe)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); ";// + "SELECT CAST(SCOPE_IDENTITY() as int)";
            this._db.Query<int>(sqlQuery, DMNganhNghe);
            //DMNganhNghe.Id = DMNganhNgheId;
            return DMNganhNghe;
        }

        public DMNganhNghe Update(DMNganhNghe DMNganhNghe)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DMNganhNghe);
            return DMNganhNghe;
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
            return GetAll().Any(x => x.Title == ten && x.ID != id);
        }
    }
}