namespace WinFormsApp37
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
            TextName = new TextBox();
            TextPrice = new TextBox();
            TextQuantity = new TextBox();
            Store = new Button();
            View = new Button();
            ListBox = new ListBox();
            label1 = new Label();
            Search = new TextBox();
            Delete = new Button();
            ADD = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // TextName
            // 
            TextName.BackColor = Color.WhiteSmoke;
            TextName.Font = new Font("Segoe UI", 12F);
            TextName.Location = new Point(39, 244);
            TextName.Margin = new Padding(4, 5, 4, 5);
            TextName.Name = "TextName";
            TextName.PlaceholderText = "Item Name";
            TextName.Size = new Size(290, 39);
            TextName.TabIndex = 0;
            TextName.TextChanged += TextName_TextChanged;
            // 
            // TextPrice
            // 
            TextPrice.BackColor = Color.WhiteSmoke;
            TextPrice.Font = new Font("Segoe UI", 12F);
            TextPrice.Location = new Point(39, 325);
            TextPrice.Margin = new Padding(4, 5, 4, 5);
            TextPrice.Name = "TextPrice";
            TextPrice.PlaceholderText = "Item Price";
            TextPrice.Size = new Size(290, 39);
            TextPrice.TabIndex = 1;
            // 
            // TextQuantity
            // 
            TextQuantity.BackColor = Color.WhiteSmoke;
            TextQuantity.Font = new Font("Segoe UI", 12F);
            TextQuantity.Location = new Point(39, 401);
            TextQuantity.Margin = new Padding(4, 5, 4, 5);
            TextQuantity.Name = "TextQuantity";
            TextQuantity.PlaceholderText = "Item Quantity";
            TextQuantity.Size = new Size(290, 39);
            TextQuantity.TabIndex = 2;
            // 
            // Store
            // 
            Store.BackColor = Color.Silver;
            Store.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Store.Location = new Point(39, 498);
            Store.Margin = new Padding(4, 5, 4, 5);
            Store.Name = "Store";
            Store.Size = new Size(124, 67);
            Store.TabIndex = 3;
            Store.Text = "Store";
            Store.UseVisualStyleBackColor = false;
            Store.Click += Store_Click;
            // 
            // View
            // 
            View.BackColor = Color.Silver;
            View.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            View.Location = new Point(199, 498);
            View.Margin = new Padding(4, 5, 4, 5);
            View.Name = "View";
            View.Size = new Size(130, 67);
            View.TabIndex = 4;
            View.Text = "View";
            View.UseVisualStyleBackColor = false;
            View.Click += View_Click;
            // 
            // ListBox
            // 
            ListBox.BackColor = Color.WhiteSmoke;
            ListBox.Font = new Font("Segoe UI", 12F);
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 32;
            ListBox.Location = new Point(442, 236);
            ListBox.Margin = new Padding(4, 5, 4, 5);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(1026, 420);
            ListBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(400, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(751, 54);
            label1.TabIndex = 6;
            label1.Text = "Invetory Storage Management System";
            label1.Click += label1_Click;
            // 
            // Search
            // 
            Search.Font = new Font("Segoe UI", 13F);
            Search.Location = new Point(697, 694);
            Search.Margin = new Padding(4, 5, 4, 5);
            Search.Name = "Search";
            Search.PlaceholderText = "Search";
            Search.Size = new Size(338, 42);
            Search.TabIndex = 9;
            Search.TextChanged += Search_TextChanged;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Silver;
            Delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Delete.Location = new Point(1345, 694);
            Delete.Margin = new Padding(4, 5, 4, 5);
            Delete.Name = "Delete";
            Delete.Size = new Size(123, 67);
            Delete.TabIndex = 10;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click_1;
            // 
            // ADD
            // 
            ADD.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ADD.Location = new Point(51, 893);
            ADD.Name = "ADD";
            ADD.Size = new Size(112, 60);
            ADD.TabIndex = 11;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += ADD_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 697);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Item Name ";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(51, 764);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Price";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(51, 815);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Item Quantity";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 640);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 15;
            label2.Text = "Change";
            // 
            // button1
            // 
            button1.Location = new Point(1152, 694);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1503, 1023);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ADD);
            Controls.Add(Delete);
            Controls.Add(Search);
            Controls.Add(label1);
            Controls.Add(ListBox);
            Controls.Add(View);
            Controls.Add(Store);
            Controls.Add(TextQuantity);
            Controls.Add(TextPrice);
            Controls.Add(TextName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Inventory Management System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextName;
        private TextBox TextPrice;
        private TextBox TextQuantity;
        private Button Store;
        private Button View;
        private ListBox ListBox;
        private Label label1;
        private TextBox Search;
        private Button Delete;
        private Button ADD;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Button button1;
    }
}
