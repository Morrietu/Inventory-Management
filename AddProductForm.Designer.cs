namespace C968___PA
{
    partial class AddProductForm
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
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productInventoryLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productInventoryTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productMaxTextBox = new System.Windows.Forms.TextBox();
            this.productMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartLabel = new System.Windows.Forms.Label();
            this.allPartsTable = new System.Windows.Forms.DataGridView();
            this.associatedPartsTable = new System.Windows.Forms.DataGridView();
            this.allPartsLabel = new System.Windows.Forms.Label();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partsSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductButton
            // 
            this.addProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductButton.Location = new System.Drawing.Point(1277, 396);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(100, 50);
            this.addProductButton.TabIndex = 4;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductButton.Location = new System.Drawing.Point(1277, 782);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(100, 50);
            this.deleteProductButton.TabIndex = 5;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(1277, 875);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 50);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(1154, 875);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 50);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.Location = new System.Drawing.Point(38, 333);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(22, 18);
            this.productIDLabel.TabIndex = 33;
            this.productIDLabel.Text = "ID";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(38, 399);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(48, 18);
            this.productNameLabel.TabIndex = 34;
            this.productNameLabel.Text = "Name";
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventoryLabel.Location = new System.Drawing.Point(38, 466);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(67, 18);
            this.productInventoryLabel.TabIndex = 35;
            this.productInventoryLabel.Text = "Inventory";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.Location = new System.Drawing.Point(38, 533);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(42, 18);
            this.productPriceLabel.TabIndex = 36;
            this.productPriceLabel.Text = "Price";
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxLabel.Location = new System.Drawing.Point(38, 591);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(36, 18);
            this.productMaxLabel.TabIndex = 37;
            this.productMaxLabel.Text = "Max";
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinLabel.Location = new System.Drawing.Point(328, 591);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(32, 18);
            this.productMinLabel.TabIndex = 38;
            this.productMinLabel.Text = "Min";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDTextBox.Location = new System.Drawing.Point(118, 327);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(166, 24);
            this.productIDTextBox.TabIndex = 39;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(118, 396);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(166, 24);
            this.productNameTextBox.TabIndex = 40;
            // 
            // productInventoryTextBox
            // 
            this.productInventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventoryTextBox.Location = new System.Drawing.Point(118, 460);
            this.productInventoryTextBox.Name = "productInventoryTextBox";
            this.productInventoryTextBox.Size = new System.Drawing.Size(166, 24);
            this.productInventoryTextBox.TabIndex = 41;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceTextBox.Location = new System.Drawing.Point(118, 530);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(166, 24);
            this.productPriceTextBox.TabIndex = 42;
            // 
            // productMaxTextBox
            // 
            this.productMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxTextBox.Location = new System.Drawing.Point(118, 588);
            this.productMaxTextBox.Name = "productMaxTextBox";
            this.productMaxTextBox.Size = new System.Drawing.Size(166, 24);
            this.productMaxTextBox.TabIndex = 43;
            // 
            // productMinTextBox
            // 
            this.productMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinTextBox.Location = new System.Drawing.Point(383, 591);
            this.productMinTextBox.Name = "productMinTextBox";
            this.productMinTextBox.Size = new System.Drawing.Size(166, 24);
            this.productMinTextBox.TabIndex = 44;
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(21, 19);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(97, 20);
            this.addPartLabel.TabIndex = 45;
            this.addPartLabel.Text = "Add Product";
            // 
            // allPartsTable
            // 
            this.allPartsTable.AllowUserToAddRows = false;
            this.allPartsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.allPartsTable.Location = new System.Drawing.Point(740, 101);
            this.allPartsTable.Name = "allPartsTable";
            this.allPartsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsTable.Size = new System.Drawing.Size(659, 279);
            this.allPartsTable.TabIndex = 46;
            // 
            // associatedPartsTable
            // 
            this.associatedPartsTable.AllowUserToAddRows = false;
            this.associatedPartsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.associatedPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.associatedPartsTable.Location = new System.Drawing.Point(740, 485);
            this.associatedPartsTable.Name = "associatedPartsTable";
            this.associatedPartsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsTable.Size = new System.Drawing.Size(659, 279);
            this.associatedPartsTable.TabIndex = 47;
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPartsLabel.Location = new System.Drawing.Point(736, 68);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(144, 20);
            this.allPartsLabel.TabIndex = 48;
            this.allPartsLabel.Text = "All Candidate Parts";
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associatedPartsLabel.Location = new System.Drawing.Point(736, 450);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(249, 20);
            this.associatedPartsLabel.TabIndex = 49;
            this.associatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchButton.Location = new System.Drawing.Point(1063, 57);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(85, 31);
            this.partsSearchButton.TabIndex = 51;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // partsSearchBox
            // 
            this.partsSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partsSearchBox.Location = new System.Drawing.Point(1154, 57);
            this.partsSearchBox.Multiline = true;
            this.partsSearchBox.Name = "partsSearchBox";
            this.partsSearchBox.Size = new System.Drawing.Size(245, 31);
            this.partsSearchBox.TabIndex = 50;
            this.partsSearchBox.TextChanged += new System.EventHandler(this.partsSearchBox_TextChanged);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1440, 985);
            this.ClientSize = new System.Drawing.Size(1424, 976);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.partsSearchBox);
            this.Controls.Add(this.associatedPartsLabel);
            this.Controls.Add(this.allPartsLabel);
            this.Controls.Add(this.associatedPartsTable);
            this.Controls.Add(this.allPartsTable);
            this.Controls.Add(this.addPartLabel);
            this.Controls.Add(this.productMinTextBox);
            this.Controls.Add(this.productMaxTextBox);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.productInventoryTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.productMinLabel);
            this.Controls.Add(this.productMaxLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productInventoryLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.addProductButton);
            this.MinimumSize = new System.Drawing.Size(1440, 985);
            this.Name = "AddProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allPartsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productInventoryLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productInventoryTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.TextBox productMaxTextBox;
        private System.Windows.Forms.TextBox productMinTextBox;
        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.Label allPartsLabel;
        private System.Windows.Forms.Label associatedPartsLabel;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.TextBox partsSearchBox;
        public System.Windows.Forms.DataGridView allPartsTable;
        public System.Windows.Forms.DataGridView associatedPartsTable;
    }
}