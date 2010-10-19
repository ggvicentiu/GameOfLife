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
            const int x = 20; 
            const int y = 20;
            var aliveCells = new List<Cell>();
            for(var i = 0; i<8;i++)
                for (var ii = 0; ii < 15; ii++)
                {
                    aliveCells.Add(new Cell(i,ii));
                }
            return new Map(x, y, aliveCells);
        }
    }
}
