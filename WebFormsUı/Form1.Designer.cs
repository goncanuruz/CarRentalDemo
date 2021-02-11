
namespace WebFormsUı
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwCars = new System.Windows.Forms.DataGridView();
            this.gbxBrand = new System.Windows.Forms.GroupBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearchCarName = new System.Windows.Forms.TextBox();
            this.lblCarName = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.cbxAddColor = new System.Windows.Forms.ComboBox();
            this.cbxAddBrand = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxAddDailyPrice = new System.Windows.Forms.TextBox();
            this.tbxAddDescription = new System.Windows.Forms.TextBox();
            this.tbxAddModelYear = new System.Windows.Forms.TextBox();
            this.tbxAddName = new System.Windows.Forms.TextBox();
            this.lblModelYear = new System.Windows.Forms.Label();
            this.lblDailyPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblColorId = new System.Windows.Forms.Label();
            this.lblBrandId = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.cbxUpdateColors = new System.Windows.Forms.ComboBox();
            this.cbxUpdateBrands = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateDailyPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateDescription = new System.Windows.Forms.TextBox();
            this.tbxUpdateModelYear = new System.Windows.Forms.TextBox();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateModelYear = new System.Windows.Forms.Label();
            this.lblUpdateDailyPrice = new System.Windows.Forms.Label();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.lblUpdateColorId = new System.Windows.Forms.Label();
            this.lblUpdateBrandId = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).BeginInit();
            this.gbxBrand.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCars
            // 
            this.dgwCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCars.Location = new System.Drawing.Point(14, 101);
            this.dgwCars.Name = "dgwCars";
            this.dgwCars.RowTemplate.Height = 25;
            this.dgwCars.Size = new System.Drawing.Size(920, 138);
            this.dgwCars.TabIndex = 0;
            this.dgwCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCars_CellClick);
            // 
            // gbxBrand
            // 
            this.gbxBrand.Controls.Add(this.cbxBrand);
            this.gbxBrand.Controls.Add(this.lblBrand);
            this.gbxBrand.Location = new System.Drawing.Point(471, 17);
            this.gbxBrand.Name = "gbxBrand";
            this.gbxBrand.Size = new System.Drawing.Size(463, 66);
            this.gbxBrand.TabIndex = 1;
            this.gbxBrand.TabStop = false;
            this.gbxBrand.Text = "Select by brand";
            this.gbxBrand.Enter += new System.EventHandler(this.gbxBrand_Enter);
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(92, 35);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(162, 23);
            this.cbxBrand.TabIndex = 4;
            this.cbxBrand.SelectedIndexChanged += new System.EventHandler(this.cbxBrand_SelectedIndexChanged);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(21, 38);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(43, 15);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brands";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearchCarName);
            this.gbxSearch.Controls.Add(this.lblCarName);
            this.gbxSearch.Location = new System.Drawing.Point(12, 16);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(450, 67);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search By Car Name";
            this.gbxSearch.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbxSearchCarName
            // 
            this.tbxSearchCarName.Location = new System.Drawing.Point(92, 33);
            this.tbxSearchCarName.Name = "tbxSearchCarName";
            this.tbxSearchCarName.Size = new System.Drawing.Size(162, 23);
            this.tbxSearchCarName.TabIndex = 5;
            this.tbxSearchCarName.TextChanged += new System.EventHandler(this.tbxSearchCarName_TextChanged);
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Location = new System.Drawing.Point(21, 36);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(60, 15);
            this.lblCarName.TabIndex = 4;
            this.lblCarName.Text = "Car Name";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.cbxAddColor);
            this.gbxAdd.Controls.Add(this.cbxAddBrand);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxAddDailyPrice);
            this.gbxAdd.Controls.Add(this.tbxAddDescription);
            this.gbxAdd.Controls.Add(this.tbxAddModelYear);
            this.gbxAdd.Controls.Add(this.tbxAddName);
            this.gbxAdd.Controls.Add(this.lblModelYear);
            this.gbxAdd.Controls.Add(this.lblDailyPrice);
            this.gbxAdd.Controls.Add(this.lblDescription);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.lblColorId);
            this.gbxAdd.Controls.Add(this.lblBrandId);
            this.gbxAdd.Location = new System.Drawing.Point(12, 257);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(292, 267);
            this.gbxAdd.TabIndex = 3;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a car";
            // 
            // cbxAddColor
            // 
            this.cbxAddColor.FormattingEnabled = true;
            this.cbxAddColor.Location = new System.Drawing.Point(92, 61);
            this.cbxAddColor.Name = "cbxAddColor";
            this.cbxAddColor.Size = new System.Drawing.Size(132, 23);
            this.cbxAddColor.TabIndex = 10;
            // 
            // cbxAddBrand
            // 
            this.cbxAddBrand.FormattingEnabled = true;
            this.cbxAddBrand.Location = new System.Drawing.Point(92, 32);
            this.cbxAddBrand.Name = "cbxAddBrand";
            this.cbxAddBrand.Size = new System.Drawing.Size(132, 23);
            this.cbxAddBrand.TabIndex = 9;
            this.cbxAddBrand.SelectedIndexChanged += new System.EventHandler(this.cbxAddBrand_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(161, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAddDailyPrice
            // 
            this.tbxAddDailyPrice.Location = new System.Drawing.Point(92, 177);
            this.tbxAddDailyPrice.Name = "tbxAddDailyPrice";
            this.tbxAddDailyPrice.Size = new System.Drawing.Size(132, 23);
            this.tbxAddDailyPrice.TabIndex = 5;
            // 
            // tbxAddDescription
            // 
            this.tbxAddDescription.Location = new System.Drawing.Point(92, 119);
            this.tbxAddDescription.Name = "tbxAddDescription";
            this.tbxAddDescription.Size = new System.Drawing.Size(132, 23);
            this.tbxAddDescription.TabIndex = 6;
            // 
            // tbxAddModelYear
            // 
            this.tbxAddModelYear.Location = new System.Drawing.Point(92, 148);
            this.tbxAddModelYear.Name = "tbxAddModelYear";
            this.tbxAddModelYear.Size = new System.Drawing.Size(132, 23);
            this.tbxAddModelYear.TabIndex = 4;
            // 
            // tbxAddName
            // 
            this.tbxAddName.Location = new System.Drawing.Point(92, 90);
            this.tbxAddName.Name = "tbxAddName";
            this.tbxAddName.Size = new System.Drawing.Size(132, 23);
            this.tbxAddName.TabIndex = 8;
            // 
            // lblModelYear
            // 
            this.lblModelYear.AutoSize = true;
            this.lblModelYear.Location = new System.Drawing.Point(9, 151);
            this.lblModelYear.Name = "lblModelYear";
            this.lblModelYear.Size = new System.Drawing.Size(66, 15);
            this.lblModelYear.TabIndex = 6;
            this.lblModelYear.Text = "Model Year";
            // 
            // lblDailyPrice
            // 
            this.lblDailyPrice.AutoSize = true;
            this.lblDailyPrice.Location = new System.Drawing.Point(9, 180);
            this.lblDailyPrice.Name = "lblDailyPrice";
            this.lblDailyPrice.Size = new System.Drawing.Size(62, 15);
            this.lblDailyPrice.TabIndex = 5;
            this.lblDailyPrice.Text = "Daily Price";
            this.lblDailyPrice.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 122);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 15);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblColorId
            // 
            this.lblColorId.AutoSize = true;
            this.lblColorId.Location = new System.Drawing.Point(9, 64);
            this.lblColorId.Name = "lblColorId";
            this.lblColorId.Size = new System.Drawing.Size(46, 15);
            this.lblColorId.TabIndex = 2;
            this.lblColorId.Text = "ColorId";
            // 
            // lblBrandId
            // 
            this.lblBrandId.AutoSize = true;
            this.lblBrandId.Location = new System.Drawing.Point(9, 35);
            this.lblBrandId.Name = "lblBrandId";
            this.lblBrandId.Size = new System.Drawing.Size(51, 15);
            this.lblBrandId.TabIndex = 1;
            this.lblBrandId.Text = "Brand Id";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.cbxUpdateColors);
            this.gbxUpdate.Controls.Add(this.cbxUpdateBrands);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUpdateDailyPrice);
            this.gbxUpdate.Controls.Add(this.tbxUpdateDescription);
            this.gbxUpdate.Controls.Add(this.tbxUpdateModelYear);
            this.gbxUpdate.Controls.Add(this.tbxUpdateName);
            this.gbxUpdate.Controls.Add(this.lblUpdateModelYear);
            this.gbxUpdate.Controls.Add(this.lblUpdateDailyPrice);
            this.gbxUpdate.Controls.Add(this.lblUpdateDescription);
            this.gbxUpdate.Controls.Add(this.lblUpdateName);
            this.gbxUpdate.Controls.Add(this.lblUpdateColorId);
            this.gbxUpdate.Controls.Add(this.lblUpdateBrandId);
            this.gbxUpdate.Location = new System.Drawing.Point(421, 257);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(270, 267);
            this.gbxUpdate.TabIndex = 4;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a car";
            // 
            // cbxUpdateColors
            // 
            this.cbxUpdateColors.FormattingEnabled = true;
            this.cbxUpdateColors.Location = new System.Drawing.Point(92, 61);
            this.cbxUpdateColors.Name = "cbxUpdateColors";
            this.cbxUpdateColors.Size = new System.Drawing.Size(132, 23);
            this.cbxUpdateColors.TabIndex = 10;
            // 
            // cbxUpdateBrands
            // 
            this.cbxUpdateBrands.FormattingEnabled = true;
            this.cbxUpdateBrands.Location = new System.Drawing.Point(92, 32);
            this.cbxUpdateBrands.Name = "cbxUpdateBrands";
            this.cbxUpdateBrands.Size = new System.Drawing.Size(132, 23);
            this.cbxUpdateBrands.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(161, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 32);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateDailyPrice
            // 
            this.tbxUpdateDailyPrice.Location = new System.Drawing.Point(92, 177);
            this.tbxUpdateDailyPrice.Name = "tbxUpdateDailyPrice";
            this.tbxUpdateDailyPrice.Size = new System.Drawing.Size(132, 23);
            this.tbxUpdateDailyPrice.TabIndex = 5;
            // 
            // tbxUpdateDescription
            // 
            this.tbxUpdateDescription.Location = new System.Drawing.Point(92, 119);
            this.tbxUpdateDescription.Name = "tbxUpdateDescription";
            this.tbxUpdateDescription.Size = new System.Drawing.Size(132, 23);
            this.tbxUpdateDescription.TabIndex = 6;
            // 
            // tbxUpdateModelYear
            // 
            this.tbxUpdateModelYear.Location = new System.Drawing.Point(92, 148);
            this.tbxUpdateModelYear.Name = "tbxUpdateModelYear";
            this.tbxUpdateModelYear.Size = new System.Drawing.Size(132, 23);
            this.tbxUpdateModelYear.TabIndex = 4;
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(92, 90);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(132, 23);
            this.tbxUpdateName.TabIndex = 8;
            // 
            // lblUpdateModelYear
            // 
            this.lblUpdateModelYear.AutoSize = true;
            this.lblUpdateModelYear.Location = new System.Drawing.Point(9, 151);
            this.lblUpdateModelYear.Name = "lblUpdateModelYear";
            this.lblUpdateModelYear.Size = new System.Drawing.Size(66, 15);
            this.lblUpdateModelYear.TabIndex = 6;
            this.lblUpdateModelYear.Text = "Model Year";
            // 
            // lblUpdateDailyPrice
            // 
            this.lblUpdateDailyPrice.AutoSize = true;
            this.lblUpdateDailyPrice.Location = new System.Drawing.Point(9, 180);
            this.lblUpdateDailyPrice.Name = "lblUpdateDailyPrice";
            this.lblUpdateDailyPrice.Size = new System.Drawing.Size(62, 15);
            this.lblUpdateDailyPrice.TabIndex = 5;
            this.lblUpdateDailyPrice.Text = "Daily Price";
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(9, 122);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(67, 15);
            this.lblUpdateDescription.TabIndex = 4;
            this.lblUpdateDescription.Text = "Description";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(9, 93);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(39, 15);
            this.lblUpdateName.TabIndex = 3;
            this.lblUpdateName.Text = "Name";
            // 
            // lblUpdateColorId
            // 
            this.lblUpdateColorId.AutoSize = true;
            this.lblUpdateColorId.Location = new System.Drawing.Point(9, 64);
            this.lblUpdateColorId.Name = "lblUpdateColorId";
            this.lblUpdateColorId.Size = new System.Drawing.Size(46, 15);
            this.lblUpdateColorId.TabIndex = 2;
            this.lblUpdateColorId.Text = "ColorId";
            // 
            // lblUpdateBrandId
            // 
            this.lblUpdateBrandId.AutoSize = true;
            this.lblUpdateBrandId.Location = new System.Drawing.Point(9, 35);
            this.lblUpdateBrandId.Name = "lblUpdateBrandId";
            this.lblUpdateBrandId.Size = new System.Drawing.Size(51, 15);
            this.lblUpdateBrandId.TabIndex = 1;
            this.lblUpdateBrandId.Text = "Brand Id";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(778, 321);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 50);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 536);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxBrand);
            this.Controls.Add(this.dgwCars);
            this.Name = "Form1";
            this.Text = "Car Rental";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).EndInit();
            this.gbxBrand.ResumeLayout(false);
            this.gbxBrand.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCars;
        private System.Windows.Forms.GroupBox gbxBrand;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox tbxSearchCarName;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblBrandId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblColorId;
        private System.Windows.Forms.TextBox tbxAddDailyPrice;
        private System.Windows.Forms.TextBox tbxAddDescription;
        private System.Windows.Forms.TextBox tbxAddModelYear;
        private System.Windows.Forms.TextBox tbxAddName;
        private System.Windows.Forms.Label lblModelYear;
        private System.Windows.Forms.Label lblDailyPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxAddColor;
        private System.Windows.Forms.ComboBox cbxAddBrand;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.ComboBox cbxUpdateColors;
        private System.Windows.Forms.ComboBox cbxUpdateBrands;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateDailyPrice;
        private System.Windows.Forms.TextBox tbxUpdateDescription;
        private System.Windows.Forms.TextBox tbxUpdateModelYear;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Label lblUpdateModelYear;
        private System.Windows.Forms.Label lblUpdateDailyPrice;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.Label lblUpdateColorId;
        private System.Windows.Forms.Label lblUpdateBrandId;
        private System.Windows.Forms.Button btnRemove;
    }
}

