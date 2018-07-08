using System.Xml;
using System.Collections.ObjectModel;

namespace DataBaseDemo
{
    class XmlWrapper : IWrapper<Car>
    {
        ObservableCollection<Car> List = new ObservableCollection<Car>();
        public XmlWrapper(params string[] path)
        {
            if (path != null)
                LoadFile(path);
        }

        ObservableCollection<Car> IWrapper<Car>.List
        {  get {  return List; }
           set { List = value; }
        }

        public void LoadFile(params string[] path)
        {
            foreach (var item in path)
            {
            using (XmlReader reader = XmlReader.Create(item))
                {
                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Car"))
                        {
                            var carType = reader.GetAttribute("Type");
                            var carRegisteredNumber = reader.GetAttribute("RegisteredNumber");
                            var carColor = reader.GetAttribute("Color");
                            var carDriverName = reader.GetAttribute("DriverName");

                            var car = new Car()
                            {
                                Type = carType.ToString(),
                                RegisteredNumber = carRegisteredNumber.ToString(),
                                Colour = carColor.ToString(),
                                DriverName = carDriverName.ToString()
                            };
                            List.Add(car);
                        }

                    }
                }
            }
        }
    }
}
