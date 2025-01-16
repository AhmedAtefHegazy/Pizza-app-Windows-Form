using System.Windows.Forms;

namespace Pizza_app
{

    public partial class frmOrderPizza : Form
    {
        byte TotalPrice = 20;
        string[] Toppings = new string[6] { "", "", "", "", "", "" };

        public frmOrderPizza()
        {
            InitializeComponent();
            lblPrice.Text = "$20";
            lblToppingsValue.Text = "No Toppings.";

        }

        private void IsNoToppings()
        {

            if ((lblToppingsValue.Text == "" || lblToppingsValue.Text == "\n"))
            {
                lblToppingsValue.Text = "No Toppings.";
            }
        }

        private void ChangeToppingText(string[] Toppings)
        {
            lblToppingsValue.Text = "";

            if (lblToppingsValue.Text != "" && lblToppingsValue.Text.Substring(0, 1) == ",")
            {
                lblToppingsValue.Text.Replace(",", "");
            }

            for (byte i = 0; i < 6; i++)
            {


                if (Toppings[i] != "" && i != 0)
                {
                    lblToppingsValue.Text += ",";
                }

                if (i == 3)
                {
                    lblToppingsValue.Text += "\n";
                }

                lblToppingsValue.Text += Toppings[i];
            }



            IsNoToppings();

        }

        private void rbtnSmall_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtnSmall.Checked)
            {
                TotalPrice += 5;
                lblPrice.Text = "$" + TotalPrice.ToString();
                lblSizeValue.Text = "Small";
            }

            else
            {
                TotalPrice -= 5;
                lblPrice.Text = "";
            }
        }

        private void rbtnMeduim_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtnMeduim.Checked)
            {
                TotalPrice += 10;
                lblPrice.Text = "$" + TotalPrice.ToString();

                lblSizeValue.Text = "Meduim";
            }

            else
            {
                TotalPrice -= 10;
                lblPrice.Text = "";
            }
        }

        private void rbtnLarge_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtnLarge.Checked)
            {
                TotalPrice += 20;
                lblPrice.Text = "$" + TotalPrice.ToString();
                lblSizeValue.Text = "Large";
            }

            else
            {
                TotalPrice -= 20;
                lblPrice.Text = "";
            }
        }

        private void rbtnThinCrust_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtnThinCrust.Checked == true)
            {
                TotalPrice += 10;
                lblPrice.Text = "$" + TotalPrice.ToString();
                lblCrustValue.Text = "Thin Crust";
            }

            else
            {
                TotalPrice -= 10;
            }
        }

        private void rbtnThickCrust_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtnThickCrust.Checked == true)
            {
                TotalPrice += 10;
                lblPrice.Text = "$" + TotalPrice.ToString();
                lblCrustValue.Text = "Thick Crust";
            }

            else
            {
                TotalPrice -= 10;
                lblPrice.Text = "$" + TotalPrice.ToString();
                lblCrustValue.Text = "Thin Crust";
            }
        }

        private void rbtnEatIn_CheckedChanged(object sender, System.EventArgs e)
        {
            lblEatValue.Text = "Eat In";
        }

        private void rbtnTakeOut_CheckedChanged(object sender, System.EventArgs e)
        {
            lblEatValue.Text = "Take Out";
        }

        private void chkExtraCheese_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkExtraCheese.Checked)
            {
                TotalPrice += 5;
                lblPrice.Text = "$" + TotalPrice.ToString();

                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "")
                    {
                        Toppings[i] = "Extra Cheese";
                        break;
                    }

                }
                ChangeToppingText(Toppings);
            }

            else
            {
                TotalPrice -= 5;
                lblPrice.Text = "$" + TotalPrice.ToString();

                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "Extra Cheese")
                    {
                        Toppings[i] = "";
                        break;
                    }


                }
                ChangeToppingText(Toppings);
            }
        }

        private void chkOnion_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkOnion.Checked)
            {
                TotalPrice += 5;
                lblPrice.Text = "$" + TotalPrice.ToString();
                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "")
                    {
                        Toppings[i] = "Onion";
                        break;
                    }
                }
                ChangeToppingText(Toppings);
            }

            else
            {
                TotalPrice -= 5;
                lblPrice.Text = "$" + TotalPrice.ToString();
                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "Onion")
                    {
                        Toppings[i] = "";
                        break;
                    }

                }
                ChangeToppingText(Toppings);
            }

        }

        private void chkMushrooms_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkMushrooms.Checked)
            {
                TotalPrice += 5;
                lblPrice.Text = "$" + TotalPrice.ToString();

                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "")
                    {
                        Toppings[i] = "Mushrooms";
                        break;
                    }
                }
                ChangeToppingText(Toppings);
            }

            else
            {
                TotalPrice -= 5;
                lblPrice.Text = "$" + TotalPrice.ToString();

                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "Mushrooms")
                    {
                        Toppings[i] = "";
                        break;
                    }
                }
                ChangeToppingText(Toppings);
            }
        }

        private void chkOlives_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkOlives.Checked)
            {
                TotalPrice += 5;
                lblPrice.Text = "$" + TotalPrice.ToString();

                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "")
                    {
                        Toppings[i] = "Olives";
                        break;
                    }

                }
                ChangeToppingText(Toppings);
            }

            else
            {
                TotalPrice -= 5;
                lblPrice.Text = "$" + TotalPrice.ToString();

                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "Olives")
                    {
                        Toppings[i] = "";
                        break;
                    }
                }
                ChangeToppingText(Toppings);
            }
        }

        private void chkTomatoes_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkTomatoes.Checked)
            {
                TotalPrice += 5;
                lblPrice.Text = "$" + TotalPrice.ToString();

                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "")
                    {
                        Toppings[i] = "Tomatoes";
                        break;
                    }
                }
                ChangeToppingText(Toppings);
            }

            else
            {
                TotalPrice -= 5;
                lblPrice.Text = "$" + TotalPrice.ToString();

                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "Tomatoes")
                    {
                        Toppings[i] = "";
                        break;
                    }
                }
                ChangeToppingText(Toppings);
            }
        }

        private void chkGreenPeppers_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkGreenPeppers.Checked)
            {
                TotalPrice += 5;
                lblPrice.Text = "$" + TotalPrice.ToString();

                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "")
                    {
                        Toppings[i] = "GreenPeppers";
                        break;
                    }
                }
                ChangeToppingText(Toppings);

            }

            else
            {
                TotalPrice -= 5;
                lblPrice.Text = "$" + TotalPrice.ToString();

                for (byte i = 0; i < 6; i++)
                {
                    if (Toppings[i] == "GreenPeppers")
                    {
                        Toppings[i] = "";
                        break;
                    }
                }
                ChangeToppingText(Toppings);
            }
        }

        private void btnOrderPizza_Click(object sender, System.EventArgs e)
        {

            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                gbCrustType.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }
        }

        private void btnResetOrder_Click(object sender, System.EventArgs e)
        {
            gbCrustType.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;
            rbtnMeduim.Checked = true;
            rbtnThinCrust.Checked = true;
            rbtnEatIn.Checked = true;
            chkExtraCheese.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
        }
    }
}
