
using System.Windows.Forms;

namespace JuegoRol
{
    partial class ViewNuevoPersonaje
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Aleatorio = new System.Windows.Forms.Button();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(29, 95);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(163, 23);
            this.txtNick.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apodo";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(29, 146);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(163, 23);
            this.cbType.TabIndex = 4;
            this.cbType.SelectedValueChanged += new System.EventHandler(this.cbType_SelectedValueChanged);
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(29, 191);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(163, 23);
            this.dtDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clase";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(29, 233);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(117, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Aleatorio
            // 
            this.Aleatorio.Location = new System.Drawing.Point(29, 262);
            this.Aleatorio.Name = "Aleatorio";
            this.Aleatorio.Size = new System.Drawing.Size(163, 23);
            this.Aleatorio.TabIndex = 9;
            this.Aleatorio.Text = "Aleatorio";
            this.Aleatorio.UseVisualStyleBackColor = true;
            this.Aleatorio.Click += new System.EventHandler(this.Aleatorio_Click);
            // 
            // imgPlayer
            // 
            this.imgPlayer.BackColor = System.Drawing.Color.Transparent;
            this.imgPlayer.Location = new System.Drawing.Point(231, 36);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(180, 220);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 10;
            this.imgPlayer.TabStop = false;
            // 
            // ViewNuevoPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 324);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.Aleatorio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "ViewNuevoPersonaje";
            this.Text = "Crear Nuevo Personaje";
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private Button Aleatorio;
        private PictureBox imgPlayer;

        public Button BtnCrear { get => btnCrear; set => btnCrear = value; }
        public Button BtnCancelar { get => btnCancelar; set => btnCancelar = value; }
        public ComboBox CbType { get => cbType; set => cbType = value; }
        public DateTimePicker DtDate { get => dtDate; set => dtDate = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
        public TextBox TxtNick { get => txtNick; set => txtNick = value; }
        public PictureBox ImgPlayer { get => imgPlayer; set => imgPlayer = value; }
    }
}

