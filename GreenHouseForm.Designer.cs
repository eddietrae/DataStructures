namespace DataStructsFinalEddie
{
    partial class GreenHouseForm
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
            this.pottingLabel = new System.Windows.Forms.Label();
            this.inspectionLabel = new System.Windows.Forms.Label();
            this.forSaleLabel = new System.Windows.Forms.Label();
            this.pottingDataGrid = new System.Windows.Forms.DataGridView();
            this.inspectionDataGrid = new System.Windows.Forms.DataGridView();
            this.forSaleDataGrid = new System.Windows.Forms.DataGridView();
            this.plantLabel = new System.Windows.Forms.Label();
            this.plantNameTextBox = new System.Windows.Forms.TextBox();
            this.pottingAddButton = new System.Windows.Forms.Button();
            this.pottingPassButton = new System.Windows.Forms.Button();
            this.inspectionPassButton = new System.Windows.Forms.Button();
            this.removeLabel = new System.Windows.Forms.Label();
            this.removeTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pottingDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forSaleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pottingLabel
            // 
            this.pottingLabel.AutoSize = true;
            this.pottingLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pottingLabel.Location = new System.Drawing.Point(73, 9);
            this.pottingLabel.Name = "pottingLabel";
            this.pottingLabel.Size = new System.Drawing.Size(106, 36);
            this.pottingLabel.TabIndex = 0;
            this.pottingLabel.Text = "Potting";
            // 
            // inspectionLabel
            // 
            this.inspectionLabel.AutoSize = true;
            this.inspectionLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectionLabel.Location = new System.Drawing.Point(324, 9);
            this.inspectionLabel.Name = "inspectionLabel";
            this.inspectionLabel.Size = new System.Drawing.Size(145, 36);
            this.inspectionLabel.TabIndex = 1;
            this.inspectionLabel.Text = "Inspection";
            // 
            // forSaleLabel
            // 
            this.forSaleLabel.AutoSize = true;
            this.forSaleLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forSaleLabel.Location = new System.Drawing.Point(603, 9);
            this.forSaleLabel.Name = "forSaleLabel";
            this.forSaleLabel.Size = new System.Drawing.Size(123, 36);
            this.forSaleLabel.TabIndex = 2;
            this.forSaleLabel.Text = "For Sale";
            // 
            // pottingDataGrid
            // 
            this.pottingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pottingDataGrid.Location = new System.Drawing.Point(12, 48);
            this.pottingDataGrid.Name = "pottingDataGrid";
            this.pottingDataGrid.Size = new System.Drawing.Size(240, 258);
            this.pottingDataGrid.TabIndex = 3;
            // 
            // inspectionDataGrid
            // 
            this.inspectionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspectionDataGrid.Location = new System.Drawing.Point(281, 48);
            this.inspectionDataGrid.Name = "inspectionDataGrid";
            this.inspectionDataGrid.Size = new System.Drawing.Size(240, 258);
            this.inspectionDataGrid.TabIndex = 4;
            // 
            // forSaleDataGrid
            // 
            this.forSaleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.forSaleDataGrid.Location = new System.Drawing.Point(548, 48);
            this.forSaleDataGrid.Name = "forSaleDataGrid";
            this.forSaleDataGrid.Size = new System.Drawing.Size(240, 258);
            this.forSaleDataGrid.TabIndex = 5;
            // 
            // plantLabel
            // 
            this.plantLabel.AutoSize = true;
            this.plantLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantLabel.Location = new System.Drawing.Point(7, 315);
            this.plantLabel.Name = "plantLabel";
            this.plantLabel.Size = new System.Drawing.Size(131, 27);
            this.plantLabel.TabIndex = 6;
            this.plantLabel.Text = "Plant Name:";
            // 
            // plantNameTextBox
            // 
            this.plantNameTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.plantNameTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantNameTextBox.Location = new System.Drawing.Point(144, 312);
            this.plantNameTextBox.Name = "plantNameTextBox";
            this.plantNameTextBox.Size = new System.Drawing.Size(173, 35);
            this.plantNameTextBox.TabIndex = 7;
            // 
            // pottingAddButton
            // 
            this.pottingAddButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pottingAddButton.Location = new System.Drawing.Point(173, 364);
            this.pottingAddButton.Name = "pottingAddButton";
            this.pottingAddButton.Size = new System.Drawing.Size(108, 36);
            this.pottingAddButton.TabIndex = 8;
            this.pottingAddButton.Text = "Add";
            this.pottingAddButton.UseVisualStyleBackColor = true;
            this.pottingAddButton.Click += new System.EventHandler(this.pottingAddButton_Click);
            // 
            // pottingPassButton
            // 
            this.pottingPassButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pottingPassButton.Location = new System.Drawing.Point(12, 345);
            this.pottingPassButton.Name = "pottingPassButton";
            this.pottingPassButton.Size = new System.Drawing.Size(126, 75);
            this.pottingPassButton.TabIndex = 9;
            this.pottingPassButton.Text = "Pass to Inspection";
            this.pottingPassButton.UseVisualStyleBackColor = true;
            this.pottingPassButton.Click += new System.EventHandler(this.pottingPassButton_Click);
            // 
            // inspectionPassButton
            // 
            this.inspectionPassButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectionPassButton.Location = new System.Drawing.Point(330, 345);
            this.inspectionPassButton.Name = "inspectionPassButton";
            this.inspectionPassButton.Size = new System.Drawing.Size(126, 75);
            this.inspectionPassButton.TabIndex = 10;
            this.inspectionPassButton.Text = "Pass to Sale";
            this.inspectionPassButton.UseVisualStyleBackColor = true;
            this.inspectionPassButton.Click += new System.EventHandler(this.inspectionPassButton_Click);
            // 
            // removeLabel
            // 
            this.removeLabel.AutoSize = true;
            this.removeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLabel.Location = new System.Drawing.Point(366, 315);
            this.removeLabel.Name = "removeLabel";
            this.removeLabel.Size = new System.Drawing.Size(272, 27);
            this.removeLabel.TabIndex = 11;
            this.removeLabel.Text = "Tray# to remove from sale:";
            // 
            // removeTextBox
            // 
            this.removeTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.removeTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTextBox.Location = new System.Drawing.Point(644, 312);
            this.removeTextBox.Name = "removeTextBox";
            this.removeTextBox.Size = new System.Drawing.Size(144, 35);
            this.removeTextBox.TabIndex = 12;
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(495, 364);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(108, 36);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(644, 355);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 65);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit Program";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // GreenHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.removeTextBox);
            this.Controls.Add(this.removeLabel);
            this.Controls.Add(this.inspectionPassButton);
            this.Controls.Add(this.pottingPassButton);
            this.Controls.Add(this.pottingAddButton);
            this.Controls.Add(this.plantNameTextBox);
            this.Controls.Add(this.plantLabel);
            this.Controls.Add(this.forSaleDataGrid);
            this.Controls.Add(this.inspectionDataGrid);
            this.Controls.Add(this.pottingDataGrid);
            this.Controls.Add(this.forSaleLabel);
            this.Controls.Add(this.inspectionLabel);
            this.Controls.Add(this.pottingLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GreenHouseForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Green House App";
            ((System.ComponentModel.ISupportInitialize)(this.pottingDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forSaleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pottingLabel;
        private System.Windows.Forms.Label inspectionLabel;
        private System.Windows.Forms.Label forSaleLabel;
        private System.Windows.Forms.DataGridView pottingDataGrid;
        private System.Windows.Forms.DataGridView inspectionDataGrid;
        private System.Windows.Forms.DataGridView forSaleDataGrid;
        private System.Windows.Forms.Label plantLabel;
        private System.Windows.Forms.TextBox plantNameTextBox;
        private System.Windows.Forms.Button pottingAddButton;
        private System.Windows.Forms.Button pottingPassButton;
        private System.Windows.Forms.Button inspectionPassButton;
        private System.Windows.Forms.Label removeLabel;
        private System.Windows.Forms.TextBox removeTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button exitButton;
    }
}

