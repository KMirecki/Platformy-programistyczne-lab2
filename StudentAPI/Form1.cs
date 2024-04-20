using System.Text.Json;

namespace StudentAPI
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }
        private async void buttonDownload_ClickAsync(object sender, EventArgs e)
        {
            string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            string response = await client.GetStringAsync(call);
            List<Student> students = JsonSerializer.Deserialize<List<Student>>(response);
            foreach (var student in students) listBox1.Items.Add(student.ToString());
            //textBoxResponse.Text = response;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonDownload_ClickAsync(sender, e);
        }
    }
}
