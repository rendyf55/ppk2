namespace order_coffe
{
    partial class CheckOut
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_no = new System.Windows.Forms.TextBox();
            this.text_pembeli = new System.Windows.Forms.TextBox();
            this.text_menu = new System.Windows.Forms.TextBox();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.text_harga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_menu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_checkout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(255, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(377, 329);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Menu";
            this.columnHeader1.Width = 153;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jumlah";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Harga";
            this.columnHeader3.Width = 97;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_total);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(255, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 39);
            this.panel1.TabIndex = 1;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(297, 16);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(13, 13);
            this.label_total.TabIndex = 1;
            this.label_total.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Pembayaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            this.label2.Visible = false;
            // 
            // text_no
            // 
            this.text_no.Location = new System.Drawing.Point(100, 63);
            this.text_no.Name = "text_no";
            this.text_no.ReadOnly = true;
            this.text_no.Size = new System.Drawing.Size(128, 20);
            this.text_no.TabIndex = 3;
            this.text_no.Visible = false;
            // 
            // text_pembeli
            // 
            this.text_pembeli.Location = new System.Drawing.Point(100, 90);
            this.text_pembeli.Name = "text_pembeli";
            this.text_pembeli.Size = new System.Drawing.Size(128, 20);
            this.text_pembeli.TabIndex = 4;
            // 
            // text_menu
            // 
            this.text_menu.Location = new System.Drawing.Point(100, 144);
            this.text_menu.Name = "text_menu";
            this.text_menu.Size = new System.Drawing.Size(128, 20);
            this.text_menu.TabIndex = 6;
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(100, 171);
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(128, 20);
            this.text_jumlah.TabIndex = 7;
            // 
            // text_harga
            // 
            this.text_harga.Location = new System.Drawing.Point(100, 198);
            this.text_harga.Name = "text_harga";
            this.text_harga.ReadOnly = true;
            this.text_harga.Size = new System.Drawing.Size(128, 20);
            this.text_harga.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nama Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nama Menu";
            // 
            // id_menu
            // 
            this.id_menu.AutoSize = true;
            this.id_menu.Location = new System.Drawing.Point(15, 119);
            this.id_menu.Name = "id_menu";
            this.id_menu.Size = new System.Drawing.Size(0, 13);
            this.id_menu.TabIndex = 12;
            this.id_menu.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Jumlah";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Harga";
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(137, 251);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 15;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.Button_refresh_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(33, 251);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 16;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(82, 280);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 17;
            this.button_delete.Text = "Hapus";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // button_checkout
            // 
            this.button_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkout.Location = new System.Drawing.Point(15, 399);
            this.button_checkout.Name = "button_checkout";
            this.button_checkout.Size = new System.Drawing.Size(213, 39);
            this.button_checkout.TabIndex = 18;
            this.button_checkout.Text = "Checkout";
            this.button_checkout.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 43);
            this.label5.TabIndex = 19;
            this.label5.Text = "Checkout Your Order";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_checkout);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id_menu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_harga);
            this.Controls.Add(this.text_jumlah);
            this.Controls.Add(this.text_menu);
            this.Controls.Add(this.text_pembeli);
            this.Controls.Add(this.text_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_no;
        private System.Windows.Forms.TextBox text_pembeli;
        private System.Windows.Forms.TextBox text_menu;
        private System.Windows.Forms.TextBox text_jumlah;
        private System.Windows.Forms.TextBox text_harga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label id_menu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_checkout;
        private System.Windows.Forms.Label label5;
    }
}