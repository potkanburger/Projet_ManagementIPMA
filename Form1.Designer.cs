namespace Projet_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(753, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(105, 22);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time: 00:00";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(12, 8);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 1;
            this.progressBar.Value = 10;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Enabled = false;
            this.textBox.Font = new System.Drawing.Font("Plantagenet Cherokee", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.Location = new System.Drawing.Point(139, 69);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(621, 257);
            this.textBox.TabIndex = 2;
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonA.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.Location = new System.Drawing.Point(161, 364);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(268, 94);
            this.buttonA.TabIndex = 3;
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.answer_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonB.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.Location = new System.Drawing.Point(483, 364);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(268, 94);
            this.buttonB.TabIndex = 4;
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.answer_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonC.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(161, 478);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(268, 94);
            this.buttonC.TabIndex = 5;
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.answer_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonD.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD.Location = new System.Drawing.Point(483, 478);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(268, 94);
            this.buttonD.TabIndex = 6;
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.answer_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.PowderBlue;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(139, 47);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(621, 533);
            this.textBoxResult.TabIndex = 7;
            this.textBoxResult.Visible = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(12, 47);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(102, 46);
            this.buttonRestart.TabIndex = 8;
            this.buttonRestart.Text = "Recommencer";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(870, 584);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Projet Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonRestart;
    }
}

