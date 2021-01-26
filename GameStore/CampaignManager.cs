using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni kampanya eklendi.");
            Console.WriteLine("--------------KAMPANYA BİLGİLERİ--------------");
            Console.WriteLine("Kampanya Id : " + campaign.Id);
            Console.WriteLine("Kampanya Adı : " + campaign.Name);
            Console.WriteLine("Kampanya İndirim Oranı : " + campaign.RateOfCampaign);
            Console.WriteLine("----------------------------------------------");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" adlı kampanya silindi.");
        }

        public void Update(Campaign newCampaigInfromations, Campaign oldCampaignInformations)
        {

            oldCampaignInformations.Name = newCampaigInfromations.Name;
            oldCampaignInformations.RateOfCampaign = newCampaigInfromations.RateOfCampaign;

            Console.WriteLine("Kampanya bilgileri güncellendi.");
            Console.WriteLine("--------------KAMPANYA BİLGİLERİ--------------");
            Console.WriteLine("Kampanya Id : " + newCampaigInfromations.Id);
            Console.WriteLine("Kampanya Adı : " + newCampaigInfromations.Name);
            Console.WriteLine("Kampanya Oranı : " + newCampaigInfromations.RateOfCampaign);
            Console.WriteLine("----------------------------------------------");

        }
    }
}
