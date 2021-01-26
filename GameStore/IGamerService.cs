using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    interface IGamerService
    {
        void Register(Gamer gamer,Gamer eStateGamer,GamerVerificationManager gamerVerificationManager);
        void Login(Gamer gamer);
        void LogOut(Gamer gamer);
        void SellGameCampaign(Gamer gamer, Game game, Campaign campaign);
        void SellGame(Gamer gamer, Game game);
        void Update(Gamer newGamerInformations,Gamer oldGamerInformations);
        void Delete(Gamer gamer);
    }
}
