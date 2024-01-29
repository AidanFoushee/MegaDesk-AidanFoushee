using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk_AidanFoushee
{
    public partial class AddQuote : Form
    {

        Dictionary<string, int> deskMaterials = new Dictionary<string, int>()
        {
            {"Oak", 200 },
            {"Laminate",  100},
            {"Pine", 50 },
            {"Rosewood", 300 },
            {"Veneer", 125}
        };

        public AddQuote()
        {
            InitializeComponent();
        }
        private void totalPrice_Click(object sender, EventArgs e)
        {
            int totalPrice = 200;
            var area = widthInput.Value * depthInput.Value;
            var rushOrderValue = Convert.ToInt32(rushOrder.SelectedValue);
            int surfaceArea = Convert.ToInt32(area);
            if (rushOrderValue < 14 && rushOrderValue != 0)
            {
                if (rushOrderValue == 3)
                {
                    if (surfaceArea < 1000)
                    {
                        totalPrice += 60;
                    }
                    else if (surfaceArea <= 2000)
                    {
                        totalPrice += 70;
                    }
                    else
                    {
                        totalPrice += 80;
                    }
                }
                if (rushOrderValue == 5)
                {
                    if (surfaceArea < 1000)
                    {
                        totalPrice += 40;
                    }
                    else if (surfaceArea <= 2000)
                    {
                        totalPrice += 50;
                    }
                    else
                    {
                        totalPrice += 60;
                    }
                }
                else
                {
                    if (surfaceArea < 1000)
                    {
                        totalPrice += 30;
                    }
                    else if (surfaceArea <= 2000)
                    {
                        totalPrice += 35;
                    }
                    else
                    {
                        totalPrice += 40;
                    }
                }
            }
            if (surfaceArea > 1000)
            {
                totalPrice += surfaceArea;
            }
            totalPrice = totalPrice + Convert.ToInt32(drawersInput.Value) * 50;
            totalPrice += deskMaterials[Convert.ToString(deskMaterialSelector.Text)];

            totalCost.Text = totalPrice.ToString();
        }
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

    }
}
