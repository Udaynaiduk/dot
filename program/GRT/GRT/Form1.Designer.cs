namespace GRT
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.CLose = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(239, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(39, 15);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Name";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.AutoSize = true;
            this.txtAdd.Location = new System.Drawing.Point(229, 175);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(49, 15);
            this.txtAdd.TabIndex = 1;
            this.txtAdd.Text = "Address";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(371, 117);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 23);
            this.txtN.TabIndex = 2;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(371, 167);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 23);
            this.txtA.TabIndex = 3;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(574, 171);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // CLose
            // 
            this.CLose.Location = new System.Drawing.Point(572, 223);
            this.CLose.Name = "CLose";
            this.CLose.Size = new System.Drawing.Size(75, 23);
            this.CLose.TabIndex = 7;
            this.CLose.Text = "Close";
            this.CLose.UseVisualStyleBackColor = true;
            this.CLose.Click += new System.EventHandler(this.CLose_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(418, 232);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(75, 23);
            this.btnRest.TabIndex = 8;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.CLose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtName;
        private Label txtAdd;
        private TextBox txtN;
        private TextBox txtA;
        private Button button1;
        private Button button2;
        private Button btnNext;
        private Button CLose;
        private Button btnRest;
    }
}