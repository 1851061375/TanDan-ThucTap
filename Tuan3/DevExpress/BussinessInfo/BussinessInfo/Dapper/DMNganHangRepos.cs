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
    public class DMNganHangRepos : BaseAPI
    {
        private string tableName = "DMNganHang", propName, propValue, propUpdate;

        public DMNganHangRepos()
        {
            PropertyInfo[] props = (new DMNganHang()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DMNganHang> GetAll()
        {
            List<DMNganHang> empList = this._db.Query<DMNganHang>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DMNganHang Find(int? id)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DMNganHang>(query).SingleOrDefault();
            }
            else
            {
                return new DMNganHang();
            }
        }
        public DMNganHang Find(string title)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (!string.IsNullOrEmpty(title))
            {
                string query = "SELECT Id FROM " + tableName + " WHERE Ten = N'" + title + "'";
                return this._db.Query<DMNganHang>(query).SingleOrDefault();
            }
            else
            {
                return new DMNganHang();
            }
        }
        public DMNganHang Add(DMNganHang DMNganHang)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DMNganHangId = this._db.Query<int>(sqlQuery, DMNganHang).Single();
            DMNganHang.Id = DMNganHangId;
            return DMNganHang;
        }

        public DMNganHang Update(DMNganHang DMNganHang)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DMNganHang);
            return DMNganHang;
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