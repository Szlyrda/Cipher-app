using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

          

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        // Metoda obsługi przycisku "Wczytaj plik"
        private void loadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Pobierz ścieżkę wybranego pliku
                sourceLabel1.Text = openFileDialog1.FileName;

                // Odczytaj zawartość pliku do strumienia
                var fileStream = openFileDialog1.OpenFile();

                // Odczytaj strumień za pomocą obiektu StreamReader i wyświetl go w polu tekstowym textBox1
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    textBox1.Text = reader.ReadToEnd();
                }

                // Wyczyść pole tekstowe textBox2
                textBox2.Text = "";
            }
        }

        // Metoda obsługi przycisku "Zapisz plik"
        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Zapisz zawartość pola tekstowego textBox2 do pliku
                System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);

                // Wyświetl ścieżkę zapisanego pliku
                destinationLabel.Text = saveFileDialog1.FileName;
            }
        }

        // Metoda obsługi przycisku "Szyfruj plik" szyfrem Cezara
        private void scipherFileButton_Click(object sender, EventArgs e)
        {
            
            int encryption, key = 3; // Liczba klucza szyfrującego, można ją zmienić
            string userSendsText, encryptedText = "";
            userSendsText = textBox1.Text;

            // Szyfruj każdy znak w tekście odczytanym z pola textBox1
            for (int i = 0; i < userSendsText.Length; i++)
            {
                int txtUser = (int)userSendsText[i];
                encryption = txtUser + key; // Przesuń numer znaku o określoną liczbę pozycji na podstawie klucza
                
                // Przekonwertuj zaszyfrowany znak na znak Unicode i dodaj go do zaszyfrowanego tekstu
                encryptedText += Char.ConvertFromUtf32(encryption); 
            }

            // Wyświetl zaszyfrowany tekst w polu textBox2
            textBox2.Text = encryptedText;
            
        }

        // Metoda do deszyfrowania tekstu za pomocą algorytmu przesuwającego
        private void descipherFileButton_Click(object sender, EventArgs e)
        {
            int decryption;
            string decryptText = "";
            int key = 3; // Liczba klucza szyfrującego, można ją zmienić
            string encryptedText;

            encryptedText = textBox1.Text;

            // Pętla po każdym znaku w zaszyfrowanym tekście
            for (int i = 0; i < encryptedText.Length; i++)
            {
                int encrypted = (int)encryptedText[i];
                decryption = encrypted - key;
                decryptText += Char.ConvertFromUtf32(decryption);
            }

            textBox2.Text = decryptText;
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void destinationLabel_Click(object sender, EventArgs e)
        {

        }

        private void sourceLabel1_Click(object sender, EventArgs e)
        {

        }


        //netoda szyfrująca
        static private byte[] EncryptRSA(byte[] userSendsText, CspParameters csp)
        {
            using (var RSA = new RSACryptoServiceProvider(csp))
            {
                return RSA.Encrypt(userSendsText, false);
            }
        }

        //metoda deszyfrująca
        static private byte[] DecryptRSA(byte[] userSendsText, CspParameters csp)
        {
            using (var RSA = new RSACryptoServiceProvider(csp))
            {
                return RSA.Decrypt(userSendsText, false);
            }
        }

        // Metoda do szyfrowania tekstu asymetrycznego za pomocą algorytmu RSA
        private void asymetricCipherButton_Click(object sender, EventArgs e)
        {
            string userSendsText = textBox1.Text;

            //kontener, w którym będą zapisywane utworzone klucze RSA
            var csp = new CspParameters
            {
                KeyContainerName = "KontenerRSA"
            };

            byte[] encryptedMsg = EncryptRSA(Encoding.UTF8.GetBytes(userSendsText), csp);

            textBox2.Text = Convert.ToBase64String(encryptedMsg); // zamiana na Base64

        }

        // Metoda do deszyfrowania tekstu asymetrycznego za pomocą algorytmu RSA
        private void asymetricDecipherButton_Click(object sender, EventArgs e)
        {
            string userSendsText = textBox1.Text;

            //kontener, w którym będą zapisywane utworzone klucze RSA
            var csp = new CspParameters
            {
                KeyContainerName = "KontenerRSA"
            };

            byte[] encryptedMsg = Convert.FromBase64String(userSendsText); // dekodowanie z Base64

            byte[] decryptedMsg = DecryptRSA(encryptedMsg, csp);

            textBox2.Text = Encoding.UTF8.GetString(decryptedMsg);
        }


    }
}