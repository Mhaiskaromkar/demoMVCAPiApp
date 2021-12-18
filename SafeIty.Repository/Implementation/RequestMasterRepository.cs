
using System;
using SafeIty.Repository.Implementation;
using SafeIty.Repository.Interface;
using SafeIty.Repository.Models;

namespace SafeIty.Repository
{


public class RequestMasterRepository : RepositoryBase<RequestMaster>, IRequestMasterRepository
    {
        public RequestMasterRepository(SafeItyContext context) : base(context)
        {
        }

        public void CreateRequestMaster(RequestMaster requestMaster)
        {
               Create(requestMaster);
        }
    }
}