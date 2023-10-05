using Pedro.Domain.Cores.Repositories;
using Pedro.Domain.Generals.Models;

namespace Pedro.Domain.Generals.Repositories
{
    public interface INotificationRepository: ICrudRepository<Notification,int>
    {
    }
}
