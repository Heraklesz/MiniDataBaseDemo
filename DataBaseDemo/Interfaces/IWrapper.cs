using System.Collections.ObjectModel;

namespace DataBaseDemo
{
    public interface IWrapper<T>
    {
        ObservableCollection<T> List { get; set; }
        void LoadFile(params string[] path);
    }
}
