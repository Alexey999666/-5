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
        /// ����� ��� ������������ �������������
        /// </summary>
        /// <param name="name">�������� ��������</param>
        /// <param name="density">��������� ��������</param>
        /// <param name="volume">����� ��������</param>
        public void SetParams(string name, int density, int volume)
        {
            Name = name;
            Density = density;
            Volume = volume;
        }
        /// <summary>
        /// ����� ��� ������������ �������������
        /// </summary>
        /// <param name="density">��������� ��������</param>
        /// <param name="volume">����� ��������</param>
        public void SetParams(int density, int volume)
        {
            Density = density;
            Volume = volume;
        }
        /// <summary>
        /// ����� ��� ������������ �������������
        /// </summary>
        /// <param name="volume">����� ��������</param>
        public void SetParams(int volume)
        {
            Volume = volume;
        }
        /// <summary>
        /// ����� ��� ������������ �������������
        /// </summary>
        /// <param name="name">�������� ��������</param>
        public void SetParams(string name)
        {
            Name = name;
        }
        /// <summary>
        /// ����� ��� ������������ �������������
        /// </summary>
        /// <param name="name">�������� ��������</param>
        /// <param name="density">��������� ��������</param>
        public void SetParams(string name, int density)
        {
            Name = name;
            Density = density;
        }
        /// <summary>
        /// ����� ��� ������������ �������������
        /// </summary>
        /// <param name="density">��������� ��������</param>
        public void SetParams(double density)
        {

            Density = (int)density;
        }
        /// <summary>
        /// ����� ��� ������������ �������������
        /// </summary>
        /// <param name="name">�������� ��������</param>
        /// <param name="volume">����� ��������</param>
        public void SetParams(string name, double volume)
        {
            Name = name;
            Volume = (int)volume;
        }


    }

}
