using System;

namespace NumeralRomano
{
    public class NumeralRomanoConversor : INumeralRomanoConversor
    {
        public string InteiroParaRomano(int numero)
        {
            if ((numero < 0) || (numero > 3000))
                throw new ArgumentException("Só é possível inserir um valor entre 0 e 3000");

            if (numero < 1)
                return string.Empty;

            if (numero >= 1000)
                return "M" + InteiroParaRomano(numero - 1000);
            if (numero >= 900)
                return "CM" + InteiroParaRomano(numero - 900);
            if (numero >= 500)
                return "D" + InteiroParaRomano(numero - 500);
            if (numero >= 400)
                return "CD" + InteiroParaRomano(numero - 400);
            if (numero >= 100)
                return "C" + InteiroParaRomano(numero - 100);
            if (numero >= 90)
                return "XC" + InteiroParaRomano(numero - 90);
            if (numero >= 50)
                return "L" + InteiroParaRomano(numero - 50);
            if (numero >= 40)
                return "XL" + InteiroParaRomano(numero - 40);
            if (numero >= 10)
                return "X" + InteiroParaRomano(numero - 10);
            if (numero >= 9)
                return "IX" + InteiroParaRomano(numero - 9);
            if (numero >= 5)
                return "V" + InteiroParaRomano(numero - 5);
            if (numero >= 4)
                return "IV" + InteiroParaRomano(numero - 4);
            if (numero >= 1)
                return "I" + InteiroParaRomano(numero - 1);


            throw new ArgumentException("Erro desconhecido");
        }
    }
}
