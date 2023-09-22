using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace ProfessionalTest
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Обработчик события запуска приложения
        private void OnStartup(object sender, StartupEventArgs e)
        {
            //Для текущего домена приложения вешаем свой обработчик в котором и будем вручную подсовывать нужные сборки
            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;
        }

        //Наш обработчик для резолва сборок
        static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            //Получаем текущую сборку которая выполняется(чтобы из нее брать ресурсы)
            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            //Формируем имя ресурса
            var name = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";
            //Находим ресурс по имени
            var resourceName = thisAssembly.GetManifestResourceNames().First(s => s.EndsWith(name));

            using (Stream stream = thisAssembly.GetManifestResourceStream(resourceName))
            {
                //Считываем ресурс в массив байтов
                byte[] block = new byte[stream.Length];
                stream.Read(block, 0, block.Length);
                //Загружаем сборку из массива байтов в текущий домен приложения и возвращаем её
                return Assembly.Load(block);
            }
        }
    }
}
