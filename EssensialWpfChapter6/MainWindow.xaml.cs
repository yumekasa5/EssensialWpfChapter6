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
                new MachineInfoStruct(500, "MultiCoptor", 35),
                new MachineInfoStruct(478, "Humanoid", 46),
                new MachineInfoStruct(546, "StanfordManipulator", 78),
                new MachineInfoStruct(789, "AirDrone", 68),
                new MachineInfoStruct(688, "AMG8833", 589)
            };

            //DataGridに追加
            InfoDataGrid.ItemsSource = machines;
        }
    }
}
