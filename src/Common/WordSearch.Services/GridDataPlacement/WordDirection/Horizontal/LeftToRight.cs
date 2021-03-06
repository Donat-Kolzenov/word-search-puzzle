namespace WordSearch.Services.GridDataPlacement.WordDirection.Horizontal
{
    using WordSearch.Services.GridDataPlacement.WordDirection.Interfaces;

    public class LeftToRight : IWordDirection
    {
        public void MoveOnGrid(ref int row, ref int column)
        {
            row += MovementState.None;
            column += MovementState.ShiftOneCell;
        }
    }
}
