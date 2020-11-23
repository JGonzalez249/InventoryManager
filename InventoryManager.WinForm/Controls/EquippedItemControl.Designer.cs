
namespace InventoryManager.WinForm.Controls
{
    partial class EquippedItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.equippedLocationTextBox = new System.Windows.Forms.TextBox();
            this.equippedItemComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // equippedLocationTextBox
            // 
            this.equippedLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equippedLocationTextBox.Location = new System.Drawing.Point(2, 3);
            this.equippedLocationTextBox.Name = "equippedLocationTextBox";
            this.equippedLocationTextBox.ReadOnly = true;
            this.equippedLocationTextBox.Size = new System.Drawing.Size(160, 22);
            this.equippedLocationTextBox.TabIndex = 0;
            this.equippedLocationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // equippedItemComboBox
            // 
            this.equippedItemComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equippedItemComboBox.DisplayMember = "Name";
            this.equippedItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equippedItemComboBox.FormattingEnabled = true;
            this.equippedItemComboBox.Location = new System.Drawing.Point(2, 29);
            this.equippedItemComboBox.Name = "equippedItemComboBox";
            this.equippedItemComboBox.Size = new System.Drawing.Size(160, 24);
            this.equippedItemComboBox.TabIndex = 1;
            this.equippedItemComboBox.SelectedIndexChanged += new System.EventHandler(this.EquippedItemComboBox_SelectedIndexChanged);
            // 
            // EquippedItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equippedItemComboBox);
            this.Controls.Add(this.equippedLocationTextBox);
            this.Name = "EquippedItemControl";
            this.Size = new System.Drawing.Size(165, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox equippedLocationTextBox;
        private System.Windows.Forms.ComboBox equippedItemComboBox;
    }
}
