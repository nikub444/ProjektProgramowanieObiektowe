using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class RezerwacjeUnitTest
    {
        /*
          * Test Example
         [TestMethod]
         public void Function_Scenario_ExpectedBehaviour()
         {
             //Arrange

             //Act

             //Assert

         }
         */

        [TestMethod]
        public void DodajRezerwacje_AddingToList_True()
        {
            //Arrange
            Sala S1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Rezerwacja r = new Rezerwacja("2020-12-25", "2020-12-22", "Jakub", "Łaszczyk", S1);//bledna data
            Rezerwacja r1 = new Rezerwacja("2020-12-25", "2020-12-28", "Jakub", "Łaszczyk", S1);
            Rezerwacja r2 = new Rezerwacja("2020-12-23", "2020-12-26", "Jakub", "Łaszczyk", S1);//false
            Rezerwacja r3 = new Rezerwacja("2020-12-27", "2020-12-30", "Jakub", "Łaszczyk", S1);//false
            Rezerwacja r4 = new Rezerwacja("2020-12-29", "2020-12-30", "Jakub", "Łaszczyk", S1);//true
            Rezerwacja r5 = new Rezerwacja("2020-12-23", "2020-12-24", "Jakub", "Łaszczyk", S1);//true
            Rezerwacje rezerw = new Rezerwacje();

            //Act
            //mamy pięć rozłącznych przypadków
            rezerw.DodajRezerwacje(r);
            int wynik = 0;
            foreach (Rezerwacja rx in rezerw.ListaRezerwacji)
            {
                wynik++;

            }
            rezerw.DodajRezerwacje(r1);
            int wynik2 = 0;
            foreach (Rezerwacja rx in rezerw.ListaRezerwacji)
            {
                wynik2++;

            }
            rezerw.DodajRezerwacje(r2);
            int wynik3 = 0;
            foreach (Rezerwacja rx in rezerw.ListaRezerwacji)
            {
                wynik3++;

            }
            rezerw.DodajRezerwacje(r3);
            int wynik4 = 0;
            foreach (Rezerwacja rx in rezerw.ListaRezerwacji)
            {
                wynik4++;

            }
            rezerw.DodajRezerwacje(r4);
            int wynik5 = 0;
            foreach (Rezerwacja rx in rezerw.ListaRezerwacji)
            {
                wynik5++;

            }
            rezerw.DodajRezerwacje(r5);
            int wynik6 = 0;
            foreach (Rezerwacja rx in rezerw.ListaRezerwacji)
            {
                wynik6++;

            }
            Console.WriteLine(rezerw);

            //Assert
            Assert.AreEqual(0, wynik);
            Assert.AreEqual(1, wynik2);
            Assert.AreEqual(1, wynik3);
            Assert.AreEqual(1, wynik4);
            Assert.AreEqual(2, wynik5);
            Assert.AreEqual(3, wynik6);
        }


        [TestMethod]
        public void OdczytajZapiszXML_ProperReading_True()
        {
            //Arrange
            Sala S1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Rezerwacja r1 = new Rezerwacja("2020-12-25", "2020-12-28", "Jakub", "Łaszczyk", S1);
            Rezerwacja r4 = new Rezerwacja("2020-12-29", "2020-12-30", "Jakub", "Łaszczyk", S1);//true
            Rezerwacja r5 = new Rezerwacja("2020-12-23", "2020-12-24", "Jakub", "Łaszczyk", S1);//true
            Rezerwacje rezerw = new Rezerwacje();

            //Act

            rezerw.DodajRezerwacje(r1);
            rezerw.DodajRezerwacje(r4);
            rezerw.DodajRezerwacje(r5);
            rezerw.ZapiszXML("test2xml.xml");
            Rezerwacje rezerw2 = Rezerwacje.OdczytajXML("test2xml.xml");
            /*Console.WriteLine("rezerw");
            Console.WriteLine(rezerw);
            Console.WriteLine("rezerw2");
            Console.WriteLine(rezerw2);*/



            //Assert
            for (int i = 0; (i < rezerw.ListaRezerwacji.Count) && (i < rezerw2.ListaRezerwacji.Count); i++)
            {
                //Console.WriteLine(rezerw.ListaRezerwacji[i]);
                //Console.WriteLine(rezerw2.ListaRezerwacji[i]);
                Assert.IsTrue(rezerw.ListaRezerwacji[i].Equals(rezerw2.ListaRezerwacji[i]));
            }



        }




        [TestMethod]
        public void RezDlaSali_ZnajdzRezerwacjeDlaSali_true()
        {
            //Arrange
            Sala Sala1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Sala Sala2 = new Sala(2, 2, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Rezerwacja R1 = new Rezerwacja("2020-12-25", "2020-12-28", "Jakub", "Łaszczyk", Sala1);
            Rezerwacja R4 = new Rezerwacja("2020-12-29", "2020-12-30", "Jakub", "Łaszczyk", Sala2);//true
            Rezerwacja R5 = new Rezerwacja("2020-12-23", "2020-12-24", "Jakub", "Łaszczyk", Sala1);//true
            Rezerwacje rezerwacje = new Rezerwacje();
            //Act
            rezerwacje.DodajRezerwacje(R1);
            rezerwacje.DodajRezerwacje(R4);
            rezerwacje.DodajRezerwacje(R5);

            //Assert

            Assert.IsTrue(rezerwacje.RezDlaSali(Sala2)[0].Equals(rezerwacje.ListaRezerwacji[1]));
            Assert.IsTrue(rezerwacje.RezDlaSali(Sala1)[0].Equals(rezerwacje.ListaRezerwacji[0]));
            Assert.IsTrue(rezerwacje.RezDlaSali(Sala1)[1].Equals(rezerwacje.ListaRezerwacji[2]));

        }

        [TestMethod]
        public void Function_Scenario_ExpectedBehaviour()
        {
            //Arrange
            Sala Sala1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Sala Sala2 = new Sala(2, 2, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Rezerwacja R1 = new Rezerwacja("2020-12-25", "2020-12-28", "Jakub", "Łaszczyk", Sala1);
            Rezerwacja R4 = new Rezerwacja("2020-12-29", "2020-12-30", "Jakub", "Łaszczyk", Sala2);//true
            Rezerwacja R5 = new Rezerwacja("2020-12-23", "2020-12-24", "Jakub", "Łaszczyk", Sala1);//true
            Rezerwacje rezerwacje = new Rezerwacje();
            //Act
            rezerwacje.DodajRezerwacje(R1);
            rezerwacje.DodajRezerwacje(R4);
            rezerwacje.DodajRezerwacje(R5);
            Rezerwacje rezerwacjeClone = new Rezerwacje();
            rezerwacjeClone = (Rezerwacje)rezerwacje.Clone();
            //Assert
            for (int i = 0; (i < rezerwacje.ListaRezerwacji.Count); i++)
            {
                //Console.WriteLine(rezerw.ListaRezerwacji[i]);
                //Console.WriteLine(rezerw2.ListaRezerwacji[i]);
                Assert.IsTrue(rezerwacje.ListaRezerwacji[i].Equals(rezerwacjeClone.ListaRezerwacji[i]));
            }

        }

        [TestMethod]
        public void UsunRezerwacje_AddingToList_True()
        {
            //Arrange
            Sala S1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Rezerwacja r1 = new Rezerwacja("2020-12-25", "2020-12-28", "Jakub", "Łaszczyk", S1);
            Rezerwacja r4 = new Rezerwacja("2020-12-29", "2020-12-30", "Jakub", "Łaszczyk", S1);//true
            Rezerwacja r5 = new Rezerwacja("2020-12-23", "2020-12-24", "Jakub", "Łaszczyk", S1);//true
            Rezerwacje rezerw = new Rezerwacje();


            //Act

            rezerw.DodajRezerwacje(r1);
            rezerw.DodajRezerwacje(r4);
            rezerw.DodajRezerwacje(r5);

            Console.WriteLine(rezerw);
            Console.WriteLine(r1.NumerRezerwacji);
            Console.WriteLine(r4.NumerRezerwacji);
            Console.WriteLine(r5.NumerRezerwacji);
            int wynik = 0;
            foreach (Rezerwacja rx in rezerw.ListaRezerwacji)
            {
                wynik++;

            }
            rezerw.UsunRezerwacje(r1);
            int wynik2 = 0;
            foreach (Rezerwacja rx in rezerw.ListaRezerwacji)
            {
                wynik2++;

            }
            rezerw.UsunRezerwacje(r4);
            int wynik3 = 0;
            foreach (Rezerwacja rx in rezerw.ListaRezerwacji)
            {
                wynik3++;

            }
            rezerw.UsunRezerwacje(r5);
            int wynik4 = 0;
            foreach (Rezerwacja rx in rezerw.ListaRezerwacji)
            {
                wynik4++;

            }
            //Assert
            Assert.AreEqual(3, wynik);
            Assert.AreEqual(2, wynik2);
            Assert.AreEqual(1, wynik3);
            Assert.AreEqual(0, wynik4);

        }


        [TestMethod]
        public void Sortuj_PosortujDomyslnie_True()
        {
            //Arrange
            Sala S1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Rezerwacja r1 = new Rezerwacja("2020-12-25", "2020-12-26", "Adam", "Niedźwiecki", S1);
            Rezerwacja r2 = new Rezerwacja("2021-12-25", "2021-12-26", "Jakub", "Niedźwiecki", S1);
            Rezerwacja r3 = new Rezerwacja("2022-12-25", "2022-12-26", "Zygmunt", "Niedźwiecki", S1);
            Rezerwacja r5 = new Rezerwacja("2023-12-25", "2023-12-26", "Jakub", "Adamowicz", S1);
            Rezerwacja r6 = new Rezerwacja("2024-12-25", "2024-12-26", "Jakub", "Zygmuntowicz", S1);
            Rezerwacje rezerwacje = new Rezerwacje();
            //Act
            rezerwacje.DodajRezerwacje(r1);
            rezerwacje.DodajRezerwacje(r2);
            rezerwacje.DodajRezerwacje(r3);
            rezerwacje.DodajRezerwacje(r5);
            rezerwacje.DodajRezerwacje(r6);
            rezerwacje.Sortuj();
            int wynik = rezerwacje.ListaRezerwacji[0].CompareTo(r2);
            int wynik2 = rezerwacje.ListaRezerwacji[0].CompareTo(r2);
            int wynik3 = rezerwacje.ListaRezerwacji[0].CompareTo(r3);
            int wynik4 = rezerwacje.ListaRezerwacji[1].CompareTo(r1);
            int wynik5 = rezerwacje.ListaRezerwacji[1].CompareTo(r3);
            int wynik6 = rezerwacje.ListaRezerwacji[1].CompareTo(r2);
            //Dla nazwiska
            int wynikN1 = rezerwacje.ListaRezerwacji[1].CompareTo(r2);
            int wynikN2 = rezerwacje.ListaRezerwacji[1].CompareTo(r5);
            int wynikN3 = rezerwacje.ListaRezerwacji[1].CompareTo(r6);
            //Assert
            Assert.AreEqual(-1, wynik);
            Assert.AreEqual(-1, wynik2);
            Assert.AreEqual(-1, wynik3);
            Assert.AreEqual(0, wynik4);
            Assert.AreEqual(-1, wynik5);
            Assert.AreEqual(-1, wynik6);
            Assert.AreEqual(-1, wynikN1);
            Assert.AreEqual(1, wynikN2);
            Assert.AreEqual(-1, wynikN3);
        }

        [TestMethod]
        public void SortujPoDataOd_PosortujPoDataOd_True()
        {

            //Arrange
            Sala S1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Rezerwacja r6 = new Rezerwacja("2024-12-25", "2024-12-26", "Jakub", "Zygmuntowicz", S1);

            Rezerwacja r2 = new Rezerwacja("2021-12-25", "2021-12-26", "Jakub", "Niedźwiecki", S1);
            Rezerwacja r3 = new Rezerwacja("2022-12-25", "2022-12-26", "Zygmunt", "Niedźwiecki", S1);
            Rezerwacja r5 = new Rezerwacja("2023-12-25", "2023-12-26", "Jakub", "Adamowicz", S1);
            Rezerwacja r1 = new Rezerwacja("2020-12-25", "2020-12-26", "Adam", "Niedźwiecki", S1);
            Rezerwacje rezerwacje = new Rezerwacje();

            //Act
            rezerwacje.DodajRezerwacje(r1);
            rezerwacje.DodajRezerwacje(r2);
            rezerwacje.DodajRezerwacje(r3);
            rezerwacje.DodajRezerwacje(r5);
            rezerwacje.DodajRezerwacje(r6);

            rezerwacje.SortujPoDataOd();

            int wynik = rezerwacje.ListaRezerwacji[0].CompareTo(r1);
            int wynik2 = rezerwacje.ListaRezerwacji[1].CompareTo(r2);
            int wynik3 = rezerwacje.ListaRezerwacji[2].CompareTo(r3);
            int wynik4 = rezerwacje.ListaRezerwacji[3].CompareTo(r5);
            int wynik5 = rezerwacje.ListaRezerwacji[4].CompareTo(r6);

            //Assert
            Assert.AreEqual(0, wynik);
            Assert.AreEqual(0, wynik2);
            Assert.AreEqual(0, wynik3);
            Assert.AreEqual(0, wynik4);
            Assert.AreEqual(0, wynik5);


        }

        [TestMethod]
        public void SortujPoDataDo_PosortujPoDataDo_True()
        {
            //Arrange
            Sala S1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Rezerwacja r6 = new Rezerwacja("2024-12-25", "2024-12-26", "Jakub", "Zygmuntowicz", S1);

            Rezerwacja r2 = new Rezerwacja("2021-12-25", "2021-12-26", "Jakub", "Niedźwiecki", S1);
            Rezerwacja r3 = new Rezerwacja("2022-12-25", "2022-12-26", "Zygmunt", "Niedźwiecki", S1);
            Rezerwacja r5 = new Rezerwacja("2023-12-25", "2023-12-26", "Jakub", "Adamowicz", S1);
            Rezerwacja r1 = new Rezerwacja("2020-12-25", "2020-12-26", "Adam", "Niedźwiecki", S1);
            Rezerwacje rezerwacje = new Rezerwacje();

            //Act
            rezerwacje.DodajRezerwacje(r1);
            rezerwacje.DodajRezerwacje(r2);
            rezerwacje.DodajRezerwacje(r3);
            rezerwacje.DodajRezerwacje(r5);
            rezerwacje.DodajRezerwacje(r6);

            rezerwacje.SortujPoDataDo();

            int wynik = rezerwacje.ListaRezerwacji[0].CompareTo(r1);
            int wynik2 = rezerwacje.ListaRezerwacji[1].CompareTo(r2);
            int wynik3 = rezerwacje.ListaRezerwacji[2].CompareTo(r3);
            int wynik4 = rezerwacje.ListaRezerwacji[3].CompareTo(r5);
            int wynik5 = rezerwacje.ListaRezerwacji[4].CompareTo(r6);

            //Assert
            Assert.AreEqual(0, wynik);
            Assert.AreEqual(0, wynik2);
            Assert.AreEqual(0, wynik3);
            Assert.AreEqual(0, wynik4);
            Assert.AreEqual(0, wynik5);


        }
    }
}
