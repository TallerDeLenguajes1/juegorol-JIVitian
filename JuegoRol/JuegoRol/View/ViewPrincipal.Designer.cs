
using System.Windows.Forms;

namespace JuegoRol.View
{
    partial class ViewPrincipal
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
            this.lbxPersonajes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.imgPersonaje = new System.Windows.Forms.PictureBox();
            this.btnBatalla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonaje)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxPersonajes
            // 
            this.lbxPersonajes.FormattingEnabled = true;
            this.lbxPersonajes.ItemHeight = 15;
            this.lbxPersonajes.Location = new System.Drawing.Point(10, 40);
            this.lbxPersonajes.Name = "lbxPersonajes";
            this.lbxPersonajes.Size = new System.Drawing.Size(156, 139);
            this.lbxPersonajes.TabIndex = 0;
            this.lbxPersonajes.SelectedIndexChanged += new System.EventHandler(this.lbPersonajes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personajes";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(10, 205);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Nuevo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(91, 205);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // imgPersonaje
            // 
            this.imgPersonaje.Image = global::JuegoRol.Properties.Resources.Arquero;
            this.imgPersonaje.Location = new System.Drawing.Point(217, 22);
            this.imgPersonaje.Name = "imgPersonaje";
            this.imgPersonaje.Size = new System.Drawing.Size(181, 234);
            this.imgPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPersonaje.TabIndex = 4;
            this.imgPersonaje.TabStop = false;
            // 
            // btnBatalla
            // 
            this.btnBatalla.Location = new System.Drawing.Point(10, 233);
            this.btnBatalla.Name = "btnBatalla";
            this.btnBatalla.Size = new System.Drawing.Size(156, 23);
            this.btnBatalla.TabIndex = 5;
            this.btnBatalla.Text = "Batalla";
            this.btnBatalla.UseVisualStyleBackColor = true;
            // 
            // ViewPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.btnBatalla);
            this.Controls.Add(this.imgPersonaje);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxPersonajes);
            this.Name = "ViewPrincipal";
            this.Text = "ViewPrincipal";
            this.VisibleChanged += new System.EventHandler(this.ViewPrincipal_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPersonajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox imgPersonaje;
        private Button btnBatalla;

        public ListBox LbxPersonajes { get => lbxPersonajes; set => lbxPersonajes = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnCrear { get => btnCrear; set => btnCrear = value; }
        public Button BtnBorrar { get => btnBorrar; set => btnBorrar = value; }
        public PictureBox ImgPersonaje { get => imgPersonaje; set => imgPersonaje = value; }
    }
}