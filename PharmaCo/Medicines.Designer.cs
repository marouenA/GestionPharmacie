namespace PharmaCo
{
    partial class Medicines
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicines));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MedName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BuyingPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SellingPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ExpirationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Company = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(215, 58);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Medicine";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(395, 90);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(455, 265);
            this.bunifuCustomDataGrid1.TabIndex = 1;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BunifuCustomDataGrid1_CellContentClick);
            // 
            // MedName
            // 
            this.MedName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MedName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MedName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MedName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedName.ForeColor = System.Drawing.Color.SeaGreen;
            this.MedName.HintForeColor = System.Drawing.Color.Empty;
            this.MedName.HintText = "";
            this.MedName.isPassword = false;
            this.MedName.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.MedName.LineIdleColor = System.Drawing.Color.Gray;
            this.MedName.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.MedName.LineThickness = 3;
            this.MedName.Location = new System.Drawing.Point(13, 111);
            this.MedName.Margin = new System.Windows.Forms.Padding(4);
            this.MedName.MaxLength = 32767;
            this.MedName.Name = "MedName";
            this.MedName.Size = new System.Drawing.Size(169, 31);
            this.MedName.TabIndex = 3;
            this.MedName.Text = "Name";
            this.MedName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BuyingPrice
            // 
            this.BuyingPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BuyingPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BuyingPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BuyingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BuyingPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BuyingPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.BuyingPrice.HintForeColor = System.Drawing.Color.Empty;
            this.BuyingPrice.HintText = "";
            this.BuyingPrice.isPassword = false;
            this.BuyingPrice.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.BuyingPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.BuyingPrice.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.BuyingPrice.LineThickness = 3;
            this.BuyingPrice.Location = new System.Drawing.Point(209, 109);
            this.BuyingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.BuyingPrice.MaxLength = 32767;
            this.BuyingPrice.Name = "BuyingPrice";
            this.BuyingPrice.Size = new System.Drawing.Size(127, 33);
            this.BuyingPrice.TabIndex = 7;
            this.BuyingPrice.Text = "Buying Price";
            this.BuyingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SellingPrice
            // 
            this.SellingPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SellingPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SellingPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellingPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SellingPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.SellingPrice.HintForeColor = System.Drawing.Color.Empty;
            this.SellingPrice.HintText = "";
            this.SellingPrice.isPassword = false;
            this.SellingPrice.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.SellingPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.SellingPrice.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.SellingPrice.LineThickness = 3;
            this.SellingPrice.Location = new System.Drawing.Point(209, 184);
            this.SellingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.SellingPrice.MaxLength = 32767;
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(127, 33);
            this.SellingPrice.TabIndex = 8;
            this.SellingPrice.Text = "Selling Price";
            this.SellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Quantity
            // 
            this.Quantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Quantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Quantity.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Quantity.ForeColor = System.Drawing.Color.SeaGreen;
            this.Quantity.HintForeColor = System.Drawing.Color.Empty;
            this.Quantity.HintText = "";
            this.Quantity.isPassword = false;
            this.Quantity.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.Quantity.LineIdleColor = System.Drawing.Color.Gray;
            this.Quantity.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.Quantity.LineThickness = 3;
            this.Quantity.Location = new System.Drawing.Point(209, 263);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.Quantity.MaxLength = 32767;
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(127, 33);
            this.Quantity.TabIndex = 9;
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(230, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(114, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(12, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(114, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 43);
            this.button4.TabIndex = 15;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.CheckedState.Parent = this.ExpirationDate;
            this.ExpirationDate.FillColor = System.Drawing.Color.SeaGreen;
            this.ExpirationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpirationDate.HoverState.Parent = this.ExpirationDate;
            this.ExpirationDate.Location = new System.Drawing.Point(13, 181);
            this.ExpirationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExpirationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ShadowDecoration.Parent = this.ExpirationDate;
            this.ExpirationDate.Size = new System.Drawing.Size(169, 36);
            this.ExpirationDate.TabIndex = 16;
            this.ExpirationDate.Value = new System.DateTime(2020, 12, 15, 22, 9, 18, 916);
            // 
            // Company
            // 
            this.Company.BackColor = System.Drawing.Color.Transparent;
            this.Company.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Company.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Company.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Company.FocusedState.Parent = this.Company;
            this.Company.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Company.HoverState.Parent = this.Company;
            this.Company.ItemHeight = 30;
            this.Company.Items.AddRange(new object[] {
            "PharmaProd",
            "ParmaCom",
            "TunisiePharma"});
            this.Company.ItemsAppearance.Parent = this.Company;
            this.Company.Location = new System.Drawing.Point(12, 263);
            this.Company.Name = "Company";
            this.Company.ShadowDecoration.Parent = this.Company;
            this.Company.Size = new System.Drawing.Size(170, 36);
            this.Company.TabIndex = 17;
            this.Company.SelectedIndexChanged += new System.EventHandler(this.Company_SelectedIndexChanged);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.ColumnHeadersHeight = 44;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(361, 28);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(684, 418);
            this.guna2DataGridView1.TabIndex = 18;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 44;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Guna2DataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1028, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1057, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.ExpirationDate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.SellingPrice);
            this.Controls.Add(this.BuyingPrice);
            this.Controls.Add(this.MedName);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medicines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicines";
            this.Load += new System.EventHandler(this.Medicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MedName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BuyingPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellingPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Quantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Guna.UI2.WinForms.Guna2DateTimePicker ExpirationDate;
        private Guna.UI2.WinForms.Guna2ComboBox Company;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label2;
    }
}