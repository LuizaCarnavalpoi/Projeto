namespace Biblioteca
{
    partial class PesquisarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarCliente));
            this.label14 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAlterar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deletarClie = new Guna.UI2.WinForms.Guna2Button();
            this.txtClienteCPF = new Guna.UI2.WinForms.Guna2TextBox();
            this.TopCenter = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.BorderColor = System.Drawing.SystemColors.Control;
            this.label14.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label14.DefaultText = "Pesquisa de Cliente";
            this.label14.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.label14.DisabledState.Parent = this.label14;
            this.label14.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.label14.FillColor = System.Drawing.SystemColors.Control;
            this.label14.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label14.FocusedState.Parent = this.label14;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label14.HoverState.Parent = this.label14;
            this.label14.Location = new System.Drawing.Point(293, 51);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label14.Name = "label14";
            this.label14.PasswordChar = '\0';
            this.label14.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.PlaceholderText = "";
            this.label14.SelectedText = "";
            this.label14.ShadowDecoration.Parent = this.label14;
            this.label14.Size = new System.Drawing.Size(267, 48);
            this.label14.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F);
            this.label1.Location = new System.Drawing.Point(99, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "Digite o CPF do Cliente:";
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientes.Location = new System.Drawing.Point(120, 176);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(481, 192);
            this.dgvClientes.TabIndex = 43;
            this.dgvClientes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClientes.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvClientes.ThemeStyle.ReadOnly = false;
            this.dgvClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvClientes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BorderColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BorderRadius = 16;
            this.btnAlterar.BorderThickness = 1;
            this.btnAlterar.CheckedState.Parent = this.btnAlterar;
            this.btnAlterar.CustomImages.Parent = this.btnAlterar;
            this.btnAlterar.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.HoverState.Parent = this.btnAlterar;
            this.btnAlterar.Location = new System.Drawing.Point(210, 384);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.ShadowDecoration.Parent = this.btnAlterar;
            this.btnAlterar.Size = new System.Drawing.Size(151, 43);
            this.btnAlterar.TabIndex = 42;
            this.btnAlterar.Text = "Alterar";
            // 
            // btn_deletarClie
            // 
            this.btn_deletarClie.BorderColor = System.Drawing.Color.Gray;
            this.btn_deletarClie.BorderRadius = 16;
            this.btn_deletarClie.BorderThickness = 1;
            this.btn_deletarClie.CheckedState.Parent = this.btn_deletarClie;
            this.btn_deletarClie.CustomImages.Parent = this.btn_deletarClie;
            this.btn_deletarClie.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_deletarClie.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deletarClie.ForeColor = System.Drawing.Color.White;
            this.btn_deletarClie.HoverState.Parent = this.btn_deletarClie;
            this.btn_deletarClie.Location = new System.Drawing.Point(391, 384);
            this.btn_deletarClie.Name = "btn_deletarClie";
            this.btn_deletarClie.ShadowDecoration.Parent = this.btn_deletarClie;
            this.btn_deletarClie.Size = new System.Drawing.Size(145, 43);
            this.btn_deletarClie.TabIndex = 40;
            this.btn_deletarClie.Text = "Deletar";
            // 
            // txtClienteCPF
            // 
            this.txtClienteCPF.BorderColor = System.Drawing.Color.Silver;
            this.txtClienteCPF.BorderRadius = 15;
            this.txtClienteCPF.BorderThickness = 0;
            this.txtClienteCPF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteCPF.DefaultText = "";
            this.txtClienteCPF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteCPF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteCPF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteCPF.DisabledState.Parent = this.txtClienteCPF;
            this.txtClienteCPF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteCPF.FillColor = System.Drawing.Color.Silver;
            this.txtClienteCPF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteCPF.FocusedState.Parent = this.txtClienteCPF;
            this.txtClienteCPF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteCPF.HoverState.Parent = this.txtClienteCPF;
            this.txtClienteCPF.Location = new System.Drawing.Point(336, 119);
            this.txtClienteCPF.Name = "txtClienteCPF";
            this.txtClienteCPF.PasswordChar = '\0';
            this.txtClienteCPF.PlaceholderText = "";
            this.txtClienteCPF.SelectedText = "";
            this.txtClienteCPF.ShadowDecoration.Parent = this.txtClienteCPF;
            this.txtClienteCPF.Size = new System.Drawing.Size(293, 27);
            this.txtClienteCPF.TabIndex = 38;
            // 
            // TopCenter
            // 
            this.TopCenter.Image = ((System.Drawing.Image)(resources.GetObject("TopCenter.Image")));
            this.TopCenter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TopCenter.Location = new System.Drawing.Point(708, 41);
            this.TopCenter.Name = "TopCenter";
            this.TopCenter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TopCenter.ShadowDecoration.Parent = this.TopCenter;
            this.TopCenter.Size = new System.Drawing.Size(34, 30);
            this.TopCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopCenter.TabIndex = 37;
            this.TopCenter.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(748, 41);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 30);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 36;
            this.btnSair.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2CirclePictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(-5, 451);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(808, 162);
            this.guna2CirclePictureBox1.TabIndex = 45;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2CirclePictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(-5, -120);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(808, 162);
            this.guna2CirclePictureBox2.TabIndex = 47;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // PesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 495);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btn_deletarClie);
            this.Controls.Add(this.txtClienteCPF);
            this.Controls.Add(this.TopCenter);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PesquisarCliente";
            this.Text = "PesquisarCliente";
            this.Load += new System.EventHandler(this.PesquisarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox label14;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClientes;
        private Guna.UI2.WinForms.Guna2Button btnAlterar;
        private Guna.UI2.WinForms.Guna2Button btn_deletarClie;
        private Guna.UI2.WinForms.Guna2TextBox txtClienteCPF;
        private Guna.UI2.WinForms.Guna2CirclePictureBox TopCenter;
        private System.Windows.Forms.PictureBox btnSair;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
    }
}