using CrudDemo.BusinessLayer.Services;
using SafeIty.Repository.Models;
using SafeIty.Services.interfaces;

namespace SafeIty.Services.Implementation
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private SafeItyContext _repoContext;
        private IRequestMasterService _requestMaster;

        public IRequestMasterService RequestMaster
        {
            get
            {
                if (_requestMaster == null)
                {
                    _requestMaster = new RequestMasterService(_repoContext);
                }
                return _requestMaster;
            }
        }


        public RepositoryWrapper(SafeItyContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}