using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Szerver
{
    class Komm
    {
        bool logged = false;
        string felhasznalo = string.Empty;
        TcpClient bejovo = null;
        StreamReader sr = null;
        StreamWriter sw = null;
        static List<Aruk> termekek = new List<Aruk> { new Aruk("Márk", 2111, "Dezodor") };

        public Komm(TcpClient kliens)
        {
            bejovo = kliens;
            sr = new StreamReader(bejovo.GetStream(), Encoding.UTF8);
            sw = new StreamWriter(bejovo.GetStream(), Encoding.UTF8);
        }


        public void Komm_Indit()
        {
            Console.WriteLine("Felcsatlakozott egy kliens!");
            bool end = false;
            string keres = string.Empty;
            sw.WriteLine("Üdv a szerveren!");
            sw.Flush();
            string[] keresekparameterei;
            while (!end)
            {
                try
                {
                    keres = sr.ReadLine();
                    keresekparameterei = keres.Split('|');
                    switch (keresekparameterei[0])
                    {
                        case "BEJELENTKEZÉS":
                            if (keresekparameterei[1]==null&&keresekparameterei[2]==null)
                            {
                                sw.WriteLine("ERR Hibás felhasználónév vagy jelszó");
                                sw.Flush();
                            }
                            else
                            {
                                logged = true;
                                felhasznalo = keresekparameterei[1];
                                sw.WriteLine("Sikeres bejentkezés.");
                                sw.Flush();
                            }
                            break;

                        case "TERMÉKEK":
                            if (!logged)
                            {
                                sw.WriteLine("ERR Kérlek jelentkezbe.");
                                sw.Flush();
                            }
                            else
                            {
                                for (int i = 0; i < termekek.Count; i++)
                                {
                                    sw.WriteLine("TERMÉKEK|"+termekek[i].Akie + "|" + termekek[i].Nev + "|"+ termekek[i].Ar);
                                    sw.Flush();
                                }
                            }
                            break;
                        case "HOZZÁAD":
                            if (!logged)
                            {
                                sw.WriteLine("ERR Kérlek jelentkezbe.");
                                sw.Flush();
                            }
                            else
                            {
                                if (keresekparameterei[1]!=null&& keresekparameterei[2] != null) 
                                {
                                    termekek.Add(new Aruk(felhasznalo, Convert.ToInt32(keresekparameterei[2]), keresekparameterei[1]));
                                }
                            }
                            break;
                        case "LICIT":
                            if (!logged)
                            {
                                sw.WriteLine("ERR Kérlek jelentkezbe.");
                                sw.Flush();
                            }
                            else
                            {
                            //    if ()
                            //    {

                            //    }
                            }
                            break;
                        case "BYE":
                            sw.WriteLine("BYE|Sikeres kijelentkezés");
                            sw.Flush();
                            end = false;
                            break;
                        default:
                            sw.WriteLine("Nincs ilyen szolgáltatás!");
                            sw.Flush();
                            break;
                    }
                    
                }
                catch(Exception e)
                {
                    if (bejovo.Connected)
                    {
                        sw.WriteLine("ERR|{0}", e.Message);
                        sw.Flush();
                    }
                    else
                    {
                        end = true;
                    }
                }
            }
        }

    }
}
