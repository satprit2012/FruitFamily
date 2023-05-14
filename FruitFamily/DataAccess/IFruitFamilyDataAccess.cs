using FruitFamily.Model;

namespace FruitFamily.DataAccess
{
    public interface IFruitFamilyDataAccess
    {
        /// <summary>
        /// GetAllFruitsData
        /// </summary>
        /// <returns>FruitFamilyModel</returns>
        public List<FruitFamilyModel> GetAllFruitsData();

        /// <summary>
        /// GetFruitFamily
        /// </summary>
        /// <param name="fruitFamily"></param>
        /// <returns>FruitFamilyModel</returns>
        public FruitFamilyModel GetFruitFamilyData(string fruitFamily);
    }
}
