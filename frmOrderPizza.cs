using System;
using System.Windows.Forms;

namespace Pizza_app
{

    public partial class frmOrderPizza : Form
    {

        public frmOrderPizza()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }

            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }

            else
            {
                return Convert.ToSingle(rbLarge.Tag);
            }
        }

        float GetToppingsPrice()
        {
            float ToppingsPrice = 0;

            if (chkExtraCheese.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOnion.Tag);

            }

            if (chkTomatos.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkTomatos.Tag);
            }

            return ToppingsPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);

            else
                return Convert.ToSingle(rbThickCrust.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedCrustPrice() + GetSelectedSizePrice() + GetToppingsPrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lblSize.Text = "Meduim";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }

            if (rbThickCrust.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }

        }

        void UpdateEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return;
            }

            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
                return;
            }

        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";


            if (chkExtraCheese.Checked)
            {
                sToppings = "Extra Cheese";
            }

            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkTomatos.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
            {
                sToppings = "No Toppings";
            }

            lblToppings.Text = sToppings;
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrust();
            UpdateEat();
            UpdateToppings();
        }

        void ResetForm()
        {
            //reset Groups
            gbCrustType.Enabled = true;
            gbSize.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbToppings.Enabled = true;

            //reset Size
            rbSmall.Checked = true;

            //reset Crust Type
            rbThinCrust.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //reset Toppings
            chkExtraCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatos.Checked = false;
            chkOnion.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset Order btn
            btnOrderPizza.Enabled = true;
        }

        private void rbtnSmall_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateSize();
        }

        private void rbtnMeduim_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateSize();
        }

        private void rbtnLarge_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateSize();
        }

        private void rbtnThinCrust_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateCrust();
        }

        private void rbtnThickCrust_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateCrust();
        }

        private void rbtnEatIn_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateEat();
        }

        private void rbtnTakeOut_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateEat();
        }

        private void chkExtraCheese_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateToppings();
        }

        private void btnOrderPizza_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbCrustType.Enabled = false;
                gbSize.Enabled = false;
                gbWhereToEat.Enabled = false;
                gbToppings.Enabled = false;

                btnOrderPizza.Enabled = false;

            }

            else
            {
                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnResetOrder_Click(object sender, System.EventArgs e)
        {
            ResetForm();
        }

        private void frmOrderPizza_Load(object sender, System.EventArgs e)
        {
            UpdateOrderSummary();
        }
    }
}
