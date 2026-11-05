using System.Collections;
using System.Text.Json;

namespace AllenamentoLambda
{
    public partial class Form1 : Form
    {
        List<Videogioco> videogiochi = new();
        List<Videogioco> videogiochi_virtual = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videogiochi = CaricaDati("videogiochi.json");
            CaricaDatiInListView(videogiochi);
        }

        private void CaricaDatiInListView(List<Videogioco> giochi)
        {
            lvVideogiochi.BeginUpdate();
            videogiochi_virtual = new(giochi);
            lvVideogiochi.VirtualListSize = videogiochi_virtual.Count;
            lvVideogiochi.EndUpdate();
            lvVideogiochi.Invalidate();
        }

        private List<Videogioco> CaricaDati(string nomeFile)
        {
            string percorso = Path.Combine(AppContext.BaseDirectory, nomeFile);
            return JsonSerializer.Deserialize<List<Videogioco>>(File.ReadAllText(percorso)) ?? new List<Videogioco>();
        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            ListViewItem riga = new ListViewItem(videogiochi_virtual[e.ItemIndex].ToStringArray());
            e.Item = riga;
        }

        private void btTitolo_Click(object sender, EventArgs e)
        {
            videogiochi.Sort((x, y) =>
            {
                if (rbCrescente.Checked)
                    return x.Titolo.CompareTo(y.Titolo);
                else
                    return y.Titolo.CompareTo(x.Titolo);
            });
            CaricaDatiInListView(videogiochi);
        }

        private void btOreGioco_Click(object sender, EventArgs e)
        {
            videogiochi.Sort((x, y) =>
            {
                if (rbCrescente.Checked)
                    return x.OreDiGioco.CompareTo(y.OreDiGioco);
                else
                    return y.OreDiGioco.CompareTo(x.OreDiGioco);
            });
            CaricaDatiInListView(videogiochi);
        }

        private void btPrezzo_Click(object sender, EventArgs e)
        {
            videogiochi.Sort((x, y) =>
            {
                if (rbCrescente.Checked)
                    return x.Prezzo.CompareTo(y.Prezzo);
                else
                    return y.Prezzo.CompareTo(x.Prezzo);
            });
            CaricaDatiInListView(videogiochi);
        }

        private void btDataUscita_Click(object sender, EventArgs e)
        {
            videogiochi.Sort((x, y) =>
            {
                if (rbCrescente.Checked)
                    return x.DataUscita.CompareTo(y.DataUscita);
                else
                    return y.DataUscita.CompareTo(x.DataUscita);
            });
            CaricaDatiInListView(videogiochi);
        }

        private void btTrovaTitolo_Click(object sender, EventArgs e)
        {
            if (videogiochi == null || videogiochi.Count == 0)
            {
                MessageBox.Show("Nessun videogioco presente in lista.");
                return;
            }

            string elementoTrovato;

            if (rbPiu.Checked)
            {
                elementoTrovato = videogiochi.Max(x => x.Titolo);
            }
            else
            {
                elementoTrovato = videogiochi.Min(x => x.Titolo);
            }
            MessageBox.Show($"Titolo: {elementoTrovato}");
        }

        private void btTrovaOreGioco_Click(object sender, EventArgs e)
        {
            if (videogiochi == null || videogiochi.Count == 0)
            {
                MessageBox.Show("Nessun videogioco presente in lista.");
                return;
            }

            int elementoTrovato;

            if (rbPiu.Checked)
            {
                elementoTrovato = videogiochi.Max(x => x.OreDiGioco);
            }
            else
            {
                elementoTrovato = videogiochi.Min(x => x.OreDiGioco);
            }
            MessageBox.Show($"Ore di gioco: {elementoTrovato}");
        }

        private void btTrovaPerzzo_Click(object sender, EventArgs e)
        {
            if (videogiochi == null || videogiochi.Count == 0)
            {
                MessageBox.Show("Nessun videogioco presente in lista.");
                return;
            }

            double elementoTrovato;

            if (rbPiu.Checked)
            {
                elementoTrovato = videogiochi.Max(x => x.Prezzo);
            }
            else
            {
                elementoTrovato = videogiochi.Min(x => x.Prezzo);
            }
            MessageBox.Show($"Prezzo: {elementoTrovato}");
        }

        private void btTrovaDataUscita_Click(object sender, EventArgs e)
        {
            if (videogiochi == null || videogiochi.Count == 0)
            {
                MessageBox.Show("Nessun videogioco presente in lista.");
                return;
            }

            DateTime elementoTrovato;

            if (rbPiu.Checked)
            {
                elementoTrovato = videogiochi.Max(x => x.DataUscita);
            }
            else
            {
                elementoTrovato = videogiochi.Min(x => x.DataUscita);
            }
            MessageBox.Show($"Data di uscita: {elementoTrovato.ToString("dd/MM/yyyy")}");
        }

        private void btTrovaRPG_Click(object sender, EventArgs e)
        {
            DateTime dataAttuale = DateTime.Now;

            List<Videogioco> risultati = videogiochi.FindAll(x =>
                x.Genere == "RPG" &&
                x.DataUscita.Year == dataAttuale.Year &&
                x.DataUscita <= dataAttuale
            );

            CaricaDatiInListView(risultati);
        }

        private void btGratis_Click(object sender, EventArgs e)
        {
            List<Videogioco> risultati = videogiochi.FindAll(x =>
                x.Prezzo == 0
            );

            CaricaDatiInListView(risultati);

            int conteggio = risultati.Count;

            MessageBox.Show($"Giochi gratuiti trovati: {conteggio}");
        }

        private void btNeon_Click(object sender, EventArgs e)
        {
            List<Videogioco> risultati = videogiochi.FindAll(x =>
                x.Titolo.StartsWith("Neon")
            );

            CaricaDatiInListView(risultati);
        }

        private void btAumentaPrezzi_Click(object sender, EventArgs e)
        {
            List<Videogioco> risultati = videogiochi.FindAll(x =>
                x.Prezzo == 0 &&
                x.DataUscita >= DateTime.Now.AddMonths(-12) &&
                x.DataUscita <= DateTime.Now
            );

            CaricaDatiInListView(risultati);
        }
    }
}
