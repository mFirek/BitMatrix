using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMatrix
{
    public class BigMatrix
    {
        private BitArray[] data;

        public int Dimension => data.Length;

        public BigMatrix(int n)

        {

            data = new BitArray[n];
            for (int i = 0; i < n; i++)
            {
                data[i] = new BitArray(n);
            }
        }
         public bool this[int i, int j]
        {
            get => data[i][j];
            set { data[i][j] = value; }
        }   
        public override string ToString()
        {
            string wynik = "";
            foreach(var wiersz in data)
            {
                foreach (var komorka in wiersz)
                    wynik += komorka + " ";
                wynik += "\n";
            }
            return wynik;
        }
    }

}
