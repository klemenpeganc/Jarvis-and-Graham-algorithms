namespace UVRGvaja2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNumPts = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbJarvis = new System.Windows.Forms.RadioButton();
            this.rbGraham = new System.Windows.Forms.RadioButton();
            this.rbQuickhull = new System.Windows.Forms.RadioButton();
            this.btnHull = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 800);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbNumPts
            // 
            this.tbNumPts.Location = new System.Drawing.Point(962, 98);
            this.tbNumPts.Name = "tbNumPts";
            this.tbNumPts.Size = new System.Drawing.Size(67, 22);
            this.tbNumPts.TabIndex = 1;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(921, 126);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(108, 34);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Narisi tocke";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // rbEqual
            // 
            this.rbEqual.Location = new System.Drawing.Point(1, 12);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(153, 41);
            this.rbEqual.TabIndex = 3;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "Enakomerna porazdelitev";
            this.rbEqual.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.Location = new System.Drawing.Point(6, 55);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(122, 43);
            this.rbNormal.TabIndex = 4;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normalna porazdelitev";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(872, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stevilo tock:";
            // 
            // rbJarvis
            // 
            this.rbJarvis.AutoSize = true;
            this.rbJarvis.Location = new System.Drawing.Point(904, 170);
            this.rbJarvis.Name = "rbJarvis";
            this.rbJarvis.Size = new System.Drawing.Size(125, 21);
            this.rbJarvis.TabIndex = 6;
            this.rbJarvis.TabStop = true;
            this.rbJarvis.Text = "Jarvisov obhod";
            this.rbJarvis.UseVisualStyleBackColor = true;
            // 
            // rbGraham
            // 
            this.rbGraham.Location = new System.Drawing.Point(904, 197);
            this.rbGraham.Name = "rbGraham";
            this.rbGraham.Size = new System.Drawing.Size(125, 46);
            this.rbGraham.TabIndex = 7;
            this.rbGraham.TabStop = true;
            this.rbGraham.Text = "Grahamovo prebiranje";
            this.rbGraham.UseVisualStyleBackColor = true;
            // 
            // rbQuickhull
            // 
            this.rbQuickhull.Location = new System.Drawing.Point(904, 238);
            this.rbQuickhull.Name = "rbQuickhull";
            this.rbQuickhull.Size = new System.Drawing.Size(136, 71);
            this.rbQuickhull.TabIndex = 8;
            this.rbQuickhull.TabStop = true;
            this.rbQuickhull.Text = "Hitra konveksna lupina";
            this.rbQuickhull.UseVisualStyleBackColor = true;
            // 
            // btnHull
            // 
            this.btnHull.Location = new System.Drawing.Point(921, 303);
            this.btnHull.Name = "btnHull";
            this.btnHull.Size = new System.Drawing.Size(108, 34);
            this.btnHull.TabIndex = 9;
            this.btnHull.Text = "Narisi lupino";
            this.btnHull.UseVisualStyleBackColor = true;
            this.btnHull.Click += new System.EventHandler(this.btnHull_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEqual);
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Location = new System.Drawing.Point(875, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 98);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTime.Location = new System.Drawing.Point(816, 343);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTime.Size = new System.Drawing.Size(213, 457);
            this.tbTime.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 853);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHull);
            this.Controls.Add(this.rbQuickhull);
            this.Controls.Add(this.rbGraham);
            this.Controls.Add(this.rbJarvis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.tbNumPts);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Vaja 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNumPts;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbJarvis;
        private System.Windows.Forms.RadioButton rbGraham;
        private System.Windows.Forms.RadioButton rbQuickhull;
        private System.Windows.Forms.Button btnHull;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTime;
    }
}

