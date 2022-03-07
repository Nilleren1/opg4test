using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using opg1obl;
using opg4obl.Manager;

namespace opg4test
{
    [TestClass]
    public class UnitTest1
    {
        private CarManager _manager;
        [TestInitialize]
        public void Init()
        {
            _manager = new CarManager();
        }
        [TestMethod]
        public void TestType()
        {
            Assert.IsInstanceOfType(_manager.GetAll("Golf"), typeof(List<Car>));
        }

        [TestMethod]
        public void AddTest()
        {
            List<Car> list = _manager.GetAll("");
            Car c1 = new Car("Ferrari2", 234115, "hi92235");
            Car c2 = _manager.AddCar(c1);

            Assert.AreEqual(c2.Id, list[list.Count-1].Id+1);
        }

        [TestMethod]
        public void DeleteTest()
        {
            Car c1 = new Car("Ferrari2", 234115, "hi92235");
            Assert.IsNotNull(_manager.DeleteCar(c1.Id));
        }

        [TestMethod]
        public void GetbyIdTest()
        {
            Assert.AreEqual("Axios",  _manager.GetById(1).Model);
            Assert.AreEqual("af92u95",  _manager.GetById(1).LicensePlate);
            Assert.AreEqual(24050,  _manager.GetById(1).Price);
        }
    }
}
