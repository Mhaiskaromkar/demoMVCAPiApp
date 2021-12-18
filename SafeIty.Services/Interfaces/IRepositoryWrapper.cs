namespace CrudDemo.BusinessLayer.Services
{
    public interface IRepositoryWrapper
    {
        IRequestMasterService RequestMaster { get; }
        void Save();
    }
}