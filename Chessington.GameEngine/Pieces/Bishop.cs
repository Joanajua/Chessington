using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMove = new List<Square>();

            if (Player == Player.White)
            {
                var currentSquare = board.FindPiece(this);

                if (currentSquare.Row == 7)
                {
                    availableMove.Add(Square.At(4, currentSquare.Col));
                    availableMove.Add(Square.At(5, currentSquare.Col));

                }

                else
                {
                    availableMove.Add(Square.At(currentSquare.Row - 1, currentSquare.Col));
                }


            }
            else
            {

                var currentSquare = board.FindPiece(this);

                if (currentSquare.Row == 1)
                {
                    availableMove.Add(Square.At(3, currentSquare.Col));
                    availableMove.Add(Square.At(2, currentSquare.Col));
                }

                else
                {
                    availableMove.Add(Square.At(currentSquare.Row + 1, currentSquare.Col));
                }

            }

            return availableMove;
            

        }
    }
}