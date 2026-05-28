            using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
            using System.Security.Cryptography.X509Certificates;
            using System.Text.Json;
            namespace WinFormsApp37
            {
    public partial class Form1 : Form
    {
        //file 
        public const string file = "Client.json"; //mao ni siya ang file path
        public List<User> files = new List<User>();//mao e ni ang mag hold sa current item records sa computer
        // ug si user is the object dire masulod ang mga naa ni user nga Class nga nag contains or nag hawid sa ItemName, ItemPrice,ItemQuantity this are the properties of the class User
        public Form1()
        {
            InitializeComponent();
            files = Loading() ?? new List<User>();
          


        }
        //dire mo save ang data save sa inputs pero kani siya kay it is a method nga gamiton
        public string Saved(List<User> user)
        {

            var options = new JsonSerializerOptions { WriteIndented = true };
            string STORE = JsonSerializer.Serialize(user, options);
            File.WriteAllText(file, STORE);
            //si writealltext it creates a new file, writes a string of text

           
            return STORE;

        }

        //mo load siya tapos tan awun niya if naay sulod ang 
        public List<User> Loading()
        {
            //tan awun if the file is exi
            if (!File.Exists(file))
            {
                
                return new List<User>();
            }

            try
            {
                // Read the raw text yaang e read ang text sa sulod sa file nga Client.json nga file path
                string filed = File.ReadAllText(file);

             
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

            ListBox.Items.Clear();

          
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

            // dire if wala gi butnga maskin usa ka text or numbers sa textbox mag hatag siya ug Message using Message box
            if (string.IsNullOrWhiteSpace(TextName.Text) ||
                    string.IsNullOrWhiteSpace(TextPrice.Text) ||
                    string.IsNullOrWhiteSpace(TextQuantity.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            //dire mo tan awun nga if decimal number nga gibutang sa user
            if (!decimal.TryParse(TextPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid number for Price.");
                return;
            }
            // dire mo tan aww if integer ang gibutang nga input  
            if (!int.TryParse(TextQuantity.Text, out int quanti))
            {
                MessageBox.Show("Please enter a valid whole number for Quantity.");
                return;
            }

            //dire ma solud ang mga gi inputs Textbox 
            User user = new User();
            user.ItemName = TextName.Text;
            user.ItemPrice = price;
            user.ItemQuantity = quanti;
          
            // and using the files.ADD MAO NI SIYA ang List nga magstore temporarily sa mga na inputs 
            files.Add(user);

            // and the Saved method is the method nga mag saved sa gi pang input so using the files nga List if naay sulod dire 
            // masulodsa saved method ang mga data nga nahawidtan ni List
            Saved(files);

            // it clear the inputs pag kahuman ug saved using the saved method
            TextName.Clear();
            TextPrice.Clear();
            TextQuantity.Clear();

            MessageBox.Show("Saved Successfully!");

        }


       

        private void View_Click(object sender, EventArgs e)
        {


            // DIRE MO VIEW ANG USER IF ICLICK NIYA ANG VIEW BUTTON
            if (string.IsNullOrEmpty(files.ToString()))
            {
                ViewHistory();
            }
            else
            {
                MessageBox.Show("No data yet");
            }
            

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click_1(object sender, EventArgs e)
        { // dire ang delete ang method nga delete.
            if (ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item in the list first.");
                return;
            }

            
            int index = ListBox.SelectedIndex;

            try
            {
               
                List<User> currentFiles = Loading();

               
                if (index >= 0 && index < currentFiles.Count)
                {
                    currentFiles.RemoveAt(index);

 
                    Saved(currentFiles);

                  
                    files = currentFiles;

                    
                    ViewHistory();

                    MessageBox.Show("Item deleted from file successfully!");
                }
                else
                {
                    MessageBox.Show("The list has changed. Please refresh and try again.", "Sync Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                
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

                // 
                if (!string.IsNullOrWhiteSpace(NameChange.Text))
                {
                    files[index].ItemName = NameChange.Text;
                    isChanged = true;
                }

               
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
     
                    files[index].Oras = DateTime.Now;

                    Saved(files);       
                    ViewHistory();   
                   
                    NameChange.Clear();
                    PriceChange.Clear();
                    QuantityChange.Clear();

                    MessageBox.Show("Item modified successfully!");
                }
                else
                {
                    MessageBox.Show("No new inputs entered to change.");
                }
            } 
        }

      



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
          //kini ang button nga click if tuslokon ma exit
            this.Close();
        }
    }
}
    