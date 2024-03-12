namespace Dolgozo_NyilvantartasForm
{
    partial class Form1
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
            this.button_dolgozok = new System.Windows.Forms.Button();
            this.dataGridView_dolgozok = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dolgozok)).BeginInit();
            this.SuspendLayout();
            // 
            // button_dolgozok
            // 
            this.button_dolgozok.Location = new System.Drawing.Point(12, 12);
            this.button_dolgozok.Name = "button_dolgozok";
            this.button_dolgozok.Size = new System.Drawing.Size(134, 33);
            this.button_dolgozok.TabIndex = 0;
            this.button_dolgozok.Text = "Dolgozók";
            this.button_dolgozok.UseVisualStyleBackColor = true;
            this.button_dolgozok.Click += new System.EventHandler(this.button_dolgozok_Click);
            // 
            // dataGridView_dolgozok
            // 
            this.dataGridView_dolgozok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dolgozok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.id,
            this.salary,
            this.position});
            this.dataGridView_dolgozok.Location = new System.Drawing.Point(12, 61);
            this.dataGridView_dolgozok.Name = "dataGridView_dolgozok";
            this.dataGridView_dolgozok.Size = new System.Drawing.Size(447, 365);
            this.dataGridView_dolgozok.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // salary
            // 
            this.salary.HeaderText = "salary";
            this.salary.Name = "salary";
            // 
            // position
            // 
            this.position.HeaderText = "position";
            this.position.Name = "position";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(488, 61);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(109, 36);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView_dolgozok);
            this.Controls.Add(this.button_dolgozok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dolgozok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_dolgozok;
        private System.Windows.Forms.DataGridView dataGridView_dolgozok;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.Button button_add;
    }
}

