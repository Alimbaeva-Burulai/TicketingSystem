// <copyright file="CardTypeToBrushConverter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TicketingSystem.WPF.UI
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Data;
    using System.Windows.Media;
    using TicketingSystem.WPF.Data;

    /// <summary>
    /// This class .
    /// </summary>
    public class CardTypeToBrushConverter : IValueConverter
    {
        /// <inheritdoc/>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string cardType = (string)value;
            if (cardType == "Mastercard" || cardType == "Visa")
            {
                return Brushes.Green;
            }
            else
            {
                return Brushes.LightGray;
            }
        }

        /// <inheritdoc/>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
