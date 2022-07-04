namespace robo1._3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelSubCont = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelRotulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMenuSociais = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMenuPredefinidos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSubCont.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.sdb)|*.sdb";
            // 
            // panelSubCont
            // 
            this.panelSubCont.Controls.Add(this.panelContent);
            this.panelSubCont.Controls.Add(this.panel1);
            this.panelSubCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubCont.Location = new System.Drawing.Point(0, 0);
            this.panelSubCont.Margin = new System.Windows.Forms.Padding(0);
            this.panelSubCont.Name = "panelSubCont";
            this.panelSubCont.Size = new System.Drawing.Size(1067, 721);
            this.panelSubCont.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelRotulo);
            this.panel1.Controls.Add(this.bunifuImageButton6);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 43);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1024, 0);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(43, 43);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 12;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btnMax
            // 
            this.btnMax.AccessibleDescription = "btnMax";
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.ImageActive = null;
            this.btnMax.Location = new System.Drawing.Point(981, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(43, 43);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 13;
            this.btnMax.TabStop = false;
            this.btnMax.Zoom = 10;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton6.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(938, 0);
            this.bunifuImageButton6.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(43, 43);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 14;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // labelRotulo
            // 
            this.labelRotulo.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelRotulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRotulo.ForeColor = System.Drawing.Color.Snow;
            this.labelRotulo.Location = new System.Drawing.Point(854, 0);
            this.labelRotulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRotulo.Name = "labelRotulo";
            this.labelRotulo.Size = new System.Drawing.Size(84, 43);
            this.labelRotulo.TabIndex = 15;
            this.labelRotulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuFlatButton3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 43);
            this.panel2.TabIndex = 16;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.MediumOrchid;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Indigo;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Inicio";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 60D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Indigo;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.DarkViolet;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(243, 43);
            this.bunifuFlatButton3.TabIndex = 7;
            this.bunifuFlatButton3.Text = "Inicio";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(243, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 43);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMenuSociais);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(253, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 43);
            this.panel3.TabIndex = 18;
            // 
            // btnMenuSociais
            // 
            this.btnMenuSociais.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMenuSociais.BackColor = System.Drawing.Color.Indigo;
            this.btnMenuSociais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuSociais.BorderRadius = 0;
            this.btnMenuSociais.ButtonText = "Comandos Sociais";
            this.btnMenuSociais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSociais.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuSociais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuSociais.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuSociais.Iconimage = null;
            this.btnMenuSociais.Iconimage_right = null;
            this.btnMenuSociais.Iconimage_right_Selected = null;
            this.btnMenuSociais.Iconimage_Selected = null;
            this.btnMenuSociais.IconMarginLeft = 0;
            this.btnMenuSociais.IconMarginRight = 0;
            this.btnMenuSociais.IconRightVisible = true;
            this.btnMenuSociais.IconRightZoom = 0D;
            this.btnMenuSociais.IconVisible = true;
            this.btnMenuSociais.IconZoom = 60D;
            this.btnMenuSociais.IsTab = false;
            this.btnMenuSociais.Location = new System.Drawing.Point(0, 0);
            this.btnMenuSociais.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenuSociais.Name = "btnMenuSociais";
            this.btnMenuSociais.Normalcolor = System.Drawing.Color.Indigo;
            this.btnMenuSociais.OnHovercolor = System.Drawing.Color.DarkOrchid;
            this.btnMenuSociais.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuSociais.selected = false;
            this.btnMenuSociais.Size = new System.Drawing.Size(301, 43);
            this.btnMenuSociais.TabIndex = 2;
            this.btnMenuSociais.Text = "Comandos Sociais";
            this.btnMenuSociais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuSociais.Textcolor = System.Drawing.Color.White;
            this.btnMenuSociais.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSociais.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(554, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(10, 43);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMenuPredefinidos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(564, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 43);
            this.panel4.TabIndex = 20;
            // 
            // btnMenuPredefinidos
            // 
            this.btnMenuPredefinidos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMenuPredefinidos.BackColor = System.Drawing.Color.Indigo;
            this.btnMenuPredefinidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuPredefinidos.BorderRadius = 0;
            this.btnMenuPredefinidos.ButtonText = "Comandos Predefinidos";
            this.btnMenuPredefinidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPredefinidos.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuPredefinidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuPredefinidos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuPredefinidos.Iconimage = null;
            this.btnMenuPredefinidos.Iconimage_right = null;
            this.btnMenuPredefinidos.Iconimage_right_Selected = null;
            this.btnMenuPredefinidos.Iconimage_Selected = null;
            this.btnMenuPredefinidos.IconMarginLeft = 0;
            this.btnMenuPredefinidos.IconMarginRight = 0;
            this.btnMenuPredefinidos.IconRightVisible = true;
            this.btnMenuPredefinidos.IconRightZoom = 0D;
            this.btnMenuPredefinidos.IconVisible = true;
            this.btnMenuPredefinidos.IconZoom = 60D;
            this.btnMenuPredefinidos.IsTab = false;
            this.btnMenuPredefinidos.Location = new System.Drawing.Point(0, 0);
            this.btnMenuPredefinidos.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenuPredefinidos.Name = "btnMenuPredefinidos";
            this.btnMenuPredefinidos.Normalcolor = System.Drawing.Color.Indigo;
            this.btnMenuPredefinidos.OnHovercolor = System.Drawing.Color.DarkViolet;
            this.btnMenuPredefinidos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenuPredefinidos.selected = false;
            this.btnMenuPredefinidos.Size = new System.Drawing.Size(311, 43);
            this.btnMenuPredefinidos.TabIndex = 3;
            this.btnMenuPredefinidos.Text = "Comandos Predefinidos";
            this.btnMenuPredefinidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuPredefinidos.Textcolor = System.Drawing.Color.White;
            this.btnMenuPredefinidos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPredefinidos.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelSubCont, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 721);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.BlueViolet;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 43);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1067, 678);
            this.panelContent.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1067, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panelSubCont.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelSubCont;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuPredefinidos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuSociais;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Label labelRotulo;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuImageButton btnMax;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelContent;
    }
}

