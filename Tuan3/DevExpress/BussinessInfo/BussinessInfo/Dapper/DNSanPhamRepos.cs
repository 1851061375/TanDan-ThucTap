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
    public class DNSanPhamRepos : BaseAPI
    {
        private string tableName = "DNSanPham", propName, propValue, propUpdate;

        public DNSanPhamRepos()
        {
            PropertyInfo[] props = (new DNSanPham()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DNSanPham> GetAll()
        {
            List<DNSanPham> empList = this._db.Query<DNSanPham>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DNSanPham Find(int? id)
        {
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DNSanPham>(query).SingleOrDefault();
            }
            else
            {
                return new DNSanPham();
            }
        }

        public DNSanPham Add(DNSanPham DNSanPham)
        {
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DNSanPhamId = this._db.Query<int>(sqlQuery, DNSanPham).Single();
            DNSanPham.Id = DNSanPhamId;
            return DNSanPham;
        }

        public DNSanPham Update(DNSanPham DNSanPham)
        {
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DNSanPham);
            return DNSanPham;
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