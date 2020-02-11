namespace SalsSandwiches
{
    partial class SandwhichBuilder
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameButton = new System.Windows.Forms.Button();
            this.sandType = new System.Windows.Forms.ListBox();
            this.breadBox = new System.Windows.Forms.ListBox();
            this.extrasBox = new System.Windows.Forms.ListBox();
            this.desLabel = new System.Windows.Forms.Label();
            this.askLabel = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(44, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Enter Your Name:";
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(47, 119);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 2;
            this.nameButton.Text = "Enter";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // sandType
            // 
            this.sandType.FormattingEnabled = true;
            this.sandType.Items.AddRange(new object[] {
            "Roast Beef",
            "Ham",
            "Turkey",
            "Bologna"});
            this.sandType.Location = new System.Drawing.Point(270, 83);
            this.sandType.Name = "sandType";
            this.sandType.Size = new System.Drawing.Size(120, 95);
            this.sandType.TabIndex = 3;
            this.sandType.Visible = false;
            this.sandType.SelectedIndexChanged += new System.EventHandler(this.sandType_SelectedIndexChanged);
            // 
            // breadBox
            // 
            this.breadBox.FormattingEnabled = true;
            this.breadBox.Items.AddRange(new object[] {
            "Wheat",
            "Sour Dough",
            "White"});
            this.breadBox.Location = new System.Drawing.Point(421, 83);
            this.breadBox.Name = "breadBox";
            this.breadBox.Size = new System.Drawing.Size(120, 95);
            this.breadBox.TabIndex = 4;
            this.breadBox.Visible = false;
            this.breadBox.SelectedIndexChanged += new System.EventHandler(this.breadBox_SelectedIndexChanged);
            // 
            // extrasBox
            // 
            this.extrasBox.FormattingEnabled = true;
            this.extrasBox.Items.AddRange(new object[] {
            "Mustard",
            "Mayo",
            "Lettuce",
            "Tomatoe",
            "Pickle"});
            this.extrasBox.Location = new System.Drawing.Point(573, 83);
            this.extrasBox.Name = "extrasBox";
            this.extrasBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.extrasBox.Size = new System.Drawing.Size(120, 95);
            this.extrasBox.TabIndex = 5;
            this.extrasBox.Visible = false;
            this.extrasBox.SelectedIndexChanged += new System.EventHandler(this.extrasBox_SelectedIndexChanged);
            // 
            // desLabel
            // 
            this.desLabel.AutoSize = true;
            this.desLabel.Location = new System.Drawing.Point(47, 225);
            this.desLabel.Name = "desLabel";
            this.desLabel.Size = new System.Drawing.Size(157, 13);
            this.desLabel.TabIndex = 6;
            this.desLabel.Text = "Welcome to Sals Sandwhiches!";
            // 
            // askLabel
            // 
            this.askLabel.AutoSize = true;
            this.askLabel.Location = new System.Drawing.Point(345, 292);
            this.askLabel.Name = "askLabel";
            this.askLabel.Size = new System.Drawing.Size(107, 13);
            this.askLabel.TabIndex = 7;
            this.askLabel.Text = "Does this look good?";
            this.askLabel.Visible = false;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(476, 287);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(133, 23);
            this.orderButton.TabIndex = 8;
            this.orderButton.Text = "Submit Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Visible = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // SandwhichBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.askLabel);
            this.Controls.Add(this.desLabel);
            this.Controls.Add(this.extrasBox);
            this.Controls.Add(this.breadBox);
            this.Controls.Add(this.sandType);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "SandwhichBuilder";
            this.Text = "Sandwhich Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.ListBox sandType;
        private System.Windows.Forms.ListBox breadBox;
        private System.Windows.Forms.ListBox extrasBox;
        private System.Windows.Forms.Label desLabel;
        private System.Windows.Forms.Label askLabel;
        private System.Windows.Forms.Button orderButton;
    }
}

