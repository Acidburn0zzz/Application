﻿using System;
using System.ServiceModel;
using WinEchek.Model;

namespace WinEchek.Core.Network
{
    [ServiceContract]
    public interface INetworkGameService
    {
     
        [OperationContract(IsOneWay = true)]
        void Inform(Move move);

        /// <summary>
        /// Méthode pour envoyer au service les informations pour se connecter au nôtre
        /// </summary>
        /// <param name="uri"></param>
        [OperationContract(IsOneWay = true)]
        void SendClientAdress(Uri uri);


        /// <summary>
        /// Renvoie la chaîne passée en paramètre par l'appellant
        /// Permet de tester le présence d'un service sur une certaine URI
        /// </summary>
        /// <param name="message">Chaine à retourner</param>
        /// <returns>Une chaine de caractère identique à celle passée en paramètre</returns>
        [OperationContract]
        string Echo(string message);
    }
}