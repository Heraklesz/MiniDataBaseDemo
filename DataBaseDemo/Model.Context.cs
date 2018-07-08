using DataBaseDemo.Interfaces;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DataBaseDemo
{
    public partial class CarsDbContext : DbContext, IDataBase<Car>
    {
        public CarsDbContext(IWrapper<Car> wrapper)
            : base("name=CarsDbContext")
        {
            if (wrapper != null)
                AddCarsToDataBase(wrapper);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Car> Cars { get; set; }
        private void AddCarsToDataBase(IWrapper<Car> wrapper)
        {
            foreach (var item in wrapper.List)
                Cars.Add(item);
        }

        public virtual ObservableCollection<Car> GetRedCars(IWrapper<Car> wrapper)
        {
            var redCars = new ObservableCollection<Car>();

            foreach (var item in wrapper.List)
                if (item.Colour == "Red")
                    redCars.Add(item);

            return redCars;
        }

        public virtual ObservableCollection<Car> GetJanosCars(IWrapper<Car> wrapper)
        {
            var janosCars = new ObservableCollection<Car>();

            foreach (var item in wrapper.List)
                if (item.DriverName == "NagyJanos")
                    janosCars.Add(item);

            return janosCars;
        }
    }
}
