using System.Text.Json;

namespace StudentAPI
{
    public partial class Form1 : Form
    {
        private University university;
        private CoctailsData coctailsData;
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            university = new University();
            client = new HttpClient();
            coctailsData = new CoctailsData();
            textBoxDatabaseCount.Text = coctailsData.Coctails.Count().ToString();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            university.Students.Add(new Student() { Name = textBoxName.Text, Average = float.Parse(textBoxAverage.Text) });
            university.SaveChanges();
            listBoxStudents.DataSource = university.Students.ToList<Student>();
        }

        private async void buttonDownload_Random(object sender, EventArgs e)
        {
            string call = "https://www.thecocktaildb.com/api/json/v1/1/random.php";
            string response = await client.GetStringAsync(call);
            DrinkRoot drinkRoot = JsonSerializer.Deserialize<DrinkRoot>(response);
            Coctail coctail = drinkRoot.drinks[0];
            textBox1.Text = coctail.ToString();
        }

        private async void buttonDownload_ByFirstLetter(object sender, EventArgs e)
        {
            //listBoxStudents.Items.Clear();
            string letter = textBox2.Text;
            if (!string.IsNullOrEmpty(letter))
            {
                if (coctailsData.Coctails.Where(drink => drink.strDrink.StartsWith(letter)).Count() == 0)
                {
                    textBox1.Text = "Pobieramy z API";
                    string call = $"https://www.thecocktaildb.com/api/json/v1/1/search.php?f={letter}";
                    string response = await client.GetStringAsync(call);
                    DrinkRoot drinkRoot = JsonSerializer.Deserialize<DrinkRoot>(response);
                    foreach (var drink in drinkRoot.drinks)
                    {
                        if (coctailsData.Coctails.Where(d => d.idDrink.Equals(drink.idDrink)).Count() == 0)
                        {
                            coctailsData.Coctails.Add(drink);
                        }
                    }
                    coctailsData.SaveChanges();
                }
                else
                {
                    textBox1.Text = "Jest w bazie";
                }
                listBoxStudents.DataSource = coctailsData.Coctails.Where(drink => drink.strDrink.StartsWith(letter)).ToList<Coctail>();
            }
            else
            {

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
            buttonAdd_Click(sender, e);
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
    }
}
