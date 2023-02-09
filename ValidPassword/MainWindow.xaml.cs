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
using MethodsLib;

namespace ValidPassword
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Добро пожаловать в программу проверки надёжности пароля!");

        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            var pass = tbPass.Text;
            if (pass != "")
            {
                if (MethodsLib.MethodsFromLib.ContainDigit(pass) == false)
                {
                    MessageBox.Show("Пароль не содержит цифры");
                }
                if (MethodsFromLib.ContainMax(pass) == false)
                {
                    MessageBox.Show("Пароль слишком длинный");
                }
                if (!MethodsFromLib.ContainMin(pass))
                {
                    MessageBox.Show("Пароль слишком короткий");
                }
                
               
                if (!MethodsFromLib.ContainsLowerLetter(pass))
                {
                    MessageBox.Show("Пароль не содержит символов нижнего регистра");
                }
                if (!MethodsFromLib.ContainsUpperLetter(pass))
                {
                    MessageBox.Show("Пароль не содержит букв верхнего регистра");
                }
                if(!MethodsFromLib.ContainSpec(pass))
                {
                    MessageBox.Show("Пароль не содержит спец.символов");
                }
                if(MethodsFromLib.ContainDigit(pass)&&
                    MethodsFromLib.ContainMax(pass)&&
                    MethodsFromLib.ContainMin(pass)&&
                    MethodsFromLib.ContainsLowerLetter(pass)&&
                    MethodsFromLib.ContainsUpperLetter(pass)
                    && MethodsFromLib.CorrectPass(pass))
                { MessageBox.Show("Это надёжный пароль"); }
                else
                {
                    MessageBox.Show("Это ненадёжный пароль");
                }
            }
            else
            {
                MessageBox.Show("Введите пароль");
            }
        }
    }
}
