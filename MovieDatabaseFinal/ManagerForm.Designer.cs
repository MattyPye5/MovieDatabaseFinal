namespace MovieDatabaseFinal
{
    partial class managerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerForm));
            this.moviesButton = new System.Windows.Forms.Button();
            this.screenRoomButton = new System.Windows.Forms.Button();
            this.ticketsButton = new System.Windows.Forms.Button();
            this.showtimeButton = new System.Windows.Forms.Button();
            this.clientButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moviesButton
            // 
            this.moviesButton.Location = new System.Drawing.Point(59, 42);
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Size = new System.Drawing.Size(182, 53);
            this.moviesButton.TabIndex = 0;
            this.moviesButton.Text = "Movies";
            this.moviesButton.UseVisualStyleBackColor = true;
            // 
            // screenRoomButton
            // 
            this.screenRoomButton.Location = new System.Drawing.Point(392, 42);
            this.screenRoomButton.Name = "screenRoomButton";
            this.screenRoomButton.Size = new System.Drawing.Size(182, 53);
            this.screenRoomButton.TabIndex = 1;
            this.screenRoomButton.Text = "Screen Room";
            this.screenRoomButton.UseVisualStyleBackColor = true;
            this.screenRoomButton.Click += new System.EventHandler(this.screenRoomButton_Click);
            // 
            // ticketsButton
            // 
            this.ticketsButton.Location = new System.Drawing.Point(392, 145);
            this.ticketsButton.Name = "ticketsButton";
            this.ticketsButton.Size = new System.Drawing.Size(182, 53);
            this.ticketsButton.TabIndex = 2;
            this.ticketsButton.Text = "Tickets";
            this.ticketsButton.UseVisualStyleBackColor = true;
            // 
            // showtimeButton
            // 
            this.showtimeButton.Location = new System.Drawing.Point(59, 145);
            this.showtimeButton.Name = "showtimeButton";
            this.showtimeButton.Size = new System.Drawing.Size(182, 53);
            this.showtimeButton.TabIndex = 3;
            this.showtimeButton.Text = "Showtime ";
            this.showtimeButton.UseVisualStyleBackColor = true;
            // 
            // clientButton
            // 
            this.clientButton.Location = new System.Drawing.Point(233, 257);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(182, 53);
            this.clientButton.TabIndex = 4;
            this.clientButton.Text = "Clients";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(233, 385);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 53);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.showtimeButton);
            this.Controls.Add(this.ticketsButton);
            this.Controls.Add(this.screenRoomButton);
            this.Controls.Add(this.moviesButton);
            this.Name = "managerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moviesButton;
        private System.Windows.Forms.Button screenRoomButton;
        private System.Windows.Forms.Button ticketsButton;
        private System.Windows.Forms.Button showtimeButton;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Button exitButton;
    }
}