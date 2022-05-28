
using Conversor_de_Monedas.Models;
using System;

namespace Conversor_de_Monedas.Service
{
    public class ConversorService
    {

        public void Convertir(ConversorViewModel cvm)
        {
            double dolar = 0;
            double euro = 0;
            double peso = 0;
            double result = cvm.ResultQuantity;


            switch (cvm.FromConvert)
            {
                case (int)FromConvert.Dolar:
                    if (cvm.FromConvert == 1 && cvm.ToConvert == 1)
                    {
                        dolar = 1;
                        cvm.ResultQuantity =  cvm.InputQuantity * dolar;
                    }

                    else if (cvm.FromConvert == 1 && cvm.ToConvert == 2)
                    {
                        euro = 0.9370;
                        cvm.ResultQuantity = cvm.InputQuantity * euro;
                    }

                    else if (cvm.FromConvert == 1 && cvm.ToConvert == 3)
                    {
                        peso = 55.21;
                        cvm.ResultQuantity = Math.Round(cvm.InputQuantity * peso, 2);
                    }

                    break;


                // Euro
                case (int)FromConvert.Euro:
                    if (cvm.FromConvert == 2 && cvm.ToConvert == 1)
                    {
                        dolar = 1.07192;
                        cvm.ResultQuantity = Math.Round(cvm.InputQuantity * dolar, 2);

                    }

                    else if (cvm.FromConvert == 2 && cvm.ToConvert == 2)
                    {
                        euro = 1;
                        cvm.ResultQuantity = Math.Round(cvm.InputQuantity * euro, 2);
                    }

                    if (cvm.FromConvert == 2 && cvm.ToConvert == 3)
                    {
                        peso = 59.2215;
                        cvm.ResultQuantity = Math.Round(cvm.InputQuantity * peso, 2);
                    }
                    break;


                case (int)FromConvert.Peso:
                    if (cvm.FromConvert == 3 && cvm.ToConvert == 1)
                    {
                        dolar = 0.0181;
                        cvm.ResultQuantity = Math.Round(cvm.InputQuantity * dolar, 2);

                    }
                    else if (cvm.FromConvert == 3 && cvm.ToConvert == 2)
                    {
                        euro = 0.0168;
                        cvm.ResultQuantity = Math.Round(cvm.InputQuantity * euro, 2);
                    }

                    if (cvm.FromConvert == 3 && cvm.ToConvert == 3)
                    {
                        peso = 1;
                        cvm.ResultQuantity = Math.Round(cvm.InputQuantity * peso, 2);

                    }

                    break;

            }



        }
    }

}
