using MovieLibirary.Classes;
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

namespace MovieLibirary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MiddleClass middleClass = new MiddleClass();
        public int columnPos = 1;
        public int rowPos = 1;
        public MainWindow()
        {
            InitializeComponent();
            middleClass.changeMovie();
            makeImage();
        }

        private void makeImage()
        {
            for(int i = 0; i < middleClass.Movies.Count; i++)
            {
                if(columnPos == 11)
                {
                    columnPos = 1;
                    rowPos += 2;
                }
                BitmapImage movieImg = new BitmapImage(new Uri(@$"{middleClass.Movies[i].Url}"));

                Image movieImage = new Image();
                movieImage.Source = movieImg;
                movieImage.Tag = middleClass.Movies[i].Name;
                Grid.SetColumn(movieImage, columnPos);
                Grid.SetRow(movieImage, rowPos);
                columnPos += 2;
                if (columnPos == 13 && rowPos == 3)
                {
                    columnPos = 1;
                    rowPos = 1;
                    secondPage.Children.Add(movieImage);
                }
                else
                {
                    firstPage.Children.Add(movieImage);

                }
            }
        }
    }
}
