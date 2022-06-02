
namespace SFTP_Files_Validator
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lvExplorer = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnConf = new System.Windows.Forms.PictureBox();
            this.btnConn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.PictureBox();
            this.btnGoHome = new System.Windows.Forms.PictureBox();
            this.btnGo = new System.Windows.Forms.PictureBox();
            this.btnGoBack = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.72909F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.27091F));
            this.tableLayoutPanel2.Controls.Add(this.lvExplorer, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.23565F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.76435F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(801, 662);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lvExplorer
            // 
            this.lvExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.lvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExplorer.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lvExplorer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.lvExplorer.HideSelection = false;
            this.lvExplorer.LargeImageList = this.iconList;
            this.lvExplorer.Location = new System.Drawing.Point(137, 84);
            this.lvExplorer.Name = "lvExplorer";
            this.lvExplorer.Size = new System.Drawing.Size(661, 575);
            this.lvExplorer.SmallImageList = this.iconList;
            this.lvExplorer.TabIndex = 0;
            this.lvExplorer.UseCompatibleStateImageBehavior = false;
            this.lvExplorer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvExplorer_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "file.png");
            this.iconList.Images.SetKeyName(1, "folder_back.png");
            this.iconList.Images.SetKeyName(2, "folder.png");
            this.iconList.Images.SetKeyName(3, "pdf.png");
            this.iconList.Images.SetKeyName(4, "txt.png");
            this.iconList.Images.SetKeyName(5, "xls.png");
            this.iconList.Images.SetKeyName(6, "file_check.png");
            this.iconList.Images.SetKeyName(7, "pdf_check.png");
            this.iconList.Images.SetKeyName(8, "txt_check.png");
            this.iconList.Images.SetKeyName(9, "xls_check.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnConf);
            this.panel1.Controls.Add(this.btnConn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel2.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(128, 656);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.label4.Location = new System.Drawing.Point(31, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ir a Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.label3.Location = new System.Drawing.Point(18, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Configuración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.label2.Location = new System.Drawing.Point(25, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Conexiones";
            // 
            // btnHome
            // 
            this.btnHome.Enabled = false;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(30, 419);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(64, 64);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 6;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnConf
            // 
            this.btnConf.Image = ((System.Drawing.Image)(resources.GetObject("btnConf.Image")));
            this.btnConf.Location = new System.Drawing.Point(30, 280);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(64, 64);
            this.btnConf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConf.TabIndex = 5;
            this.btnConf.TabStop = false;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // btnConn
            // 
            this.btnConn.Enabled = false;
            this.btnConn.Image = ((System.Drawing.Image)(resources.GetObject("btnConn.Image")));
            this.btnConn.Location = new System.Drawing.Point(30, 152);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(64, 64);
            this.btnConn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConn.TabIndex = 4;
            this.btnConn.TabStop = false;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnGoHome);
            this.panel2.Controls.Add(this.btnGo);
            this.panel2.Controls.Add(this.btnGoBack);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(137, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 75);
            this.panel2.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.Enabled = false;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(551, 28);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(25, 25);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReload.TabIndex = 9;
            this.btnReload.TabStop = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Enabled = false;
            this.btnGoHome.Image = ((System.Drawing.Image)(resources.GetObject("btnGoHome.Image")));
            this.btnGoHome.Location = new System.Drawing.Point(586, 28);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(25, 25);
            this.btnGoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGoHome.TabIndex = 8;
            this.btnGoHome.TabStop = false;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.Location = new System.Drawing.Point(517, 29);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(25, 25);
            this.btnGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGo.TabIndex = 7;
            this.btnGo.TabStop = false;
            this.btnGo.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Enabled = false;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.Location = new System.Drawing.Point(483, 29);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(25, 25);
            this.btnGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGoBack.TabIndex = 6;
            this.btnGoBack.TabStop = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSearch.Location = new System.Drawing.Point(104, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(369, 21);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta remota:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 662);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FTP Validator";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView lvExplorer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnConf;
        private System.Windows.Forms.PictureBox btnConn;
        private System.Windows.Forms.PictureBox btnReload;
        private System.Windows.Forms.PictureBox btnGoHome;
        private System.Windows.Forms.PictureBox btnGo;
        private System.Windows.Forms.PictureBox btnGoBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

