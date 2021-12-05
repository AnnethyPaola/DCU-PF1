
namespace ProyectoFinal
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
            this.pictureCap = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCapturar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDectetar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTrain = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnrecognize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picDectetar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtvacunado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCap)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDectetar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureCap
            // 
            this.pictureCap.Location = new System.Drawing.Point(12, 64);
            this.pictureCap.Name = "pictureCap";
            this.pictureCap.Size = new System.Drawing.Size(271, 296);
            this.pictureCap.TabIndex = 0;
            this.pictureCap.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 58);
            this.panel1.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(921, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 29);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(247, 42);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Proyecto Final";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCapturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCapturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapturar.BorderRadius = 6;
            this.btnCapturar.ButtonText = "Capturar Rostro";
            this.btnCapturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapturar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCapturar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCapturar.Iconimage = null;
            this.btnCapturar.Iconimage_right = null;
            this.btnCapturar.Iconimage_right_Selected = null;
            this.btnCapturar.Iconimage_Selected = null;
            this.btnCapturar.IconMarginLeft = 0;
            this.btnCapturar.IconMarginRight = 0;
            this.btnCapturar.IconRightVisible = true;
            this.btnCapturar.IconRightZoom = 0D;
            this.btnCapturar.IconVisible = true;
            this.btnCapturar.IconZoom = 90D;
            this.btnCapturar.IsTab = false;
            this.btnCapturar.Location = new System.Drawing.Point(38, 377);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCapturar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCapturar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCapturar.selected = false;
            this.btnCapturar.Size = new System.Drawing.Size(221, 48);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar Rostro";
            this.btnCapturar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCapturar.Textcolor = System.Drawing.Color.White;
            this.btnCapturar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnDectetar
            // 
            this.btnDectetar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDectetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDectetar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDectetar.BorderRadius = 6;
            this.btnDectetar.ButtonText = "Dectetar  Rostro";
            this.btnDectetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDectetar.DisabledColor = System.Drawing.Color.Gray;
            this.btnDectetar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDectetar.Iconimage = null;
            this.btnDectetar.Iconimage_right = null;
            this.btnDectetar.Iconimage_right_Selected = null;
            this.btnDectetar.Iconimage_Selected = null;
            this.btnDectetar.IconMarginLeft = 0;
            this.btnDectetar.IconMarginRight = 0;
            this.btnDectetar.IconRightVisible = true;
            this.btnDectetar.IconRightZoom = 0D;
            this.btnDectetar.IconVisible = true;
            this.btnDectetar.IconZoom = 90D;
            this.btnDectetar.IsTab = false;
            this.btnDectetar.Location = new System.Drawing.Point(302, 377);
            this.btnDectetar.Name = "btnDectetar";
            this.btnDectetar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDectetar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDectetar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDectetar.selected = false;
            this.btnDectetar.Size = new System.Drawing.Size(332, 48);
            this.btnDectetar.TabIndex = 5;
            this.btnDectetar.Text = "Dectetar  Rostro";
            this.btnDectetar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDectetar.Textcolor = System.Drawing.Color.White;
            this.btnDectetar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDectetar.Click += new System.EventHandler(this.btnDectetar_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrain.BorderRadius = 6;
            this.btnTrain.ButtonText = "Imagenes capturadas";
            this.btnTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrain.DisabledColor = System.Drawing.Color.Gray;
            this.btnTrain.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTrain.Iconimage = null;
            this.btnTrain.Iconimage_right = null;
            this.btnTrain.Iconimage_right_Selected = null;
            this.btnTrain.Iconimage_Selected = null;
            this.btnTrain.IconMarginLeft = 0;
            this.btnTrain.IconMarginRight = 0;
            this.btnTrain.IconRightVisible = true;
            this.btnTrain.IconRightZoom = 0D;
            this.btnTrain.IconVisible = true;
            this.btnTrain.IconZoom = 90D;
            this.btnTrain.IsTab = false;
            this.btnTrain.Location = new System.Drawing.Point(713, 262);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTrain.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTrain.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTrain.selected = false;
            this.btnTrain.Size = new System.Drawing.Size(213, 38);
            this.btnTrain.TabIndex = 8;
            this.btnTrain.Text = "Imagenes capturadas";
            this.btnTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrain.Textcolor = System.Drawing.Color.White;
            this.btnTrain.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnrecognize
            // 
            this.btnrecognize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnrecognize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnrecognize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrecognize.BorderRadius = 6;
            this.btnrecognize.ButtonText = "Reconocer rostro";
            this.btnrecognize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrecognize.DisabledColor = System.Drawing.Color.Gray;
            this.btnrecognize.Iconcolor = System.Drawing.Color.Transparent;
            this.btnrecognize.Iconimage = null;
            this.btnrecognize.Iconimage_right = null;
            this.btnrecognize.Iconimage_right_Selected = null;
            this.btnrecognize.Iconimage_Selected = null;
            this.btnrecognize.IconMarginLeft = 0;
            this.btnrecognize.IconMarginRight = 0;
            this.btnrecognize.IconRightVisible = true;
            this.btnrecognize.IconRightZoom = 0D;
            this.btnrecognize.IconVisible = true;
            this.btnrecognize.IconZoom = 90D;
            this.btnrecognize.IsTab = false;
            this.btnrecognize.Location = new System.Drawing.Point(713, 65);
            this.btnrecognize.Name = "btnrecognize";
            this.btnrecognize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnrecognize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnrecognize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnrecognize.selected = false;
            this.btnrecognize.Size = new System.Drawing.Size(213, 38);
            this.btnrecognize.TabIndex = 9;
            this.btnrecognize.Text = "Reconocer rostro";
            this.btnrecognize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrecognize.Textcolor = System.Drawing.Color.White;
            this.btnrecognize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecognize.Click += new System.EventHandler(this.btnrecognize_Click);
            // 
            // picDectetar
            // 
            this.picDectetar.Location = new System.Drawing.Point(713, 109);
            this.picDectetar.Name = "picDectetar";
            this.picDectetar.Size = new System.Drawing.Size(213, 124);
            this.picDectetar.TabIndex = 10;
            this.picDectetar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(674, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 128);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(820, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 128);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vacunado:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(24, 56);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(135, 17);
            this.txtnombre.TabIndex = 4;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(177, 56);
            this.txtcorreo.Multiline = true;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(135, 17);
            this.txtcorreo.TabIndex = 5;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(16, 147);
            this.txttelefono.Multiline = true;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(135, 21);
            this.txttelefono.TabIndex = 6;
            this.txttelefono.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtvacunado
            // 
            this.txtvacunado.Location = new System.Drawing.Point(177, 147);
            this.txtvacunado.Multiline = true;
            this.txtvacunado.Name = "txtvacunado";
            this.txtvacunado.Size = new System.Drawing.Size(135, 21);
            this.txtvacunado.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 6;
            this.btnAgregar.ButtonText = "Agregar persona";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = null;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 90D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(16, 219);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(296, 38);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar persona";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.txtvacunado);
            this.panel2.Controls.Add(this.txttelefono);
            this.panel2.Controls.Add(this.txtcorreo);
            this.panel2.Controls.Add(this.txtnombre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(302, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 295);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 446);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.picDectetar);
            this.Controls.Add(this.btnrecognize);
            this.Controls.Add(this.btnDectetar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureCap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDectetar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCap;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCapturar;
        private Bunifu.Framework.UI.BunifuFlatButton btnDectetar;
        private Bunifu.Framework.UI.BunifuFlatButton btnTrain;
        private Bunifu.Framework.UI.BunifuFlatButton btnrecognize;
        private System.Windows.Forms.PictureBox picDectetar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private System.Windows.Forms.TextBox txtvacunado;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

