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
    public class DNNganhNgheRepos : BaseAPI
    {
        private string tableName = "DNNganhNghe", propName, propValue, propUpdate;

        public DNNganhNgheRepos()
        {
            PropertyInfo[] props = (new DNNganhNghe()).GetType().GetProperties().Where(x => x.Name != "Id").ToArray();
            propName = string.Join(", ", props.Select(x => x.Name));
            propValue = string.Join(", ", props.Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Select(x => x.Name + " = @" + x.Name));
        }
        public List<DNNganhNghe> GetAll()
        {
            List<DNNganhNghe> empList = this._db.Query<DNNganhNghe>("SELECT * FROM " + tableName).ToList();
            return empList;
        }

        public DNNganhNghe Find(int? id)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (id.HasValue)
            {
                string query = "SELECT Id FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DNNganhNghe>(query).SingleOrDefault();
            }
            else
            {
                return new DNNganhNghe();
            }
        }
        public DNNganhNghe Find(int? dnID, int? nnID)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            if (dnID.HasValue && nnID.HasValue)
            {
                string query = "SELECT Id FROM " + tableName + " WHERE DoanhNghiepId = " + dnID + " And NganhNgheId = " + nnID;
                return this._db.Query<DNNganhNghe>(query).SingleOrDefault();
            }
            else
            {
                return new DNNganhNghe();
            }
        }

        public DNNganhNghe Add(DNNganhNghe DNNganhNghe)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var DNNganhNgheId = this._db.Query<int>(sqlQuery, DNNganhNghe).Single();
            //DNNganhNghe.Id = DNNganhNgheId;
            return DNNganhNghe;
        }

        public DNNganhNghe Update(DNNganhNghe DNNganhNghe)
        {
            if (this._db.State == ConnectionState.Closed)
                _db.Open();
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DNNganhNghe);
            return DNNganhNghe;
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