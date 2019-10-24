using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04_Galaxis
{
    class Program
    {
        static Random rnd = new Random();
        static Galaxis MilkyWay = new Galaxis();

        static void WriteErrorMessage(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}", Message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void FajlBeolvas(string FajlNeve)
        {
            StreamReader sr = new StreamReader(Stream.Null);
            try
            {
                if (!File.Exists(FajlNeve))
                    throw new FileNotFoundException(FajlNeve);
                sr = new StreamReader(FajlNeve,
                    Encoding.Default);
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] adatok = sr.ReadLine().Split(';');
                    if (adatok[0] == "cs")
                    {
                        try
                        {
                            Csillag cs = new Csillag("11111");
                            cs.Nev = adatok[1] == string.Empty ? null : adatok[1];
                            cs.Eletkor = Convert.ToUInt16(adatok[2]);
                            cs.Osztaly = (CsillagOsztaly)Enum.Parse(typeof(CsillagOsztaly), adatok[3]);
                            cs.Atmero = (float)Convert.ToDouble(adatok[4]);
                            MilkyWay.AddCsillag(cs);
                        }
                        catch (Exception ex)
                        { WriteErrorMessage(ex.Message); }
                    }
                    else if (adatok[0] == "b")
                    {
                        Bolygo b = new Bolygo("111111");

                        List<string> errors = new List<string>();

                        try
                        {
                            b.Nev = adatok[1] == string.Empty ? null : adatok[1];
                        }
                        catch (EgitestNevException ex)
                        {
                            errors.Add(ex.Message);
                        }
                        catch (Exception)
                        {
                            //Máshogy oldom meg, ha akarom
                        }


                        try
                        {
                            b.Eletkor = Convert.ToUInt16(adatok[2]);
                        }
                        catch (FormatException)
                        {
                            b.Eletkor = (ushort)rnd.Next(Beallitasok.Default.MaxEgitestEletkor);
                            errors.Add("Konvertálhatatlan életkor adat: " + adatok[2] + ", helyette véletlenszerűen beállítva: " + b.Eletkor);
                        }
                        catch (EgitestEletkorTulNagyException ex)
                        {
                            b.Eletkor = Beallitasok.Default.MaxEgitestEletkor;
                            errors.Add(ex.Message);
                        }

                        b.Osztaly = (BolygoOsztaly)Enum.Parse(typeof(BolygoOsztaly), adatok[3]);

                        try
                        {
                            b.KeringesiTavolsag = (float)Convert.ToDouble(adatok[4]);
                        }
                        catch (FormatException)
                        {
                            b.KeringesiTavolsag = (float)rnd.NextDouble() * 
                                (Beallitasok.Default.MaxBolygoKeringesiTavolsag - Beallitasok.Default.MinBolygoKeringesiTavolsag)
                                + Beallitasok.Default.MinBolygoKeringesiTavolsag;
                            errors.Add("Konvertálhatatlan keringési távolság adat: " + adatok[4] + ", helyette véletlenszerűen beállítva: " + b.KeringesiTavolsag);
                        }
                        catch(BolygoKeringesiTavolsagException ex)
                        {
                            if (ex.KeringesiTavolsagRosszErtek < Beallitasok.Default.MinBolygoKeringesiTavolsag)
                                b.KeringesiTavolsag = Beallitasok.Default.MinBolygoKeringesiTavolsag;
                            else b.KeringesiTavolsag = Beallitasok.Default.MaxBolygoKeringesiTavolsag;
                            errors.Add(ex.Message);
                        }
                        catch(Exception)
                        {
                            //Valami nagyon drasztikus megoldás
                        }

                        MilkyWay.AddBolygo(b);

                        if (errors.Count > 0)
                        {
                            WriteErrorMessage(string.Format("\nA(z) {0} azonosítójú bolygó hibái:",
                                MilkyWay.Bolygok.Last().Azonosito));
                            for (int i = 0; i < errors.Count; i++)
                            {
                                WriteErrorMessage((i + 1) + ": " + errors[i]);
                            }
                            Console.WriteLine();
                        }
                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("A hiba oka az, hogy a fájl nem létezik: {0}", ex.FileName);
                return;
            }
            //catch(Exception)
            //{
            //    sr.Close();
            //    return;
            //}
            finally
            {
                sr.Close();
            }
        }

        static void Main(string[] args)
        {
            FajlBeolvas("Egitestek.csv");

            //MilkyWay[10].Nev = "WERTZTVF";
            //Console.WriteLine(MilkyWay[10]);

            foreach (var egitest in MilkyWay.Egitestek)
            {
                Console.WriteLine(egitest);
            }

            //for (int i = 1; i <= 50; i++)
            //{
            //    MilkyWay.AddCsillag(
            //        "Csillag " + i.ToString().PadLeft(3, ' '),
            //        (ushort)rnd.Next(Beallitasok.Default.MaxEgitestEletkor),
            //        (CsillagOsztaly)rnd.Next(6),
            //        (float)(rnd.NextDouble() *
            //            (Beallitasok.Default.MaxCsillagAtmero - Beallitasok.Default.MinCsillagAtmero) +
            //            Beallitasok.Default.MinCsillagAtmero));
            //}

            //MilkyWay[5] = new Csillag("EDE1234", "Halálcsillag 3",
            //    23, CsillagOsztaly.HALAL, 2.56f);

            //Console.WriteLine(MilkyWay["E-00012-CS"]);

            //foreach (Csillag csillag in MilkiWay.HasonloCsillagok(MilkiWay.Csillagok[5]))
            //    Console.WriteLine(csillag);

            Console.ReadLine();
        }
    }
}
