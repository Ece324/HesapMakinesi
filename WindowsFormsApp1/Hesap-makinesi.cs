using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Hesap_makinesi
    {
        
        public int topla(string[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += Convert.ToInt16(sayilar[i]);
            }
            return toplam;
        }

        public int cıkar(string[] sayilar)
        {
            int cikar = Convert.ToInt16(sayilar[0]) - Convert.ToInt16(sayilar[1]);
            for (int i = 2; i < sayilar.Length; i++)
                {
                cikar -= Convert.ToInt16(sayilar[i]);
                    
                }
            return cikar;
        }

        public int carp(string[] sayilar)
        {
            int carp = 1;
            for (int i = 0; i < sayilar.Length; i++)
            {
                carp *= Convert.ToInt16(sayilar[i]);
            }
            return carp;
        }

        public int bol(string[] sayilar)
        {
            double bol = Convert.ToInt16(sayilar[0]) / Convert.ToInt16(sayilar[1]);
            for (int i = 2; i < sayilar.Length; i++)
            {
                bol /= Convert.ToInt16(sayilar[i]);
            }
            return (int)bol;
        }
    }
}
