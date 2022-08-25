
namespace Knjiznica
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
            this.components = new System.ComponentModel.Container();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languagecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numpagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textreviewscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaDataSet = new Knjiznica.KnjiznicaDataSet();
            this.booksTableAdapter = new Knjiznica.KnjiznicaDataSetTableAdapters.booksTableAdapter();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_posudeno = new System.Windows.Forms.Button();
            this.btn_vraceno = new System.Windows.Forms.Button();
            this.btn_posudi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_trazi = new System.Windows.Forms.TextBox();
            this.btn_trazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Uname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exit.Location = new System.Drawing.Point(1347, 771);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(120, 27);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.bookID,
            this.authorsDataGridViewTextBoxColumn,
            this.averageratingDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.isbn13DataGridViewTextBoxColumn,
            this.languagecodeDataGridViewTextBoxColumn,
            this.numpagesDataGridViewTextBoxColumn,
            this.ratingscountDataGridViewTextBoxColumn,
            this.textreviewscountDataGridViewTextBoxColumn,
            this.publicationdateDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(309, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 519);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 400;
            // 
            // bookID
            // 
            this.bookID.DataPropertyName = "bookID";
            this.bookID.HeaderText = "bookID";
            this.bookID.Name = "bookID";
            this.bookID.ReadOnly = true;
            this.bookID.Visible = false;
            this.bookID.Width = 200;
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            this.authorsDataGridViewTextBoxColumn.DataPropertyName = "authors";
            this.authorsDataGridViewTextBoxColumn.HeaderText = "authors";
            this.authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            this.authorsDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorsDataGridViewTextBoxColumn.Width = 200;
            // 
            // averageratingDataGridViewTextBoxColumn
            // 
            this.averageratingDataGridViewTextBoxColumn.DataPropertyName = "average_rating";
            this.averageratingDataGridViewTextBoxColumn.HeaderText = "average rating";
            this.averageratingDataGridViewTextBoxColumn.Name = "averageratingDataGridViewTextBoxColumn";
            this.averageratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbn13DataGridViewTextBoxColumn
            // 
            this.isbn13DataGridViewTextBoxColumn.DataPropertyName = "isbn13";
            this.isbn13DataGridViewTextBoxColumn.HeaderText = "isbn13";
            this.isbn13DataGridViewTextBoxColumn.Name = "isbn13DataGridViewTextBoxColumn";
            this.isbn13DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languagecodeDataGridViewTextBoxColumn
            // 
            this.languagecodeDataGridViewTextBoxColumn.DataPropertyName = "language_code";
            this.languagecodeDataGridViewTextBoxColumn.HeaderText = "language code";
            this.languagecodeDataGridViewTextBoxColumn.Name = "languagecodeDataGridViewTextBoxColumn";
            this.languagecodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numpagesDataGridViewTextBoxColumn
            // 
            this.numpagesDataGridViewTextBoxColumn.DataPropertyName = "  num_pages";
            this.numpagesDataGridViewTextBoxColumn.HeaderText = "number of pages";
            this.numpagesDataGridViewTextBoxColumn.Name = "numpagesDataGridViewTextBoxColumn";
            this.numpagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingscountDataGridViewTextBoxColumn
            // 
            this.ratingscountDataGridViewTextBoxColumn.DataPropertyName = "ratings_count";
            this.ratingscountDataGridViewTextBoxColumn.HeaderText = "ratings count";
            this.ratingscountDataGridViewTextBoxColumn.Name = "ratingscountDataGridViewTextBoxColumn";
            this.ratingscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textreviewscountDataGridViewTextBoxColumn
            // 
            this.textreviewscountDataGridViewTextBoxColumn.DataPropertyName = "text_reviews_count";
            this.textreviewscountDataGridViewTextBoxColumn.HeaderText = "text reviews count";
            this.textreviewscountDataGridViewTextBoxColumn.Name = "textreviewscountDataGridViewTextBoxColumn";
            this.textreviewscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publicationdateDataGridViewTextBoxColumn
            // 
            this.publicationdateDataGridViewTextBoxColumn.DataPropertyName = "publication_date";
            this.publicationdateDataGridViewTextBoxColumn.HeaderText = "publication date";
            this.publicationdateDataGridViewTextBoxColumn.Name = "publicationdateDataGridViewTextBoxColumn";
            this.publicationdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.knjiznicaDataSet;
            // 
            // knjiznicaDataSet
            // 
            this.knjiznicaDataSet.DataSetName = "KnjiznicaDataSet";
            this.knjiznicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_logout.Location = new System.Drawing.Point(1207, 771);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(120, 27);
            this.btn_logout.TabIndex = 17;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // btn_posudeno
            // 
            this.btn_posudeno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_posudeno.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_posudeno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_posudeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_posudeno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_posudeno.Location = new System.Drawing.Point(82, 605);
            this.btn_posudeno.Name = "btn_posudeno";
            this.btn_posudeno.Size = new System.Drawing.Size(120, 27);
            this.btn_posudeno.TabIndex = 18;
            this.btn_posudeno.Text = "Posuđeno";
            this.btn_posudeno.UseVisualStyleBackColor = false;
            this.btn_posudeno.Click += new System.EventHandler(this.btn_posudeno_Click);
            // 
            // btn_vraceno
            // 
            this.btn_vraceno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_vraceno.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_vraceno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vraceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_vraceno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_vraceno.Location = new System.Drawing.Point(82, 638);
            this.btn_vraceno.Name = "btn_vraceno";
            this.btn_vraceno.Size = new System.Drawing.Size(120, 27);
            this.btn_vraceno.TabIndex = 19;
            this.btn_vraceno.Text = "Vraćeno";
            this.btn_vraceno.UseVisualStyleBackColor = false;
            this.btn_vraceno.Click += new System.EventHandler(this.btn_vraceno_Click);
            // 
            // btn_posudi
            // 
            this.btn_posudi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_posudi.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_posudi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_posudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_posudi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_posudi.Location = new System.Drawing.Point(82, 146);
            this.btn_posudi.Name = "btn_posudi";
            this.btn_posudi.Size = new System.Drawing.Size(120, 27);
            this.btn_posudi.TabIndex = 20;
            this.btn_posudi.Text = "Posudi";
            this.btn_posudi.UseVisualStyleBackColor = false;
            this.btn_posudi.Click += new System.EventHandler(this.btn_posudi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(305, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Traži prema isbn :";
            // 
            // tb_trazi
            // 
            this.tb_trazi.Location = new System.Drawing.Point(516, 90);
            this.tb_trazi.Name = "tb_trazi";
            this.tb_trazi.Size = new System.Drawing.Size(223, 20);
            this.tb_trazi.TabIndex = 22;
            // 
            // btn_trazi
            // 
            this.btn_trazi.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_trazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_trazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_trazi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_trazi.Location = new System.Drawing.Point(745, 87);
            this.btn_trazi.Name = "btn_trazi";
            this.btn_trazi.Size = new System.Drawing.Size(120, 27);
            this.btn_trazi.TabIndex = 23;
            this.btn_trazi.Text = "Traži";
            this.btn_trazi.UseVisualStyleBackColor = false;
            this.btn_trazi.Click += new System.EventHandler(this.btn_trazi_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // lb_Uname
            // 
            this.lb_Uname.AutoSize = true;
            this.lb_Uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Uname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Uname.Location = new System.Drawing.Point(13, 13);
            this.lb_Uname.Name = "lb_Uname";
            this.lb_Uname.Size = new System.Drawing.Size(52, 17);
            this.lb_Uname.TabIndex = 24;
            this.lb_Uname.Text = "label3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1479, 810);
            this.ControlBox = false;
            this.Controls.Add(this.lb_Uname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_trazi);
            this.Controls.Add(this.tb_trazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_posudi);
            this.Controls.Add(this.btn_vraceno);
            this.Controls.Add(this.btn_posudeno);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KnjiznicaDataSet knjiznicaDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private KnjiznicaDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_posudeno;
        private System.Windows.Forms.Button btn_vraceno;
        private System.Windows.Forms.Button btn_posudi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_trazi;
        private System.Windows.Forms.Button btn_trazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Uname;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languagecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numpagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textreviewscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
    }
}