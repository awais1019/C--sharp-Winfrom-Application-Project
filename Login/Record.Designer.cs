
namespace Login
{
    partial class Record
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnbillrecord = new Guna.UI2.WinForms.Guna2Button();
            this.GridProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(257, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(304, 47);
            this.guna2HtmlLabel1.TabIndex = 77;
            this.guna2HtmlLabel1.Text = "Previous History";
     
            // 
            // btnbillrecord
            // 
            this.btnbillrecord.BackColor = System.Drawing.Color.Transparent;
            this.btnbillrecord.BorderRadius = 13;
            this.btnbillrecord.BorderThickness = 1;
            this.btnbillrecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbillrecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbillrecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbillrecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbillrecord.FillColor = System.Drawing.Color.White;
            this.btnbillrecord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbillrecord.ForeColor = System.Drawing.Color.Black;
            this.btnbillrecord.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnbillrecord.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnbillrecord.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnbillrecord.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbillrecord.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnbillrecord.Location = new System.Drawing.Point(363, 355);
            this.btnbillrecord.Name = "btnbillrecord";
            this.btnbillrecord.PressedColor = System.Drawing.Color.White;
            this.btnbillrecord.PressedDepth = 40;
            this.btnbillrecord.Size = new System.Drawing.Size(125, 34);
            this.btnbillrecord.TabIndex = 76;
            this.btnbillrecord.Text = "View Record";
            this.btnbillrecord.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnbillrecord.UseTransparentBackground = true;
            this.btnbillrecord.Click += new System.EventHandler(this.btnbillrecord_Click);
            this.btnbillrecord.Leave += new System.EventHandler(this.btnbillrecord_Leave);
            // 
            // GridProducts
            // 
            this.GridProducts.AllowUserToAddRows = false;
            this.GridProducts.AllowUserToDeleteRows = false;
            this.GridProducts.AllowUserToResizeColumns = false;
            this.GridProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GridProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridProducts.ColumnHeadersHeight = 30;
            this.GridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GridProducts.Location = new System.Drawing.Point(106, 80);
            this.GridProducts.MultiSelect = false;
            this.GridProducts.Name = "GridProducts";
            this.GridProducts.ReadOnly = true;
            this.GridProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.GridProducts.RowHeadersVisible = false;
            this.GridProducts.RowHeadersWidth = 40;
            this.GridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridProducts.ShowEditingIcon = false;
            this.GridProducts.Size = new System.Drawing.Size(548, 258);
            this.GridProducts.TabIndex = 75;
            this.GridProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GridProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GridProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
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
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 1;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(705, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Red;
            this.guna2Button2.PressedDepth = 40;
            this.guna2Button2.Size = new System.Drawing.Size(42, 27);
            this.guna2Button2.TabIndex = 84;
            this.guna2Button2.Text = "X";
            this.guna2Button2.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnbillrecord);
            this.Controls.Add(this.GridProducts);
            this.Name = "Record";
            this.Size = new System.Drawing.Size(747, 402);
            ((System.ComponentModel.ISupportInitialize)(this.GridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnbillrecord;
        private Guna.UI2.WinForms.Guna2DataGridView GridProducts;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
