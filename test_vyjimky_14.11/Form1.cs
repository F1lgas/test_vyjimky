using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_vyjimky_14._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pocet = 0;
                double soucet = 0;
                int cislo = 0;

                string[] pole = textBox1.Lines;

                for (int i = 0; i < pole.Length; i++)
                {
                    cislo = Convert.ToInt32(pole[i]);

                    if (cislo < 0)
                    {
                        soucet += cislo;
                        pocet++;
                    }
                }

                double vysledek = soucet / pocet;
                MessageBox.Show("Aritmetrický průměr záporných čísel je " + vysledek);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Zadal jsi moc velké číslo!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Na vstupu nejsou pouze čísla!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Nezadal jsi žádné záporné číslo!");
            }
        }
    }
}
