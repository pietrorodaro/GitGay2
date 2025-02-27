using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppGay2
{
    public class Camera
    {
        //Variabili
        private int numero;
        private string descrizione;
        private string tipologia;

        public int Numero { get => numero; set => numero = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public string Tipologia { get => tipologia; set => tipologia = value; }

        // Costruttore
        public Camera(int numero, string descrizione, string tipologia)
        {
            this.numero = numero;
            this.descrizione = descrizione;
            this.tipologia = tipologia;
        }
    }
}
