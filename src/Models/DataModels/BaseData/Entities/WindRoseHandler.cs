using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.Entities
{
    public static class WindRoseHandler
    {
        public const double Unit = 22.5;

        // Роза ветров ???
        public double WindDirection {  get; set; }
        public double WindSpeed { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double SnowHeight {  get; set; }



        public static double? GradToRadian(double? grad) => grad == null ? null : GetCheckGrad(grad) * (Math.PI / 180);
        public static double RadianToGrad(double rad) => Math.Round(rad * (180 / Math.PI), 1);
        
        public static double? GetCheckGrad(double? grad)
        {
            if (grad == null) return null;
            var result = Math.Round((double)grad, 1);
            if (result % Unit != 0 || grad < 0 || grad >= 360)
                throw new ArgumentException(nameof(grad));
            return result;
        }
    }
}
