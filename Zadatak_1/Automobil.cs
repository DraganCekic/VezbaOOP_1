using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    internal class Automobil
    {
     public string Marka {  get; set; }
     public string Model { get; set; }
     public string Boja { get; set; }
     public int Godiste { get; set; }
     public int MaxBrzina { get; set; }
     public int TrenutnaBrzina { get; set; }
   
     
     public Automobil(string marka,string model,string boja, int godiste, int maxBrzina, int trenutnaBrzina)
        {
            this.Marka = marka;
            this.Model = model;
            this.Boja = boja;
            this.Godiste = godiste;
            this.MaxBrzina = maxBrzina;
            this.TrenutnaBrzina = trenutnaBrzina;
           
        }
        
        public  void IspisiAtribute()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Godiste: {Godiste}");
            Console.WriteLine($"Boja: {Boja}");
            Console.WriteLine($"Maksimalna Brzina: {MaxBrzina}");
            Console.WriteLine($"Trenutna Brzina: {TrenutnaBrzina}");
           
            Console.WriteLine("-------------------------");
        }

        public void Farbaj(string boja)
        {
            this.Boja = boja;
        }
        
        public int Ubrzaj()
        {
            this.TrenutnaBrzina += 5;
            if (TrenutnaBrzina >= MaxBrzina)
                TrenutnaBrzina = MaxBrzina;
            return this.TrenutnaBrzina;
        }
        public int Uspori()
        {
          TrenutnaBrzina -= 5;
            if (TrenutnaBrzina < 0)
                TrenutnaBrzina = 0;
            return TrenutnaBrzina;
        }
     

    }
}
