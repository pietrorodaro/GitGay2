using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppGay2
{
    public class Prenotazione
    {
        private DateOnly dataPrenotazione;
        private DateOnly dataInizio;
        private DateOnly dataFine;
        private int caparra;
        private Camera camera;
        private Cliente cliente;
        private int tariffa;

        public Prenotazione(Camera camera, Cliente cliente, DateOnly dataPrenotazione, DateOnly dataInizio, DateOnly dataFine)
        {
            this.dataPrenotazione = dataPrenotazione;
            this.dataInizio = dataInizio;
            this.dataFine = dataFine;
            this.camera = camera;
            this.cliente = cliente;
            Calcola();
        }

        public DateOnly DataPrenotazione { get => dataPrenotazione; set => dataPrenotazione = value; }
        public DateOnly DataInizio { get => dataInizio; set => dataInizio = value; }
        public DateOnly DataFine { get => dataFine; set => dataFine = value; }
        public int Caparra { get => caparra; set => caparra = value; }
        public Camera Camera { get => camera; set => camera = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int Tariffa { get => tariffa; set => tariffa = value; }

        public void Calcola()
        {
            int giorni = DataFine.DayOfYear - DataInizio.DayOfYear;
            this.caparra = 10 * giorni;
            this.tariffa = giorni;
        }
    }
}
