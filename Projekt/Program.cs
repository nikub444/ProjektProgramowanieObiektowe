using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Sala S1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Sala s1 = new SalaPremium(1, 2, Budynki.B, Wyposazenia.krzesla, 100, 40, 299.99, Taknie.tak, Taknie.tak, Taknie.nie, Taknie.tak, Taknie.tak);
            Sala s2 = new SalaPremium(1, 2, Budynki.C, Wyposazenia.krzesla, 50, 30, 299.99, Taknie.tak, Taknie.tak, Taknie.nie, Taknie.tak, Taknie.tak);
            Sala S2 = new Sala(2, 2, Budynki.A, Wyposazenia.pelne, 50, 30, 499.99);
            Sala S3 = new Sala(3, 2, Budynki.B, Wyposazenia.brak, 150, 55, 550.00);
            Sala s3 = new SalaPremium(3, 1, Budynki.B, Wyposazenia.pelne, 70, 50, 699.99, Taknie.tak, Taknie.nie, Taknie.tak, Taknie.nie, Taknie.tak);
            Sala S4 = new Sala(4, 1, Budynki.C, Wyposazenia.brak, 100, 80, 899.00);
            Sala s4 = new SalaPremium(4, 2, Budynki.C, Wyposazenia.pelne, 90, 70, 950.00, Taknie.tak, Taknie.tak, Taknie.tak, Taknie.nie, Taknie.tak);

            KompleksBudynkow kompleks = new KompleksBudynkow();
            kompleks.DodajSale(s1);
            kompleks.DodajSale(s2);
            kompleks.DodajSale(S1);
            kompleks.DodajSale(S2);
            kompleks.DodajSale(S3);
            kompleks.DodajSale(s3);
            kompleks.DodajSale(s4);
            kompleks.DodajSale(S4);
            kompleks.ZapiszXML("sale.xml");
            KompleksBudynkow k2 = KompleksBudynkow.OdczytajXML("sale.xml");

           // Console.WriteLine(k2);
            foreach(Sala s in kompleks.FiltrujPojemnosc(9, kompleks.FiltrujPremium(2)))
                {
              //  Console.WriteLine(s);
             
                    
                    }

            

            //Console.WriteLine(s1);
          Rezerwacja r1 = new Rezerwacja("2020-12-25","2020-12-26", "Jakub", "Łaszczyk", S1);
            Rezerwacja r2 = new Rezerwacja("2020-12-23", "2020-12-24", "Marcin", "Korkowski", S1);
            Rezerwacja r3 = new Rezerwacja("2025-12-29", "2025-12-30", "Anna", "Wolicz", S2);
            Rezerwacja r4 = new Rezerwacja("2026-12-29", "2026-12-30", "Adam", "Polonski", s1);
            Rezerwacja r5 = new Rezerwacja("2022-12-29", "2022-12-30", "Jakub", "Niedzwiedzki", s2);
            Rezerwacja r6 = new Rezerwacja("2022-12-29", "2022-12-30", "Klaudia", "Len", s3);
            Rezerwacja r7 = new Rezerwacja("2021-01-29", "2021-02-10", "Edyta", "Gorek", S1);
            Rezerwacja r8 = new Rezerwacja("2021-02-15", "2021-02-17", "Janusz", "Trokke", S3);
            Rezerwacja r9 = new Rezerwacja("2021-05-12", "2021-05-20", "Monika", "Kowalczyk", s3);
            Rezerwacja r10 = new Rezerwacja("2021-10-11", "2021-10-19", "Mariusz", "Blask", s2);
            Rezerwacja r11 = new Rezerwacja("2021-02-20", "2021-02-23", "Aleksander", "Pioro", s1);
            Rezerwacja r12 = new Rezerwacja("2022-01-29", "2022-02-13", "Justyna", "Obesa", s2);
            Rezerwacja r13 = new Rezerwacja("2021-09-19", "2021-09-21", "Izabela", "Miko", s1);
            Rezerwacja r14 = new Rezerwacja("2021-06-05", "2021-06-06", "Agnieszka", "Kulim", s3);
            Rezerwacja r15 = new Rezerwacja("2021-11-11", "2021-11-13", "Jakub", "Łaszczyk", S3);
            Rezerwacja r16 = new Rezerwacja("2021-03-03", "2021-03-13", "Marek", "Krawczyk", s4);
            Rezerwacja r17 = new Rezerwacja("2022-05-26", "2022-05-30", "Piotr", "Okresa", S2);
            Rezerwacja r18 = new Rezerwacja("2022-10-01", "2022-10-13", "Ela", "Krokus", S4);
            Rezerwacja r19 = new Rezerwacja("2021-04-13", "2021-04-17", "Karol", "Olig", s3);
            Rezerwacja r20 = new Rezerwacja("2021-12-22", "2021-12-26", "Jozef", "Markiewicz", s4);

            Rezerwacje rezerw = new Rezerwacje();
            rezerw.DodajRezerwacje(r1);
            rezerw.DodajRezerwacje(r2);
            rezerw.DodajRezerwacje(r3);
            rezerw.DodajRezerwacje(r4);
            rezerw.DodajRezerwacje(r5);
            rezerw.DodajRezerwacje(r6);
            rezerw.DodajRezerwacje(r7);
            rezerw.DodajRezerwacje(r8);
            rezerw.DodajRezerwacje(r9);
            rezerw.DodajRezerwacje(r10);
            rezerw.DodajRezerwacje(r11);
            rezerw.DodajRezerwacje(r12);
            rezerw.DodajRezerwacje(r13);
            rezerw.DodajRezerwacje(r14);
            rezerw.DodajRezerwacje(r15);
            rezerw.DodajRezerwacje(r16);
            rezerw.DodajRezerwacje(r17);
            rezerw.DodajRezerwacje(r18);
            rezerw.DodajRezerwacje(r19);
            rezerw.DodajRezerwacje(r20);
            // Console.WriteLine(rezerw);
            rezerw.SortujPoDataOd();
            Console.WriteLine(rezerw);

            rezerw.ZapiszXML("testxml.xml");
            Rezerwacje rezerw2 = Rezerwacje.OdczytajXML("testxml.xml");
          
            Console.WriteLine("odczyt");
            Console.WriteLine(rezerw2);
            Rezerwacje rezerwClone = new Rezerwacje();
            Console.WriteLine("Clone");
            rezerwClone = (Rezerwacje)rezerw2.Clone();
            Console.WriteLine(rezerwClone);
            
            rezerwClone.Sortuj();
            Console.WriteLine(rezerwClone);
            rezerwClone.SortujPoDataOd();
            Console.WriteLine(rezerwClone);
            rezerwClone.SortujPoDataDo();
            Console.WriteLine(rezerwClone);
            

            Console.ReadKey();


        }
    }
}
