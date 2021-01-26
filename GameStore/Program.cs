using System;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            CampaignManager campaignManager = new CampaignManager();
            GamerVerificationManager gamerVerificationManager = new GamerVerificationManager();

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.Name = "Fatih";
            gamer1.Surname = "Kırık";
            gamer1.TcNo = "12345678910";
            gamer1.DateOfBirth = "30/07/2000";

            Gamer gamer2 = new Gamer();
            gamer2.Id = 1;
            gamer2.Name = "Mehmet";
            gamer2.Surname = "Yılmaz";
            gamer2.TcNo = "94973675710";
            gamer2.DateOfBirth = "10/08/1995";

            Gamer eStateGamer = new Gamer();
            eStateGamer.Id = 1;
            eStateGamer.Name = "Fatih";
            eStateGamer.Surname = "Kırık";
            eStateGamer.TcNo = "12345678910";
            eStateGamer.DateOfBirth = "30/07/2000";

            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "CyberPunk 2077";
            game1.Point = 8;
            game1.Price = 300;
            game1.ReleaseDate = "10 Aralık 2020";

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Yeni yıl kampanyası";
            campaign1.RateOfCampaign = 20;

            Campaign campaign2 = new Campaign();
            campaign2.Id = 1;
            campaign2.Name = "Cadılar bayramı kampanyası";
            campaign2.RateOfCampaign = 20;


            //KAYIT VE DOĞRULAMA İŞLEMİ 
            gamerManager.Register(gamer1, eStateGamer, gamerVerificationManager);
            Console.WriteLine();

            //GİRİŞ İŞLEMİ
            gamerManager.Login(gamer1);
            Console.WriteLine();

            //KULLANICI BİLGİSİ GÜNCELLEME İŞLEMİ 
            gamerManager.Update(gamer2,gamer1);
            Console.WriteLine();

            //ÇIKIŞ İŞLEMİ
            gamerManager.LogOut(gamer1);
            Console.WriteLine();

            //KULLANICI SİLME
            gamerManager.Delete(gamer1);
            Console.WriteLine();

            //KAMPANYA EKLEME İŞLEMİ
            campaignManager.Add(campaign1);
            Console.WriteLine();

            //KAMPANYA GÜNCELLEME İŞLEMİ
            campaignManager.Update(campaign2, campaign1);
            Console.WriteLine();

            //KAMPANYA SİLME İŞLEMİ
            campaignManager.Delete(campaign1);
            Console.WriteLine();

            //KAMPANYALI OYUN SATIŞ İŞLEMİ
            gamerManager.SellGameCampaign(gamer1, game1, campaign1);
            Console.WriteLine();

            //KAMPANYASIZ OYUN SATIŞ IŞLEMİ
            gamerManager.SellGame(gamer1, game1);
            Console.WriteLine();

            






        }
    }
}
