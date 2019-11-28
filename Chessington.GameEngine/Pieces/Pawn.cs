using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {

            List<Square> availableMove = new List<Square>();

            if (Player == Player.White)
            {
                availableMove.Add(Square.At(6, 0));
                return availableMove;
            }
            else
            {
                availableMove.Add(Square.At(2, 0));
                return availableMove;
            }
        }

    }
}