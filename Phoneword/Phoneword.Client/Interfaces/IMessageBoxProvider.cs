using System.Threading.Tasks;

namespace Phoneword.Client.Interfaces
{
    public interface IMessageBoxProvider
    {
        Task<bool> ShowMessageBox(string title, string content);
    }
}