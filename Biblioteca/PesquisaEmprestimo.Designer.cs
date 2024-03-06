namespace Biblioteca
{
    partial class PesquisaEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaEmprestimo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.TopCenter = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtPesquisaEmp = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEmprestados = new Guna.UI2.WinForms.Guna2Button();
            this.btnConcluidos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_concluirEmp = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlterar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvEmprestimo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.TabStop = false;
            // 
            // TopCenter
            // 
            resources.ApplyResources(this.TopCenter, "TopCenter");
            this.TopCenter.Name = "TopCenter";
            this.TopCenter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TopCenter.ShadowDecoration.Parent = this.TopCenter;
            this.TopCenter.TabStop = false;
            // 
            // txtPesquisaEmp
            // 
            this.txtPesquisaEmp.BorderColor = System.Drawing.Color.Silver;
            this.txtPesquisaEmp.BorderRadius = 15;
            this.txtPesquisaEmp.BorderThickness = 0;
            this.txtPesquisaEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisaEmp.DefaultText = "";
            this.txtPesquisaEmp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisaEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisaEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaEmp.DisabledState.Parent = this.txtPesquisaEmp;
            this.txtPesquisaEmp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisaEmp.FillColor = System.Drawing.Color.Silver;
            this.txtPesquisaEmp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaEmp.FocusedState.Parent = this.txtPesquisaEmp;
            this.txtPesquisaEmp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisaEmp.HoverState.Parent = this.txtPesquisaEmp;
            resources.ApplyResources(this.txtPesquisaEmp, "txtPesquisaEmp");
            this.txtPesquisaEmp.Name = "txtPesquisaEmp";
            this.txtPesquisaEmp.PasswordChar = '\0';
            this.txtPesquisaEmp.PlaceholderText = "";
            this.txtPesquisaEmp.SelectedText = "";
            this.txtPesquisaEmp.ShadowDecoration.Parent = this.txtPesquisaEmp;
            // 
            // btnEmprestados
            // 
            this.btnEmprestados.BorderColor = System.Drawing.Color.Gray;
            this.btnEmprestados.BorderRadius = 16;
            this.btnEmprestados.BorderThickness = 1;
            this.btnEmprestados.CheckedState.Parent = this.btnEmprestados;
            this.btnEmprestados.CustomImages.Parent = this.btnEmprestados;
            this.btnEmprestados.FillColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.btnEmprestados, "btnEmprestados");
            this.btnEmprestados.ForeColor = System.Drawing.Color.White;
            this.btnEmprestados.HoverState.Parent = this.btnEmprestados;
            this.btnEmprestados.Name = "btnEmprestados";
            this.btnEmprestados.ShadowDecoration.Parent = this.btnEmprestados;
            // 
            // btnConcluidos
            // 
            this.btnConcluidos.BorderColor = System.Drawing.Color.Gray;
            this.btnConcluidos.BorderRadius = 16;
            this.btnConcluidos.BorderThickness = 1;
            this.btnConcluidos.CheckedState.Parent = this.btnConcluidos;
            this.btnConcluidos.CustomImages.Parent = this.btnConcluidos;
            this.btnConcluidos.FillColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.btnConcluidos, "btnConcluidos");
            this.btnConcluidos.ForeColor = System.Drawing.Color.White;
            this.btnConcluidos.HoverState.Parent = this.btnConcluidos;
            this.btnConcluidos.Name = "btnConcluidos";
            this.btnConcluidos.ShadowDecoration.Parent = this.btnConcluidos;
            // 
            // btn_concluirEmp
            // 
            this.btn_concluirEmp.BorderColor = System.Drawing.Color.Gray;
            this.btn_concluirEmp.BorderRadius = 16;
            this.btn_concluirEmp.BorderThickness = 1;
            this.btn_concluirEmp.CheckedState.Parent = this.btn_concluirEmp;
            this.btn_concluirEmp.CustomImages.Parent = this.btn_concluirEmp;
            this.btn_concluirEmp.FillColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.btn_concluirEmp, "btn_concluirEmp");
            this.btn_concluirEmp.ForeColor = System.Drawing.Color.White;
            this.btn_concluirEmp.HoverState.Parent = this.btn_concluirEmp;
            this.btn_concluirEmp.Name = "btn_concluirEmp";
            this.btn_concluirEmp.ShadowDecoration.Parent = this.btn_concluirEmp;
            this.btn_concluirEmp.Click += new System.EventHandler(this.btn_concluirEmp_Click);
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
            resources.ApplyResources(this.btnAlterar, "btnAlterar");
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.HoverState.Parent = this.btnAlterar;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.ShadowDecoration.Parent = this.btnAlterar;
            // 
            // dgvEmprestimo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEmprestimo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmprestimo.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmprestimo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmprestimo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgvEmprestimo, "dgvEmprestimo");
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmprestimo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmprestimo.EnableHeadersVisualStyles = false;
            this.dgvEmprestimo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.RowHeadersVisible = false;
            this.dgvEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmprestimo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvEmprestimo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmprestimo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmprestimo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmprestimo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmprestimo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmprestimo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmprestimo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmprestimo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmprestimo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmprestimo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEmprestimo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmprestimo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmprestimo.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvEmprestimo.ThemeStyle.ReadOnly = false;
            this.dgvEmprestimo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmprestimo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmprestimo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEmprestimo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvEmprestimo.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEmprestimo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmprestimo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.guna2CirclePictureBox1, "guna2CirclePictureBox1");
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.guna2CirclePictureBox2, "guna2CirclePictureBox2");
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.BorderColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Pesquisa de Emprestimo";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            resources.ApplyResources(this.guna2TextBox1, "guna2TextBox1");
            this.guna2TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 22;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            // 
            // PesquisaEmprestimo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmprestimo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btn_concluirEmp);
            this.Controls.Add(this.btnConcluidos);
            this.Controls.Add(this.btnEmprestados);
            this.Controls.Add(this.txtPesquisaEmp);
            this.Controls.Add(this.TopCenter);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PesquisaEmprestimo";
            this.Load += new System.EventHandler(this.PesquisaEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnSair;
        private Guna.UI2.WinForms.Guna2CirclePictureBox TopCenter;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisaEmp;
        private Guna.UI2.WinForms.Guna2Button btnEmprestados;
        private Guna.UI2.WinForms.Guna2Button btnConcluidos;
        private Guna.UI2.WinForms.Guna2Button btn_concluirEmp;
        private Guna.UI2.WinForms.Guna2Button btnAlterar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmprestimo;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}