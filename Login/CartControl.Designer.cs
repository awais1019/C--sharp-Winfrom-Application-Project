
namespace Login
{
    partial class CartControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelProducts = new System.Windows.Forms.Label();
            this.RemoveButton = new Guna.UI2.WinForms.Guna2Button();
            this.Searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // GridProducts
            // 
            this.GridProducts.AllowUserToAddRows = false;
            this.GridProducts.AllowUserToDeleteRows = false;
            this.GridProducts.AllowUserToResizeColumns = false;
            this.GridProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.GridProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridProducts.ColumnHeadersHeight = 30;
            this.GridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GridProducts.Location = new System.Drawing.Point(197, 94);
            this.GridProducts.MultiSelect = false;
            this.GridProducts.Name = "GridProducts";
            this.GridProducts.ReadOnly = true;
            this.GridProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridProducts.RowHeadersVisible = false;
            this.GridProducts.RowHeadersWidth = 40;
            this.GridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridProducts.RowTemplate.ErrorText = "Error";
            this.GridProducts.ShowEditingIcon = false;
            this.GridProducts.Size = new System.Drawing.Size(509, 277);
            this.GridProducts.TabIndex = 71;
            this.GridProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GridProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GridProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridProducts.ThemeStyle.HeaderStyle.Height = 30;
            this.GridProducts.ThemeStyle.ReadOnly = true;
            this.GridProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridProducts.ThemeStyle.RowsStyle.Height = 22;
            this.GridProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProducts_CellClick);
            this.GridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProducts_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 13;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnEdit.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(36, 235);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedColor = System.Drawing.Color.Aqua;
            this.btnEdit.PressedDepth = 40;
            this.btnEdit.Size = new System.Drawing.Size(125, 34);
            this.btnEdit.TabIndex = 70;
            this.btnEdit.Text = "Edit Qunatity";
            this.btnEdit.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.BorderThickness = 0;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(33, 105);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtName.PlaceholderText = "Product Name";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(125, 25);
            this.txtName.TabIndex = 68;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(33, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 10);
            this.panel2.TabIndex = 69;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderColor = System.Drawing.Color.White;
            this.txtQuantity.BorderThickness = 0;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(33, 167);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtQuantity.PlaceholderText = "Quantity";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(128, 23);
            this.txtQuantity.TabIndex = 66;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(33, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 10);
            this.panel4.TabIndex = 67;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProducts.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.ForeColor = System.Drawing.Color.Black;
            this.labelProducts.Location = new System.Drawing.Point(334, 10);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(143, 32);
            this.labelProducts.TabIndex = 65;
            this.labelProducts.Text = "Your Cart";
            this.labelProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Animated = true;
            this.RemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.BorderRadius = 13;
            this.RemoveButton.BorderThickness = 1;
            this.RemoveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveButton.FillColor = System.Drawing.Color.White;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveButton.HoverState.BorderColor = System.Drawing.Color.White;
            this.RemoveButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemoveButton.HoverState.FillColor = System.Drawing.Color.Black;
            this.RemoveButton.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(36, 299);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.PressedColor = System.Drawing.Color.Aqua;
            this.RemoveButton.PressedDepth = 40;
            this.RemoveButton.Size = new System.Drawing.Size(125, 34);
            this.RemoveButton.TabIndex = 72;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.RemoveButton.UseTransparentBackground = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Searchbox
            // 
            this.Searchbox.BorderThickness = 2;
            this.Searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchbox.DefaultText = "";
            this.Searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Searchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.Location = new System.Drawing.Point(551, 64);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.PasswordChar = '\0';
            this.Searchbox.PlaceholderText = "Search";
            this.Searchbox.SelectedText = "";
            this.Searchbox.Size = new System.Drawing.Size(155, 24);
            this.Searchbox.TabIndex = 73;
            this.Searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            // 
            // CartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.GridProducts);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelProducts);
            this.Name = "CartControl";
            this.Size = new System.Drawing.Size(746, 411);
            this.Load += new System.EventHandler(this.CartControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView GridProducts;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelProducts;
        private Guna.UI2.WinForms.Guna2Button RemoveButton;
        private Guna.UI2.WinForms.Guna2TextBox Searchbox;
    }
}
