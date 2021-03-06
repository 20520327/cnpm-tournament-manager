using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QLQA.Command
{
    public static class TitleBarCommand
    {
        public static RoutedCommand CloseWindowCommand { get; set; }
        public static RoutedCommand MaximizeWindowCommand { get; set; }
        public static RoutedCommand MinimizeWindowCommand { get; set; }
        public static RoutedCommand MouseMoveWindowCommand { get; set; }

        static TitleBarCommand()
        {
            CloseWindowCommand = new RoutedCommand();
            CommandManager.RegisterClassCommandBinding(typeof(Window)
                , new CommandBinding(CloseWindowCommand, CloseWindowCommandHandle, TitleBarCommandCanExecute));

            MaximizeWindowCommand = new RoutedCommand();
            CommandManager.RegisterClassCommandBinding(typeof(Window)
                , new CommandBinding(MaximizeWindowCommand, MaximizeWindowCommandHandle, TitleBarCommandCanExecute));

            MinimizeWindowCommand = new RoutedCommand();
            CommandManager.RegisterClassCommandBinding(typeof(Window)
                , new CommandBinding(MinimizeWindowCommand, MinimizeWindowCommandHandle, TitleBarCommandCanExecute));

            MouseMoveWindowCommand = new RoutedCommand();
            CommandManager.RegisterClassCommandBinding(typeof(Window)
                , new CommandBinding(MouseMoveWindowCommand, MouseMoveWindowCommandHandle, TitleBarCommandCanExecute));
        }

        private static void TitleBarCommandCanExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            if (args.Command != CloseWindowCommand && args.Command != MaximizeWindowCommand
                && args.Command != MinimizeWindowCommand && args.Command != MouseMoveWindowCommand)
                return;
            object Parameter = args.Parameter;
            if (Parameter == null || !(Parameter is DependencyObject))
            {
                args.CanExecute = false;
                return;
            }
            args.CanExecute = true;
        }

        private static void CloseWindowCommandHandle(object sender, ExecutedRoutedEventArgs args)
        {
            if (args.Command != CloseWindowCommand)
                return;
            object Parameter = args.Parameter;
            Window.GetWindow(Parameter as DependencyObject)?.Close();
        }

        private static void MaximizeWindowCommandHandle(object sender, ExecutedRoutedEventArgs args)
        {
            if (args.Command != MaximizeWindowCommand)
                return;
            object Parameter = args.Parameter;
            Window parentWindow = Window.GetWindow(Parameter as DependencyObject);
            if (parentWindow != null)
            {
                parentWindow.WindowState = parentWindow.WindowState != WindowState.Maximized
                    ? WindowState.Maximized
                    : WindowState.Normal;
            }
        }

        private static void MinimizeWindowCommandHandle(object sender, ExecutedRoutedEventArgs args)
        {
            if (args.Command != MinimizeWindowCommand)
                return;
            object Parameter = args.Parameter;
            Window parentWindow = Window.GetWindow(Parameter as DependencyObject);
            if (parentWindow != null)
            {
                parentWindow.WindowState = parentWindow.WindowState != WindowState.Minimized
                    ? WindowState.Minimized
                    : WindowState.Normal;
            }
        }

        private static void MouseMoveWindowCommandHandle(object sender, ExecutedRoutedEventArgs args)
        {
            if (args.Command != MouseMoveWindowCommand)
                return;
            object Parameter = args.Parameter;
            Window.GetWindow(Parameter as DependencyObject)?.DragMove();
        }
    }
}
