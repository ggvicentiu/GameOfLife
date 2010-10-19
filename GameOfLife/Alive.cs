namespace GameOfLife
{
    public class Alive : State
    {
        public Alive(Cell cell)
            : base(cell)
        {
        }

        public override State NextState()
        {
            return 2 <= Cell.LiveNeighbours && Cell.LiveNeighbours <= 3 ? (State) this : new Dead(Cell);
        }

        public override string ToString()
        {
            return "live";
        }

      

    }
}