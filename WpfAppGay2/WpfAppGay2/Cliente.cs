using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppGay2
{
    public class Cliente
    {
        private string codiceFiscale;
        private string cognome;
        private string nome;
        private string citta;
        private string provincia;
        private string email;
        private string telefono;
        private string cellulare;

        public string CodiceFiscale { get => codiceFiscale; set => codiceFiscale = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Citta { get => citta; set => citta = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cellulare { get => cellulare; set => cellulare = value; }

        // Costruttore
        public Cliente(string codiceFiscale, string cognome, string nome, string citta, string provincia, string email, string telefono, string cellulare)
        {
            this.codiceFiscale = codiceFiscale;
            this.cognome = cognome;
            this.nome = nome;
            this.citta = citta;
            this.provincia = provincia;
            this.email = email;
            this.telefono = telefono;
            this.cellulare = cellulare;
        }

        // Metodo ToString
        public override string ToString()
        {
            return $"Cliente {{ CodiceFiscale = '{CodiceFiscale}', Cognome = '{Cognome}', Nome = '{Nome}', Citta = '{Citta}', Provincia = '{Provincia}', Email = '{Email}', Telefono = '{Telefono}', Cellulare = '{Cellulare}' }}";
        }
    }
}
