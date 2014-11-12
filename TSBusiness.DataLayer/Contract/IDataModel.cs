using System;

namespace TSBusiness.DataLayer.Contract
{
    public interface IDataModel
    {
        void SetUpdateProperties(Guid userId);
        void SetCreateProperties(Guid userId, Guid organizationId);
    }
}