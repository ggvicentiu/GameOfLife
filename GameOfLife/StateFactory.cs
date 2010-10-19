namespace GameOfLife
{
    public class StateFactory: IStateFactory
    {
        public State SetNextTickLifeState(Cell cell)
        {
            var state = cell.State;
            return cell.ChangeStateTo(state.NextState());
        }
    }
}