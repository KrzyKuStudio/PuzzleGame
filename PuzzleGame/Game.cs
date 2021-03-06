﻿using System;

namespace PuzzleGame
{
    class Game
    {
        #region private Fields
        //------------------------------------------------------
        //
        //  private Fields
        //
        //------------------------------------------------------
        int moves;
        int time;
        Puzzle puzzle;
        bool isSolved = false;
        string gameName;

        #endregion private Fields

        #region public Properties

        //------------------------------------------------------
        //
        //  public Properties
        //
        //------------------------------------------------------

        public string GameName
        {
            get { return gameName; }
        }

        public bool IsSolved
        {
            get { return isSolved; }
            set { isSolved = value; }
        }

        public int Moves
        {
            get { return moves; }
            set { moves = value; }
        }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public Puzzle Puzzle
        {
            get { return puzzle; }
        }
        #endregion public Properties

        #region Constructors

        //------------------------------------------------------
        //
        //  Constructors
        //
        //------------------------------------------------------
        /// <summary>
        /// Initialize game puzzle
        /// </summary>
        /// <param name="puzzleHeight"></param>
        /// <param name="puzzleWidth"></param>
        /// <param name="initialGrid"></param>
        /// 
        public Game(int puzzleHeight, int puzzleWidth, int[,] initialGrid = null)
        {
            puzzle = new Puzzle(puzzleHeight, puzzleWidth, initialGrid);
            this.moves = 0;
            this.time = 0;
            this.gameName = puzzleHeight.ToString() + puzzleWidth.ToString();
        }
        #endregion Constructors

        #region public Methods
        //------------------------------------------------------
        //
        //  Public Methods
        //
        //------------------------------------------------------
        
        /// <summary>
        /// Update puzzle based on move string and add moves counter
        /// </summary>
        /// <param name="move"></param>
        public void MakeMove(string move)
        {
            try
            {
                puzzle.UpdatePuzzle(move);
                this.moves += 1;
            }
            catch (Exception ex)
            {
                ;
            }
        }

        /// <summary>
        /// Update puzzle based on direction
        /// </summary>
        /// <param name="move"></param>
        public void UpdatePuzzle(string direction)
        {
            this.puzzle.UpdatePuzzle(direction);
        }

        /// <summary>
        /// Make solution string
        /// </summary>
        /// <returns></returns>
        public string MakeSolution()
        {
            string solution;
            Puzzle newPuzzle = puzzle.Clone();
            solution = newPuzzle.SolvePuzzle();
            return solution;
        }
        #endregion public Methods
    }
}
