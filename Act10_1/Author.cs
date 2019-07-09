using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Act10_1
{
    class Author
    {
        private SqlConnection pubConnection;
        private string connString;


        //Constructor
        public Author()
        {
            connString = "Data Source=localhost;Initial Catalog=pubs;Integrated Security=True";
            pubConnection = new SqlConnection();
            pubConnection.ConnectionString = connString;
        }

        public int CountAuthors()
        {
            try
            {
                SqlCommand pubCommand = new SqlCommand();
                pubCommand.Connection = pubConnection;
                pubCommand.CommandText = "Select Count(au id) from authors";
                pubConnection.Open();
                return (int)pubCommand.ExecuteScalar();
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                if(pubConnection != null)
                {
                    pubConnection.Close();
                }
            }
        }

        public List<string> GetAuthorList()
        {
            SqlCommand authorsCommand = new SqlCommand();
            SqlDataReader authorDataReader;
            List<string> nameList = new List<string>();

            try
            {
                authorsCommand.Connection = pubConnection;
                authorsCommand.CommandText = "Select au lname from authors";
                pubConnection.Open();
                authorDataReader = authorsCommand.ExecuteReader();

                while(authorDataReader.Read() == true)
                {
                    nameList.Add(authorDataReader.GetString(0));
                }
                return nameList;
            }
            catch(SqlException exc)
            {
                throw exc;
            }
            finally
            {
                if (pubConnection != null)
                {
                    pubConnection.Close();
                }
            }
        }

        public List<string> GetAuthorList(int royalty)
        {
            SqlCommand authorsCommand = new SqlCommand();
            SqlDataReader authorDataReader;
            List<string> nameList = new List<string>();
            SqlParameter inputParameter = new SqlParameter();

            try
            {
                authorsCommand.Connection = pubConnection;
                authorsCommand.CommandText = "SELECT au lname FROM authors";
                pubConnection.Open();
                authorDataReader = authorsCommand.ExecuteReader();

                while(authorDataReader.Read() == true)
                {
                    nameList.Add(authorDataReader.GetString(0));
                }
                return nameList;
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                if(pubConnection != null)
                {
                    pubConnection.Close();
                }
            }
        }
    }
}
