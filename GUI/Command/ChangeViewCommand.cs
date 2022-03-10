using GUI.Views.MainWindow;
using MaterialDesignThemes.Wpf;
using GUI.Views.Pages;
using GUI.Views.MainWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QLQA.Command
{
    public static class ChangeViewCommand
    {
        public static RoutedCommand Command { get; set; }

        //static ChangeViewCommand()
        //{
        //    Command = new RoutedCommand();
        //    CommandManager.RegisterClassCommandBinding(typeof(Page)
        //        , new CommandBinding(Command, Handle, Condition));
        //}

        //private static void Condition(object sender, CanExecuteRoutedEventArgs args)
        //{
        //    if (args.Command != Command)
        //        return;
        //    object Parameter = args.Parameter;
        //    if (Parameter != null && MainWindow. != null)
        //    {
        //        args.CanExecute = true;
        //    }
        //    else
        //    {
        //        args.CanExecute = false;
        //        return;
        //    }
        //}

        //private static void Handle(object sender, ExecutedRoutedEventArgs args)
        //{
        //    if (args.Command != Command)
        //        return;
        //    object Parameter = args.Parameter;
        //    if (Parameter is AccountView && SQL.lg.ROLEid != 0)
        //    {
        //        QLQA.Notification.ViewModel.ViewModel dia = new QLQA.Notification.ViewModel.ViewModel("Bạn không có quyền truy cập !");
        //        QLQA.Notification.WrongPass b = new QLQA.Notification.WrongPass();
        //        b.DataContext = dia;
        //        DialogHost.Show(b, "main");
        //        return;
        //    }
        //    if (Parameter is EmployeeView && SQL.lg.ROLEid != 0)
        //    {
        //        QLQA.Notification.ViewModel.ViewModel dia = new QLQA.Notification.ViewModel.ViewModel("Bạn không có quyền truy cập !");
        //        QLQA.Notification.WrongPass b = new QLQA.Notification.WrongPass();
        //        b.DataContext = dia;
        //        DialogHost.Show(b, "main");
        //        return;
        //    }
        //    QAWindow.Instance.DataContext = Parameter;
        //}
        
    }
}
