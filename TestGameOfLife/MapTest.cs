using GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestGameOfLife
{
    
    
    /// <summary>
    ///This is a test class for MapTest and is intended
    ///to contain all MapTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MapTest
    {
        /// <summary>
        ///A test for Tick
        ///</summary>
        [TestMethod()]
        public void TickTest()
        {
            var map = GetMap();
            var target = map.Cells.Find(c => c.Position.X == 1 &&
                                  c.Position.Y == 1);
            Assert.AreEqual(target.State.GetType(), typeof(Alive));

            map.Tick();

            target = map.Cells.Find(c => c.Position.X == 1 &&
                                  c.Position.Y == 1);
            Assert.AreEqual(target.State.GetType(), typeof(Dead));
            
        }

        private static Map GetMap()
        {
            var x = new Coordinate(30); 
            var y = new Coordinate(30);
            var aliveCells = new List<Cell>();
            for(var i = 0; i<8;i++)
                for (var ii = 0; ii < 15; ii++)
                {
                    var coordX = new Coordinate(i);
                    var coordY = new Coordinate(ii);
                    aliveCells.Add(new Cell(coordX,coordY));
                }
            return new Map(x, y, aliveCells);
        }
    }
}
