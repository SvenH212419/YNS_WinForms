using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
namespace TestMongoDB
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dbClient = new MongoClient("mongodb+srv://NovaFoxy:Kyuubi99@maincluster.jtr1q.mongodb.net/?retryWrites=true&w=majority");
                IMongoDatabase db = dbClient.GetDatabase("YNS");
                var YNS = db.GetCollection<BsonDocument>("Parameters");

                var documents = YNS.Find(new BsonDocument()).ToList();

                foreach (BsonDocument doc in documents)
                {
                    MessageBox.Show(doc.ToString());
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Yo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}