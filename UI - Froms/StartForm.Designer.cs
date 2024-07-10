namespace UI___Froms
{
    partial class StartForm
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
            this.btnZObjectSearch = new System.Windows.Forms.Button();
            this.lblObject = new System.Windows.Forms.Label();
            this.txtZObject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZObjectSearch
            // 
            this.btnZObjectSearch.BackColor = System.Drawing.Color.LightGreen;
            this.btnZObjectSearch.FlatAppearance.BorderSize = 0;
            this.btnZObjectSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnZObjectSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZObjectSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnZObjectSearch.Location = new System.Drawing.Point(10, 94);
            this.btnZObjectSearch.Name = "btnZObjectSearch";
            this.btnZObjectSearch.Size = new System.Drawing.Size(100, 23);
            this.btnZObjectSearch.TabIndex = 0;
            this.btnZObjectSearch.Text = "Buscar";
            this.btnZObjectSearch.UseVisualStyleBackColor = false;
            this.btnZObjectSearch.Click += new System.EventHandler(this.btnZObjectSearch_Click);
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObject.Location = new System.Drawing.Point(12, 45);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(60, 20);
            this.lblObject.TabIndex = 1;
            this.lblObject.Text = "Objeto Z";
            this.lblObject.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtZObject
            // 
            this.txtZObject.Location = new System.Drawing.Point(10, 68);
            this.txtZObject.Name = "txtZObject";
            this.txtZObject.Size = new System.Drawing.Size(100, 20);
            this.txtZObject.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "ZObject Searcher";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZObject);
            this.Controls.Add(this.lblObject);
            this.Controls.Add(this.btnZObjectSearch);
            this.Name = "StartForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZObjectSearch;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.TextBox txtZObject;
        private System.Windows.Forms.Label label1;
    }
}

