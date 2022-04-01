using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa
{
    public partial class frmCaixa : Form
    {
        string[] codProd = new string[6];
        string[] nomeProd = new string[6];
        decimal[] valorProd = new decimal[6];
        decimal somaTotal;

        public frmCaixa()
        {
            InitializeComponent();
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            loadProducts();
            somaTotal = 0;
        }
        private void loadProducts()
        {
            codProd[1] = "12345";
            codProd[2] = "12346";
            codProd[3] = "12347";
            codProd[4] = "12348";
            codProd[5] = "12349";

            nomeProd[1] = "Tocador de Blu-ray Sony";
            nomeProd[2] = "Rádio com CD Sencon";
            nomeProd[3] = "Toca-fitas Sony";
            nomeProd[4] = "iPod Classic 30GB";
            nomeProd[5] = "iPhone SE 16GB";

            valorProd[1] = 699.00M;
            valorProd[2] = 89.90M;
            valorProd[3] = 119.90M;
            valorProd[4] = 349.00M;
            valorProd[5] = 999.00M;

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if(txtCod.Text.Length == 5)
            {
                int ind = 0;

                for(int cp = 1; cp < 6; cp ++)
                {
                    if(txtCod.Text == codProd[cp])
                    {
                        ind = cp;
                    }
                }

                if (ind > 0)
                {
                    listProd.Items.Add(String.Format("#{0} - {1} - {2:C}", codProd[ind], nomeProd[ind], valorProd[ind]));
                    picProd.ImageLocation = "C:/Users/rigby/Pictures/Produtos/" + codProd[ind] + ".png";
                    somaTotal += valorProd[ind];
                    txtTotal.Text = Convert.ToString("R$" + somaTotal);

                    txtCod.Text = "";
                    txtCod.Focus();


                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                }
            }
        }
    }
}
