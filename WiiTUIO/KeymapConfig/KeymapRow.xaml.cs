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
using WiiTUIO.Provider;

namespace WiiTUIO
{
    /// <summary>
    /// Interaction logic for LayoutSelectionRow.xaml
    /// </summary>
    public partial class KeymapRow : UserControl
    {
        private Keymap keymap;

        public Action<Keymap> OnClick; //filename

        public KeymapRow(Keymap keymap)
        {
            InitializeComponent();
            this.keymap = keymap;
            this.tbName.Text = keymap.getName();
        }

        private void tbName_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (OnClick != null)
            {
                OnClick(this.keymap);
            }
        }



    }
}
