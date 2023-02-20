using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace otoslotto
{
    public partial class Form1 : Form
    {
        public readonly Random random = new Random();
        public readonly int[] selectedNumbers = new int[5];

        public int kivalasztott = 0;
        public Form1()
        {
            InitializeComponent();
            int size = 40;
            int num = 1;

            for (int i = 0; i < 6; i++)
            {
                for (int a = 0; a < 16; a++)
                {
                    Button button = new Button()
                    {
                        Bounds = new Rectangle(a * size, i * size, size, size),
                        Text = num.ToString(),
                        Font = new Font("Arial", 15, FontStyle.Bold),
                        FlatStyle = FlatStyle.Flat,
                        Cursor = Cursors.Hand,
                        Tag = num
                    };

                    button.FlatAppearance.BorderSize = 0;

                    button.Click += (o, e) => {
                        if (o is Button clicked)
                        {
                            if (clicked.BackColor == Color.Red)
                            {
                                clicked.BackColor = Color.Transparent;

                                selectedNumbers[kivalasztott - 1] = -1;
                                kivalasztott--;
                                return;
                            }

                            if (clicked.Tag is int number)
                            {
                                if (kivalasztott >= 5)
                                {
                                    MessageBox.Show("Maximum 5 db számot választhat.", "Sorsolás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                clicked.BackColor = Color.Red;

                                selectedNumbers[kivalasztott] = number;
                                kivalasztott++;
                            }
                        }
                    };

                    panel1.Controls.Add(button);
                    num++;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            talalt.Text = "Találat ->";
            if (kivalasztott < 4 )
            {
                MessageBox.Show("Legalább 4 számot kell választania a sorsoláshoz.", "Sorsolás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int[] szamok = new int[5];

            for (int i = 0; i < 5; i++)
            {
                int rd = random.Next(0, 91);

                foreach (int one in szamok)
                {
                    while (one == rd)
                    {
                        rd = random.Next(0, 91);
                    }
                }
                szamok[i] = rd;

            }
            var filtered = selectedNumbers.Where(one => one != -1);

            megjatszott.Text = $"Megjátszott -> {string.Join(", ", filtered)}";
            nyeroszamok.Text = $"Nyerőszámok -> {string.Join(", ", szamok)}";

            string tal = "";

            foreach (int one in filtered)
            {
                foreach (int ran in szamok)
                {
                    if (one == ran)
                    {
                        if (tal.Length != 0)
                        {
                            tal += ", ";
                        }

                        tal += $"{one}";
                    }
                }
            }

            if (tal.Length != 0)
            {
                talalt.Text = $"Találat -> {tal}";
            }
        }
    }
}
