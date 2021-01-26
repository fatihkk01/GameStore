using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class GamerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oturumunuz silindi.");
        }

        public void Login(Gamer gamer)
        {
            Console.WriteLine("Merhaba "+gamer.Name+".");
        }

        public void LogOut(Gamer gamer)
        {
            Console.WriteLine("Oturumunuz kapatıldı.");
        }

        public void Register(Gamer gamer, Gamer eStateGamer,GamerVerificationManager gamerVerificationManager)
        {
            gamerVerificationManager.VerifyGamer(gamer, eStateGamer);
        }

        public void SellGameCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            double newPrice = (game.Price *(100 - campaign.RateOfCampaign)) / 100;
            Console.WriteLine(game.Name + " adlı oyun " + gamer.Name + " " + gamer.Surname + " tarafıdan %" + campaign.RateOfCampaign+" indirim ile "+ newPrice + " TL'ye satıldı.");
        }

        public void SellGame(Gamer gamer, Game game)
        {
            Console.WriteLine(game.Name + " adlı oyun " + gamer.Name + " " + gamer.Surname + " tarafıdan " + game.Price + " TL'ye satıldı.");
        }

        public void Update(Gamer newGamerInformations, Gamer oldGamerInformations)
        {
            oldGamerInformations.Name = newGamerInformations.Name;
            oldGamerInformations.Surname = newGamerInformations.Surname;

            Console.WriteLine("Bilgileriniz Güncellendi");
        }
    }
}
