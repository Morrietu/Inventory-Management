namespace C968___PA
{
    partial class MainForm
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
            this.addPartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.partsTable = new System.Windows.Forms.DataGridView();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.partsSearchBox = new System.Windows.Forms.TextBox();
            this.productsSearchBox = new System.Windows.Forms.TextBox();
            this.mainScreenLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.productsSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(365, 481);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(100, 50);
            this.addPartButton.TabIndex = 0;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.UseWaitCursor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.Location = new System.Drawing.Point(471, 481);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(100, 50);
            this.modifyPartButton.TabIndex = 1;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.UseWaitCursor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.modifyPartButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(577, 481);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(100, 50);
            this.deletePartButton.TabIndex = 2;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.UseWaitCursor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductButton.Location = new System.Drawing.Point(1402, 481);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(100, 50);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.UseWaitCursor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyProductButton.Location = new System.Drawing.Point(1508, 481);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(100, 50);
            this.modifyProductButton.TabIndex = 4;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.UseWaitCursor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductButton.Location = new System.Drawing.Point(1614, 481);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(100, 50);
            this.deleteProductButton.TabIndex = 5;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.UseWaitCursor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(1614, 567);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 50);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.UseWaitCursor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // partsTable
            // 
            this.partsTable.AllowUserToAddRows = false;
            this.partsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partsTable.Location = new System.Drawing.Point(36, 182);
            this.partsTable.Name = "partsTable";
            this.partsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsTable.Size = new System.Drawing.Size(641, 279);
            this.partsTable.TabIndex = 7;
            this.partsTable.UseWaitCursor = true;
            // 
            // productsTable
            // 
            this.productsTable.AllowUserToAddRows = false;
            this.productsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productsTable.Location = new System.Drawing.Point(1074, 182);
            this.productsTable.Name = "productsTable";
            this.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTable.Size = new System.Drawing.Size(640, 279);
            this.productsTable.TabIndex = 8;
            this.productsTable.UseWaitCursor = true;
            this.productsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsTable_CellContentClick);
            // 
            // partsSearchBox
            // 
            this.partsSearchBox.Location = new System.Drawing.Point(432, 129);
            this.partsSearchBox.Multiline = true;
            this.partsSearchBox.Name = "partsSearchBox";
            this.partsSearchBox.Size = new System.Drawing.Size(245, 31);
            this.partsSearchBox.TabIndex = 9;
            this.partsSearchBox.UseWaitCursor = true;
            this.partsSearchBox.TextChanged += new System.EventHandler(this.partsSearchBox_TextChanged);
            // 
            // productsSearchBox
            // 
            this.productsSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productsSearchBox.Location = new System.Drawing.Point(1469, 129);
            this.productsSearchBox.Multiline = true;
            this.productsSearchBox.Name = "productsSearchBox";
            this.productsSearchBox.Size = new System.Drawing.Size(245, 31);
            this.productsSearchBox.TabIndex = 10;
            this.productsSearchBox.UseWaitCursor = true;
            this.productsSearchBox.TextChanged += new System.EventHandler(this.productsSearchBox_TextChanged);
            // 
            // mainScreenLabel
            // 
            this.mainScreenLabel.AutoSize = true;
            this.mainScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenLabel.Location = new System.Drawing.Point(21, 9);
            this.mainScreenLabel.Name = "mainScreenLabel";
            this.mainScreenLabel.Size = new System.Drawing.Size(229, 20);
            this.mainScreenLabel.TabIndex = 11;
            this.mainScreenLabel.Text = "Inventory Management System";
            this.mainScreenLabel.UseWaitCursor = true;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(32, 140);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(46, 20);
            this.partsLabel.TabIndex = 12;
            this.partsLabel.Text = "Parts";
            this.partsLabel.UseWaitCursor = true;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(1070, 140);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(72, 20);
            this.productsLabel.TabIndex = 13;
            this.productsLabel.Text = "Products";
            this.productsLabel.UseWaitCursor = true;
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchButton.Location = new System.Drawing.Point(341, 129);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(85, 31);
            this.partsSearchButton.TabIndex = 14;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.UseWaitCursor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsSearchButton.Location = new System.Drawing.Point(1378, 129);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(85, 31);
            this.productsSearchButton.TabIndex = 15;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            this.productsSearchButton.UseWaitCursor = true;
            this.productsSearchButton.Click += new System.EventHandler(this.productsSearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1754, 629);
            this.Controls.Add(this.productsSearchButton);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.mainScreenLabel);
            this.Controls.Add(this.productsSearchBox);
            this.Controls.Add(this.partsSearchBox);
            this.Controls.Add(this.productsTable);
            this.Controls.Add(this.partsTable);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.deletePartButton);
            this.Controls.Add(this.modifyPartButton);
            this.Controls.Add(this.addPartButton);
            this.MaximumSize = new System.Drawing.Size(1770, 668);
            this.MinimumSize = new System.Drawing.Size(1770, 668);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox partsSearchBox;
        private System.Windows.Forms.TextBox productsSearchBox;
        private System.Windows.Forms.Label mainScreenLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.Button productsSearchButton;
        public System.Windows.Forms.DataGridView partsTable;
        public System.Windows.Forms.DataGridView productsTable;
    }
}

