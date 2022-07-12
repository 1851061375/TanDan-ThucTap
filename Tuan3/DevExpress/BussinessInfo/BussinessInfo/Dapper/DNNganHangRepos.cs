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
    public class DNNganHangRepos : BaseAPI
    {
        private string tableName = "DNNganHang", propName, propValue, propUpdate;

        public DNNganHangRepos()
        {
            PropertyInfo[] props = (new DNNganHang()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DNNganHang> GetAll()
        {
            List<DNNganHang> empList = this._db.Query<DNNganHang>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DNNganHang Find(int? id)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (id.HasValue)
            {
                string query = "SELECT Id FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DNNganHang>(query).SingleOrDefault();
            }
            else
            {
                return new DNNganHang();
            }
        }

        public DNNganHang Add(DNNganHang DNNganHang)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DNNganHangId = this._db.Query<int>(sqlQuery, DNNganHang).Single();
            DNNganHang.Id = DNNganHangId;
            return DNNganHang;
        }

        public DNNganHang Update(DNNganHang DNNganHang)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DNNganHang);
            return DNNganHang;
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