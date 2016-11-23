﻿using System;
using WinEchek.Model;
using WinEchek.Model.Piece;
using Type = WinEchek.Model.Piece.Type;

namespace WinEchek.Engine.Rules
{
    public class BishopRule : PieceRule
    {
        public override bool Handle(Piece piece, Square square)
        {
            if (piece.Type != Type.Bishop)
            {
                if (Next != null)
                {
                    return Next.Handle(piece, square);
                }
                throw new Exception("NOBODY TREATS THIS PIECE !!! " + piece);
            }
            return true;
        }
    }
}