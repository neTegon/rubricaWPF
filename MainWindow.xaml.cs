﻿using System;
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

namespace tegon.elettra._4i.rubricaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Contatto c = new Contatto();
            c.Numero = 1;
            c.Nome = "Elettra";
            c.Cognome = "Tegon";
            Contatto[] Contatti= new Contatto[100];
            Contatti[0] = c;
            Contatti[1].Nome = "Riccardo";
            Contatti[1].Cognome = "Bianchi";
        }
    }
}
