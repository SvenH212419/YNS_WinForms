using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
namespace TestMongoDB
{
    public partial class Form1 : Form
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<Media> m_Collection;

        public Form1()
        {
            InitializeComponent();
            m_Client = new MongoClient("mongodb+srv://Sven1719:Winnie19@maincluster.jtr1q.mongodb.net/test\r\n");
            m_Database = m_Client.GetDatabase("FoxFinder");
            m_Collection = m_Database.GetCollection<Media>("Media");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ding = m_Database.GetCollection<Media>("Media").FindSync(x => x.Media_type == "Game").FirstOrDefault();
                MessageBox.Show(ding.Media_title, ding.Media_playable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Yo");
            }
        }
    }
}