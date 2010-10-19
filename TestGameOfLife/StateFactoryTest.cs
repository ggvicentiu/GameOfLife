using GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestGameOfLife
{
    
    
    /// <summary>
    ///This is a test class for StateFactoryTest and is intended
    ///to contain all StateFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StateFactoryTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for SetNextTickLifeState
        ///</summary>
        [TestMethod()]
        public void SetNextTickLifeStateTest()
        {
            var target = new StateFactory();

            var cell = new Cell(1,2) {LiveNeighbours = 3};
            
            cell.State = new Alive(cell);
            
            State expectedA = new Alive(cell); 
            State actual = target.SetNextTickLifeState(cell);

            Assert.AreEqual(expectedA, actual);


            var expectedD = new Dead(cell);
            cell.LiveNeighbours = 4;
            actual = target.SetNextTickLifeState(cell);

            Assert.AreEqual(expectedD, actual);

            cell.LiveNeighbours = 1;
            actual = target.SetNextTickLifeState(cell);

            Assert.AreEqual(expectedD, actual);

            cell.LiveNeighbours = 3;
            actual = target.SetNextTickLifeState(cell);

            Assert.AreEqual(expectedA, actual);
        }
    }
}
