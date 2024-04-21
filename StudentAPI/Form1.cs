using System.Diagnostics.Metrics;
using System.Text.Json;
using static System.Windows.Forms.LinkLabel;

namespace StudentAPI
{
    public partial class Form1 : Form
    {
        private CoctailsData coctailsData;
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            coctailsData = new CoctailsData();
            textBoxDatabaseCount.Text = coctailsData.Coctails.Count().ToString();
        }

        private async void buttonDownload_Random(object sender, EventArgs e)
        {
            string call = "https://www.thecocktaildb.com/api/json/v1/1/random.php";
            string response = await client.GetStringAsync(call);
            DrinkRoot drinkRoot = JsonSerializer.Deserialize<DrinkRoot>(response);
            Coctail coctail = drinkRoot.drinks[0];
            if (coctailsData.Coctails.Where(d => d.idDrink.Equals(coctail.idDrink)).Count() == 0)
            {
                coctailsData.Coctails.Add(coctail);
                coctailsData.SaveChanges();
                textBoxSource.Text = "API";
            }
            else
            {
                textBoxSource.Text = "Database";
            }
            listBoxCoctails.DataSource = coctailsData.Coctails.Where(d => d.idDrink.Equals(coctail.idDrink)).ToList();
        }

        private async void buttonDownload_ByFirstLetter(object sender, EventArgs e)
        {
            string letter = textBox2.Text;
            if (!string.IsNullOrEmpty(letter))
            {
                if (coctailsData.Coctails.Where(drink => drink.strDrink.StartsWith(letter)).Count() < 5)
                {
                    string call = $"https://www.thecocktaildb.com/api/json/v1/1/search.php?f={letter}";
                    string response = await client.GetStringAsync(call);
                    if (!string.IsNullOrEmpty(response))
                    {
                        DrinkRoot drinkRoot = JsonSerializer.Deserialize<DrinkRoot>(response);
                        if (drinkRoot.drinks != null)
                        {
                            foreach (var drink in drinkRoot.drinks)
                            {
                                if (coctailsData.Coctails.Where(d => d.idDrink.Equals(drink.idDrink)).Count() == 0)
                                {
                                    coctailsData.Coctails.Add(drink);
                                }
                            }
                            coctailsData.SaveChanges();
                            textBoxSource.Text = "API";
                        }
                    }
                }
                else
                {
                    textBoxSource.Text = "Database";
                }
                listBoxCoctails.DataSource = coctailsData.Coctails.Where(drink => drink.strDrink.StartsWith(letter)).ToList<Coctail>();
            }
            else
            {

            }
        }

        private async void buttonDownload_ByName(object sender, EventArgs e)
        {
            string name = textBoxName.Text.ToLower();
            if (!string.IsNullOrEmpty(name))
            {
                if (coctailsData.Coctails.Where(drink => drink.strDrink.ToLower().Contains(name)).Count() == 0)
                {
                    string call = $"https://www.thecocktaildb.com/api/json/v1/1/search.php?s={name}";
                    string response = await client.GetStringAsync(call);
                    if (!string.IsNullOrEmpty(response))
                    {
                        DrinkRoot drinkRoot = JsonSerializer.Deserialize<DrinkRoot>(response);
                        if (drinkRoot.drinks != null)
                        {
                            foreach (var drink in drinkRoot.drinks)
                            {
                                if (coctailsData.Coctails.Where(d => d.idDrink.Equals(drink.idDrink)).Count() == 0)
                                {
                                    coctailsData.Coctails.Add(drink);
                                }
                            }
                            coctailsData.SaveChanges();
                            textBoxSource.Text = "API";
                        }
                    }
                }
                else
                {
                    textBoxSource.Text = "Database";
                }
                listBoxCoctails.DataSource = coctailsData.Coctails.Where(drink => drink.strDrink.ToLower().Contains(name)).ToList<Coctail>();
            }
        }

        private void button_ClearDatabase(object sender, EventArgs e)
        {
            coctailsData.Coctails.RemoveRange(coctailsData.Coctails);
            coctailsData.SaveChanges();
            textBoxDatabaseCount.Text = coctailsData.Coctails.Count().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonDownload_ByName(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonDownload_Random(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonDownload_ByFirstLetter(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_ClearDatabase(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDatabaseCount.Text = coctailsData.Coctails.Count().ToString();
        }

        private void listBoxCoctails_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxIngredients.Items.Clear();
            if(listBoxCoctails.SelectedIndex != -1)
            {
               if(listBoxCoctails.SelectedItem.GetType() ==  typeof(Coctail))
                {
                    Coctail coctail = listBoxCoctails.SelectedItem as Coctail;
                    textBox1.Text = coctail.strInstructions;
                    List<string> list = coctail.getIngredientsList();
                    foreach(string str in list)
                    {
                        if(str != null)
                        {
                            listBoxIngredients.Items.Add(str);
                        }
                    }
                }
            }
        }
    }
}
