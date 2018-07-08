using System.ComponentModel;
using System.Data.Entity;
using System.Windows;

namespace DataBaseDemo
{
    public partial class MainWindow : Window
    {
        private const string path = "CarsDoc.xml";
        private const string anotherPath = "AnotherCarDoc.xml";
        private IWrapper<Car> xmlWrapper = new XmlWrapper(path, anotherPath);
        private CarsDbContext carsContext;
        public MainWindow()
        {
            InitializeComponent();
            carsContext = new CarsDbContext(xmlWrapper);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource carViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carViewSource")));
            carsContext.Cars.Load();
            carViewSource.Source = carsContext.Cars.Local;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            carsContext.Dispose();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var result = carsContext.GetRedCars(xmlWrapper);
            foreach (var item in result)
                listBox.Items.Add(item.DriverName + " " + item.Type + " " + item.RegisteredNumber + " " + item.Colour);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var result = carsContext.GetJanosCars(xmlWrapper);
            foreach (var item in result)
                listBox1.Items.Add(item.DriverName + " " + item.Type + " " + item.RegisteredNumber + " " + item.Colour);
        }
    }
}
