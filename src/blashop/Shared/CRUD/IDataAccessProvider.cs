using System;
using System.Collections.Generic;

namespace blashop.Shared
{

    public interface IDataAccessProvider
    {
        void AddRecord(CartItem item);
        void UpdateRecord(CartItem item);
        void DeleteRecord(string id);
        User GetSingleRecord(string id);
        List<User> GetRecords();
    }

}
