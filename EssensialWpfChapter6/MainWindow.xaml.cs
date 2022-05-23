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
using MahApps.Metro.Controls;

namespace EssensialWpfChapter6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        //機器情報のリスト
        private List<MachineInfoStruct> machines;
        
        public MainWindow()
        {
            InitializeComponent();

            //DataGridに行を追加
            machines = new List<MachineInfoStruct>
            {
                new MachineInfoStruct(7000, "VL53L0x", 9999),
                new MachineInfoStruct(5000, "MPU9250", 9999),
                new MachineInfoStruct(5460, "MC023CG-SY", 9999),
                new MachineInfoStruct(7890, "MC023MG-SY", 68),
                new MachineInfoStruct(6880, "AMG8833", 589),
                new MachineInfoStruct(5660, "HC-SR04", 600),
                new MachineInfoStruct(5661, "MC031CG-SY", 700)
            };

            //DataGridに追加
            InfoDataGrid.ItemsSource = machines;
        }
    }
}
