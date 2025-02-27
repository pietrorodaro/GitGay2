using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppGay2
{
    public partial class MainWindow : Window
    {
        private List<Cliente> clientiList = new List<Cliente>();
        private List<Camera> camereList = new List<Camera>();
        private List<Prenotazione> prenotazioneList = new List<Prenotazione>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Aggiungi Cliente
        private void AggiungiClienteButton_Click(object sender, RoutedEventArgs e)
        {
            // Ottieni i dati dai TextBox
            string codiceFiscale = CodiceFiscaleTextBox.Text;
            string cognome = CognomeTextBox.Text;
            string nome = NomeTextBox.Text;
            string citta = CittaTextBox.Text;
            string provincia = ProvinciaTextBox.Text;
            string email = EmailTextBox.Text;
            string telefono = TelefonoTextBox.Text;
            string cellulare = CellulareTextBox.Text;

            // Crea un nuovo Cliente
            Cliente cliente = new Cliente(codiceFiscale, cognome, nome, citta, provincia, email, telefono, cellulare);

            // Aggiungi il cliente alla lista
            clientiList.Add(cliente);

            // Messaggio di conferma
            MessageBox.Show($"Cliente aggiunto con successo! \n {cliente}");
        }

        // Aggiungi Camera
        private void AggiungiCameraButton_Click(object sender, RoutedEventArgs e)
        {
            // Ottieni i dati dalla Camera
            int numeroCamera = int.Parse(NumeroCameraTextBox.Text);
            string descrizione = DescrizioneCameraTextBox.Text;
            string tipologia = TipologiaTextBox.Text;

            // Crea una nuova Camera
            Camera camera = new Camera(numeroCamera, descrizione, tipologia);

            // Aggiungi la camera alla lista
            camereList.Add(camera);

            // Messaggio di conferma
            MessageBox.Show($"Camera {camera.Numero} ({camera.Tipologia}) aggiunta con successo!");
        }

        // Crea Prenotazione
        private void CreaPrenotazioneButton_Click(object sender, RoutedEventArgs e)
        {
            // Ottieni la data di prenotazione, inizio e fine
            DateOnly dataPrenotazione = DateOnly.FromDateTime(DataPrenotazioneDatePicker.SelectedDate.Value);
            DateOnly dataInizio = DateOnly.FromDateTime(DataInizioDatePicker.SelectedDate.Value);
            DateOnly dataFine = DateOnly.FromDateTime(DataFineDatePicker.SelectedDate.Value);

            bool flag = false;
            int camera = int.Parse(CameraTextBox.Text);
            Camera cameraFR = null;

            foreach (Camera c in camereList)
            {
                if (c.Numero == camera)
                {
                    flag = true;
                    cameraFR = c;
                }
            }

            if (!flag)
            {
                MessageBox.Show("Camera non trovata!");
                return;
            }

            flag = false;
            string codiceFiscale = ClienteTextBox.Text;
            Cliente clienteFR = null;

            foreach (Cliente c in clientiList)
            {
                if (c.CodiceFiscale == codiceFiscale)
                {
                    flag = true;
                    clienteFR = c;
                }
            }

            if (!flag)
            {
                MessageBox.Show("Cliente non trovato!");
                return;
            }

            // Crea una nuova Prenotazione
            Prenotazione prenotazione = new Prenotazione(cameraFR, clienteFR, dataPrenotazione, dataInizio, dataFine);

            prenotazioneList.Add(prenotazione);

            // Messaggio di conferma
            MessageBox.Show($"Prenotazione confermata! Caparra: {prenotazione.Caparra}, Tariffa: {prenotazione.Tariffa}");
        }
    }
}