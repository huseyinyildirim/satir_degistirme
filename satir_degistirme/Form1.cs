using System;
using System.IO;
using System.Windows.Forms;

namespace satir_degistirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string Degistir(string k)
        {
            string[] sifre =
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s",
                "u", "t", "v", "y", "z", "q", "x", "w", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z", "Q", "X", "W"
            };

            string[] gercek =
            {
                "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "R", "Z", "A", "B", "C", "E", "F",
                "H", "G", "İ", "l", "M", "D", "K", "J", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                "a", "b", "c", "e", "f", "g", "h", "i", "l", "m", "d", "k", "j"
            };

            for (int i = 0; i < sifre.Length; i++)
            {
                if (sifre[i]==k)
                {
                    return gercek[i];
                }
            }

            return k;

            //return k.Replace("a", "N")
            //            .Replace("b", "O")
            //            .Replace("c", "P")
            //            .Replace("d", "Q")
            //            .Replace("e", "R")
            //            .Replace("f", "S")
            //            .Replace("g", "T")
            //            .Replace("h", "U")
            //            .Replace("i", "V")
            //            .Replace("j", "W")
            //            .Replace("k", "X")
            //            .Replace("l", "R")
            //            .Replace("m", "Z")
            //            .Replace("n", "A")
            //            .Replace("o", "B")
            //            .Replace("p", "C")
            //            .Replace("r", "E")
            //            .Replace("s", "F")
            //            .Replace("u", "H")
            //            .Replace("t", "G")
            //            .Replace("v", "İ")
            //            .Replace("y", "l")
            //            .Replace("z", "M")
            //            .Replace("q", "D")
            //            .Replace("x", "K")
            //            .Replace("w", "J")
            //            .Replace("A", "n")
            //            .Replace("B", "o")
            //            .Replace("C", "p")
            //            .Replace("D", "q")
            //            .Replace("E", "r")
            //            .Replace("F", "s")
            //            .Replace("G", "t")
            //            .Replace("H", "u")
            //            .Replace("I", "v")
            //            .Replace("J", "w")
            //            .Replace("K", "x")
            //            .Replace("L", "y")
            //            .Replace("M", "z")
            //            .Replace("N", "a")
            //            .Replace("O", "b")
            //            .Replace("P", "c")
            //            .Replace("R", "e")
            //            .Replace("S", "f")
            //            .Replace("T", "g")
            //            .Replace("U", "h")
            //            .Replace("V", "i")
            //            .Replace("Y", "l")
            //            .Replace("Z", "m")
            //            .Replace("Q", "d")
            //            .Replace("X", "k")
            //            .Replace("W", "j");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\huseyinyildirim\Desktop\App\satir_degistirme\satir_degistirme\ilac.csv"));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split('	');

                string ilac = values[2];

                string yeniIlac = null;

                for (int i = 0; i < ilac.Length; i++)
                {
                    yeniIlac = yeniIlac + Degistir(ilac[i].ToString());
                }


                //textBox1.AppendText(yeniIlac + "	" + values[4] + "	" + values[5] + "	" + values[6]+ "	" + values[7] +
               //                     "	" + values[9] + "	" + values[10] + "	" + values[11] + "	" + "\r\n");

                textBox1.AppendText(values[0] + "	" + values[1] + "	" + values[2] + "	" + DateTime.Parse(values[3]).ToString("yyyy-MM-dd") + "	" + values[4] +
                                    "	" + values[5] + "	" + values[6] + "	" + values[7] + "	" + values[8] + "\r\n");
            }
        }
    }
}
