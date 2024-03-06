namespace Biblioteca
{
    partial class PesquisarLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarLivro));
            this.label14 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvLivros = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAlterar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deletarLivro = new Guna.UI2.WinForms.Guna2Button();
            this.txtLivroISBN = new Guna.UI2.WinForms.Guna2TextBox();
            this.TopCenter = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
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
            this.label14.DefaultText = "Pesquisa de Livros";
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
            this.label14.Location = new System.Drawing.Point(303, 24);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label14.Name = "label14";
            this.label14.PasswordChar = '\0';
            this.label14.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.PlaceholderText = "";
            this.label14.SelectedText = "";
            this.label14.ShadowDecoration.Parent = this.label14;
            this.label14.Size = new System.Drawing.Size(267, 48);
            this.label14.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F);
            this.label1.Location = new System.Drawing.Point(62, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 27);
            this.label1.TabIndex = 71;
            this.label1.Text = "Digite o ISBN do Livro:";
            // 
            // dgvLivros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLivros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivros.BackgroundColor = System.Drawing.Color.White;
            this.dgvLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLivros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLivros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivros.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLivros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLivros.EnableHeadersVisualStyles = false;
            this.dgvLivros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLivros.Location = new System.Drawing.Point(118, 137);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.RowHeadersVisible = false;
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(607, 192);
            this.dgvLivros.TabIndex = 70;
            this.dgvLivros.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvLivros.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLivros.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLivros.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLivros.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLivros.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLivros.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLivros.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLivros.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLivros.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLivros.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLivros.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLivros.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLivros.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvLivros.ThemeStyle.ReadOnly = false;
            this.dgvLivros.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLivros.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLivros.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLivros.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvLivros.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLivros.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLivros.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnAlterar.Location = new System.Drawing.Point(207, 345);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.ShadowDecoration.Parent = this.btnAlterar;
            this.btnAlterar.Size = new System.Drawing.Size(151, 43);
            this.btnAlterar.TabIndex = 69;
            this.btnAlterar.Text = "Alterar";
            // 
            // btn_deletarLivro
            // 
            this.btn_deletarLivro.BorderColor = System.Drawing.Color.Gray;
            this.btn_deletarLivro.BorderRadius = 16;
            this.btn_deletarLivro.BorderThickness = 1;
            this.btn_deletarLivro.CheckedState.Parent = this.btn_deletarLivro;
            this.btn_deletarLivro.CustomImages.Parent = this.btn_deletarLivro;
            this.btn_deletarLivro.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_deletarLivro.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deletarLivro.ForeColor = System.Drawing.Color.White;
            this.btn_deletarLivro.HoverState.Parent = this.btn_deletarLivro;
            this.btn_deletarLivro.Location = new System.Drawing.Point(459, 345);
            this.btn_deletarLivro.Name = "btn_deletarLivro";
            this.btn_deletarLivro.ShadowDecoration.Parent = this.btn_deletarLivro;
            this.btn_deletarLivro.Size = new System.Drawing.Size(145, 43);
            this.btn_deletarLivro.TabIndex = 68;
            this.btn_deletarLivro.Text = "Deletar";
            // 
            // txtLivroISBN
            // 
            this.txtLivroISBN.BorderColor = System.Drawing.Color.Silver;
            this.txtLivroISBN.BorderRadius = 15;
            this.txtLivroISBN.BorderThickness = 0;
            this.txtLivroISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLivroISBN.DefaultText = "";
            this.txtLivroISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLivroISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLivroISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLivroISBN.DisabledState.Parent = this.txtLivroISBN;
            this.txtLivroISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLivroISBN.FillColor = System.Drawing.Color.Silver;
            this.txtLivroISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLivroISBN.FocusedState.Parent = this.txtLivroISBN;
            this.txtLivroISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLivroISBN.HoverState.Parent = this.txtLivroISBN;
            this.txtLivroISBN.Location = new System.Drawing.Point(289, 93);
            this.txtLivroISBN.Name = "txtLivroISBN";
            this.txtLivroISBN.PasswordChar = '\0';
            this.txtLivroISBN.PlaceholderText = "";
            this.txtLivroISBN.SelectedText = "";
            this.txtLivroISBN.ShadowDecoration.Parent = this.txtLivroISBN;
            this.txtLivroISBN.Size = new System.Drawing.Size(293, 27);
            this.txtLivroISBN.TabIndex = 67;
            // 
            // TopCenter
            // 
            this.TopCenter.Image = ((System.Drawing.Image)(resources.GetObject("TopCenter.Image")));
            this.TopCenter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TopCenter.Location = new System.Drawing.Point(704, 15);
            this.TopCenter.Name = "TopCenter";
            this.TopCenter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TopCenter.ShadowDecoration.Parent = this.TopCenter;
            this.TopCenter.Size = new System.Drawing.Size(34, 30);
            this.TopCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopCenter.TabIndex = 66;
            this.TopCenter.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(744, 15);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 30);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 65;
            this.btnSair.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2CirclePictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(-10, 407);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(817, 162);
            this.guna2CirclePictureBox1.TabIndex = 72;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // PesquisarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btn_deletarLivro);
            this.Controls.Add(this.txtLivroISBN);
            this.Controls.Add(this.TopCenter);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PesquisarLivro";
            this.Text = "PesquisarLivro";
            this.Load += new System.EventHandler(this.PesquisarLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox label14;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLivros;
        private Guna.UI2.WinForms.Guna2Button btnAlterar;
        private Guna.UI2.WinForms.Guna2Button btn_deletarLivro;
        private Guna.UI2.WinForms.Guna2TextBox txtLivroISBN;
        private Guna.UI2.WinForms.Guna2CirclePictureBox TopCenter;
        private System.Windows.Forms.PictureBox btnSair;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}