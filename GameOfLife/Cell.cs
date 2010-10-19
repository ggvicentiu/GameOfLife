namespace GameOfLife
{
    public class  Cell
    {
        public Cell(Coordinate x, Coordinate y)
        {
            Position = new Position(x.Value(),y.Value());
        }

        public Position Position{ get; private set;}
        public State State { get; set;}
        public int LiveNeighbours
        {
            get; set;
        }

        public State ChangeStateTo(State newState)
        {
            State = newState;
            return State;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == typeof (Cell) && Equals((Cell) obj);
        }

        public bool Equals(Cell other)
        {
            if (ReferenceEquals(null, other)) return false;
            return ReferenceEquals(this, other) || Equals(other.Position, Position);
        }

        public override int GetHashCode()
        {
            return (Position != null ? Position.GetHashCode() : 0);
        }
    }
}