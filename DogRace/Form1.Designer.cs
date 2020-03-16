namespace DogRace
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Dog1 = new System.Windows.Forms.CheckBox();
            this.Dog2 = new System.Windows.Forms.CheckBox();
            this.Dog3 = new System.Windows.Forms.CheckBox();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.PlayerNo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Dog4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Dog ";
            // 
            // Dog1
            // 
            this.Dog1.AutoSize = true;
            this.Dog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dog1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dog1.Location = new System.Drawing.Point(23, 73);
            this.Dog1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(133, 33);
            this.Dog1.TabIndex = 2;
            this.Dog1.Text = "First Dog";
            this.Dog1.UseVisualStyleBackColor = true;
            this.Dog1.CheckedChanged += new System.EventHandler(this.Dog1_CheckedChanged);
            // 
            // Dog2
            // 
            this.Dog2.AutoSize = true;
            this.Dog2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dog2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dog2.Location = new System.Drawing.Point(21, 107);
            this.Dog2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(169, 33);
            this.Dog2.TabIndex = 3;
            this.Dog2.Text = "Second Dog";
            this.Dog2.UseVisualStyleBackColor = true;
            this.Dog2.CheckedChanged += new System.EventHandler(this.Dog2_CheckedChanged);
            // 
            // Dog3
            // 
            this.Dog3.AutoSize = true;
            this.Dog3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dog3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dog3.Location = new System.Drawing.Point(23, 145);
            this.Dog3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(143, 33);
            this.Dog3.TabIndex = 4;
            this.Dog3.Text = "Third Dog";
            this.Dog3.UseVisualStyleBackColor = true;
            this.Dog3.CheckedChanged += new System.EventHandler(this.Dog3_CheckedChanged);
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.ForeColor = System.Drawing.SystemColors.Control;
            this.Player1.Location = new System.Drawing.Point(205, 76);
            this.Player1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(178, 24);
            this.Player1.TabIndex = 5;
            this.Player1.Text = "Aman has 90 Dollar ";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.ForeColor = System.Drawing.SystemColors.Control;
            this.Player2.Location = new System.Drawing.Point(205, 116);
            this.Player2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(172, 24);
            this.Player2.TabIndex = 6;
            this.Player2.Text = "Addy has 90 Dollar ";
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3.ForeColor = System.Drawing.SystemColors.Control;
            this.Player3.Location = new System.Drawing.Point(205, 154);
            this.Player3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(181, 24);
            this.Player3.TabIndex = 7;
            this.Player3.Text = "Sandy has 90 Dollar ";
            // 
            // PlayerNo
            // 
            this.PlayerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNo.Location = new System.Drawing.Point(587, 74);
            this.PlayerNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerNo.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.PlayerNo.Name = "PlayerNo";
            this.PlayerNo.Size = new System.Drawing.Size(160, 30);
            this.PlayerNo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(580, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter the Player No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(580, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter the Bet Value ";
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(587, 149);
            this.Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Amount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(160, 30);
            this.Amount.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(904, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 57);
            this.button1.TabIndex = 12;
            this.button1.Text = "Better";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(904, 132);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 57);
            this.button2.TabIndex = 13;
            this.button2.Text = "Race";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(3, 214);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1241, 342);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // p1
            // 
            this.p1.Image = global::DogRace.Properties.Resources.dogy1;
            this.p1.Location = new System.Drawing.Point(16, 228);
            this.p1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(133, 62);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 15;
            this.p1.TabStop = false;
            // 
            // p2
            // 
            this.p2.Image = global::DogRace.Properties.Resources.dogy2;
            this.p2.Location = new System.Drawing.Point(16, 311);
            this.p2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(133, 62);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 16;
            this.p2.TabStop = false;
            // 
            // p3
            // 
            this.p3.Image = global::DogRace.Properties.Resources.dogy3;
            this.p3.Location = new System.Drawing.Point(17, 398);
            this.p3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(133, 62);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 17;
            this.p3.TabStop = false;
            // 
            // p4
            // 
            this.p4.Image = global::DogRace.Properties.Resources.dogy4;
            this.p4.Location = new System.Drawing.Point(17, 480);
            this.p4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(133, 62);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4.TabIndex = 18;
            this.p4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dog4
            // 
            this.Dog4.AutoSize = true;
            this.Dog4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dog4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dog4.Location = new System.Drawing.Point(23, 177);
            this.Dog4.Margin = new System.Windows.Forms.Padding(4);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(142, 33);
            this.Dog4.TabIndex = 19;
            this.Dog4.Text = "Forth Dog";
            this.Dog4.UseVisualStyleBackColor = true;
            this.Dog4.CheckedChanged += new System.EventHandler(this.Dog4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1249, 556);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayerNo);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Dog1;
        private System.Windows.Forms.CheckBox Dog2;
        private System.Windows.Forms.CheckBox Dog3;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.NumericUpDown PlayerNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox Dog4;
    }
}

