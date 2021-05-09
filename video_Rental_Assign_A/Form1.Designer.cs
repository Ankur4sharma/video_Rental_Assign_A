
namespace video_Rental_Assign_A
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
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.pop_customer_button = new System.Windows.Forms.Button();
            this.pop_movie_button = new System.Windows.Forms.Button();
            this.rental_buttn = new System.Windows.Forms.Button();
            this.video_buttn = new System.Windows.Forms.Button();
            this.customer_buttn = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.returnDT = new System.Windows.Forms.DateTimePicker();
            this.issueDT = new System.Windows.Forms.DateTimePicker();
            this.del_movie = new System.Windows.Forms.Button();
            this.return_mov = new System.Windows.Forms.Button();
            this.issue_mov = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.movie_id_box = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.customer_id_box = new System.Windows.Forms.TextBox();
            this.video_del = new System.Windows.Forms.Button();
            this.video_update = new System.Windows.Forms.Button();
            this.adding_video_button = new System.Windows.Forms.Button();
            this.genre = new System.Windows.Forms.TextBox();
            this.plot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.copies = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cutomer_delete_button = new System.Windows.Forms.Button();
            this.update_customer_button = new System.Windows.Forms.Button();
            this.customer_add_button = new System.Windows.Forms.Button();
            this.address_box_customer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.customer_ph_box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.customer_Email_box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.customer_name_box = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.realease_year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.video_rating = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecord
            // 
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Location = new System.Drawing.Point(1, 6);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.Size = new System.Drawing.Size(848, 220);
            this.dgvRecord.TabIndex = 31;
            this.dgvRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellClick);
            // 
            // pop_customer_button
            // 
            this.pop_customer_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pop_customer_button.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pop_customer_button.Location = new System.Drawing.Point(856, 258);
            this.pop_customer_button.Name = "pop_customer_button";
            this.pop_customer_button.Size = new System.Drawing.Size(137, 60);
            this.pop_customer_button.TabIndex = 30;
            this.pop_customer_button.Text = "POP Customer";
            this.pop_customer_button.UseVisualStyleBackColor = false;
            this.pop_customer_button.Click += new System.EventHandler(this.pop_customer_button_Click);
            // 
            // pop_movie_button
            // 
            this.pop_movie_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pop_movie_button.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pop_movie_button.Location = new System.Drawing.Point(855, 203);
            this.pop_movie_button.Name = "pop_movie_button";
            this.pop_movie_button.Size = new System.Drawing.Size(130, 49);
            this.pop_movie_button.TabIndex = 29;
            this.pop_movie_button.Text = "POP Movie";
            this.pop_movie_button.UseVisualStyleBackColor = false;
            this.pop_movie_button.Click += new System.EventHandler(this.pop_movie_button_Click);
            // 
            // rental_buttn
            // 
            this.rental_buttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rental_buttn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_buttn.Location = new System.Drawing.Point(856, 148);
            this.rental_buttn.Name = "rental_buttn";
            this.rental_buttn.Size = new System.Drawing.Size(130, 49);
            this.rental_buttn.TabIndex = 28;
            this.rental_buttn.Text = "Rental";
            this.rental_buttn.UseVisualStyleBackColor = false;
            this.rental_buttn.Click += new System.EventHandler(this.rental_buttn_Click);
            // 
            // video_buttn
            // 
            this.video_buttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.video_buttn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_buttn.Location = new System.Drawing.Point(855, 93);
            this.video_buttn.Name = "video_buttn";
            this.video_buttn.Size = new System.Drawing.Size(130, 49);
            this.video_buttn.TabIndex = 27;
            this.video_buttn.Text = "Video\'s";
            this.video_buttn.UseVisualStyleBackColor = false;
            this.video_buttn.Click += new System.EventHandler(this.video_buttn_Click);
            // 
            // customer_buttn
            // 
            this.customer_buttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.customer_buttn.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_buttn.Location = new System.Drawing.Point(856, 38);
            this.customer_buttn.Name = "customer_buttn";
            this.customer_buttn.Size = new System.Drawing.Size(130, 49);
            this.customer_buttn.TabIndex = 26;
            this.customer_buttn.Text = "Customer";
            this.customer_buttn.UseVisualStyleBackColor = false;
            this.customer_buttn.Click += new System.EventHandler(this.customer_buttn_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 22);
            this.label21.TabIndex = 0;
            this.label21.Text = "Customer ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.returnDT);
            this.groupBox3.Controls.Add(this.issueDT);
            this.groupBox3.Controls.Add(this.del_movie);
            this.groupBox3.Controls.Add(this.return_mov);
            this.groupBox3.Controls.Add(this.issue_mov);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.movie_id_box);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.customer_id_box);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(600, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 429);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rental\'s";
            // 
            // returnDT
            // 
            this.returnDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.returnDT.Location = new System.Drawing.Point(23, 251);
            this.returnDT.Name = "returnDT";
            this.returnDT.Size = new System.Drawing.Size(181, 20);
            this.returnDT.TabIndex = 17;
            // 
            // issueDT
            // 
            this.issueDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.issueDT.Location = new System.Drawing.Point(23, 175);
            this.issueDT.Name = "issueDT";
            this.issueDT.Size = new System.Drawing.Size(181, 20);
            this.issueDT.TabIndex = 16;
            // 
            // del_movie
            // 
            this.del_movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.del_movie.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_movie.Location = new System.Drawing.Point(69, 342);
            this.del_movie.Name = "del_movie";
            this.del_movie.Size = new System.Drawing.Size(100, 34);
            this.del_movie.TabIndex = 15;
            this.del_movie.Text = "Delete";
            this.del_movie.UseVisualStyleBackColor = false;
            this.del_movie.Click += new System.EventHandler(this.del_movie_Click);
            // 
            // return_mov
            // 
            this.return_mov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.return_mov.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_mov.Location = new System.Drawing.Point(140, 292);
            this.return_mov.Name = "return_mov";
            this.return_mov.Size = new System.Drawing.Size(94, 34);
            this.return_mov.TabIndex = 14;
            this.return_mov.Text = "Return";
            this.return_mov.UseVisualStyleBackColor = false;
            this.return_mov.Click += new System.EventHandler(this.return_mov_Click);
            // 
            // issue_mov
            // 
            this.issue_mov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.issue_mov.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_mov.Location = new System.Drawing.Point(6, 292);
            this.issue_mov.Name = "issue_mov";
            this.issue_mov.Size = new System.Drawing.Size(100, 34);
            this.issue_mov.TabIndex = 8;
            this.issue_mov.Text = "Issue";
            this.issue_mov.UseVisualStyleBackColor = false;
            this.issue_mov.Click += new System.EventHandler(this.issue_mov_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(51, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 22);
            this.label18.TabIndex = 6;
            this.label18.Text = "Return Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(65, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 22);
            this.label19.TabIndex = 4;
            this.label19.Text = "Issue Date";
            // 
            // movie_id_box
            // 
            this.movie_id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_id_box.Location = new System.Drawing.Point(140, 91);
            this.movie_id_box.Name = "movie_id_box";
            this.movie_id_box.Size = new System.Drawing.Size(78, 29);
            this.movie_id_box.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 22);
            this.label20.TabIndex = 2;
            this.label20.Text = "Movie ID";
            // 
            // customer_id_box
            // 
            this.customer_id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id_box.Location = new System.Drawing.Point(140, 39);
            this.customer_id_box.Name = "customer_id_box";
            this.customer_id_box.Size = new System.Drawing.Size(78, 29);
            this.customer_id_box.TabIndex = 1;
            // 
            // video_del
            // 
            this.video_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.video_del.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_del.Location = new System.Drawing.Point(73, 395);
            this.video_del.Name = "video_del";
            this.video_del.Size = new System.Drawing.Size(100, 34);
            this.video_del.TabIndex = 15;
            this.video_del.Text = "Delete";
            this.video_del.UseVisualStyleBackColor = false;
            this.video_del.Click += new System.EventHandler(this.video_del_Click);
            // 
            // video_update
            // 
            this.video_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.video_update.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_update.Location = new System.Drawing.Point(147, 355);
            this.video_update.Name = "video_update";
            this.video_update.Size = new System.Drawing.Size(100, 34);
            this.video_update.TabIndex = 14;
            this.video_update.Text = "Update";
            this.video_update.UseVisualStyleBackColor = false;
            this.video_update.Click += new System.EventHandler(this.video_update_Click);
            // 
            // adding_video_button
            // 
            this.adding_video_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.adding_video_button.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adding_video_button.Location = new System.Drawing.Point(0, 355);
            this.adding_video_button.Name = "adding_video_button";
            this.adding_video_button.Size = new System.Drawing.Size(100, 34);
            this.adding_video_button.TabIndex = 8;
            this.adding_video_button.Text = "Add";
            this.adding_video_button.UseVisualStyleBackColor = false;
            this.adding_video_button.Click += new System.EventHandler(this.adding_video_button_Click);
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.Location = new System.Drawing.Point(138, 318);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(127, 29);
            this.genre.TabIndex = 13;
            // 
            // plot
            // 
            this.plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot.Location = new System.Drawing.Point(138, 279);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(127, 29);
            this.plot.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Plot";
            // 
            // copies
            // 
            this.copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copies.Location = new System.Drawing.Point(138, 233);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(127, 29);
            this.copies.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Copies";
            // 
            // cost
            // 
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.Location = new System.Drawing.Point(138, 188);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(127, 29);
            this.cost.TabIndex = 7;
            this.cost.TextChanged += new System.EventHandler(this.cost_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.cutomer_delete_button);
            this.groupBox2.Controls.Add(this.update_customer_button);
            this.groupBox2.Controls.Add(this.customer_add_button);
            this.groupBox2.Controls.Add(this.address_box_customer);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.customer_ph_box);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.customer_Email_box);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.customer_name_box);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(313, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 429);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer\'s";
            // 
            // cutomer_delete_button
            // 
            this.cutomer_delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cutomer_delete_button.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutomer_delete_button.Location = new System.Drawing.Point(75, 292);
            this.cutomer_delete_button.Name = "cutomer_delete_button";
            this.cutomer_delete_button.Size = new System.Drawing.Size(100, 34);
            this.cutomer_delete_button.TabIndex = 15;
            this.cutomer_delete_button.Text = "Delete";
            this.cutomer_delete_button.UseVisualStyleBackColor = false;
            this.cutomer_delete_button.Click += new System.EventHandler(this.cutomer_delete_button_Click);
            // 
            // update_customer_button
            // 
            this.update_customer_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.update_customer_button.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_customer_button.Location = new System.Drawing.Point(140, 251);
            this.update_customer_button.Name = "update_customer_button";
            this.update_customer_button.Size = new System.Drawing.Size(100, 34);
            this.update_customer_button.TabIndex = 14;
            this.update_customer_button.Text = "Update";
            this.update_customer_button.UseVisualStyleBackColor = false;
            this.update_customer_button.Click += new System.EventHandler(this.update_customer_button_Click);
            // 
            // customer_add_button
            // 
            this.customer_add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.customer_add_button.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_add_button.Location = new System.Drawing.Point(6, 251);
            this.customer_add_button.Name = "customer_add_button";
            this.customer_add_button.Size = new System.Drawing.Size(100, 34);
            this.customer_add_button.TabIndex = 8;
            this.customer_add_button.Text = "Add";
            this.customer_add_button.UseVisualStyleBackColor = false;
            this.customer_add_button.Click += new System.EventHandler(this.customer_add_button_Click);
            // 
            // address_box_customer
            // 
            this.address_box_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_box_customer.Location = new System.Drawing.Point(140, 201);
            this.address_box_customer.Name = "address_box_customer";
            this.address_box_customer.Size = new System.Drawing.Size(127, 29);
            this.address_box_customer.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "Address";
            // 
            // customer_ph_box
            // 
            this.customer_ph_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_ph_box.Location = new System.Drawing.Point(140, 147);
            this.customer_ph_box.Name = "customer_ph_box";
            this.customer_ph_box.Size = new System.Drawing.Size(127, 29);
            this.customer_ph_box.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 22);
            this.label12.TabIndex = 4;
            this.label12.Text = "Phone";
            // 
            // customer_Email_box
            // 
            this.customer_Email_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_Email_box.Location = new System.Drawing.Point(140, 91);
            this.customer_Email_box.Name = "customer_Email_box";
            this.customer_Email_box.Size = new System.Drawing.Size(127, 29);
            this.customer_Email_box.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "Email";
            // 
            // customer_name_box
            // 
            this.customer_name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name_box.Location = new System.Drawing.Point(140, 39);
            this.customer_name_box.Name = "customer_name_box";
            this.customer_name_box.Size = new System.Drawing.Size(127, 29);
            this.customer_name_box.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.video_del);
            this.groupBox1.Controls.Add(this.video_update);
            this.groupBox1.Controls.Add(this.adding_video_button);
            this.groupBox1.Controls.Add(this.genre);
            this.groupBox1.Controls.Add(this.plot);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.copies);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.realease_year);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.video_rating);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 434);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Video\'s";
            // 
            // realease_year
            // 
            this.realease_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realease_year.Location = new System.Drawing.Point(138, 134);
            this.realease_year.Name = "realease_year";
            this.realease_year.Size = new System.Drawing.Size(127, 29);
            this.realease_year.TabIndex = 5;
            this.realease_year.TextChanged += new System.EventHandler(this.realease_year_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year Realease";
            // 
            // video_rating
            // 
            this.video_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_rating.Location = new System.Drawing.Point(138, 78);
            this.video_rating.Name = "video_rating";
            this.video_rating.Size = new System.Drawing.Size(127, 29);
            this.video_rating.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(138, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(127, 29);
            this.title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(995, 672);
            this.Controls.Add(this.dgvRecord);
            this.Controls.Add(this.pop_customer_button);
            this.Controls.Add(this.pop_movie_button);
            this.Controls.Add(this.rental_buttn);
            this.Controls.Add(this.video_buttn);
            this.Controls.Add(this.customer_buttn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "7\\[8po ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Button pop_customer_button;
        private System.Windows.Forms.Button pop_movie_button;
        private System.Windows.Forms.Button rental_buttn;
        private System.Windows.Forms.Button video_buttn;
        private System.Windows.Forms.Button customer_buttn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker returnDT;
        private System.Windows.Forms.DateTimePicker issueDT;
        private System.Windows.Forms.Button del_movie;
        private System.Windows.Forms.Button return_mov;
        private System.Windows.Forms.Button issue_mov;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox movie_id_box;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox customer_id_box;
        private System.Windows.Forms.Button video_del;
        private System.Windows.Forms.Button video_update;
        private System.Windows.Forms.Button adding_video_button;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.TextBox plot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cutomer_delete_button;
        private System.Windows.Forms.Button update_customer_button;
        private System.Windows.Forms.Button customer_add_button;
        private System.Windows.Forms.TextBox address_box_customer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox customer_ph_box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox customer_Email_box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox customer_name_box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox realease_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox video_rating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
    }
}

