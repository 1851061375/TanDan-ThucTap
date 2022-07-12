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
    public class DMTinhThanhRepos : BaseAPI
    {
        private string tableName = "DMTinhThanh", propName, propValue, propUpdate;

        public DMTinhThanhRepos()
        {
            PropertyInfo[] props = (new DMTinhThanh()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DMTinhThanh> GetAll()
        {
            List<DMTinhThanh> empList = this._db.Query<DMTinhThanh>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DMTinhThanh Find(int? id)
        {
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DMTinhThanh>(query).SingleOrDefault();
            }
            else
            {
                return new DMTinhThanh();
            }
        }
        public DMTinhThanh Find(string ten)
        {
            if (!string.IsNullOrEmpty(ten))
            {
                string query = "SELECT * FROM " + tableName + " WHERE Ten like N'%" + ten + "%'";
                return this._db.Query<DMTinhThanh>(query).SingleOrDefault();
            }
            else
            {
                return new DMTinhThanh();
            }
        }
        public DMTinhThanh Add(DMTinhThanh DMTinhThanh)
        {
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DMTinhThanhId = this._db.Query<int>(sqlQuery, DMTinhThanh).Single();
            DMTinhThanh.Id = DMTinhThanhId;
            return DMTinhThanh;
        }

        public DMTinhThanh Update(DMTinhThanh DMTinhThanh)
        {
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DMTinhThanh);
            return DMTinhThanh;
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