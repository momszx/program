using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Hal
    {
        #region :: hal sulya ::
        protected double _suly = 0;
        public double suly
        {
            get
            {
                if (_suly == 0) throw new Exception("még nincs beállítva");
                return _suly;
            }
            set
            {
                if (value < 0.5 || value > 40) throw new Exception("Nem jó a súly adat!");
                if (_suly == 0) _suly = value;
                else
                {
                    double arany = value * 100 / _suly;
                    if (0.9 <= arany && arany <= 1.1) _suly = value;
                    else throw new Exception("Ennyivel nem ugorhat meg a sulya!");
                }
            }
        }
        #endregion
        #region :: hal ragadozo-e ::
        protected bool _ragadozo;
        protected bool _ragadozo_beallitva = false;
        public bool ragadozo
        {
            get
            {
                if (_ragadozo_beallitva == false) throw new Exception("meg nincs beallitva");
                return _ragadozo;
            }
            set
            {
                if (_ragadozo_beallitva == true) throw new Exception("mar be van allitva");
                _ragadozo_beallitva = true;
                _ragadozo = value;
            }
        }
        #endregion
        #region :: hal uszasi magassag ::
        protected int _magas;
        public int magas
        {
            get
            {
                return _magas;
            }
            set
            {
                if (value < 0 || value > 400) throw new Exception("Nem jó a top adat!");
                else _magas = value;
            }
        }
        #endregion
        #region :: hal uszasi melysege ::
        protected int _melyseg;
        public int melyseg
        {
            get
            {
                return _melyseg;
            }
            set
            {
                if (value < 10 || value > 400) throw new Exception("Nem jó a depth adat!");
                else _melyseg = value;
            }
        }
        #endregion
        #region :: halfaj ::
        protected string _halfaj = null;
        public string halfaj
        {
            get
            {
                if (_halfaj == null) throw new Exception("meg nincs beallitva");
                return _halfaj;
            }
            set
            {
                if (value == null) throw new Exception("nem lehet null");
                if (value.Length < 3 || value.Length > 30) throw new Exception("nem jo halfaj nev");
                _halfaj = value;
            }
        }
        #endregion
    }
}
