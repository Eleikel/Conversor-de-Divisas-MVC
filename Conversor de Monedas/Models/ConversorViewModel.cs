namespace Conversor_de_Monedas.Models
{
    public class ConversorViewModel
    {

        //Desde que moneda voy a convertir
        public int FromConvert { get; set; }
        //A que moneda voy a convertir
        public int ToConvert { get; set; }
        public double InputQuantity { get; set; }

        public double ResultQuantity { get; set; }

    }
}
