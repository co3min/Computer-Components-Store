
namespace Pavel_Cosmin_Proiect_Paw_1056_D
{
    partial class ViewAllForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllForm));
            this.dataViewGrid = new System.Windows.Forms.DataGridView();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewGrid
            // 
            this.dataViewGrid.AllowUserToAddRows = false;
            this.dataViewGrid.AllowUserToDeleteRows = false;
            this.dataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewGrid.Location = new System.Drawing.Point(12, 12);
            this.dataViewGrid.Name = "dataViewGrid";
            this.dataViewGrid.ReadOnly = true;
            this.dataViewGrid.RowHeadersWidth = 51;
            this.dataViewGrid.RowTemplate.Height = 24;
            this.dataViewGrid.Size = new System.Drawing.Size(912, 405);
            this.dataViewGrid.TabIndex = 0;
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(760, 441);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(100, 32);
            this.exitbtn.TabIndex = 1;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // ViewAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(952, 496);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.dataViewGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataViewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewGrid;
        private System.Windows.Forms.Button exitbtn;
    }
}