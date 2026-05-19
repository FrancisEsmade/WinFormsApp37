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
            string STORE = JsonSerializer.Serialize(user, options); // Removed Environment.NewLine to keep JSON valid
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
            // 1. Sync the brain: Load the data from the file into the 'files' list
            files = Loading() ?? new List<User>();

            // 2. Clear the screen
            ListBox.Items.Clear();

            // 3. Populate the screen from the synced list
            foreach (var result in files)
            {
                ListBox.Items.Add($"ItemName :{result.ItemName}  ItemPrice :{result.ItemPrice}   ItemQuantity :{result.ItemQuantity}    DateTime :{result.Oras}");
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
            // 1. Check if the user selected an item in the ListBox
            if (ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item in the list first.");
                return;
            }

            // 2. Get the index of the selected item
            int index = ListBox.SelectedIndex;

            try
            {
                // 3. Sync memory: ensure 'files' list matches what is in the file
                // This prevents deleting the wrong item if you haven't clicked 'View' in a while
                files = Loading();

                if (index < files.Count)
                {
                    // 4. Remove the item from the C# List
                    files.RemoveAt(index);

                    // 5. Overwrite the file with the updated list (this "deletes" it from the file)
                    Saved(files);

                    // 6. Refresh the UI so it disappears from the screen
                    ViewHistory();

                    MessageBox.Show("Item deleted from file successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
