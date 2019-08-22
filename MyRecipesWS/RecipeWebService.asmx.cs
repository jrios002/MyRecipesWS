using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyRecipesWS
{
    /// <summary>
    /// Summary description for RecipeWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RecipeWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<WSRecipe> GetWebServiceRecipes()
        {
            List<WSRecipe> list = new List<WSRecipe>();
            WSRecipeLists preloadList = new WSRecipeLists();

            list = preloadList.loadPreloadedRecipes();
            list = preloadList.sortRecipeList(list);

            Debug.WriteLine(list.Count.ToString() + " total recipes transferred!");
            return list;
        }

        [WebMethod]
        public void ReadUserInformation(string UserName, string TimeStamp, string StatusMsg)
        {
            SqlConnection dbConnection = new SqlConnection(
                ConfigurationManager.ConnectionStrings["LoginDatabaseConnString"].
                ConnectionString);
            dbConnection.Open();

            SqlCommand command = dbConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO UserLoginInfoTable (UserName, TimeStamp, Status) " +
                    "VALUES (@userName, @timeStamp, @status)";
            command.Parameters.AddWithValue("@userName", UserName);
            command.Parameters.AddWithValue("@timeStamp", TimeStamp);
            command.Parameters.AddWithValue("@status", StatusMsg);

            try
            {
                command.ExecuteNonQuery();   
            }
            catch
            {
                Debug.WriteLine("Unable to add user information to database table!");
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
