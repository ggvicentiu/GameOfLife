using System;

namespace GameOfLife
{
    public abstract class State
    {
        protected Cell Cell;
        protected State(Cell cell)
        {
            this.Cell = cell;
        }

        public abstract State NextState();
        public override bool Equals(object obj)
        {
            return this.ToString().Equals(obj.ToString());
        }

        public bool Equals(State other)
        {
            if (ReferenceEquals(null, other)) return false;
            return ReferenceEquals(this, other) || Equals(other.Cell, Cell);
        }

        public override int GetHashCode()
        {
            return (Cell != null ? Cell.GetHashCode() : 0);
        }
    }
}