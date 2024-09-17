using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar uma instância da classe Nokia
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "NOK123456", 64);
            
            // Criar uma instância da classe Iphone
            Iphone iphone = new Iphone("987654321", "iPhone 13", "IPH123456", 128);

            // Testar os métodos da classe Nokia
            Console.WriteLine("Smartphone Nokia:");
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");
            Console.WriteLine(); 

            // Testar os métodos da classe Iphone
            Console.WriteLine("Smartphone iPhone:");
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
            Console.WriteLine(); 
        }
    }
}
