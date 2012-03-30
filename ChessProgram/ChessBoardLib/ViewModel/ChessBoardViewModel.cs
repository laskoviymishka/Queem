﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Queem.Core.ChessBoard;
using Queem.Core;
using System.Collections.ObjectModel;

namespace ChessBoardVisualLib.ViewModel
{
    public class ChessBoardViewModel : ObservableObject
    {
        private GameProvider provider;
        private ObservableCollection<SquareItem> squareItems;

        public ChessBoardViewModel(GameProvider gameProvider)
        {
            this.provider = gameProvider;
        }

        private bool isFigureMoving;
        public bool IsFigureMoving
        {
            get { return this.isFigureMoving; }
            set
            {
                if (this.isFigureMoving != value)
                {
                    this.isFigureMoving = value;
                    OnPropertyChanged("IsFigureMoving");
                }
            }
        }

        public ObservableCollection<SquareItem> Items
        {
            get { return this.squareItems; }
        }

        public Color CurrentPlayerColor
        {
            get;
            set;
        }
    }
}
