using FruitFamily.Model;

namespace FruitFamily.Service
{
    public interface IFruitFamilyService
    {
        /// <summary>
        /// To fetch ALl the fruits 
        /// </summary>
        /// <param name=int min,int max></param>
        /// <returns>List of all the fruits</returns>
        public List<FruitFamilyModel> GetAllFruits();

        /// <summary>
        /// GetFruitFamily
        /// </summary>
        /// <param name="familyName"></param>
        /// <returns>FruitDetails</returns>
        public FruitFamilyModel GetFruitFamily(FruitRequestModel fruitRequestModel);

    }
}
