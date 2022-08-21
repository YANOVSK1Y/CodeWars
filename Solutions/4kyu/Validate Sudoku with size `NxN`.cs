using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions._4kyu
{
    /// <summary>
    /// Given a Sudoku data structure with size NxN, 
    /// N > 0 and √N == integer, write a method to 
    /// validate if it has been filled out correctly.Rules for validation
    /// 
    ///Data structure dimension: NxN where N > 0 and √N == integer
    ///Rows may only contain integers: 1..N(N included)
    ///Columns may only contain integers: 1..N(N included)
    ///'Little squares' (3x3 in example above) may also only contain integers: 1..N(N included)
    /// </summary>

    public class Sudoku
    {
        private int[][] board;

        public Sudoku(int[][] sudokuData)
        {
            this.board = sudokuData;
        }

        public bool IsValid()
        {
            var n = this.board.GetLength(0);
            var s = (int)Math.Sqrt(n);
            var e = s * s;
            var sum = (e * e + e) / 2;

            return Enumerable
              .Range(0, n)
              .SelectMany(i => new[]
              {
          board[i].Sum(),
          board.Sum(b => b[i]),
          board.Skip(s * (i / s)).Take(s).SelectMany(r => r.Skip(s * (i % s)).Take(s)).Sum()
              })
              .All(i => i == sum);
        }
    }
}
