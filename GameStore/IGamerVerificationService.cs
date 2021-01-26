using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    interface IGamerVerificationService
    {
        void VerifyGamer(Gamer gamer,Gamer eStateGamer);
    }
}
