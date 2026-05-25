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
            Delete = new Button();
            ADD = new Button();
            NameChange = new TextBox();
            PriceChange = new TextBox();
            QuantityChange = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Status = new Label();
            StatusResult = new Label();
            SuspendLayout();
            // 
            // TextName
            // 
            TextName.BackColor = Color.WhiteSmoke;
            TextName.Font = new Font("Segoe UI", 12F);
            TextName.Location = new Point(27, 146);
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
            TextPrice.Location = new Point(27, 195);
            TextPrice.Name = "TextPrice";
            TextPrice.PlaceholderText = "Item Price";
            TextPrice.Size = new Size(204, 29);
            TextPrice.TabIndex = 1;
            // 
            // TextQuantity
            // 
            TextQuantity.BackColor = Color.WhiteSmoke;
            TextQuantity.Font = new Font("Segoe UI", 12F);
            TextQuantity.Location = new Point(27, 241);
            TextQuantity.Name = "TextQuantity";
            TextQuantity.PlaceholderText = "Item Quantity";
            TextQuantity.Size = new Size(204, 29);
            TextQuantity.TabIndex = 2;
            // 
            // Store
            // 
            Store.BackColor = Color.Silver;
            Store.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Store.Location = new Point(27, 299);
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
            View.Location = new Point(139, 299);
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
            ListBox.Location = new Point(309, 142);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(719, 235);
            ListBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(280, 44);
            label1.Name = "label1";
            label1.Size = new Size(511, 37);
            label1.TabIndex = 6;
            label1.Text = "Invetory Storage Management System";
            label1.Click += label1_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Silver;
            Delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Delete.Location = new Point(942, 416);
            Delete.Name = "Delete";
            Delete.Size = new Size(86, 40);
            Delete.TabIndex = 10;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click_1;
            // 
            // ADD
            // 
            ADD.BackColor = Color.Silver;
            ADD.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ADD.Location = new Point(27, 554);
            ADD.Margin = new Padding(2);
            ADD.Name = "ADD";
            ADD.Size = new Size(78, 36);
            ADD.TabIndex = 11;
            ADD.Text = "Update";
            ADD.UseVisualStyleBackColor = false;
            ADD.Click += ADD_Click;
            // 
            // NameChange
            // 
            NameChange.Font = new Font("Segoe UI", 11F);
            NameChange.Location = new Point(27, 416);
            NameChange.Margin = new Padding(2);
            NameChange.Name = "NameChange";
            NameChange.PlaceholderText = "Item Name ";
            NameChange.Size = new Size(194, 27);
            NameChange.TabIndex = 12;
            // 
            // PriceChange
            // 
            PriceChange.Font = new Font("Segoe UI", 11F);
            PriceChange.Location = new Point(27, 458);
            PriceChange.Margin = new Padding(2);
            PriceChange.Name = "PriceChange";
            PriceChange.PlaceholderText = "Price";
            PriceChange.Size = new Size(195, 27);
            PriceChange.TabIndex = 13;
            // 
            // QuantityChange
            // 
            QuantityChange.Font = new Font("Segoe UI", 11F);
            QuantityChange.Location = new Point(27, 507);
            QuantityChange.Margin = new Padding(2);
            QuantityChange.Name = "QuantityChange";
            QuantityChange.PlaceholderText = "Item Quantity";
            QuantityChange.Size = new Size(194, 27);
            QuantityChange.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(36, 384);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 15;
            label2.Text = "Change";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(36, 112);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 16;
            label3.Text = "Inputs";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Status.Location = new Point(309, 416);
            Status.Name = "Status";
            Status.Size = new Size(65, 20);
            Status.TabIndex = 17;
            Status.Text = "Status  :";
            // 
            // StatusResult
            // 
            StatusResult.AutoSize = true;
            StatusResult.Font = new Font("Segoe UI", 10F);
            StatusResult.Location = new Point(380, 418);
            StatusResult.Name = "StatusResult";
            StatusResult.Size = new Size(17, 19);
            StatusResult.TabIndex = 18;
            StatusResult.Text = "0";
            StatusResult.Click += StatusResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1052, 629);
            Controls.Add(StatusResult);
            Controls.Add(Status);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(QuantityChange);
            Controls.Add(PriceChange);
            Controls.Add(NameChange);
            Controls.Add(ADD);
            Controls.Add(Delete);
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
        private Button Delete;
        private Button ADD;
        private TextBox NameChange;
        private TextBox PriceChange;
        private TextBox QuantityChange;
        private Label label2;
        private Label label3;
        private Label Status;
        private Label StatusResult;
    }
}
