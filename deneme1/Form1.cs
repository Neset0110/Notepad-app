using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
namespace deneme1
{

    public partial class Form1 : Form
    {
        public class NotItem
        {
            public int Id { get; set; }
            public string Baslik { get; set; }

            public override string ToString()
            {
                return Baslik;
            }
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1
            string dbPath = Path.Combine(Application.StartupPath, "NotDefteri.db");

            try
            {
                using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();

                    // Tablo oluþturma sorgusu (hatasýz örnek)
                    string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Notlar (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Baslik TEXT NOT NULL,
                Icerik TEXT,
                Tarih DATETIME DEFAULT CURRENT_TIMESTAMP
            )";

                    new SQLiteCommand(createTableQuery, conn).ExecuteNonQuery();

                    // Örnek veri çekme sorgusu (parametreli)
                    string selectQuery = "SELECT * FROM Notlar";
                    var adapter = new SQLiteDataAdapter(selectQuery, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("SQL Hatasý: " + ex.Message + "\n\nDetay: " + ex.StackTrace);
            }
            //2
            listBox1.Items.Clear();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=NotDefteri.db;Version=3;"))
            {
                conn.Open();
                string sql = "SELECT id, baslik FROM Notlar";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            string baslik = reader["baslik"].ToString();

                            listBox1.Items.Add(new NotItem { Id = id, Baslik = baslik });
                        }
                    }
                }
            }
            //3

        }


        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string icerik = richTextBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(icerik))
            {
                MessageBox.Show("Not boþ olamaz!");
                return;
            }

            string baslik = icerik.Length > 20 ? icerik.Substring(0, 20) + "..." : icerik;

            using (SQLiteConnection con = new SQLiteConnection("Data Source=notlar.db;Version=3;"))
            {
                con.Open();

                string tabloKontrol = @"CREATE TABLE IF NOT EXISTS Notlar (
                                  Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                  Baslik TEXT,
                                  Icerik TEXT
                                )";
                new SQLiteCommand(tabloKontrol, con).ExecuteNonQuery();

                string sql = "INSERT INTO Notlar (Baslik, Icerik) VALUES (@baslik, @icerik)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@baslik", baslik);
                    cmd.Parameters.AddWithValue("@icerik", icerik);
                    cmd.ExecuteNonQuery();
                }

                long id = con.LastInsertRowId;

                // Basit ListBox kullanýmý
                listBox1.Items.Add(new NotItem { Id = (int)id, Baslik = baslik });

                richTextBox1.Clear();
                MessageBox.Show("Not baþarýyla kaydedildi.");
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem is NotItem seciliNot)
            {
                using (var connection = new SQLiteConnection("Data Source=NotDefteri.db;Version=3;"))
                {
                    connection.Open();
                    string sql = "SELECT icerik FROM Notlar WHERE id = @id";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", seciliNot.Id);
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            richTextBox1.Text = result.ToString();
                        }
                    }
                }
            }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is NotItem seciliNot)
            {
                DialogResult sonuc = MessageBox.Show("Bu notu silmek istediðinizden emin misiniz?", "Silme Onayý", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    using (var conn = new SQLiteConnection("Data Source=NotDefteri.db;Version=3;"))
                    {
                        conn.Open();
                        string sql = "DELETE FROM Notlar WHERE Id = @id";
                        using (var cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", seciliNot.Id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    listBox1.Items.Remove(seciliNot);
                    richTextBox1.Clear();
                    MessageBox.Show("Not baþarýyla silindi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediðiniz notu seçin.");
            }
        }

        private void farklýKayderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyasý|*.txt";
            saveFileDialog.Title = "Farklý Kaydet";
            saveFileDialog.FileName = "";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                    MessageBox.Show("Dosya baþarýyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Dosyalarý (*.txt)|*.txt";
            openFileDialog.Title = "Bir Dosya Seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Seçilen dosyadaki içeriði oku
                    string dosyaIcerigi = File.ReadAllText(openFileDialog.FileName);

                    // Ýçeriði richTextBox'a yükle
                    richTextBox1.Text = dosyaIcerigi;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya açýlýrken bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // RichTextBox'da deðiþiklik olup olmadýðýný kontrol et
            string icerik = richTextBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(icerik))
            {
                MessageBox.Show("Not boþ olamaz!");
                return;
            }

            if (listBox1.SelectedItem is NotItem seciliNot)
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=NotDefteri.db;Version=3;"))
                {
                    conn.Open();

                    // Güncelleme sorgusu
                    string sql = "UPDATE Notlar SET Icerik = @icerik WHERE Id = @id";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@icerik", icerik);
                        cmd.Parameters.AddWithValue("@id", seciliNot.Id);
                        cmd.ExecuteNonQuery();
                    }

                    // Güncellenmiþ notu ListBox'a geri yansýt
                    listBox1.Items[listBox1.SelectedIndex] = new NotItem { Id = seciliNot.Id, Baslik = icerik.Length > 20 ? icerik.Substring(0, 20) + "..." : icerik };

                    // Kullanýcýya mesaj ver
                    MessageBox.Show("Not baþarýyla güncellendi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediðiniz notu seçin.");
            }
        }

        private void dosyaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            listBox1.ClearSelected();

        }

        private void yazdýrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 12), Brushes.Black, ev.MarginBounds);
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void çýkýþYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kopyalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
                Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                Clipboard.SetText(richTextBox1.SelectedText);
                richTextBox1.SelectedText = "";
            }
        }

        private void yapýþtýrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                richTextBox1.SelectedText = Clipboard.GetText();
        }

        private void hepsiniSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void hepsiniSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void tarihZamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(" " + DateTime.Now.ToString());
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = richTextBox1.Font;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Font = fontDialog.Font;
                }
            }
        }

        private void açýkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = true;
        }

        private void kapalýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
        }

        private void hakkýndaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOT DEFTERÝ PRO MAX");
        }

        private void karanlýkTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.BackColor = ColorTranslator.FromHtml("#343a40");
            menuStrip1.BackColor = ColorTranslator.FromHtml("#343a40");
            menuStrip1.ForeColor = Color.White;
            richTextBox1.BackColor = ColorTranslator.FromHtml("#343a40");
            richTextBox1.ForeColor = Color.White;
            listBox1.BackColor = ColorTranslator.FromHtml("#343a40");
            listBox1.ForeColor = Color.White;
            panel2.BackColor = ColorTranslator.FromHtml("#343a40");
            pictureBox1.Image = Image.FromFile(@"C:\notepadTry\images\notlogodark.png");
        }

        private void aydýnlýkTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
            listBox1.BackColor = Color.White;
            listBox1.ForeColor = Color.Black;
            panel2.BackColor = SystemColors.Window;
            pictureBox1.Image = Image.FromFile(@"C:\notepadTry\images\notdefteriv2.png");
        }
    }
}
