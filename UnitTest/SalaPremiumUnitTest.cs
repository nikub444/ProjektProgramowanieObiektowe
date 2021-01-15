using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt;
using System;

namespace UnitTest
{
    [TestClass]
    public class SalaPremiumUnitTest
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
        public void atrybuty_ProperString_True()
        {
            //Arrange
            SalaPremium s1 = new SalaPremium(1, 2, Budynki.B, Wyposazenia.krzesla, 100, 40, 299.99, Taknie.tak, Taknie.tak, Taknie.tak, Taknie.tak, Taknie.tak);
            SalaPremium s2 = new SalaPremium(1, 2, Budynki.B, Wyposazenia.krzesla, 100, 40, 299.99, Taknie.tak, Taknie.tak, Taknie.tak, Taknie.tak, Taknie.nie);
            SalaPremium s3 = new SalaPremium(1, 2, Budynki.B, Wyposazenia.krzesla, 100, 40, 299.99, Taknie.tak, Taknie.tak, Taknie.tak, Taknie.nie, Taknie.nie);
            SalaPremium s4 = new SalaPremium(1, 2, Budynki.B, Wyposazenia.krzesla, 100, 40, 299.99, Taknie.tak, Taknie.tak, Taknie.nie, Taknie.nie, Taknie.nie);
            SalaPremium s5 = new SalaPremium(1, 2, Budynki.B, Wyposazenia.krzesla, 100, 40, 299.99, Taknie.tak, Taknie.nie, Taknie.nie, Taknie.nie, Taknie.nie);
            SalaPremium s6 = new SalaPremium(1, 2, Budynki.B, Wyposazenia.krzesla, 100, 40, 299.99, Taknie.nie, Taknie.nie, Taknie.nie, Taknie.nie, Taknie.nie);

            //Act

            Console.WriteLine(s1.atrybuty());
            Console.WriteLine(s2.atrybuty());
            Console.WriteLine(s3.atrybuty());
            Console.WriteLine(s4.atrybuty());
            Console.WriteLine(s5.atrybuty());
            Console.WriteLine(s6.atrybuty());

            bool wynik = s1.atrybuty() == "Projektor , Glosniki , Mikrofon , Klimatyzacja , Bezpłatne Wifi ";
            bool wynik2 = s2.atrybuty() == "Projektor , Glosniki , Mikrofon , Klimatyzacja ";
            bool wynik3 = s3.atrybuty() == "Projektor , Glosniki , Mikrofon ";
            bool wynik4 = s4.atrybuty() == "Projektor , Glosniki ";
            bool wynik5 = s5.atrybuty() == "Projektor ";
            bool wynik6 = s6.atrybuty() == "";
            //Assert
            Assert.IsTrue(wynik);
            Assert.IsTrue(wynik2);
            Assert.IsTrue(wynik3);
            Assert.IsTrue(wynik4);
            Assert.IsTrue(wynik5);
            Assert.IsTrue(wynik6);
        }
    }
}
