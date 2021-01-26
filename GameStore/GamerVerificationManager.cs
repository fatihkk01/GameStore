using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class GamerVerificationManager : IGamerVerificationService
    {
        public void VerifyGamer(Gamer gamer, Gamer eStateGamer)
        {
            if(gamer.Name==eStateGamer.Name && gamer.Surname==eStateGamer.Surname && gamer.TcNo.Equals(eStateGamer.TcNo) && gamer.DateOfBirth.Equals(eStateGamer.DateOfBirth))
            {
                Console.WriteLine("Doğrulama Başarılı.");
                Console.WriteLine("Kayıt Başarılı.");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız.");
                Console.WriteLine("Kayıt Başarısız.");
            }
        }
    }
}
