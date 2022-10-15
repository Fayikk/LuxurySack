using Core.Entities.Concrete;

namespace Businness.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string mail);
    }
}
