namespace Biblioteca
{
    partial class PesquisarFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarFuncionario));
            this.label14 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvFuncionario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAlterarFunc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deletarFunc = new Guna.UI2.WinForms.Guna2Button();
            this.txtFuncCPF = new Guna.UI2.WinForms.Guna2TextBox();
            this.TopCenter = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
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
            this.label14.DefaultText = "Pesquisa de Funcionario";
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
            this.label14.Location = new System.Drawing.Point(291, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.label14.Name = "label14";
            this.label14.PasswordChar = '\0';
            this.label14.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.PlaceholderText = "";
            this.label14.SelectedText = "";
            this.label14.ShadowDecoration.Parent = this.label14;
            this.label14.Size = new System.Drawing.Size(267, 48);
            this.label14.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F);
            this.label1.Location = new System.Drawing.Point(64, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 27);
            this.label1.TabIndex = 62;
            this.label1.Text = "Digite o CPF do Funcionario:";
            // 
            // dgvFuncionario
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFuncionario.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFuncionario.EnableHeadersVisualStyles = false;
            this.dgvFuncionario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFuncionario.Location = new System.Drawing.Point(120, 129);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(607, 192);
            this.dgvFuncionario.TabIndex = 61;
            this.dgvFuncionario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFuncionario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFuncionario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFuncionario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvFuncionario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFuncionario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFuncionario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFuncionario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFuncionario.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvFuncionario.ThemeStyle.ReadOnly = false;
            this.dgvFuncionario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFuncionario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFuncionario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvFuncionario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvFuncionario.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFuncionario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFuncionario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAlterarFunc
            // 
            this.btnAlterarFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarFunc.BorderColor = System.Drawing.Color.Transparent;
            this.btnAlterarFunc.BorderRadius = 16;
            this.btnAlterarFunc.BorderThickness = 1;
            this.btnAlterarFunc.CheckedState.Parent = this.btnAlterarFunc;
            this.btnAlterarFunc.CustomImages.Parent = this.btnAlterarFunc;
            this.btnAlterarFunc.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAlterarFunc.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlterarFunc.ForeColor = System.Drawing.Color.White;
            this.btnAlterarFunc.HoverState.Parent = this.btnAlterarFunc;
            this.btnAlterarFunc.Location = new System.Drawing.Point(209, 337);
            this.btnAlterarFunc.Name = "btnAlterarFunc";
            this.btnAlterarFunc.ShadowDecoration.Parent = this.btnAlterarFunc;
            this.btnAlterarFunc.Size = new System.Drawing.Size(151, 43);
            this.btnAlterarFunc.TabIndex = 60;
            this.btnAlterarFunc.Text = "Alterar";
            // 
            // btn_deletarFunc
            // 
            this.btn_deletarFunc.BorderColor = System.Drawing.Color.Gray;
            this.btn_deletarFunc.BorderRadius = 16;
            this.btn_deletarFunc.BorderThickness = 1;
            this.btn_deletarFunc.CheckedState.Parent = this.btn_deletarFunc;
            this.btn_deletarFunc.CustomImages.Parent = this.btn_deletarFunc;
            this.btn_deletarFunc.FillColor = System.Drawing.Color.SteelBlue;
            this.btn_deletarFunc.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deletarFunc.ForeColor = System.Drawing.Color.White;
            this.btn_deletarFunc.HoverState.Parent = this.btn_deletarFunc;
            this.btn_deletarFunc.Location = new System.Drawing.Point(461, 337);
            this.btn_deletarFunc.Name = "btn_deletarFunc";
            this.btn_deletarFunc.ShadowDecoration.Parent = this.btn_deletarFunc;
            this.btn_deletarFunc.Size = new System.Drawing.Size(145, 43);
            this.btn_deletarFunc.TabIndex = 59;
            this.btn_deletarFunc.Text = "Deletar";
            // 
            // txtFuncCPF
            // 
            this.txtFuncCPF.BorderColor = System.Drawing.Color.Silver;
            this.txtFuncCPF.BorderRadius = 15;
            this.txtFuncCPF.BorderThickness = 0;
            this.txtFuncCPF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFuncCPF.DefaultText = "";
            this.txtFuncCPF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFuncCPF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFuncCPF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncCPF.DisabledState.Parent = this.txtFuncCPF;
            this.txtFuncCPF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncCPF.FillColor = System.Drawing.Color.Silver;
            this.txtFuncCPF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuncCPF.FocusedState.Parent = this.txtFuncCPF;
            this.txtFuncCPF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuncCPF.HoverState.Parent = this.txtFuncCPF;
            this.txtFuncCPF.Location = new System.Drawing.Point(334, 85);
            this.txtFuncCPF.Name = "txtFuncCPF";
            this.txtFuncCPF.PasswordChar = '\0';
            this.txtFuncCPF.PlaceholderText = "";
            this.txtFuncCPF.SelectedText = "";
            this.txtFuncCPF.ShadowDecoration.Parent = this.txtFuncCPF;
            this.txtFuncCPF.Size = new System.Drawing.Size(293, 27);
            this.txtFuncCPF.TabIndex = 58;
            // 
            // TopCenter
            // 
            this.TopCenter.Image = ((System.Drawing.Image)(resources.GetObject("TopCenter.Image")));
            this.TopCenter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TopCenter.Location = new System.Drawing.Point(706, 7);
            this.TopCenter.Name = "TopCenter";
            this.TopCenter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TopCenter.ShadowDecoration.Parent = this.TopCenter;
            this.TopCenter.Size = new System.Drawing.Size(34, 30);
            this.TopCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopCenter.TabIndex = 57;
            this.TopCenter.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(746, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 30);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 56;
            this.btnSair.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2CirclePictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(-8, 399);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(808, 162);
            this.guna2CirclePictureBox1.TabIndex = 63;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // PesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.btnAlterarFunc);
            this.Controls.Add(this.btn_deletarFunc);
            this.Controls.Add(this.txtFuncCPF);
            this.Controls.Add(this.TopCenter);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PesquisarFuncionario";
            this.Text = "PesquisarFuncionario";
            this.Load += new System.EventHandler(this.PesquisarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox label14;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFuncionario;
        private Guna.UI2.WinForms.Guna2Button btnAlterarFunc;
        private Guna.UI2.WinForms.Guna2Button btn_deletarFunc;
        private Guna.UI2.WinForms.Guna2TextBox txtFuncCPF;
        private Guna.UI2.WinForms.Guna2CirclePictureBox TopCenter;
        private System.Windows.Forms.PictureBox btnSair;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}