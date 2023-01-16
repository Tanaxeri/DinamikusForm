using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikusForm
{

    public partial class MainForm : Form
    {

        int sorokSzama = 3;
        int oszlopokSzama = 6;
        int buttonSize = 60;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < sorokSzama; i++)
            {

                for (int j = 0; j < oszlopokSzama; j++)
                {

                    Button button = new Button();
                    button.SetBounds(j * buttonSize, i * buttonSize, buttonSize, buttonSize);
                    button.Text = (i * oszlopokSzama + j).ToString();
                    button.Click += (o, ev)=>{

                        Button gomb = (Button)o;
                        MessageBox.Show(gomb.Text);
                        gomb.BackColor = Color.Green;

                    }; 
                    tarolo.Controls.Add(button);

                }

            }

        }

    }

}
