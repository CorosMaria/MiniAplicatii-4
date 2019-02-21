namespace Colorare_buton_prin_TrackBar
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
            this.tkBR = new System.Windows.Forms.TrackBar();
            this.tkBB = new System.Windows.Forms.TrackBar();
            this.tkBG = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tkBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkBB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkBG)).BeginInit();
            this.SuspendLayout();
            // 
            // tkBR
            // 
            this.tkBR.Location = new System.Drawing.Point(75, 24);
            this.tkBR.Maximum = 255;
            this.tkBR.Name = "tkBR";
            this.tkBR.Size = new System.Drawing.Size(436, 45);
            this.tkBR.TabIndex = 0;
            this.tkBR.ValueChanged += new System.EventHandler(this.tkBR_ValueChanged);
            // 
            // tkBB
            // 
            this.tkBB.Location = new System.Drawing.Point(75, 75);
            this.tkBB.Maximum = 255;
            this.tkBB.Name = "tkBB";
            this.tkBB.Size = new System.Drawing.Size(436, 45);
            this.tkBB.TabIndex = 1;
            this.tkBB.ValueChanged += new System.EventHandler(this.tkBB_ValueChanged);
            // 
            // tkBG
            // 
            this.tkBG.Location = new System.Drawing.Point(75, 126);
            this.tkBG.Maximum = 255;
            this.tkBG.Name = "tkBG";
            this.tkBG.Size = new System.Drawing.Size(436, 45);
            this.tkBG.TabIndex = 2;
            this.tkBG.ValueChanged += new System.EventHandler(this.tkBG_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 76);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tkBG);
            this.Controls.Add(this.tkBB);
            this.Controls.Add(this.tkBR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tkBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkBB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tkBR;
        private System.Windows.Forms.TrackBar tkBB;
        private System.Windows.Forms.TrackBar tkBG;
        private System.Windows.Forms.Button button1;
    }
}

