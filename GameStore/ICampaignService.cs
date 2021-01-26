using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign newCampaigInfromations, Campaign oldCampaignInformations);
        void Delete(Campaign campaign);
    }
}
