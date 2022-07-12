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
    public class DMPhuongXaRepos : BaseAPI
    {
        private string tableName = "DMPhuongXa", propName, propValue, propUpdate;

        public DMPhuongXaRepos()
        {
            PropertyInfo[] props = (new DMPhuongXa()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DMPhuongXa> GetAll()
        {
            List<DMPhuongXa> empList = this._db.Query<DMPhuongXa>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DMPhuongXa Find(int? id)
        {
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DMPhuongXa>(query).SingleOrDefault();
            }
            else
            {
                return new DMPhuongXa();
            }
        }
        public DMPhuongXa Find(string ten)
        {
            if (!string.IsNullOrEmpty(ten))
            {
                string query = "SELECT * FROM " + tableName + " WHERE Ten like N'%" + ten + "%'";
                return this._db.Query<DMPhuongXa>(query).SingleOrDefault();
            }
            else
            {
                return new DMPhuongXa();
            }
        }
        public DMPhuongXa Add(DMPhuongXa DMPhuongXa)
        {
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DMPhuongXaId = this._db.Query<int>(sqlQuery, DMPhuongXa).Single();
            DMPhuongXa.Id = DMPhuongXaId;
            return DMPhuongXa;
        }

        public DMPhuongXa Update(DMPhuongXa DMPhuongXa)
        {
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DMPhuongXa);
            return DMPhuongXa;
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