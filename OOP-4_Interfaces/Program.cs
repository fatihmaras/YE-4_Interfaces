using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var saver = new SaverAccount();
            saver.PayIn(500);
            saver.Withdraw(300);
            saver.Withdraw(500);
            Console.WriteLine("Current Balance : " + saver.Balance);
            Console.WriteLine(saver);

            Console.ReadLine();
        }
    }
}

/*
 - Bir interface kalıtımla devralındığı zaman interface üzerinde tanımlı olan property,method gibi üyelerin devralınan sınıfta implemente edilmesini
    (yani gövdelerinin yazılmasını) zorunlu hale getirir.
     Eğer bir class bir interface'i miras alıyorsa,  miras alnınan interfacede yer alan methodaları implemente etmek zorundayız.
    İlgili Classta Interface seçilir, Ctrl ve . ile implement interface seçilir

 - C#, birden fazla interface'i kullanarak kalıtımla ilgili interface yapısının devralınmasına olanak sağlar.







*/




















/*
 - Bir interface kalıtımla devralındığı zaman interface üzerinde tanımlı olan property,method gibi üyelerin devralınan sınıfta implemente edilmesini
    (yani gövdelerinin yazılmasını) zorunlu hale getirir.
 - C#, birden fazla interface'i kullanarak kalıtımla ilgili interface yapısının devralınmasına olanak sağlar.







*/