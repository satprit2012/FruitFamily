using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Data;
using System.IO;
using FruitFamily.Service;
using FruitFamily.Model;
using FruitFamily.DataAccess;

namespace FruitFamily.Service
{

    public class FruitFamilyService : IFruitFamilyService
    {
        private readonly IFruitFamilyDataAccess fruitFamilyDataAccess;
        public FruitFamilyService(IFruitFamilyDataAccess dataaccess)
        {
            fruitFamilyDataAccess = dataaccess;
        }
        /// <summary>
        /// GetAllFruits
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>List<FruitDetails></returns>
        public List<FruitFamilyModel> GetAllFruits()
        {
            List<FruitFamilyModel> fruitsList = new List<FruitFamilyModel>();
            try
            {
                fruitsList = fruitFamilyDataAccess.GetAllFruitsData();
            }
            catch (Exception ex)
            {

            }
            return fruitsList;
        }

        /// <summary>
        /// GetFruitFamily
        /// </summary>
        /// <param name="familyName"></param>
        /// <returns>FruitDetails</returns>
        public FruitFamilyModel GetFruitFamily(FruitRequestModel fruitRequestModel)
        {
            FruitFamilyModel fruit = new FruitFamilyModel();
            try
            {
                fruit = fruitFamilyDataAccess.GetFruitFamilyData(fruitRequestModel.fruitFamily);
            }
            catch (Exception ex)
            {

            }
            return fruit;
        }
    }
}
