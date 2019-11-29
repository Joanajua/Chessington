using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var expectedMoves = new List<Square>();

            for (var i = 0; i < 8; i++)
                expectedMoves.Add(Square.At(4, i));

            for (var i = 0; i < 8; i++)
                expectedMoves.Add(Square.At(i, 4));

            //Get rid of our starting location.
            expectedMoves.RemoveAll(s => s == Square.At(4, 4));

            

            for (var i = 0; i < 8; i++)
                expectedMoves.Add(Square.At(i, i));

            for (var i = 1; i < 8; i++)
                expectedMoves.Add(Square.At(i, 8 - i));

            //Get rid of our starting location.
            expectedMoves.RemoveAll(s => s == Square.At(4, 4));

            
            return expectedMoves;
        }
        
    }
}