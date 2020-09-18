namespace ComputerManagment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shutdownBtn = new System.Windows.Forms.PictureBox();
            this.altavozBtn = new System.Windows.Forms.PictureBox();
            this.cascosBtn = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.shutdownBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altavozBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascosBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.Image = global::ComputerManagment.Properties.Resources.shutdown;
            this.shutdownBtn.InitialImage = global::ComputerManagment.Properties.Resources.shutdown;
            this.shutdownBtn.Location = new System.Drawing.Point(70, 69);
            this.shutdownBtn.Name = "shutdownBtn";
            this.shutdownBtn.Size = new System.Drawing.Size(282, 247);
            this.shutdownBtn.TabIndex = 0;
            this.shutdownBtn.TabStop = false;
            this.shutdownBtn.Click += new System.EventHandler(this.handleClick);
            this.shutdownBtn.MouseHover += new System.EventHandler(this.handleHover);
            // 
            // altavozBtn
            // 
            this.altavozBtn.BackColor = System.Drawing.SystemColors.Control;
            this.altavozBtn.Image = global::ComputerManagment.Properties.Resources.altavoces;
            this.altavozBtn.InitialImage = global::ComputerManagment.Properties.Resources.altavoces;
            this.altavozBtn.Location = new System.Drawing.Point(567, 69);
            this.altavozBtn.Name = "altavozBtn";
            this.altavozBtn.Size = new System.Drawing.Size(282, 247);
            this.altavozBtn.TabIndex = 1;
            this.altavozBtn.TabStop = false;
            this.altavozBtn.Click += new System.EventHandler(this.handleClick);
            this.altavozBtn.MouseEnter += new System.EventHandler(this.handleHover);
            // 
            // cascosBtn
            // 
            this.cascosBtn.Image = global::ComputerManagment.Properties.Resources.cascos;
            this.cascosBtn.InitialImage = global::ComputerManagment.Properties.Resources.cascos;
            this.cascosBtn.Location = new System.Drawing.Point(1039, 69);
            this.cascosBtn.Name = "cascosBtn";
            this.cascosBtn.Size = new System.Drawing.Size(282, 247);
            this.cascosBtn.TabIndex = 2;
            this.cascosBtn.TabStop = false;
            this.cascosBtn.Click += new System.EventHandler(this.handleClick);
            this.cascosBtn.MouseEnter += new System.EventHandler(this.handleHover);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 411);
            this.Controls.Add(this.cascosBtn);
            this.Controls.Add(this.altavozBtn);
            this.Controls.Add(this.shutdownBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.shutdownBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altavozBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cascosBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox shutdownBtn;
        private System.Windows.Forms.PictureBox altavozBtn;
        private System.Windows.Forms.PictureBox cascosBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

