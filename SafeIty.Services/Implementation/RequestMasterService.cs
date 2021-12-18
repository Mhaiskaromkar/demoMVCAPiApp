using System;
using System.Threading.Tasks;
using SafeIty.Repository.Implementation;
using SafeIty.Repository.Interface;
using SafeIty.Repository.Models;
using SafeIty.Services.interfaces;

namespace SafeIty.Services.Implementation
{
public class RequestMasterService :  RepositoryBase<RequestMaster> ,IRequestMasterService
    {
        private readonly IRequestMasterRepository _requestMasterRepository;

        public RequestMasterService(SafeItyContext safeItyContext): base(safeItyContext)
        {
            
        }

        public  void AddRequestMasterAsync(RequestMaster requestMaster)
        {
           Create(requestMaster);
        }
    }
}