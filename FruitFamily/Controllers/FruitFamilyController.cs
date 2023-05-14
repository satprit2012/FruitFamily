using Microsoft.AspNetCore.Mvc;
using FruitFamily.Model;
using FruitFamily.Service;

namespace FruitFamily.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitFamilyInfoController : ControllerBase
    {
        public readonly IFruitFamilyService IfruitFamilyService;
        public FruitFamilyInfoController(IFruitFamilyService ifruit)
        {
            IfruitFamilyService = ifruit;
        }

        /// <summary>
        /// GetAllFruits
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>list of all the fruits</returns>
      
        [HttpGet("All")]
        public List<FruitFamilyModel> All()
        {
            return IfruitFamilyService.GetAllFruits();
        }

        /// <summary>
        /// GetFruitFamily
        /// </summary>
        /// <param name="familyName"></param>
        /// <returns>return fruitdetail</returns>
        /// 
        [HttpPost("FruitDetailsByName")]
        public FruitFamilyModel FruitFamiyByName([FromBody]FruitRequestModel fruitRequestModel)
        {
            return IfruitFamilyService.GetFruitFamily(fruitRequestModel);
        }
    }
}
