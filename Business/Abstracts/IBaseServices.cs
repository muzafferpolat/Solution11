using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IBaseServices
    {
        void GetAll();
        void Add();
        void Delete();
        void Update();
    }
}
