using FruitFamily.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FruitFamily.DataAccess
{
    public class FruitFamilyDataAccess : IFruitFamilyDataAccess
    {
        public IConfiguration configuration { get; }
        string strConn = "";
        SqlConnection conn ;
        SqlCommand cmd ;
        SqlDataAdapter ad;
        //public readonly IFruitFamilyDataAccess fruitFamilyDataAccess;
        public FruitFamilyDataAccess(IConfiguration config)
        {
            configuration = config;
            strConn = configuration.GetConnectionString("connectionString");
            conn = new SqlConnection(strConn);
        }

        /// <summary>
        /// GetAllFruitsData
        /// </summary>
        /// <returns> List<FruitFamilyModel> </returns>
        public List<FruitFamilyModel> GetAllFruitsData()
        {
            List<FruitFamilyModel> listFruit = new List<FruitFamilyModel>();
            conn.Open();
            DataSet ds = new DataSet();
            string sqlCmd = "select * from FruitFamily";

            try
            {
                cmd = new SqlCommand(sqlCmd, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    FruitFamilyModel fruitFamilyModel = new FruitFamilyModel();
                    fruitFamilyModel.Id = Convert.ToInt32(rdr["Id"]);
                    fruitFamilyModel.Name = Convert.ToString(rdr["Name"]);
                    fruitFamilyModel.Genus = Convert.ToString(rdr["Genus"]);
                    fruitFamilyModel.FruitOrder = Convert.ToString(rdr["FruitOrder"]);
                    fruitFamilyModel.Family = Convert.ToString(rdr["Family"]);

                    Nutrition nutrition = new Nutrition();
                    nutrition.Fat = Convert.ToDouble(rdr["Fat"]);
                    nutrition.Carbohydrates = Convert.ToDouble(rdr["Carbohydrates"]);
                    nutrition.Protein = Convert.ToDouble(rdr["Protein"]);
                    nutrition.Calories = Convert.ToDouble(rdr["Calories"]);
                    nutrition.Sugar = Convert.ToDouble(rdr["Sugar"]);
                    fruitFamilyModel.Nutrition = nutrition;
                    listFruit.Add(fruitFamilyModel);
                }
            }
            catch (Exception ex)
            {
                
            }
            return listFruit;
        }

        /// <summary>
        /// GetFruitFamilyData
        /// </summary>
        /// <param name="fruitRequestModel"></param>
        /// <returns>FruitFamilyModel</returns>
        public FruitFamilyModel GetFruitFamilyData(string family)
        {
            FruitFamilyModel fruitFamilyModel = new FruitFamilyModel();
            conn.Open();
            DataSet ds = new DataSet();
            string sqlCmd = "select * from FruitFamily where Family= '"+family+"' ";

            try
            {
                cmd = new SqlCommand(sqlCmd, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                   
                    fruitFamilyModel.Id = Convert.ToInt32(rdr["Id"]);
                    fruitFamilyModel.Name = Convert.ToString(rdr["Name"]);
                    fruitFamilyModel.Genus = Convert.ToString(rdr["Genus"]);
                    fruitFamilyModel.FruitOrder = Convert.ToString(rdr["FruitOrder"]);
                    fruitFamilyModel.Family = Convert.ToString(rdr["Family"]);

                    Nutrition nutrition = new Nutrition();
                    nutrition.Fat = Convert.ToDouble(rdr["Fat"]);
                    nutrition.Carbohydrates = Convert.ToDouble(rdr["Carbohydrates"]);
                    nutrition.Protein = Convert.ToDouble(rdr["Protein"]);
                    nutrition.Calories = Convert.ToDouble(rdr["Calories"]);
                    nutrition.Sugar = Convert.ToDouble(rdr["Sugar"]);
                    fruitFamilyModel.Nutrition = nutrition;
                }
            }
            catch (Exception ex)
            {

            }
            return fruitFamilyModel;
        }
    }
}
