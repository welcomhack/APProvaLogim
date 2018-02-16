namespace AppRovaLogim2
{
    partial class ventLogim
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventLogim));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSalir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogim = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(380, 69);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::AppRovaLogim2.Properties.Resources.Menu;
            this.bunifuImageButton1.ImageActive = global::AppRovaLogim2.Properties.Resources.Menu2;
            this.bunifuImageButton1.Location = new System.Drawing.Point(332, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // txtPass
            // 
            this.txtPass.BorderColorFocused = System.Drawing.Color.White;
            this.txtPass.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtPass.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtPass.BorderThickness = 3;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.isPassword = true;
            this.txtPass.Location = new System.Drawing.Point(60, 354);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(269, 52);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Contraseña";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsu
            // 
            this.txtUsu.BorderColorFocused = System.Drawing.Color.White;
            this.txtUsu.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtUsu.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtUsu.BorderThickness = 3;
            this.txtUsu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.ForeColor = System.Drawing.Color.White;
            this.txtUsu.isPassword = false;
            this.txtUsu.Location = new System.Drawing.Point(60, 292);
            this.txtUsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(269, 52);
            this.txtUsu.TabIndex = 0;
            this.txtUsu.Text = "Usuario";
            this.txtUsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(57, 556);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(145, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Recuperar contraseña.";
            // 
            // btnNuevo
            // 
            this.btnNuevo.ActiveBorderThickness = 1;
            this.btnNuevo.ActiveCornerRadius = 40;
            this.btnNuevo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.btnNuevo.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuevo.ActiveLineColor = System.Drawing.Color.White;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.IdleBorderThickness = 1;
            this.btnNuevo.IdleCornerRadius = 40;
            this.btnNuevo.IdleFillColor = System.Drawing.Color.White;
            this.btnNuevo.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.btnNuevo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.btnNuevo.Location = new System.Drawing.Point(60, 486);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(240, 54);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveBorderThickness = 1;
            this.btnSalir.ActiveCornerRadius = 20;
            this.btnSalir.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.btnSalir.ActiveForecolor = System.Drawing.Color.White;
            this.btnSalir.ActiveLineColor = System.Drawing.Color.White;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.IdleBorderThickness = 1;
            this.btnSalir.IdleCornerRadius = 20;
            this.btnSalir.IdleFillColor = System.Drawing.Color.White;
            this.btnSalir.IdleForecolor = System.Drawing.Color.Red;
            this.btnSalir.IdleLineColor = System.Drawing.Color.Maroon;
            this.btnSalir.Location = new System.Drawing.Point(328, 647);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 33);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLogim
            // 
            this.btnLogim.ActiveBorderThickness = 1;
            this.btnLogim.ActiveCornerRadius = 40;
            this.btnLogim.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.btnLogim.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogim.ActiveLineColor = System.Drawing.Color.White;
            this.btnLogim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnLogim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogim.BackgroundImage")));
            this.btnLogim.ButtonText = "Iniciar";
            this.btnLogim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogim.IdleBorderThickness = 1;
            this.btnLogim.IdleCornerRadius = 40;
            this.btnLogim.IdleFillColor = System.Drawing.Color.White;
            this.btnLogim.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.btnLogim.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.btnLogim.Location = new System.Drawing.Point(60, 422);
            this.btnLogim.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogim.Name = "btnLogim";
            this.btnLogim.Size = new System.Drawing.Size(240, 54);
            this.btnLogim.TabIndex = 1;
            this.btnLogim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ventLogim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(380, 680);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLogim);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(380, 680);
            this.MinimumSize = new System.Drawing.Size(380, 680);
            this.Name = "ventLogim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logim";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogim;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNuevo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPass;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

