
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApodo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSalud = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.lblArmadura = new System.Windows.Forms.Label();
            this.Ranking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonaje)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxPersonajes
            // 
            this.lbxPersonajes.FormattingEnabled = true;
            this.lbxPersonajes.ItemHeight = 15;
            this.lbxPersonajes.Location = new System.Drawing.Point(10, 40);
            this.lbxPersonajes.Name = "lbxPersonajes";
            this.lbxPersonajes.Size = new System.Drawing.Size(156, 124);
            this.lbxPersonajes.TabIndex = 0;
            this.lbxPersonajes.SelectedIndexChanged += new System.EventHandler(this.lbPersonajes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personajes";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(10, 170);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Nuevo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(91, 170);
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
            this.imgPersonaje.Location = new System.Drawing.Point(239, 22);
            this.imgPersonaje.Name = "imgPersonaje";
            this.imgPersonaje.Size = new System.Drawing.Size(181, 229);
            this.imgPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPersonaje.TabIndex = 4;
            this.imgPersonaje.TabStop = false;
            // 
            // btnBatalla
            // 
            this.btnBatalla.Location = new System.Drawing.Point(10, 199);
            this.btnBatalla.Name = "btnBatalla";
            this.btnBatalla.Size = new System.Drawing.Size(156, 23);
            this.btnBatalla.TabIndex = 5;
            this.btnBatalla.Text = "Batalla";
            this.btnBatalla.UseVisualStyleBackColor = true;
            this.btnBatalla.Click += new System.EventHandler(this.btnBatalla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(442, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(442, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(38, 15);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "label3";
            // 
            // lblApodo
            // 
            this.lblApodo.AutoSize = true;
            this.lblApodo.Location = new System.Drawing.Point(442, 92);
            this.lblApodo.Name = "lblApodo";
            this.lblApodo.Size = new System.Drawing.Size(38, 15);
            this.lblApodo.TabIndex = 8;
            this.lblApodo.Text = "label4";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(442, 130);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 15);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "label5";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(442, 164);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "label6";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(442, 205);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(38, 15);
            this.lblNivel.TabIndex = 11;
            this.lblNivel.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(613, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Stats";
            // 
            // lblSalud
            // 
            this.lblSalud.AutoSize = true;
            this.lblSalud.Location = new System.Drawing.Point(613, 55);
            this.lblSalud.Name = "lblSalud";
            this.lblSalud.Size = new System.Drawing.Size(38, 15);
            this.lblSalud.TabIndex = 13;
            this.lblSalud.Text = "label9";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(613, 92);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(44, 15);
            this.lblFuerza.TabIndex = 14;
            this.lblFuerza.Text = "label10";
            // 
            // lblDestreza
            // 
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.Location = new System.Drawing.Point(613, 130);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(44, 15);
            this.lblDestreza.TabIndex = 15;
            this.lblDestreza.Text = "label11";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(613, 164);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(44, 15);
            this.lblVelocidad.TabIndex = 16;
            this.lblVelocidad.Text = "label12";
            // 
            // lblArmadura
            // 
            this.lblArmadura.AutoSize = true;
            this.lblArmadura.Location = new System.Drawing.Point(613, 205);
            this.lblArmadura.Name = "lblArmadura";
            this.lblArmadura.Size = new System.Drawing.Size(44, 15);
            this.lblArmadura.TabIndex = 17;
            this.lblArmadura.Text = "label13";
            // 
            // Ranking
            // 
            this.Ranking.Location = new System.Drawing.Point(10, 228);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(156, 23);
            this.Ranking.TabIndex = 18;
            this.Ranking.Text = "Ranking";
            this.Ranking.UseVisualStyleBackColor = true;
            this.Ranking.Click += new System.EventHandler(this.Ranking_Click);
            // 
            // ViewPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.Ranking);
            this.Controls.Add(this.lblArmadura);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.lblDestreza);
            this.Controls.Add(this.lblFuerza);
            this.Controls.Add(this.lblSalud);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApodo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
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
        private Label label2;
        private Label lblNombre;
        private Label lblApodo;
        private Label lblEdad;
        private Label lblFecha;
        private Label lblNivel;
        private Label label8;
        private Label lblSalud;
        private Label lblFuerza;
        private Label lblDestreza;
        private Label lblVelocidad;
        private Label lblArmadura;
        private Button Ranking;

        public ListBox LbxPersonajes { get => lbxPersonajes; set => lbxPersonajes = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnCrear { get => btnCrear; set => btnCrear = value; }
        public Button BtnBorrar { get => btnBorrar; set => btnBorrar = value; }
        public PictureBox ImgPersonaje { get => imgPersonaje; set => imgPersonaje = value; }
        public Label LblSalud { get => lblSalud; set => lblSalud = value; }
        public Label LblFuerza { get => lblFuerza; set => lblFuerza = value; }
        public Label LblDestreza { get => lblDestreza; set => lblDestreza = value; }
        public Label LblVelocidad { get => lblVelocidad; set => lblVelocidad = value; }
        public Label LblArmadura { get => lblArmadura; set => lblArmadura = value; }
        public Label LblNombre { get => lblNombre; set => lblNombre = value; }
        public Label LblApodo { get => lblApodo; set => lblApodo = value; }
        public Label LblEdad { get => lblEdad; set => lblEdad = value; }
        public Label LblFecha { get => lblFecha; set => lblFecha = value; }
        public Label LblNivel { get => lblNivel; set => lblNivel = value; }
    }
}