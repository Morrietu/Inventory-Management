namespace C968___PA
{
    partial class ModifyProductForm
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
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partsSearchBox = new System.Windows.Forms.TextBox();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.allPartsLabel = new System.Windows.Forms.Label();
            this.associatedPartsTable = new System.Windows.Forms.DataGridView();
            this.allPartsTable = new System.Windows.Forms.DataGridView();
            this.modifyPartLabel = new System.Windows.Forms.Label();
            this.productMinTextBox = new System.Windows.Forms.TextBox();
            this.productMaxTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productInventoryTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productInventoryLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchButton.Location = new System.Drawing.Point(1057, 58);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(85, 31);
            this.partsSearchButton.TabIndex = 74;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // partsSearchBox
            // 
            this.partsSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partsSearchBox.Location = new System.Drawing.Point(1148, 58);
            this.partsSearchBox.Multiline = true;
            this.partsSearchBox.Name = "partsSearchBox";
            this.partsSearchBox.Size = new System.Drawing.Size(245, 31);
            this.partsSearchBox.TabIndex = 73;
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associatedPartsLabel.Location = new System.Drawing.Point(746, 451);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(249, 20);
            this.associatedPartsLabel.TabIndex = 72;
            this.associatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPartsLabel.Location = new System.Drawing.Point(746, 69);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(144, 20);
            this.allPartsLabel.TabIndex = 71;
            this.allPartsLabel.Text = "All Candidate Parts";
            // 
            // associatedPartsTable
            // 
            this.associatedPartsTable.AllowUserToAddRows = false;
            this.associatedPartsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.associatedPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.associatedPartsTable.Location = new System.Drawing.Point(750, 486);
            this.associatedPartsTable.Name = "associatedPartsTable";
            this.associatedPartsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsTable.Size = new System.Drawing.Size(643, 279);
            this.associatedPartsTable.TabIndex = 70;
            // 
            // allPartsTable
            // 
            this.allPartsTable.AllowUserToAddRows = false;
            this.allPartsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.allPartsTable.Location = new System.Drawing.Point(750, 102);
            this.allPartsTable.Name = "allPartsTable";
            this.allPartsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsTable.Size = new System.Drawing.Size(643, 279);
            this.allPartsTable.TabIndex = 69;
            // 
            // modifyPartLabel
            // 
            this.modifyPartLabel.AutoSize = true;
            this.modifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartLabel.Location = new System.Drawing.Point(31, 20);
            this.modifyPartLabel.Name = "modifyPartLabel";
            this.modifyPartLabel.Size = new System.Drawing.Size(114, 20);
            this.modifyPartLabel.TabIndex = 68;
            this.modifyPartLabel.Text = "Modify Product";
            // 
            // productMinTextBox
            // 
            this.productMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinTextBox.Location = new System.Drawing.Point(393, 592);
            this.productMinTextBox.Name = "productMinTextBox";
            this.productMinTextBox.Size = new System.Drawing.Size(166, 24);
            this.productMinTextBox.TabIndex = 67;
            // 
            // productMaxTextBox
            // 
            this.productMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxTextBox.Location = new System.Drawing.Point(128, 589);
            this.productMaxTextBox.Name = "productMaxTextBox";
            this.productMaxTextBox.Size = new System.Drawing.Size(166, 24);
            this.productMaxTextBox.TabIndex = 66;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceTextBox.Location = new System.Drawing.Point(128, 531);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(166, 24);
            this.productPriceTextBox.TabIndex = 65;
            // 
            // productInventoryTextBox
            // 
            this.productInventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventoryTextBox.Location = new System.Drawing.Point(128, 461);
            this.productInventoryTextBox.Name = "productInventoryTextBox";
            this.productInventoryTextBox.Size = new System.Drawing.Size(166, 24);
            this.productInventoryTextBox.TabIndex = 64;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(128, 397);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(166, 24);
            this.productNameTextBox.TabIndex = 63;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDTextBox.Location = new System.Drawing.Point(128, 328);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(166, 24);
            this.productIDTextBox.TabIndex = 62;
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinLabel.Location = new System.Drawing.Point(338, 592);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(32, 18);
            this.productMinLabel.TabIndex = 61;
            this.productMinLabel.Text = "Min";
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxLabel.Location = new System.Drawing.Point(48, 592);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(36, 18);
            this.productMaxLabel.TabIndex = 60;
            this.productMaxLabel.Text = "Max";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.Location = new System.Drawing.Point(48, 534);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(42, 18);
            this.productPriceLabel.TabIndex = 59;
            this.productPriceLabel.Text = "Price";
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventoryLabel.Location = new System.Drawing.Point(48, 467);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(67, 18);
            this.productInventoryLabel.TabIndex = 58;
            this.productInventoryLabel.Text = "Inventory";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(48, 400);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(48, 18);
            this.productNameLabel.TabIndex = 57;
            this.productNameLabel.Text = "Name";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.Location = new System.Drawing.Point(48, 334);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(22, 18);
            this.productIDLabel.TabIndex = 56;
            this.productIDLabel.Text = "ID";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(1148, 876);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 50);
            this.saveButton.TabIndex = 55;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(1271, 876);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 50);
            this.cancelButton.TabIndex = 54;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductButton.Location = new System.Drawing.Point(1271, 783);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(100, 50);
            this.deleteProductButton.TabIndex = 53;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductButton.Location = new System.Drawing.Point(1271, 397);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(100, 50);
            this.addProductButton.TabIndex = 52;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1424, 946);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.partsSearchBox);
            this.Controls.Add(this.associatedPartsLabel);
            this.Controls.Add(this.allPartsLabel);
            this.Controls.Add(this.associatedPartsTable);
            this.Controls.Add(this.allPartsTable);
            this.Controls.Add(this.modifyPartLabel);
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
            this.Name = "ModifyProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.TextBox partsSearchBox;
        private System.Windows.Forms.Label associatedPartsLabel;
        private System.Windows.Forms.Label allPartsLabel;
        private System.Windows.Forms.Label modifyPartLabel;
        private System.Windows.Forms.TextBox productMinTextBox;
        private System.Windows.Forms.TextBox productMaxTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.TextBox productInventoryTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productInventoryLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button addProductButton;
        public System.Windows.Forms.DataGridView associatedPartsTable;
        public System.Windows.Forms.DataGridView allPartsTable;
    }
}