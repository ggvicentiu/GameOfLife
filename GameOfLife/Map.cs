using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    public class Map 
    {
        public List<Cell> Cells;

        public IStateFactory Factory;

        public void Tick()
        {
            foreach (var cell in Cells)
            {
                SetALiveNeighbours(cell);
                cell.State = Factory.SetNextTickLifeState(cell);
            }
        }

        private void SetALiveNeighbours(Cell cell)
        {
            var a = cell.Position.X ;
            var b = cell.Position.Y ;
            cell.LiveNeighbours = 0;

            for (var x = a -1 ;  x <= a+1; x++ )
                for (var y = b - 1; y <= b+1; y++)
                {
                    if (x==a && y == b) continue;
                    if (!AreCoordinatesOnTheMap(x, y)) continue;
                    var x1 = x;
                    var y1 = y;
                    var c1 = (Cells.Find(c => c.Position.X == x1 &&
                                              c.Position.Y == y1));
                    cell.LiveNeighbours += ((c1.State.GetType() == typeof(Alive)) ? 1 : 0);
                }
        }


        public Map(Coordinate x, Coordinate y, IEnumerable<Cell> aliveCells)
        {
            X = x.Value();
            Y = y.Value();
            Factory = new StateFactory();
            Cells = new List<Cell>((X+1) * (Y+1));
            for (var i = 0; i < X+1; i++)
                for (var j = 0; j < Y+1; j++)
                {
                    var coordinateX = new Coordinate(i);
                    var coordinateY = new Coordinate(j);
                    var cell = new Cell(coordinateX, coordinateY);
                    cell.State = (aliveCells.Contains(cell)) ? (State) new Alive(cell) : new Dead(cell);
                    Cells.Add(cell);
                }
        }

        public int Y
        {
            get;
            private set;
        }

        public int X
        {
            get;
            private set;
        }



        private bool AreCoordinatesOnTheMap(int x, int y)
        {

            return (x >= 0 && x <= X) && (y >= 0 && y <= Y);

        }
    }
}
