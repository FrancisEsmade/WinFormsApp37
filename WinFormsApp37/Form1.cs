            using System.IO;
            using System.Runtime.InteropServices;
            using System.Security.Cryptography.X509Certificates;
            using System.Text.Json;
            namespace WinFormsApp37
            {
    public partial class Form1 : Form
    {
        //file 
        public const string file = "Client.json";
        public List<User> files = new List<User>();

        public Form1()
        {
            InitializeComponent();
            files = Loading() ?? new List<User>();



        }
        //dire mo save ang 
        public string Saved(List<User> user)
        {

            var options = new JsonSerializerOptions { WriteIndented = true };
            string STORE = JsonSerializer.Serialize(user, options);
            File.WriteAllText(file, STORE);

            // Removed Loading() call from here to prevent unnecessary recursion/loops
            return STORE;

        }
        //mo load siya tapos tan awun niya if naay sulod ang hmm si Saved nga method.

        public List<User> Loading()
        {

            if (!File.Exists(file))
            {
                // Removed MessageBox here so it doesn't pop up every time on a fresh install
                return new List<User>();
            }

            try
            {
                // Read the raw text
                string filed = File.ReadAllText(file);

                // Convert text into C# object
                // If the file is empty, return a new list instead of null
                return JsonSerializer.Deserialize<List<User>>(filed) ?? new List<User>();
            }
            catch (JsonException)
            {
                MessageBox.Show("Error reading JSON data.");
                return new List<User>();
            }


        }

        //dire ma view ang mga na saved sa ngaSaved nga method nga naay serializer;
        //tapos dire yaang ibalik sa original nga out put hmm orginal stae of object
        public void ViewHistory()
        {

            files = Loading() ?? new List<User>();

            // 2. Clear the screen
            ListBox.Items.Clear();

            // 3. Populate the screen from the synced list 
            foreach (var result in files)
            {
                string formattedDate = result.Oras.ToString();
                ListBox.Items.Add($"ItemName : {result.ItemName}  ItemPrice : {result.ItemPrice}   ItemQuantity : {result.ItemQuantity}    DateTime : {result.Oras}");

            }

        }
        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        //dire mo temporarily mo store sa listbox
        private void Store_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(TextName.Text) ||
                    string.IsNullOrWhiteSpace(TextPrice.Text) ||
                    string.IsNullOrWhiteSpace(TextQuantity.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(TextPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid number for Price.");
                return;
            }

            if (!int.TryParse(TextQuantity.Text, out int quanti))
            {
                MessageBox.Show("Please enter a valid whole number for Quantity.");
                return;
            }

            User user = new User();
            user.ItemName = TextName.Text;
            user.ItemPrice = price;
            user.ItemQuantity = quanti;
            // Note: Ensure your User class sets the "Oras" property inside its constructor or here
            // user.Oras = DateTime.Now.ToString(); 

            files.Add(user);
            Saved(files);

            // Clear inputs
            TextName.Clear();
            TextPrice.Clear();
            TextQuantity.Clear();

            MessageBox.Show("Saved Successfully!");

        }




        private void View_Click(object sender, EventArgs e)
        {


            ViewHistory();



        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            // 1.Check if the user selected an item in the ListBox
            if (ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item in the list first.");
                return;
            }

            // 2. Get the index of the selected item
            int index = ListBox.SelectedIndex;

            try
            {
                // 3. Sync memory safely
                // Load the fresh data to ensure we are modifying the latest file state
                List<User> currentFiles = Loading();

                // 4. Validate the index against the freshly loaded data
                if (index >= 0 && index < currentFiles.Count)
                {
                    // 5. Remove the item from the local list
                    currentFiles.RemoveAt(index);

                    // 6. Overwrite the file with the updated list
                    Saved(currentFiles);

                    // 7. Update your global variable (if 'files' is used elsewhere)
                    files = currentFiles;

                    // 8. Refresh the UI so it disappears from the screen
                    ViewHistory();

                    MessageBox.Show("Item deleted from file successfully!");
                }
                else
                {
                    MessageBox.Show("The list has changed. Please refresh and try again.", "Sync Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // FIXED: Added the missing call to force a refresh and realign the UI with reality
                    ViewHistory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void ADD_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item from the list to update first.");
                return;
            }

            int index = ListBox.SelectedIndex;
            files = Loading() ?? new List<User>();

            if (index < files.Count)
            {
                bool isChanged = false;

                // 1. Fixed: Reading from NameChange.Text instead of TextName.Text
                if (!string.IsNullOrWhiteSpace(NameChange.Text))
                {
                    files[index].ItemName = NameChange.Text;
                    isChanged = true;
                }

                // 2. Fixed: Parsing PriceChange.Text instead of TextPrice.Text
                if (!string.IsNullOrWhiteSpace(PriceChange.Text))
                {
                    if (decimal.TryParse(PriceChange.Text, out decimal newPrice))
                    {
                        files[index].ItemPrice = newPrice;
                        isChanged = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number for the new Price.");
                        return;
                    }
                }

                // 3. Fixed: Parsing QuantityChange.Text instead of TextQuantity.Text
                if (!string.IsNullOrWhiteSpace(QuantityChange.Text))
                {
                    if (int.TryParse(QuantityChange.Text, out int newQuanti))
                    {
                        files[index].ItemQuantity = newQuanti;
                        isChanged = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid whole number for the new Quantity.");
                        return;
                    }
                }

                if (isChanged)
                {
                    // Update timestamp to show when it was modified
                    files[index].Oras = DateTime.Now;

                    Saved(files);       // Write to JSON
                    ViewHistory();     // Refresh the ListBox display

                    // Clear the update textboxes
                    NameChange.Clear();
                    PriceChange.Clear();
                    QuantityChange.Clear();

                    MessageBox.Show("Item modified successfully!");
                }
                else
                {
                    MessageBox.Show("No new inputs entered to change.");
                }
            } // <-- Closed index < files.Count block
        }

        // Cleaned up empty unused designer event handlers



        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void View2_Click(object sender, EventArgs e)
        {

        }

        private void StatusResult_Click(object sender, EventArgs e)
        {
        }

        private void Exit_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
    }
}
    