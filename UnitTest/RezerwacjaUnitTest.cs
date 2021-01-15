using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Projekt;

namespace UnitTest
{
    [TestClass]
    public class RezerwacjaUnitTest
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
        public void Clone_ArePropertiesEquals_ReturnTrue()
        {
            //Arrange
            Sala S1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Rezerwacja r1 = new Rezerwacja("2020-12-25", "2020-12-26", "Jakub", "Niedźwiecki", S1);

            //Act

            Rezerwacja clone = (Rezerwacja)r1.Clone();
            //Assert
            Assert.IsTrue(clone.Equals(r1));


        }

        [TestMethod]
        public void NumerRezerwacji_AddingProperly_True()
        {
            //Arrange
            Sala S1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Rezerwacja r1 = new Rezerwacja("2020-12-25", "2020-12-26", "Jakub", "Niedźwiecki", S1);
            Rezerwacja r2 = new Rezerwacja("2020-12-25", "2020-12-26", "Jakub", "Niedźwiecki", S1);
            Rezerwacja r3 = new Rezerwacja("2020-12-25", "2020-12-26", "Jakub", "Niedźwiecki", S1);
            //Act
            int licznik = r1.NumerRezerwacji;
            //Assert
            Assert.AreEqual(licznik + 1, r2.NumerRezerwacji);
            Assert.AreEqual(licznik + 2, r3.NumerRezerwacji);
        }

        [TestMethod]
        public void CompareTo_Sorting_True()
        {
            //Arrange
            Sala S1 = new Sala(1, 1, Budynki.A, Wyposazenia.pelne, 50, 10, 499.99);
            Rezerwacja r1 = new Rezerwacja("2020-12-25", "2020-12-26", "Adam", "Niedźwiecki", S1);
            Rezerwacja r2 = new Rezerwacja("2020-12-25", "2020-12-26", "Jakub", "Niedźwiecki", S1);
            Rezerwacja r3 = new Rezerwacja("2020-12-25", "2020-12-26", "Zygmunt", "Niedźwiecki", S1);
            Rezerwacja r5 = new Rezerwacja("2020-12-25", "2020-12-26", "Jakub", "Adamowicz", S1);
            Rezerwacja r6 = new Rezerwacja("2020-12-25", "2020-12-26", "Jakub", "Zygmuntowicz", S1);
            //Act
            int wynik = r1.CompareTo(r2);
            int wynik2 = r1.CompareTo(r2);
            int wynik3 = r1.CompareTo(r3);
            int wynik4 = r2.CompareTo(r1);
            int wynik5 = r2.CompareTo(r3);
            int wynik6 = r2.CompareTo(r2);
            //Dla nazwiska
            int wynikN1 = r2.CompareTo(r2);
            int wynikN2 = r2.CompareTo(r5);
            int wynikN3 = r2.CompareTo(r6);
            //Assert
            Assert.AreEqual(-1, wynik);
            Assert.AreEqual(-1, wynik2);
            Assert.AreEqual(-1, wynik3);
            Assert.AreEqual(1, wynik4);
            Assert.AreEqual(-1, wynik5);
            Assert.AreEqual(0, wynik6);
            Assert.AreEqual(0, wynikN1);
            Assert.AreEqual(1, wynikN2);
            Assert.AreEqual(-1, wynikN3);

        }
    }
}
