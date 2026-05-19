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
            button1 = new Button();
            SuspendLayout();
            // 
            // TextName
            // 
            TextName.BackColor = Color.WhiteSmoke;
            TextName.Font = new Font("Segoe UI", 12F);
            TextName.Location = new Point(27, 177);
            TextName.Name = "TextName";
            TextName.PlaceholderText = "Item Name";
            TextName.Size = new Size(204, 29);
            TextName.TabIndex = 0;
            TextName.TextChanged += TextName_TextChanged;
            // 
            // TextPrice
            // 
            TextPrice.BackColor = Color.WhiteSmoke;
            TextPrice.Font = new Font("Segoe UI", 12F);
            TextPrice.Location = new Point(27, 226);
            TextPrice.Name = "TextPrice";
            TextPrice.PlaceholderText = "Item Price";
            TextPrice.Size = new Size(204, 29);
            TextPrice.TabIndex = 1;
            // 
            // TextQuantity
            // 
            TextQuantity.BackColor = Color.WhiteSmoke;
            TextQuantity.Font = new Font("Segoe UI", 12F);
            TextQuantity.Location = new Point(27, 280);
            TextQuantity.Name = "TextQuantity";
            TextQuantity.PlaceholderText = "Item Quantity";
            TextQuantity.Size = new Size(204, 29);
            TextQuantity.TabIndex = 2;
            // 
            // Store
            // 
            Store.BackColor = Color.Silver;
            Store.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Store.Location = new Point(27, 339);
            Store.Name = "Store";
            Store.Size = new Size(87, 40);
            Store.TabIndex = 3;
            Store.Text = "Store";
            Store.UseVisualStyleBackColor = false;
            Store.Click += Store_Click;
            // 
            // View
            // 
            View.BackColor = Color.Silver;
            View.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            View.Location = new Point(692, 183);
            View.Name = "View";
            View.Size = new Size(91, 40);
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
            ListBox.ItemHeight = 21;
            ListBox.Location = new Point(289, 245);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(625, 256);
            ListBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(289, 74);
            label1.Name = "label1";
            label1.Size = new Size(511, 37);
            label1.TabIndex = 6;
            label1.Text = "Invetory Storage Management System";
            // 
            // Search
            // 
            Search.Font = new Font("Segoe UI", 13F);
            Search.Location = new Point(289, 189);
            Search.Name = "Search";
            Search.PlaceholderText = "Search";
            Search.Size = new Size(238, 31);
            Search.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(828, 183);
            button1.Name = "button1";
            button1.Size = new Size(86, 40);
            button1.TabIndex = 10;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(948, 538);
            Controls.Add(button1);
            Controls.Add(Search);
            Controls.Add(label1);
            Controls.Add(ListBox);
            Controls.Add(View);
            Controls.Add(Store);
            Controls.Add(TextQuantity);
            Controls.Add(TextPrice);
            Controls.Add(TextName);
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
        private Button button1;
    }
}
