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
    public class DMDiaBanRepos : BaseAPI
    {
        private string tableName = "DMDiaBan", propName, propValue, propUpdate;

        public DMDiaBanRepos()
        {
            PropertyInfo[] props = (new DMDiaBan()).GetType().GetProperties().ToArray();
            propName = string.Join(", ", props.Where(x => x.CustomAttributes.Where(y => y.AttributeType.FullName.Contains("NotMapped")).Count() == 0).Select(x => x.Name));
            propValue = string.Join(", ", props.Where(x => x.CustomAttributes.Where(y => y.AttributeType.FullName.Contains("NotMapped")).Count() == 0).Select(x => "@" + x.Name));
            propUpdate = string.Join(", ", props.Where(x => x.CustomAttributes.Where(y => y.AttributeType.FullName.Contains("NotMapped")).Count() == 0).Select(x => x.Name + " = @" + x.Name));
        }
        public List<DMDiaBan> GetAll()
        {
            List<DMDiaBan> empList = this._db.Query<DMDiaBan>("SELECT * FROM " + tableName).ToList();
            return empList;
        }
        public List<DMDiaBan> GetAll(List<string> fieldSelect)
        {
            List<DMDiaBan> empList = this._db.Query<DMDiaBan>("SELECT " + string.Join(",", fieldSelect.ToArray()) + " FROM " + tableName).ToList();
            return empList;
        }
        public DMDiaBan Find(int? id)
        {
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + "";
                return this._db.Query<DMDiaBan>(query).SingleOrDefault();
            }
            else
            {
                return new DMDiaBan();
            }
        }
        public DMDiaBan Find(int? id, int type)
        {
            if (id.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE Id = " + id + " And Type = "+ type;
                return this._db.Query<DMDiaBan>(query).SingleOrDefault();
            }
            else
            {
                return new DMDiaBan();
            }
        }
        public List<DMDiaBan> FindXaPhuongFromTinhThanh(int? idTinhThanh, int type)
        {
            if (idTinhThanh.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE TinhThanhID = " + idTinhThanh + " And Type = " + type;
                return this._db.QueryMultiple(query).Read<DMDiaBan>().ToList();
            }
            else
            {
                return new List<DMDiaBan>();
            }
        }

        public List<DMDiaBan> FindQuanHuyenFromTinhThanh(int? idTinhThanh, int type)
        {
            if (idTinhThanh.HasValue)
            {
                string query = "SELECT * FROM " + tableName + " WHERE TinhThanhID = " + idTinhThanh + " And Type = " + type;
                return this._db.QueryMultiple(query).Read<DMDiaBan>().ToList();
            }
            else
            {
                return new List<DMDiaBan>();
            }
        }
        public List<DMDiaBan> FindXaPhuongFromTinhQuan(string tinh,string quan, int type)
        {
            if (!string.IsNullOrEmpty(tinh)&&!string.IsNullOrEmpty(quan))
            {
                string query = "SELECT * FROM " + tableName + " WHERE TinhThanhTitle = N'" + tinh + "' And QuanHuyenTitle = N'" + quan + "' And Type = " + type;
                return this._db.QueryMultiple(query).Read<DMDiaBan>().ToList();
            }
            else
            {
                return new List<DMDiaBan>();
            }
        }
        public DMDiaBan Find(string ten)
        {
            if (!string.IsNullOrEmpty(ten))
            {
                string query = "SELECT * FROM " + tableName + " WHERE Ten like N'%" + ten + "%'";
                return this._db.Query<DMDiaBan>(query).SingleOrDefault();
            }
            else
            {
                return new DMDiaBan();
            }
        }
        public DMDiaBan Add(DMDiaBan DMDiaBan)
        {
            var sqlQuery = "INSERT INTO " + tableName + " (" + propName + ") VALUES(" + propValue + "); ";// + "SELECT CAST(SCOPE_IDENTITY() as int)";
            this._db.Query<int>(sqlQuery, DMDiaBan);
            //DMDiaBan.Id = DMDiaBanId;
            return DMDiaBan;
        }

        public DMDiaBan Update(DMDiaBan DMDiaBan)
        {
            var sqlQuery = "UPDATE " + tableName + " SET " + propUpdate + " WHERE Id = @Id";
            this._db.Execute(sqlQuery, DMDiaBan);
            return DMDiaBan;
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

        public bool IsExisted(string ten)
        {
            return GetAll().Any(x => x.Title == ten);
        }
    }
}