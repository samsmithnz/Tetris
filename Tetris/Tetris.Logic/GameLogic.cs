using System;
using System.Collections.Generic;
using System.Linq;

namespace Tetris.Logic
{
    public class GameLogic
    {
        private readonly int[,] _arena;
        private readonly Dictionary<string, int[,]> _pieces;
        private int _score;
        private (int X, int Y) _playerPosition;
        private int[,] _playerMatrix;

        public GameLogic()
        {
            _arena = CreateMatrix(12, 20);
            _pieces = InitializePieces();
            ResetPlayer();
        }

        private static int[,] CreateMatrix(int w, int h)
        {
            var matrix = new int[h, w];
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    matrix[y, x] = 0;
                }
            }
            return matrix;
        }

        private static Dictionary<string, int[,]> InitializePieces()
        {
            return new Dictionary<string, int[,]>
            {
                {"T", new[,] {{0, 0, 0}, {1, 1, 1}, {0, 1, 0}}},
                {"O", new[,] {{2, 2}, {2, 2}}},
                {"L", new[,] {{0, 3, 0}, {0, 3, 0}, {0, 3, 3}}},
                {"J", new[,] {{0, 4, 0}, {0, 4, 0}, {4, 4, 0}}},
                {"I", new[,] {{0, 5, 0, 0}, {0, 5, 0, 0}, {0, 5, 0, 0}, {0, 5, 0, 0}}},
                {"S", new[,] {{0, 6, 6}, {6, 6, 0}, {0, 0, 0}}},
                {"Z", new[,] {{7, 7, 0}, {0, 7, 7}, {0, 0, 0}}}
            };
        }

        public void ResetPlayer()
        {
            var pieces = "ILJOTSZ";
            var random = new Random();
            var piece = pieces[random.Next(pieces.Length)];
            _playerMatrix = _pieces[piece];
            _playerPosition = (5, 0); // Start in the middle of the arena
        }

        // Additional methods for game logic (collision detection, rotate, move, etc.) will be implemented here.
    }
}
