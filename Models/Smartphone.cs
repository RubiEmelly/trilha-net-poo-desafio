namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        // Construtor com todos os parâmetros
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Método para ligar o smartphone
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // Método para receber ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato para instalar aplicativo
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
