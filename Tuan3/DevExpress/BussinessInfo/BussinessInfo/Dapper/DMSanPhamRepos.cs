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
    public class DMSanPhamRepos : BaseAPI
    {
        private string tableName = "DMSanPham", propName, propValue, propUpdate;

        public DMSanPhamRepos()
        {
            PropertyInfo[] props = (new DMSanPham()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DMSanPham> GetAll()
        {
            List<DMSanPham> empList = this._db.Query<DMSanPham>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DMSanPham Find(int? id)
        {
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DMSanPham>(query).SingleOrDefault();
            }
            else
            {
                return new DMSanPham();
            }
        }

        public DMSanPham Add(DMSanPham DMSanPham)
        {
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DMSanPhamId = this._db.Query<int>(sqlQuery, DMSanPham).Single();
            DMSanPham.Id = DMSanPhamId;
            return DMSanPham;
        }

        public DMSanPham Update(DMSanPham DMSanPham)
        {
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DMSanPham);
            return DMSanPham;
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