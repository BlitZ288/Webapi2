using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi2
{
    [Serializable]

    public class Window
    {
        public int Id { get; set; }
        /// <summary>
        /// Количество окон
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Ширина окна
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Длинна окна
        /// </summary>
        public double Lenght { get; set; }
        /// <summary>
        /// Площадь
        /// </summary>
        public double S { get; set; }
        /// <summary>
        /// Периметр 
        /// </summary>
        public double P { get; set; }
        /// <summary>
        /// Конечная стоимость
        /// </summary>
        public double Result { get; set; }

    }
}
