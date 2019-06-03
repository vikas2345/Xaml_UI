using System;
using System.Collections.Generic;
using System.Text;

namespace Xamls.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        QuestionsPage,
        ChameleonUI,
        DataBindingPage,
        WeatherPage

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
