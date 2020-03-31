using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using System;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using DataModels;

namespace DAL
{
    public class DataAccess
    {

        private readonly string ConnectionStringName = "DefaultConnection";
        private IConfiguration _configuration;

        public DataAccess() { }
        public DataAccess(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        public GetInTouch1[] GetAllGetInTouch1FromDatabase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.BlogConnectionStringValue(_configuration, ConnectionStringName)))
            {

                GetInTouch1[] contacts = connection.Query<GetInTouch1>("Select * from GetInTouch order by id asc").ToArray();
                return contacts;
            }
            //throw new NotImplementedException();
            //var articles = new[] {
            //    new Article()
            //    {
            //        Author = "Donna H",
            //        Title = "My Title",
            //        Body = "This is awesome text",
            //        DateCreated = DateTime.Now
            //    },

            //    new Article() {
            //        Author = "Prof Donna Harris",
            //        Title = "My Article about Testing",
            //        Body = "Testing is cool. Everybody should learn to test.",
            //        DateCreated = DateTime.Now
            //    }
            //};

            //return articles;
        }

        public object AddGetInTouch1ToDatabase(GetInTouch1 newGetInTouch1)
        {
            string queryString = "INSERT INTO GetInTouch(Name,Email,Contact,Message,DateCreated)Values('" + newGetInTouch1.Name + "','" + newGetInTouch1.Email + "','" + newGetInTouch1.Contact + "','" + newGetInTouch1.Message + "','" + newGetInTouch1.DateCreated + "');";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.BlogConnectionStringValue(_configuration, ConnectionStringName)))
            {

                GetInTouch1[] contacts = connection.Query<GetInTouch1>(queryString).ToArray();
                return contacts;
            }
        }
    }
}

