﻿namespace PONG_SIM
{
    partial class SimOutput
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.pbxSim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSim)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTick
            // 
            this.tmrTick.Enabled = true;
            this.tmrTick.Interval = 50;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // pbxSim
            // 
            this.pbxSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxSim.Location = new System.Drawing.Point(0, 0);
            this.pbxSim.Margin = new System.Windows.Forms.Padding(0);
            this.pbxSim.Name = "pbxSim";
            this.pbxSim.Size = new System.Drawing.Size(284, 261);
            this.pbxSim.TabIndex = 0;
            this.pbxSim.TabStop = false;
            this.pbxSim.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxSim_Paint);
            // 
            // SimOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pbxSim);
            this.Name = "SimOutput";
            this.Text = "PONG";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SimOutput_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.PictureBox pbxSim;
    }
}

