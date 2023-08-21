﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace Diary.Decoration.WindowDecoration
{
    public partial class WindowStyle
    {
        private void WindLoaded(object sender, RoutedEventArgs e)
        {
            (sender as System.Windows.Window).StateChanged += WindStateChanged;
        }

        private void WindStateChanged(object sender, EventArgs e)
        {
            System.Windows.Window me = (sender as System.Windows.Window);
            Button btnResizeCaption = me.Template.FindName("btnResize", me) as Button;
            
        }

        private void btnCloseClick(object sender, RoutedEventArgs e)
        {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window).Close();
        }

        private void btnResizeClick(object sender, RoutedEventArgs e)
        {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
            .WindowState = (((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
            .WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        }

        private void btnHideClick(object sender, RoutedEventArgs e)
        {
            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
            .WindowState = WindowState.Minimized;
        }

        private void gMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                if (((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
                .WindowState == WindowState.Maximized)
                {
                    ((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
                    .WindowState = WindowState.Normal;

                }


            ((sender as FrameworkElement).TemplatedParent as System.Windows.Window)
            .DragMove();
            }
        }
    }
}
