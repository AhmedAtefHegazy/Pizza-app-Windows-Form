namespace Pizza_app
{
    partial class frmOrderPizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMakeYourPizza = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbtnLarge = new System.Windows.Forms.RadioButton();
            this.rbtnMeduim = new System.Windows.Forms.RadioButton();
            this.rbtnSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbtnThickCrust = new System.Windows.Forms.RadioButton();
            this.rbtnThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbtnTakeOut = new System.Windows.Forms.RadioButton();
            this.rbtnEatIn = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMakeYourPizza
            // 
            this.lblMakeYourPizza.AutoSize = true;
            this.lblMakeYourPizza.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeYourPizza.ForeColor = System.Drawing.Color.Red;
            this.lblMakeYourPizza.Location = new System.Drawing.Point(261, 9);
            this.lblMakeYourPizza.Name = "lblMakeYourPizza";
            this.lblMakeYourPizza.Size = new System.Drawing.Size(824, 103);
            this.lblMakeYourPizza.TabIndex = 0;
            this.lblMakeYourPizza.Text = "Make Your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.SystemColors.Control;
            this.gbSize.Controls.Add(this.rbtnLarge);
            this.gbSize.Controls.Add(this.rbtnMeduim);
            this.gbSize.Controls.Add(this.rbtnSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbSize.Location = new System.Drawing.Point(70, 175);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(170, 181);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbtnLarge
            // 
            this.rbtnLarge.AutoSize = true;
            this.rbtnLarge.Location = new System.Drawing.Point(18, 141);
            this.rbtnLarge.Name = "rbtnLarge";
            this.rbtnLarge.Size = new System.Drawing.Size(63, 20);
            this.rbtnLarge.TabIndex = 2;
            this.rbtnLarge.Tag = "15";
            this.rbtnLarge.Text = "Large";
            this.rbtnLarge.UseVisualStyleBackColor = true;
            // 
            // rbtnMeduim
            // 
            this.rbtnMeduim.AutoSize = true;
            this.rbtnMeduim.Checked = true;
            this.rbtnMeduim.Location = new System.Drawing.Point(18, 87);
            this.rbtnMeduim.Name = "rbtnMeduim";
            this.rbtnMeduim.Size = new System.Drawing.Size(76, 20);
            this.rbtnMeduim.TabIndex = 1;
            this.rbtnMeduim.TabStop = true;
            this.rbtnMeduim.Tag = "10";
            this.rbtnMeduim.Text = "Meduim";
            this.rbtnMeduim.UseVisualStyleBackColor = true;
            // 
            // rbtnSmall
            // 
            this.rbtnSmall.AutoSize = true;
            this.rbtnSmall.Location = new System.Drawing.Point(18, 33);
            this.rbtnSmall.Name = "rbtnSmall";
            this.rbtnSmall.Size = new System.Drawing.Size(62, 20);
            this.rbtnSmall.TabIndex = 0;
            this.rbtnSmall.Tag = "5";
            this.rbtnSmall.Text = "Small";
            this.rbtnSmall.UseVisualStyleBackColor = true;
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbtnThickCrust);
            this.gbCrustType.Controls.Add(this.rbtnThinCrust);
            this.gbCrustType.Location = new System.Drawing.Point(70, 404);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(170, 156);
            this.gbCrustType.TabIndex = 2;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbtnThickCrust
            // 
            this.rbtnThickCrust.AutoSize = true;
            this.rbtnThickCrust.Location = new System.Drawing.Point(18, 108);
            this.rbtnThickCrust.Name = "rbtnThickCrust";
            this.rbtnThickCrust.Size = new System.Drawing.Size(94, 20);
            this.rbtnThickCrust.TabIndex = 4;
            this.rbtnThickCrust.Tag = "10";
            this.rbtnThickCrust.Text = "Thick Crust";
            this.rbtnThickCrust.UseVisualStyleBackColor = true;
            // 
            // rbtnThinCrust
            // 
            this.rbtnThinCrust.AutoSize = true;
            this.rbtnThinCrust.Checked = true;
            this.rbtnThinCrust.Location = new System.Drawing.Point(18, 57);
            this.rbtnThinCrust.Name = "rbtnThinCrust";
            this.rbtnThinCrust.Size = new System.Drawing.Size(87, 20);
            this.rbtnThinCrust.TabIndex = 3;
            this.rbtnThinCrust.TabStop = true;
            this.rbtnThinCrust.Tag = "5";
            this.rbtnThinCrust.Text = "Thin Crust";
            this.rbtnThinCrust.UseVisualStyleBackColor = true;
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Location = new System.Drawing.Point(279, 175);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(318, 181);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Tag = "0";
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(169, 143);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(169, 89);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 20);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(169, 34);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(64, 20);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(29, 141);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(91, 20);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(29, 87);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(99, 20);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(29, 33);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(109, 20);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbtnTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbtnEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(280, 404);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(317, 156);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where to eat";
            // 
            // rbtnTakeOut
            // 
            this.rbtnTakeOut.AutoSize = true;
            this.rbtnTakeOut.Location = new System.Drawing.Point(161, 78);
            this.rbtnTakeOut.Name = "rbtnTakeOut";
            this.rbtnTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rbtnTakeOut.TabIndex = 6;
            this.rbtnTakeOut.Text = "Take Out";
            this.rbtnTakeOut.UseVisualStyleBackColor = true;
            // 
            // rbtnEatIn
            // 
            this.rbtnEatIn.AutoSize = true;
            this.rbtnEatIn.Checked = true;
            this.rbtnEatIn.Location = new System.Drawing.Point(21, 78);
            this.rbtnEatIn.Name = "rbtnEatIn";
            this.rbtnEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbtnEatIn.TabIndex = 5;
            this.rbtnEatIn.TabStop = true;
            this.rbtnEatIn.Text = "Eat in";
            this.rbtnEatIn.UseVisualStyleBackColor = true;
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lblPrice);
            this.gbOrderSummary.Location = new System.Drawing.Point(652, 175);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(654, 385);
            this.gbOrderSummary.TabIndex = 4;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(169, 318);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 43);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Tag = "0";
            this.lblPrice.Text = "0";
           // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(16, 287);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(105, 22);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "Total Price :";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(70, 625);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(527, 61);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.Location = new System.Drawing.Point(779, 625);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(527, 61);
            this.btnResetOrder.TabIndex = 6;
            this.btnResetOrder.Text = "Reset Order";
            this.btnResetOrder.UseVisualStyleBackColor = true;
            // 
            // frmOrderPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 774);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblMakeYourPizza);
            this.Name = "frmOrderPizza";
            this.Text = "Pizza Order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMakeYourPizza;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.RadioButton rbtnLarge;
        private System.Windows.Forms.RadioButton rbtnMeduim;
        private System.Windows.Forms.RadioButton rbtnSmall;
        private System.Windows.Forms.RadioButton rbtnThickCrust;
        private System.Windows.Forms.RadioButton rbtnThinCrust;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.RadioButton rbtnTakeOut;
        private System.Windows.Forms.RadioButton rbtnEatIn;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}