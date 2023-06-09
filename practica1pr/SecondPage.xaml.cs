﻿using practica1pr.AORUSDataSetTableAdapters;
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

namespace practica1pr
{
    
    public partial class SecondPage : Page
    {
        PickturesTableAdapter pictures = new PickturesTableAdapter();
        public SecondPage()
        {
            InitializeComponent();
            ColorDataGrid.ItemsSource = pictures.GetData();
            ColorDataGrid.DisplayMemberPath = "picktures_name";
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pictures.InsertQuery(PaintPictures.Text);
            ColorDataGrid.ItemsSource = pictures.GetData();
            
        }
    }
}
