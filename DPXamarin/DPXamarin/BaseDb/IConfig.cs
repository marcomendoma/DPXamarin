
using SQLite.Net.Interop;

namespace DPXamarin.BaseDb
{
    public interface IConfig
    {
        string DiretorioDB { get; }
        ISQLitePlatform Plataforma { get; }
    }
}
