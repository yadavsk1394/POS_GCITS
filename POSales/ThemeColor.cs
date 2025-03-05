using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSales
{
    public static class ThemeColor
    {
        public static List<string> ColorList = new List<string>() {
    "#2C3E50",  // Dark Blue-Gray (Main Background)
    "#34495E",  // Darker Gray-Blue (Sidebar, Headers)
    "#1ABC9C",  // Teal (Primary Buttons, Highlights)
    "#16A085",  // Dark Teal (Hover/Pressed State)
    "#E74C3C",  // Red (Delete, Warnings, Alerts)
    "#C0392B",  // Dark Red (Critical Warnings)
    "#F39C12",  // Orange (Notifications, Warnings)
    "#D35400",  // Dark Orange (Secondary Highlights)
    "#27AE60",  // Green (Success, Confirmations)
    "#2ECC71",  // Light Green (Positive Indicators)
    "#3498DB",  // Blue (Info Messages, Secondary Buttons)
    "#2980B9",  // Dark Blue (Hover Effects)
    "#9B59B6",  // Purple (Optional Accents)
    "#8E44AD",  // Dark Purple (Branding Elements)
    "#BDC3C7",  // Light Gray (Disabled Elements, Borders)
    "#95A5A6",  // Medium Gray (Background Sections)
    "#7F8C8D",  // Dark Gray (Subtext, Minor UI Elements)
    "#ECF0F1",  // Light Background (Cards, Panels)
    "#F1C40F",  // Yellow (Promotions, Offers)
    "#D7DBDD"   // Soft Gray (Neutral Elements)
};


        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If correction factor is less than 0 , darken color.

            if(correctionFactor <0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }

            // if correction factor si greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
