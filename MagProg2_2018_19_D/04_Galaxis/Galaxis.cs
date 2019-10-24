using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace _04_Galaxis
{
    class Galaxis
    {
        private uint Id = 1;

        //Blake Crouch: Sötét anyag
        public Galaxis()
        {
            this.egitestek = new List<Egitest>();
        }

        private List<Egitest> egitestek;
        public List<Egitest> Egitestek
        {
            get
            {
                ////return new List<Egitest>(egitestek);
                //List<Egitest> temp = new List<Egitest>();
                //foreach (Egitest egitest in egitestek)
                //{
                //    //if (egitest is Csillag)
                //    //    temp.Add((egitest as Csillag).Clone());
                //    //else if (egitest is Egitest)
                //        temp.Add(egitest.Clone());
                //}
                //return temp;
                return egitestek.Select(e => e.Clone()).ToList();
            }
        }
        public List<Bolygo> Bolygok
        {
            get
            {
                //List<Bolygo> temp = new List<Bolygo>();
                //foreach (Egitest egitest in Egitestek)
                //{
                //    if (egitest is Bolygo)
                //        temp.Add(egitest as Bolygo);
                //}
                //return temp;
                return Egitestek.Where(e => e is Bolygo)
                    .Select(e => e as Bolygo).ToList();
            }
        }
        public List<Bolygo> FoldszeruBolygok
        {
            get
            {
                //List<Bolygo> temp = new List<Bolygo>();
                //foreach (Bolygo bolygo in Bolygok)
                //{
                //    if (bolygo.Foldszeru)
                //    {
                //        temp.Add(bolygo);
                //    }
                //}
                //return temp;
                return Bolygok.Where(b => b.Foldszeru).ToList();
            }
        }
        public List<Csillag> Csillagok
        {
            get
            {
                List<Csillag> temp = new List<Csillag>();
                foreach (Egitest egitest in egitestek)
                {
                    if (egitest is Csillag)
                        temp.Add(egitest as Csillag);
                }
                return temp;
            }
        }
        public List<Csillag> NeutronCsillagok
        {
            get
            {
                //List<Csillag> temp = new List<Csillag>();
                //foreach (Csillag csillag in Csillagok)
                //{
                //    if (csillag.Osztaly == CsillagOsztaly.NEUTRON)
                //        temp.Add(csillag);
                //}
                //return temp;
                return Csillagok.Where(cs => cs.Osztaly == CsillagOsztaly.NEUTRON).ToList();
            }
        }
        public List<Csillag> HasonloCsillagok(Csillag csillag)
        {
            //List<Csillag> temp = new List<Csillag>();
            //foreach (Csillag cs in Csillagok)
            //{
            //    if (csillag.Hasonlo(cs))
            //        temp.Add(cs);
            //}
            //return temp;
            return Csillagok.Where(cs => cs.Hasonlo(csillag)).ToList();
        }
        //A 250 és 500 NÁ közötti átmérőjő barna törpék átlagos átmérője
        public double TrollTanarUrIdiotaLekerdezese
        {
            get
            {
                return Csillagok.Where(cs => cs.Osztaly == CsillagOsztaly.BARNATORPE)
                                .Where(cs => cs.Atmero > 250 && cs.Atmero < 500)
                                .Average(cs => cs.Atmero);
            }
        }
        //A 12 és 18 CsE közötti keringési távolsággal rendelkező bolygók osztályai 
        //nevének hossszának tekintetében visszafele rendezve egyedileg
        public List<string> TrollTanarUrIdiotaLekerdezese2
        {
            get
            {
                return Bolygok.Where(b => b.KeringesiTavolsag >= 12 && b.KeringesiTavolsag <= 18)
                              .OrderByDescending(b => Bolygo.BolygoOsztalyFormat(b.Osztaly).Length)
                              .Select(b => Bolygo.BolygoOsztalyFormat(b.Osztaly))
                              .Distinct().ToList();
            }
        }

        public Egitest this[int index]
        {
            get
            {
                return Egitestek[index];
            }
            //set
            //{
            //    Egitestek[index] = value;
            //}
        }
        public Egitest this[string Azonosito]
        {
            get
            {
                //foreach (Egitest egitest in Egitestek)
                //{
                //    if (egitest.Azonosito == Azonosito)
                //        return egitest;
                //}
                if (Egitestek.Any(e => e.Azonosito == Azonosito))
                    return Egitestek.Where(e => e.Azonosito == Azonosito).FirstOrDefault();
                throw new Exception("A megadott azonosító nem létezik!");
            }
        }

        private string GetId()
        {
            return Id.ToString().PadLeft(5, '0');
        }

        public void AddBolygo()
        {
            egitestek.Add(new Bolygo(
                GetId()));
            Id++;
        }
        public void AddBolygo(string Nev, ushort Eletkor)
        {
            egitestek.Add(new Bolygo(
                GetId(), Nev, Eletkor));
            Id++;
        }
        public void AddBolygo(string Nev, ushort Eletkor,
            BolygoOsztaly Osztaly, float KeringesiTavolsag)
        {
            egitestek.Add(new Bolygo(
                GetId(), Nev, Eletkor, Osztaly, KeringesiTavolsag));
            Id++;
        }
        public void AddBolygo(Bolygo bolygo)
        {
            egitestek.Add(new Bolygo(GetId(),
                bolygo.Nev,
                bolygo.Eletkor,
                bolygo.Osztaly,
                bolygo.KeringesiTavolsag));
            Id++;
        }

        public void AddCsillag()
        {
            egitestek.Add(new Csillag(
                GetId()));
            Id++;
        }
        public void AddCsillag(string Nev, ushort Eletkor)
        {
            egitestek.Add(new Csillag(
                GetId(), Nev, Eletkor));
            Id++;
        }
        public void AddCsillag(string Nev, ushort Eletkor,
            CsillagOsztaly Osztaly, float Atmero)
        {
            egitestek.Add(new Csillag(
                GetId(), Nev, Eletkor, Osztaly, Atmero));
            Id++;
        }
        public void AddCsillag(Csillag csillag)
        {
            egitestek.Add(new Csillag(GetId(),
                csillag.Nev,
                csillag.Eletkor,
                csillag.Osztaly,
                csillag.Atmero));
        }
    }
}
