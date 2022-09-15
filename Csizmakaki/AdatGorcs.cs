using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csizmakaki
{
    class AdatGorcs
    {
        private int elso;

        public int Elso
        {
            get { return elso; }
            set { elso = value; }
        }

        private string masodik;

        public string Masodik
        {
            get { return masodik; }
            set { masodik = value; }
        }

        private int harmadik;

        public int Harmadik
        {
            get { return harmadik; }
            set { harmadik = value; }
        }

        public AdatGorcs(string a)
        {
            string[] temp = a.Split();
            Elso = Convert.ToInt32(temp[0]);
            Masodik = temp[1];
            Harmadik = Convert.ToInt32(temp[2]);


        }

    }
}
