﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LudoGameEngine
{
    public class GamePiece
    {
        public int PieceID { get; set; }
        public int CurrentPos { get; set; } = 0;
        public int CurrentGlobalPos { get; set; } = 0;
        public int LocalStartPos { get; } = 0;
        public int GoalPosIndex { get; } = 45;
        public bool PieceInGoal { get; set; } = false;

        public IList<bool> LocalCoordinatePositions = new List<bool>();

        public GamePiece(int id)
        {
            this.PieceID = id;
            InitializeLocalPositions();
        }

        private void InitializeLocalPositions()
        {
            for(int i = 0; i < 46; i++)
            {
                if(i == 0)
                {
                    LocalCoordinatePositions.Add(true);
                }
                else
                {
                    LocalCoordinatePositions.Add(false);
                }
            }
        }
    }
}
