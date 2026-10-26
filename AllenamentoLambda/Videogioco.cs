using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllenamentoLambda
{
    public class Videogioco
    {
        public string Titolo { get; set; } = "";
        public string Genere { get; set; } = "";
        public int OreDiGioco { get; set; }
        public double Prezzo { get; set; }
        public DateTime DataUscita { get; set; }
        public double Voto { get; set; }

        public override string ToString() =>
            $"{Titolo,-26} {Genere,-10} {OreDiGioco,4} h {Prezzo,7:0.00} €  {DataUscita:dd/MM/yyyy}  voto {Voto:0.0}";

        public string[] ToStringArray()
        {
            return new string[]
            {
                Titolo,
                Genere,
                OreDiGioco.ToString(),
                Prezzo.ToString("0.00"),
                DataUscita.ToString("dd/MM/yyyy"),
                Voto.ToString("0.0")
            };
        }
    }
}
