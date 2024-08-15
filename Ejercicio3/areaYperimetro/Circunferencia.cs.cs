using System;

namespace FigurasGeometricas
{
    public class Circunferencia
    {
        public double Radio { get; set; }

        public Circunferencia(double radio)
        {
            Radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
