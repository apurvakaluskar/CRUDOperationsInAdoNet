
using System.Windows.Forms;

namespace CRUDOperationsInMoviesDatabase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(58, 42);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(59, 25);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 31);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvMovies
            // 
            this.dgvMovies.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn1,
            this.ReleaseYear,
            this.Genre,
            this.Rating});
            this.dgvMovies.Location = new System.Drawing.Point(506, 42);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.RowHeadersWidth = 62;
            this.dgvMovies.RowTemplate.Height = 33;
            this.dgvMovies.Size = new System.Drawing.Size(621, 486);
            this.dgvMovies.TabIndex = 2;
            this.dgvMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick);
            this.dgvMovies.DoubleClick += new System.EventHandler(this.dgvMovies_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // ReleaseYear
            // 
            this.ReleaseYear.DataPropertyName = "ReleaseYear";
            this.ReleaseYear.HeaderText = "Release Year";
            this.ReleaseYear.MinimumWidth = 8;
            this.ReleaseYear.Name = "ReleaseYear";
            this.ReleaseYear.Width = 150;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 8;
            this.Genre.Name = "Genre";
            this.Genre.Width = 150;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 8;
            this.Rating.Name = "Rating";
            this.Rating.Width = 150;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(58, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Location = new System.Drawing.Point(57, 88);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(107, 25);
            this.lblReleaseYear.TabIndex = 0;
            this.lblReleaseYear.Text = "Release Year";
            this.lblReleaseYear.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(209, 88);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(150, 31);
            this.txtReleaseYear.TabIndex = 1;
            this.txtReleaseYear.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(58, 136);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(58, 25);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Genre";
            this.lblGenre.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(58, 185);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(63, 25);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "Rating";
            this.lblRating.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(209, 130);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(150, 31);
            this.txtGenre.TabIndex = 1;
            this.txtGenre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(209, 182);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(150, 31);
            this.txtRating.TabIndex = 1;
            this.txtRating.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(197, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(340, 250);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(112, 34);
            this.btnDelete1.TabIndex = 7;
            this.btnDelete1.Text = "Delete";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 871);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblReleaseYear);
            this.Controls.Add(this.Name);
            // this.Name = "Form1";
            this.Text = "CRUD operations on Movies Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvMovies;
        private Button btnUpdate;
        private Button btnDelete1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ReleaseYear;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Rating;
    }
}

