namespace Biblioteca
{
    partial class PesquisarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarFornecedor));
            this.label14 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvFornecedor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAlterarForn = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deletarForn = new Guna.UI2.WinForms.Guna2Button();
            this.txtFornCNPJ = new Guna.UI2.WinForms.Guna2TextBox();
            this.TopCenter = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.BorderColor = System.Drawing.SystemColors.Control;
            this.label14.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label14.DefaultText = "Pesquisa de Fornecedor";
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
            this.label14.Location = new System.Drawing.Point(292, 22);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label14.Name = "label14";
            this.label14.PasswordChar = '\0';
            this.label14.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.PlaceholderText = "";
            this.label14.SelectedText = "";
            this.label14.ShadowDecoration.Parent = this.label14;
            this.label14.Size = new System.Drawing.Size(267, 48);
            this.label14.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F);
            this.label1.Location = new System.Drawing.Point(65, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 27);
            this.label1.TabIndex = 53;
            this.label1.Text = "Digite o CNPJ do Fornecedor:";
            // 
            // dgvFornecedor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.dgvFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFornecedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFornecedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFornecedor.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFornecedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFornecedor.EnableHeadersVisualStyles = false;
            this.dgvFornecedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFornecedor.Location = new System.Drawing.Point(121, 134);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.RowHeadersVisible = false;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(481, 192);
            this.dgvFornecedor.TabIndex = 52;
            this.dgvFornecedor.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvFornecedor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFornecedor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFornecedor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFornecedor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFornecedor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFornecedor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFornecedor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFornecedor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvFornecedor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFornecedor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFornecedor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFornecedor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFornecedor.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvFornecedor.ThemeStyle.ReadOnly = false;
            this.dgvFornecedor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFornecedor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFornecedor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFornecedor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvFornecedor.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFornecedor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFornecedor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAlterarForn
            // 
            this.btnAlterarForn.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarForn.BorderColor = System.Drawing.Color.Transparent;
            this.btnAlterarForn.BorderRadius = 16;
            this.btnAlterarForn.BorderThickness = 1;
            this.btnAlterarForn.CheckedState.Parent = this.btnAlterarForn;
            this.btnAlterarForn.CustomImages.Parent = this.btnAlterarForn;
            this.btnAlterarForn.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAlterarForn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlterarForn.ForeColor = System.Drawing.Color.White;
            this.btnAlterarForn.HoverState.Parent = this.btnAlterarForn;
            this.btnAlterarForn.Location = new System.Drawing.Point(210, 342);
            this.btnAlterarForn.Name = "btnAlterarForn";
            this.btnAlterarForn.ShadowDecoration.Parent = this.btnAlterarForn;
            this.btnAlterarForn.Size = new System.Drawing.Size(151, 43);
            this.btnAlterarForn.TabIndex = 51;
            this.btnAlterarForn.Text = "Alterar";
            // 
            // btn_deletarForn
            // 
            this.btn_deletarForn.BorderColor = System.Drawing.Color.Gray;
            this.btn_deletarForn.BorderRadius = 16;
            this.btn_deletarForn.BorderThickness = 1;
            this.btn_deletarForn.CheckedState.Parent = this.btn_deletarForn;
            this.btn_deletarForn.CustomImages.Parent = this.btn_deletarForn;
            this.btn_deletarForn.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_deletarForn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deletarForn.ForeColor = System.Drawing.Color.White;
            this.btn_deletarForn.HoverState.Parent = this.btn_deletarForn;
            this.btn_deletarForn.Location = new System.Drawing.Point(391, 342);
            this.btn_deletarForn.Name = "btn_deletarForn";
            this.btn_deletarForn.ShadowDecoration.Parent = this.btn_deletarForn;
            this.btn_deletarForn.Size = new System.Drawing.Size(145, 43);
            this.btn_deletarForn.TabIndex = 50;
            this.btn_deletarForn.Text = "Deletar";
            // 
            // txtFornCNPJ
            // 
            this.txtFornCNPJ.BorderColor = System.Drawing.Color.Silver;
            this.txtFornCNPJ.BorderRadius = 15;
            this.txtFornCNPJ.BorderThickness = 0;
            this.txtFornCNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFornCNPJ.DefaultText = "";
            this.txtFornCNPJ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFornCNPJ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFornCNPJ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFornCNPJ.DisabledState.Parent = this.txtFornCNPJ;
            this.txtFornCNPJ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFornCNPJ.FillColor = System.Drawing.Color.Silver;
            this.txtFornCNPJ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFornCNPJ.FocusedState.Parent = this.txtFornCNPJ;
            this.txtFornCNPJ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFornCNPJ.HoverState.Parent = this.txtFornCNPJ;
            this.txtFornCNPJ.Location = new System.Drawing.Point(335, 90);
            this.txtFornCNPJ.Name = "txtFornCNPJ";
            this.txtFornCNPJ.PasswordChar = '\0';
            this.txtFornCNPJ.PlaceholderText = "";
            this.txtFornCNPJ.SelectedText = "";
            this.txtFornCNPJ.ShadowDecoration.Parent = this.txtFornCNPJ;
            this.txtFornCNPJ.Size = new System.Drawing.Size(293, 27);
            this.txtFornCNPJ.TabIndex = 49;
            // 
            // TopCenter
            // 
            this.TopCenter.Image = ((System.Drawing.Image)(resources.GetObject("TopCenter.Image")));
            this.TopCenter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TopCenter.Location = new System.Drawing.Point(707, 12);
            this.TopCenter.Name = "TopCenter";
            this.TopCenter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TopCenter.ShadowDecoration.Parent = this.TopCenter;
            this.TopCenter.Size = new System.Drawing.Size(34, 30);
            this.TopCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopCenter.TabIndex = 48;
            this.TopCenter.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(747, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 30);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 47;
            this.btnSair.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2CirclePictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(-7, 404);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(808, 162);
            this.guna2CirclePictureBox1.TabIndex = 54;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // PesquisarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.btnAlterarForn);
            this.Controls.Add(this.btn_deletarForn);
            this.Controls.Add(this.txtFornCNPJ);
            this.Controls.Add(this.TopCenter);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PesquisarFornecedor";
            this.Text = "PesquisarFornecedor";
            this.Load += new System.EventHandler(this.PesquisarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox label14;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFornecedor;
        private Guna.UI2.WinForms.Guna2Button btnAlterarForn;
        private Guna.UI2.WinForms.Guna2Button btn_deletarForn;
        private Guna.UI2.WinForms.Guna2TextBox txtFornCNPJ;
        private Guna.UI2.WinForms.Guna2CirclePictureBox TopCenter;
        private System.Windows.Forms.PictureBox btnSair;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}