using System;
using System.Collections.Generic;
using System.Text;
using WpfHamburgerMenuButton.Models;

namespace WpfHamburgerMenuButton.ViewModels
{
    public class MainViewModel
    {
        public string AppName { get; set; } = "Grace Chella";
        public Navigator Navigator { get; set; }
        public MainViewModel()
        {
            Navigator = new Navigator();
        }
    }
}
