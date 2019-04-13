using System.Threading.Tasks;

namespace BlazorMVVM.ViewModels
{
    public interface ILoadable
    {
         Task Load();
    }
}