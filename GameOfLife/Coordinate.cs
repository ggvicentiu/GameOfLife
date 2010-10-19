using System;

namespace GameOfLife
{
    public class Coordinate
    {
        private readonly int m_i;
        public Coordinate(int i)
        {
            m_i = i;
        }

        public int Value()
        {
            return Math.Abs(m_i);
        }
    }
}