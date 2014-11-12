using TSBusiness.DataLayer.Contract;
using TSBusiness.DataLayer.Entities;

namespace TSBusiness.DataLayer.Repository
{
    public class UserRepository : BaseRepository<AspNetUser>
    {
        public UserRepository(IUnitOfWork unit) : base(unit) {}
    }
}
