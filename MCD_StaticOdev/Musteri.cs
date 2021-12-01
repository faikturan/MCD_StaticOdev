﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_StaticOdev
{
    public class Musteri
    {
        #region Sanal Database
        static ArrayList musteriDatabase;
        #endregion

        #region Static Yapıcı Metot
        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }
        #endregion

        #region Field
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string sifre { get; set; }
        #endregion

        #region Kapsulleme
        private string _kullaniciAdi;
        public string KullaniciAdi
        {
            get
            {
                return this._kullaniciAdi;
            }

            set
            {
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);
                if (kullaniciAdiKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlı");
                    this._kullaniciAdi = string.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }
            }
        }
        #endregion

        private bool musteriKullaniciAdiKontrol(string value)
        {
            throw new NotImplementedException();
        }

       

    }
}