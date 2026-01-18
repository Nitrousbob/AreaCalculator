namespace AreaCalculator4
{
    partial class frmArea
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtWidth = new TextBox();
            lblWidth = new Label();
            lblHeight = new Label();
            txtHeight = new TextBox();
            btnCalculate = new Button();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(126, 27);
            txtWidth.Margin = new Padding(4, 5, 4, 5);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(141, 31);
            txtWidth.TabIndex = 0;
            txtWidth.Text = "0";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(61, 32);
            lblWidth.Margin = new Padding(4, 0, 4, 0);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(60, 25);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(61, 80);
            lblHeight.Margin = new Padding(4, 0, 4, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(65, 25);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Height";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(126, 75);
            txtHeight.Margin = new Padding(4, 5, 4, 5);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(141, 31);
            txtHeight.TabIndex = 2;
            txtHeight.Text = "0";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(160, 189);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(107, 38);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(199, 124);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(68, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: 0";
            lblTotal.Click += lblTotal_Click;
            // 
            // frmArea
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 282);
            Controls.Add(lblTotal);
            Controls.Add(btnCalculate);
            Controls.Add(lblHeight);
            Controls.Add(txtHeight);
            Controls.Add(lblWidth);
            Controls.Add(txtWidth);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmArea";
            Text = "Area";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWidth;
        private Label lblWidth;
        private Label lblHeight;
        private TextBox txtHeight;
        private Button btnCalculate;
        private Label lblTotal;
    }
}
