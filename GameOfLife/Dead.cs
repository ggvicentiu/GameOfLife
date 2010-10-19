namespace GameOfLife
{
    public class Dead : State
    {
        public Dead(Cell cell)
            : base(cell)
        {
        }


        public override State NextState()
        {
            return Cell.LiveNeighbours == 3 ? (State) new Alive(Cell) : this;
        }

        public override string ToString()
        {
            return "dead";
        }
    }
}