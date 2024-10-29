using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lib_14
{

  
    public class Liquid
    {

        public string Name { get; set; }
        public int Density { get; set; }
        public int Volume { get; set; }
        /// <summary>
        /// метод для присваивания характеристик
        /// </summary>
        /// <param name="name">название жидкости</param>
        /// <param name="density">плотность жидкости</param>
        /// <param name="volume">объём жидкости</param>
        public void SetParams(string name, int density, int volume)
        {
            Name = name;
            Density = density;
            Volume = volume;
        }
        /// <summary>
        /// метод для присваивания характеристик
        /// </summary>
        /// <param name="density">плотность жидкости</param>
        /// <param name="volume">объём жидкости</param>
        public void SetParams(int density, int volume)
        {
            Density = density;
            Volume = volume;
        }
        /// <summary>
        /// метод для присваивания характеристик
        /// </summary>
        /// <param name="volume">объём жидкости</param>
        public void SetParams(int volume)
        {
            Volume = volume;
        }
        /// <summary>
        /// метод для присваивания характеристик
        /// </summary>
        /// <param name="name">название жидкости</param>
        public void SetParams(string name)
        {
            Name = name;
        }
        /// <summary>
        /// метод для присваивания характеристик
        /// </summary>
        /// <param name="name">название жидкости</param>
        /// <param name="density">плотность жидкости</param>
        public void SetParams(string name, int density)
        {
            Name = name;
            Density = density;
        }
        /// <summary>
        /// метод для присваивания характеристик
        /// </summary>
        /// <param name="density">плотность жидкости</param>
        public void SetParams(double density)
        {

            Density = (int)density;
        }
        /// <summary>
        /// метод для присваивания характеристик
        /// </summary>
        /// <param name="name">название жидкости</param>
        /// <param name="volume">объём жидкости</param>
        public void SetParams(string name, double volume)
        {
            Name = name;
            Volume = (int)volume;
        }


    }

}
