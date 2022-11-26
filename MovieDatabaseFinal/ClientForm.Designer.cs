namespace MovieDatabaseFinal
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.moviesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.movieTheatreDataSet = new MovieDatabaseFinal.MovieTheatreDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new MovieDatabaseFinal.MovieTheatreDataSetTableAdapters.MoviesTableAdapter();
            this.tableAdapterManager = new MovieDatabaseFinal.MovieTheatreDataSetTableAdapters.TableAdapterManager();
            this.screenRoomTableAdapter = new MovieDatabaseFinal.MovieTheatreDataSetTableAdapters.ScreenRoomTableAdapter();
            this.screenRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.movieNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenreColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTheatreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesBindingSource1
            // 
            this.moviesBindingSource1.DataMember = "Movies";
            this.moviesBindingSource1.DataSource = this.movieTheatreDataSet;
            // 
            // movieTheatreDataSet
            // 
            this.movieTheatreDataSet.DataSetName = "MovieTheatreDataSet";
            this.movieTheatreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.movieTheatreDataSet;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MoviesTableAdapter = this.moviesTableAdapter;
            this.tableAdapterManager.MovieTicketUserTableAdapter = null;
            this.tableAdapterManager.ScreenRoomTableAdapter = this.screenRoomTableAdapter;
            this.tableAdapterManager.ShowTimeTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MovieDatabaseFinal.MovieTheatreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDataTableAdapter = null;
            // 
            // screenRoomTableAdapter
            // 
            this.screenRoomTableAdapter.ClearBeforeFill = true;
            // 
            // screenRoomBindingSource
            // 
            this.screenRoomBindingSource.DataMember = "FK__ScreenRoo__Movie__04E4BC85";
            this.screenRoomBindingSource.DataSource = this.moviesBindingSource;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.movieNameColumnHeader,
            this.GenreColumnHeader,
            this.actorColumnHeader,
            this.yearColumnHeader});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(69, 94);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(628, 237);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // movieNameColumnHeader
            // 
            this.movieNameColumnHeader.Text = "MovieName";
            this.movieNameColumnHeader.Width = 155;
            // 
            // GenreColumnHeader
            // 
            this.GenreColumnHeader.Text = "Genre";
            this.GenreColumnHeader.Width = 134;
            // 
            // actorColumnHeader
            // 
            this.actorColumnHeader.Text = "Actors";
            this.actorColumnHeader.Width = 119;
            // 
            // yearColumnHeader
            // 
            this.yearColumnHeader.Text = "Year";
            this.yearColumnHeader.Width = 163;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 619);
            this.Controls.Add(this.listView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTheatreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenRoomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MovieTheatreDataSet movieTheatreDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private MovieTheatreDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.BindingSource moviesBindingSource1;
        private MovieTheatreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MovieTheatreDataSetTableAdapters.ScreenRoomTableAdapter screenRoomTableAdapter;
        private System.Windows.Forms.BindingSource screenRoomBindingSource;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader movieNameColumnHeader;
        private System.Windows.Forms.ColumnHeader GenreColumnHeader;
        private System.Windows.Forms.ColumnHeader actorColumnHeader;
        private System.Windows.Forms.ColumnHeader yearColumnHeader;
    }
}