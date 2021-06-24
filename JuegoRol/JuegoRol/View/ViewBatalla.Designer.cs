
using System.Windows.Forms;

namespace JuegoRol.View
{
    partial class ViewBatalla
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
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgCpu = new System.Windows.Forms.PictureBox();
            this.btnAtacarPlayer = new System.Windows.Forms.Button();
            this.lbNombrePlayer = new System.Windows.Forms.Label();
            this.VidaPlayer = new System.Windows.Forms.ProgressBar();
            this.lbNivelPlayer = new System.Windows.Forms.Label();
            this.vidaCpu = new System.Windows.Forms.ProgressBar();
            this.lbNivelCpu = new System.Windows.Forms.Label();
            this.lbNombreCpu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPlayer
            // 
            this.imgPlayer.Location = new System.Drawing.Point(12, 29);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(180, 220);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 0;
            this.imgPlayer.TabStop = false;
            // 
            // imgCpu
            // 
            this.imgCpu.Location = new System.Drawing.Point(441, 28);
            this.imgCpu.Name = "imgCpu";
            this.imgCpu.Size = new System.Drawing.Size(180, 220);
            this.imgCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCpu.TabIndex = 1;
            this.imgCpu.TabStop = false;
            // 
            // btnAtacarPlayer
            // 
            this.btnAtacarPlayer.Location = new System.Drawing.Point(271, 209);
            this.btnAtacarPlayer.Name = "btnAtacarPlayer";
            this.btnAtacarPlayer.Size = new System.Drawing.Size(90, 40);
            this.btnAtacarPlayer.TabIndex = 2;
            this.btnAtacarPlayer.Text = "Atacar";
            this.btnAtacarPlayer.UseVisualStyleBackColor = true;
            this.btnAtacarPlayer.Click += new System.EventHandler(this.btnAtacarPlayer_Click);
            // 
            // lbNombrePlayer
            // 
            this.lbNombrePlayer.Location = new System.Drawing.Point(12, 251);
            this.lbNombrePlayer.Name = "lbNombrePlayer";
            this.lbNombrePlayer.Size = new System.Drawing.Size(180, 15);
            this.lbNombrePlayer.TabIndex = 3;
            this.lbNombrePlayer.Text = "Nombre";
            this.lbNombrePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VidaPlayer
            // 
            this.VidaPlayer.Location = new System.Drawing.Point(24, 13);
            this.VidaPlayer.Name = "VidaPlayer";
            this.VidaPlayer.Size = new System.Drawing.Size(160, 11);
            this.VidaPlayer.TabIndex = 4;
            this.VidaPlayer.Value = 100;
            // 
            // lbNivelPlayer
            // 
            this.lbNivelPlayer.Location = new System.Drawing.Point(12, 279);
            this.lbNivelPlayer.Name = "lbNivelPlayer";
            this.lbNivelPlayer.Size = new System.Drawing.Size(180, 15);
            this.lbNivelPlayer.TabIndex = 5;
            this.lbNivelPlayer.Text = "Nivel";
            this.lbNivelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vidaCpu
            // 
            this.vidaCpu.Location = new System.Drawing.Point(450, 12);
            this.vidaCpu.Name = "vidaCpu";
            this.vidaCpu.Size = new System.Drawing.Size(160, 11);
            this.vidaCpu.TabIndex = 6;
            this.vidaCpu.Value = 100;
            // 
            // lbNivelCpu
            // 
            this.lbNivelCpu.Location = new System.Drawing.Point(441, 279);
            this.lbNivelCpu.Name = "lbNivelCpu";
            this.lbNivelCpu.Size = new System.Drawing.Size(180, 15);
            this.lbNivelCpu.TabIndex = 8;
            this.lbNivelCpu.Text = "Nivel";
            this.lbNivelCpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNombreCpu
            // 
            this.lbNombreCpu.Location = new System.Drawing.Point(441, 251);
            this.lbNombreCpu.Name = "lbNombreCpu";
            this.lbNombreCpu.Size = new System.Drawing.Size(180, 15);
            this.lbNombreCpu.TabIndex = 9;
            this.lbNombreCpu.Text = "Nombre";
            this.lbNombreCpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewBatalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 356);
            this.Controls.Add(this.lbNombreCpu);
            this.Controls.Add(this.lbNivelCpu);
            this.Controls.Add(this.vidaCpu);
            this.Controls.Add(this.lbNivelPlayer);
            this.Controls.Add(this.VidaPlayer);
            this.Controls.Add(this.lbNombrePlayer);
            this.Controls.Add(this.btnAtacarPlayer);
            this.Controls.Add(this.imgCpu);
            this.Controls.Add(this.imgPlayer);
            this.Name = "ViewBatalla";
            this.Text = "ViewBatalla";
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCpu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.PictureBox imgCpu;
        private System.Windows.Forms.Button btnAtacarPlayer;
        private System.Windows.Forms.Label lbNombrePlayer;
        private System.Windows.Forms.ProgressBar VidaPlayer;
        private System.Windows.Forms.Label lbNivelPlayer;
        private System.Windows.Forms.ProgressBar vidaCpu;
        private System.Windows.Forms.Label lbNivelCpu;
        private System.Windows.Forms.Label lbNombreCpu;

        public PictureBox ImgPlayer { get => imgPlayer; set => imgPlayer = value; }
        public PictureBox ImgCpu { get => imgCpu; set => imgCpu = value; }
        public Button BtnAtacarPlayer { get => btnAtacarPlayer; set => btnAtacarPlayer = value; }
        public Label LbNombrePlayer { get => lbNombrePlayer; set => lbNombrePlayer = value; }
        public ProgressBar VidaPlayer1 { get => VidaPlayer; set => VidaPlayer = value; }
        public Label LbNivelPlayer { get => lbNivelPlayer; set => lbNivelPlayer = value; }
        public ProgressBar VidaCpu { get => vidaCpu; set => vidaCpu = value; }
        public Label LbNivelCpu { get => lbNivelCpu; set => lbNivelCpu = value; }
        public Label LbNombreCpu { get => lbNombreCpu; set => lbNombreCpu = value; }
    }
}