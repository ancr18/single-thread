namespace single_thread
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
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // numScore
            // 
            this.numScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numScore.Location = new System.Drawing.Point(481, 45);
            this.numScore.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(185, 45);
            this.numScore.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(449, 445);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStart.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(481, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(185, 43);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(482, 152);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(184, 43);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHide.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(481, 201);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(87, 43);
            this.btnHide.TabIndex = 5;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(579, 201);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 43);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(476, 13);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(198, 29);
            this.Label.TabIndex = 7;
            this.Label.Text = "Nilai Maksimum";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Green;
            this.lblResult.Location = new System.Drawing.Point(485, 261);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 29);
            this.lblResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 471);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.numScore);
            this.Name = "Form1";
            this.Text = "Single Thread";
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label lblResult;
    }
}

