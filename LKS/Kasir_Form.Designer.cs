namespace LKS
{
    partial class Kasir_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasir_Form));
            this.cbKode = new Guna.UI.WinForms.GunaComboBox();
            this.txtHarga = new Guna.UI.WinForms.GunaTextBox();
            this.txtJumlah = new Guna.UI.WinForms.GunaTextBox();
            this.txtTotal = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnTambah = new Guna.UI.WinForms.GunaButton();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSve = new Guna.UI.WinForms.GunaButton();
            this.btnPrint = new Guna.UI.WinForms.GunaButton();
            this.txtBayar = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbTotal = new Guna.UI.WinForms.GunaLabel();
            this.lbChange = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnBayar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKode
            // 
            this.cbKode.BackColor = System.Drawing.Color.Transparent;
            this.cbKode.BaseColor = System.Drawing.Color.White;
            this.cbKode.BorderColor = System.Drawing.Color.DarkOrange;
            this.cbKode.BorderSize = 1;
            this.cbKode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKode.ForeColor = System.Drawing.Color.Black;
            this.cbKode.FormattingEnabled = true;
            this.cbKode.Location = new System.Drawing.Point(316, 131);
            this.cbKode.Name = "cbKode";
            this.cbKode.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbKode.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbKode.Radius = 2;
            this.cbKode.Size = new System.Drawing.Size(300, 35);
            this.cbKode.TabIndex = 0;
            this.cbKode.SelectedIndexChanged += new System.EventHandler(this.cbKode_SelectedIndexChanged);
            // 
            // txtHarga
            // 
            this.txtHarga.BaseColor = System.Drawing.Color.White;
            this.txtHarga.BorderColor = System.Drawing.Color.DarkOrange;
            this.txtHarga.BorderSize = 1;
            this.txtHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHarga.Enabled = false;
            this.txtHarga.FocusedBaseColor = System.Drawing.Color.White;
            this.txtHarga.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtHarga.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHarga.Location = new System.Drawing.Point(316, 211);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PasswordChar = '\0';
            this.txtHarga.Radius = 2;
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(300, 52);
            this.txtHarga.TabIndex = 1;
            // 
            // txtJumlah
            // 
            this.txtJumlah.BaseColor = System.Drawing.Color.White;
            this.txtJumlah.BorderColor = System.Drawing.Color.DarkOrange;
            this.txtJumlah.BorderSize = 1;
            this.txtJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlah.FocusedBaseColor = System.Drawing.Color.White;
            this.txtJumlah.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtJumlah.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtJumlah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJumlah.Location = new System.Drawing.Point(761, 131);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.PasswordChar = '\0';
            this.txtJumlah.Radius = 2;
            this.txtJumlah.Size = new System.Drawing.Size(300, 43);
            this.txtJumlah.TabIndex = 2;
            this.txtJumlah.TextChanged += new System.EventHandler(this.txtJumlah_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BaseColor = System.Drawing.Color.White;
            this.txtTotal.BorderColor = System.Drawing.Color.DarkOrange;
            this.txtTotal.BorderSize = 1;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Enabled = false;
            this.txtTotal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotal.Location = new System.Drawing.Point(761, 211);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.Radius = 2;
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(300, 52);
            this.txtTotal.TabIndex = 3;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gunaPanel1.Controls.Add(this.btnLogout);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(246, 824);
            this.gunaPanel1.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.Red;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = null;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(35, 717);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Radius = 2;
            this.btnLogout.Size = new System.Drawing.Size(175, 51);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(26, 140);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(184, 176);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnTambah
            // 
            this.btnTambah.AnimationHoverSpeed = 0.07F;
            this.btnTambah.AnimationSpeed = 0.03F;
            this.btnTambah.BaseColor = System.Drawing.Color.Green;
            this.btnTambah.BorderColor = System.Drawing.Color.Black;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Image = null;
            this.btnTambah.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTambah.Location = new System.Drawing.Point(679, 304);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTambah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTambah.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTambah.OnHoverImage = null;
            this.btnTambah.OnPressedColor = System.Drawing.Color.Black;
            this.btnTambah.Radius = 2;
            this.btnTambah.Size = new System.Drawing.Size(175, 51);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BaseColor = System.Drawing.Color.Red;
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = null;
            this.btnReset.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReset.Location = new System.Drawing.Point(886, 304);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Radius = 2;
            this.btnReset.Size = new System.Drawing.Size(175, 51);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeBarang,
            this.nBarang,
            this.hBarang,
            this.jBarang,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(320, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 204);
            this.dataGridView1.TabIndex = 7;
            // 
            // kodeBarang
            // 
            this.kodeBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kodeBarang.HeaderText = "Kode Barang";
            this.kodeBarang.MinimumWidth = 6;
            this.kodeBarang.Name = "kodeBarang";
            this.kodeBarang.ReadOnly = true;
            // 
            // nBarang
            // 
            this.nBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nBarang.HeaderText = "Nama Barang";
            this.nBarang.MinimumWidth = 6;
            this.nBarang.Name = "nBarang";
            this.nBarang.ReadOnly = true;
            // 
            // hBarang
            // 
            this.hBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hBarang.HeaderText = "Harga Satuan";
            this.hBarang.MinimumWidth = 6;
            this.hBarang.Name = "hBarang";
            this.hBarang.ReadOnly = true;
            // 
            // jBarang
            // 
            this.jBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jBarang.HeaderText = "Jumlah Barang";
            this.jBarang.MinimumWidth = 6;
            this.jBarang.Name = "jBarang";
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total Harga";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // btnSve
            // 
            this.btnSve.AnimationHoverSpeed = 0.07F;
            this.btnSve.AnimationSpeed = 0.03F;
            this.btnSve.BaseColor = System.Drawing.Color.Teal;
            this.btnSve.BorderColor = System.Drawing.Color.Black;
            this.btnSve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSve.ForeColor = System.Drawing.Color.White;
            this.btnSve.Image = null;
            this.btnSve.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSve.Location = new System.Drawing.Point(886, 710);
            this.btnSve.Name = "btnSve";
            this.btnSve.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSve.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSve.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSve.OnHoverImage = null;
            this.btnSve.OnPressedColor = System.Drawing.Color.Black;
            this.btnSve.Radius = 2;
            this.btnSve.Size = new System.Drawing.Size(175, 51);
            this.btnSve.TabIndex = 9;
            this.btnSve.Text = "Simpan";
            this.btnSve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSve.Click += new System.EventHandler(this.btnSve_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BaseColor = System.Drawing.Color.Teal;
            this.btnPrint.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = null;
            this.btnPrint.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrint.Location = new System.Drawing.Point(679, 710);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Radius = 2;
            this.btnPrint.Size = new System.Drawing.Size(175, 51);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBayar
            // 
            this.txtBayar.BaseColor = System.Drawing.Color.White;
            this.txtBayar.BorderColor = System.Drawing.Color.DarkOrange;
            this.txtBayar.BorderSize = 1;
            this.txtBayar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBayar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBayar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBayar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBayar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBayar.Location = new System.Drawing.Point(320, 662);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.PasswordChar = '\0';
            this.txtBayar.Radius = 2;
            this.txtBayar.Size = new System.Drawing.Size(300, 44);
            this.txtBayar.TabIndex = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(315, 631);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(52, 25);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "Total";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(572, 632);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(48, 25);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "Rp.0";
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.Location = new System.Drawing.Point(572, 778);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(48, 25);
            this.lbChange.TabIndex = 14;
            this.lbChange.Text = "Rp.0";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(315, 777);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(99, 25);
            this.gunaLabel3.TabIndex = 13;
            this.gunaLabel3.Text = "Kembalian";
            // 
            // btnBayar
            // 
            this.btnBayar.AnimationHoverSpeed = 0.07F;
            this.btnBayar.AnimationSpeed = 0.03F;
            this.btnBayar.BaseColor = System.Drawing.Color.Teal;
            this.btnBayar.BorderColor = System.Drawing.Color.Black;
            this.btnBayar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Image = null;
            this.btnBayar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBayar.Location = new System.Drawing.Point(320, 717);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBayar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBayar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBayar.OnHoverImage = null;
            this.btnBayar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBayar.Radius = 2;
            this.btnBayar.Size = new System.Drawing.Size(300, 51);
            this.btnBayar.TabIndex = 15;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(309, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(158, 38);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "Form Kasir";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.OrangeRed;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Enabled = false;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(873, 28);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 2;
            this.gunaButton2.Size = new System.Drawing.Size(90, 51);
            this.gunaButton2.TabIndex = 17;
            this.gunaButton2.Text = "Kasir 1";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(312, 98);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(108, 23);
            this.gunaLabel4.TabIndex = 18;
            this.gunaLabel4.Text = "Kode Barang";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(313, 184);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(115, 23);
            this.gunaLabel5.TabIndex = 19;
            this.gunaLabel5.Text = "Harga Barang";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(757, 107);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(123, 23);
            this.gunaLabel6.TabIndex = 20;
            this.gunaLabel6.Text = "Jumlah Barang";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(757, 187);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(97, 23);
            this.gunaLabel7.TabIndex = 21;
            this.gunaLabel7.Text = "Total Harga";
            // 
            // Kasir_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 824);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtBayar);
            this.Controls.Add(this.btnSve);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.cbKode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kasir_Form";
            this.Text = "Kasir_Form";
            this.Load += new System.EventHandler(this.Kasir_Form_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cbKode;
        private Guna.UI.WinForms.GunaTextBox txtHarga;
        private Guna.UI.WinForms.GunaTextBox txtJumlah;
        private Guna.UI.WinForms.GunaTextBox txtTotal;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton btnTambah;
        private Guna.UI.WinForms.GunaButton btnReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaButton btnSve;
        private Guna.UI.WinForms.GunaButton btnPrint;
        private Guna.UI.WinForms.GunaTextBox txtBayar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbTotal;
        private Guna.UI.WinForms.GunaLabel lbChange;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btnBayar;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}