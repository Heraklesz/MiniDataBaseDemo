using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseDemo.Interfaces
{
    public interface IDataBase<T>
    {
        ObservableCollection<Car> GetRedCars(IWrapper<T> wrapper);
        ObservableCollection<Car> GetJanosCars(IWrapper<T> wrapper);
    }
}
