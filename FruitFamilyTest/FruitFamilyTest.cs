
using FruitFamily.Service;
using Moq;
using FruitFamily.Controllers;
using FruitFamily.Model;
using UnitConversionTest.Test_Data;
using FruitFamily.DataAccess;

namespace FruitFamilyTest
{
    public class FruitFamilyTest
    {
        //private FruitFamilyInfoController controller;
        //TestData TestData = new TestData();
        //private  Mock<IFruitFamilyService> mockfruitFamilyService;
        //private  FruitFamilyService fruitFamilyService;
        //private  Mock<IFruitFamilyDataAccess> mockfruitFamilyDataAccess;
        //private  FruitFamilyDataAccess fruitFamilyDataAccess;

        //[SetUp]
        //public void Setup()
        //{
        //    mockfruitFamilyDataAccess = new Mock<IFruitFamilyDataAccess>();
        //    mockfruitFamilyService = new Mock<IFruitFamilyService>();
        //    fruitFamilyService = new FruitFamilyService(mockfruitFamilyDataAccess);
        //    controller = new FruitFamilyInfoController(fruitFamilyService);
        //}

        //[Test]
        //public void UnitConversionSuccess()
        //{
        //    var str = mockunitConversionService.Setup(x => x.ConvertUnit(TestData.GetUnitData()));
        //    string result = controller.UnitConversion(TestData.GetUnitData());
        //    Assert.IsNotNull(result);
        //}

        //[Test]
        //public void UnitConversionException()
        //{
        //    var str = mockunitConversionService.Setup(x => x.ConvertUnit(TestData.GetUnitData())).Throws(new Exception());
        //    string result = controller.GetAllFruits(new UnitConversionModel());
        //    Assert.IsNotNull(new Exception());
        //}

        //[Test]
        //public void UnitConversionReturnNull()
        //{
        //    var str = mockunitConversionService.Setup(x => x.ConvertUnit(TestData.GetUnitData()));
        //    string result = controller.UnitConversion(TestData.GetUnitDataNull());
        //    Assert.IsNotNull(result);
        //}

    }
}