namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string _modelo;
        private string _imei;
        private int _memoria;
        public string Numero { get; set; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Imei { get => _imei; set => _imei = value; }
        public int Memoria { get => _memoria; set => _memoria = value; }

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}