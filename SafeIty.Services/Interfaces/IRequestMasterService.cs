using System;
using SafeIty.Repository.Interface;
using SafeIty.Repository.Models;

namespace SafeIty.Services.interfaces
{
 public interface IRequestMasterService :  IRepositoryBase<RequestMaster>
    {
        void AddRequestMasterAsync(RequestMaster requestMaster);
    }
}