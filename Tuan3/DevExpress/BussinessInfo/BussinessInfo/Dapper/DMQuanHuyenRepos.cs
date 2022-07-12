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
    public class DMQuanHuyenRepos : BaseAPI
    {
        private string tableName = "DMQuanHuyen", propName, propValue, propUpdate;

        public DMQuanHuyenRepos()
        {
            PropertyInfo[] props = (new DMQuanHuyen()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DMQuanHuyen> GetAll()
        {
            List<DMQuanHuyen> empList = this._db.Query<DMQuanHuyen>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DMQuanHuyen Find(int? id)
        {
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DMQuanHuyen>(query).SingleOrDefault();
            }
            else
            {
                return new DMQuanHuyen();
            }
        }
        public DMQuanHuyen Find(string ten)
        {
            if (!string.IsNullOrEmpty(ten))
            {
                string query = "SELECT * FROM " + tableName + " WHERE Ten like N'%" + ten + "%'";
                return this._db.Query<DMQuanHuyen>(query).SingleOrDefault();
            }
            else
            {
                return new DMQuanHuyen();
            }
        }

        public DMQuanHuyen Add(DMQuanHuyen DMQuanHuyen)
        {
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DMQuanHuyenId = this._db.Query<int>(sqlQuery, DMQuanHuyen).Single();
            DMQuanHuyen.Id = DMQuanHuyenId;
            return DMQuanHuyen;
        }

        public DMQuanHuyen Update(DMQuanHuyen DMQuanHuyen)
        {
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DMQuanHuyen);
            return DMQuanHuyen;
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