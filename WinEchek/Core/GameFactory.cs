﻿using System.Collections.Generic;
using System.Linq;
using WinEchek.GUI;
using WinEchek.Model;

namespace WinEchek.Core
{
    public class GameFactory
    {
        public List<GameCreator> GameCreators = new List<GameCreator>();

        public GameFactory()
        {
            GameCreators.Add(new LocalGameCreator());
        }

        /// <summary>
        /// Retourne une instance de partie dans le mode de jeu passé en paramètre
        /// </summary>
        /// <param name="mode">Mode de jeu souhaité</param>
        /// <returns>Une partie dans le mode de jeu passé en paramètre</returns>
        public Game CreateGame(Mode mode, Board board, BoardView boardView)
        {
            return GameCreators.FindAll(x => x.Mode == mode).First().CreateGame(board, boardView);
        }
    }


    /// <summary>
    /// Défini les différents mode de jeu possibles
    /// </summary>
    public enum Mode {
        Local,
        Network,
        AI
    }
}