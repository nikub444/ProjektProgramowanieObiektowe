using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt
{
    /// <summary>Klasa sluzaca do obslugi sal w budynkach</summary>
    [Serializable]
    public class KompleksBudynkow:IKompleksBudynkow
    {
        List<Sala> _listaSal;

        /// <summary>zawiera liste sal</summary>
        public List<Sala> ListaSal { get => _listaSal; set => _listaSal = value; }

        /// <summary>inicjuje nowe dane w liscie sal dla klasy <see cref="KompleksBudynkow" /></summary>
        public KompleksBudynkow()
        {
            ListaSal = new List<Sala>();
        }

        /// <summary>dodaje sale do listy</summary>
        public void DodajSale(Sala s)
        {
            ListaSal.Add(s);
        }
        /// <summary>usuwa sale z listy</summary>
        public void UsunSale(Sala s)
        {

            ListaSal.Remove(s);
        }
        /// <summary>Filtruje liste sal, czy sa PREMIUM czy NORMAL</summary>
        /// <returns>lista sal PREMIUM lub lista sal NORMAL</returns>
        public List<Sala> FiltrujPremium(int x)
        {
            List<Sala> wyjscie = new List<Sala>();
            if (x == 1)
            {
                foreach (Sala s in ListaSal)
                {
                    if (s.KodSali.Contains("PREMIUM"))
                    {
                        wyjscie.Add(s);
                    }

                }
            }
            if (x == 2)
            {
                foreach (Sala s in ListaSal)
                {
                    if (s.KodSali.Contains("NORMAL"))
                    {
                        wyjscie.Add(s);
                    }

                }
            }   
            if(x==3)
            {
                wyjscie = ListaSal;
            }
            return wyjscie;
            }
        /// <summary>filtruje liste sal, po pojemnosci</summary>
        /// <returns>lista sal z oczekiwana pojemnoscia</returns>
        public List<Sala> FiltrujPojemnosc(int x,List<Sala> wejscie)
        {
            List<Sala> wyjscie = new List<Sala>();
            foreach(Sala s in wejscie)
            {
                if (s.Pojemnosc>x)
                {
                    wyjscie.Add(s);
                }
            }
            return wyjscie; 
        }

        /// <summary>zapisuje  dane klasy do pliku XML</summary>
        public void ZapiszXML(string plik)
        {
            using (StreamWriter file2 = new StreamWriter(plik))
            {
                XmlSerializer xml = new XmlSerializer(typeof(KompleksBudynkow));
                xml.Serialize(file2, this);
            }
        }
        /// <summary>Odczytuje plik XML</summary>
        public static KompleksBudynkow OdczytajXML(string plik)
        {
            if (!File.Exists(plik)) { return null; }
            using (StreamReader file2 = new StreamReader(plik))
            {
                XmlSerializer xml = new XmlSerializer(typeof(KompleksBudynkow));
                return (KompleksBudynkow)xml.Deserialize(file2);
            }
        }

        /// <summary>konwertuje obiekty na ciag znakow reprezentujacych liste sal</summary>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            foreach (Sala r in ListaSal)
            {
                sb.AppendLine(r.ToString());
                sb.AppendLine("------------");
            }
            return sb.ToString();
        }
    }

    }

