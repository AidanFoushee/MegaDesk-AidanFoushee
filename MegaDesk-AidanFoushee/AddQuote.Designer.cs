namespace MegaDesk_AidanFoushee
{
    partial class AddQuote
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
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.errorMessage1 = new System.Windows.Forms.Label();
            this.errorMessage2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.drawersInput = new System.Windows.Forms.NumericUpDown();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.deskMaterialSelector = new System.Windows.Forms.ComboBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.errorMessage3 = new System.Windows.Forms.Label();
            this.errorMessage4 = new System.Windows.Forms.Label();
            this.rushOrder = new System.Windows.Forms.CheckedListBox();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(81, 68);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(118, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Desk Width: (24in-96in)";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(81, 125);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(119, 13);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Desk Depth: (12in-48in)";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(84, 84);
            this.widthInput.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(120, 20);
            this.widthInput.TabIndex = 4;
            this.widthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(84, 141);
            this.depthInput.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthInput.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(120, 20);
            this.depthInput.TabIndex = 5;
            this.depthInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // errorMessage1
            // 
            this.errorMessage1.AutoSize = true;
            this.errorMessage1.Location = new System.Drawing.Point(210, 91);
            this.errorMessage1.Name = "errorMessage1";
            this.errorMessage1.Size = new System.Drawing.Size(0, 13);
            this.errorMessage1.TabIndex = 6;
            // 
            // errorMessage2
            // 
            this.errorMessage2.AutoSize = true;
            this.errorMessage2.Location = new System.Drawing.Point(210, 148);
            this.errorMessage2.Name = "errorMessage2";
            this.errorMessage2.Size = new System.Drawing.Size(0, 13);
            this.errorMessage2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(81, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name:";
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(84, 200);
            this.drawersInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(120, 20);
            this.drawersInput.TabIndex = 11;
            // 
            // drawersLabel
            // 
            this.drawersLabel.AutoSize = true;
            this.drawersLabel.Location = new System.Drawing.Point(81, 184);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(122, 13);
            this.drawersLabel.TabIndex = 10;
            this.drawersLabel.Text = "Number ofDrawers: (0-7)";
            // 
            // deskMaterialSelector
            // 
            this.deskMaterialSelector.FormattingEnabled = true;
            this.deskMaterialSelector.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.deskMaterialSelector.Location = new System.Drawing.Point(83, 263);
            this.deskMaterialSelector.Name = "deskMaterialSelector";
            this.deskMaterialSelector.Size = new System.Drawing.Size(121, 21);
            this.deskMaterialSelector.TabIndex = 12;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(81, 247);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(72, 13);
            this.materialLabel.TabIndex = 13;
            this.materialLabel.Text = "Desk Material";
            // 
            // errorMessage3
            // 
            this.errorMessage3.AutoSize = true;
            this.errorMessage3.Location = new System.Drawing.Point(210, 207);
            this.errorMessage3.Name = "errorMessage3";
            this.errorMessage3.Size = new System.Drawing.Size(0, 13);
            this.errorMessage3.TabIndex = 14;
            // 
            // errorMessage4
            // 
            this.errorMessage4.AutoSize = true;
            this.errorMessage4.Location = new System.Drawing.Point(210, 271);
            this.errorMessage4.Name = "errorMessage4";
            this.errorMessage4.Size = new System.Drawing.Size(0, 13);
            this.errorMessage4.TabIndex = 15;
            // 
            // rushOrder
            // 
            this.rushOrder.FormattingEnabled = true;
            this.rushOrder.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days"});
            this.rushOrder.Location = new System.Drawing.Point(83, 328);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(121, 49);
            this.rushOrder.TabIndex = 16;
            // 
            // rushOrderLabel
            // 
            this.rushOrderLabel.AutoSize = true;
            this.rushOrderLabel.Location = new System.Drawing.Point(84, 309);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(99, 13);
            this.rushOrderLabel.TabIndex = 17;
            this.rushOrderLabel.Text = "Rush order options:";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(315, 200);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(19, 13);
            this.totalCost.TabIndex = 18;
            this.totalCost.Text = "$0";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.total.Location = new System.Drawing.Point(275, 200);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(34, 13);
            this.total.TabIndex = 19;
            this.total.Text = "Total:";
            this.total.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(267, 216);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(80, 34);
            this.totalPrice.TabIndex = 20;
            this.totalPrice.Text = "Calculate Total";
            this.totalPrice.UseVisualStyleBackColor = true;
            this.totalPrice.Click += new System.EventHandler(this.totalPrice_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(267, 325);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(175, 52);
            this.mainMenuButton.TabIndex = 21;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.rushOrderLabel);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.errorMessage4);
            this.Controls.Add(this.errorMessage3);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.deskMaterialSelector);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.errorMessage2);
            this.Controls.Add(this.errorMessage1);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.Label errorMessage1;
        private System.Windows.Forms.Label errorMessage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.NumericUpDown drawersInput;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.ComboBox deskMaterialSelector;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label errorMessage3;
        private System.Windows.Forms.Label errorMessage4;
        private System.Windows.Forms.CheckedListBox rushOrder;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button totalPrice;
        private System.Windows.Forms.Button mainMenuButton;
    }
}