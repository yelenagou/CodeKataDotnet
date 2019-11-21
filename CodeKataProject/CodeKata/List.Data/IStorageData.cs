using List.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace List.Data
{
    /// <summary>
    ///     Interface used by CodeKata_OnPost
    ///     Get storage information
    /// </summary>
   public interface IStorageData
    {
        IEnumerable<StorageInfo> GetStorageInfo();
    }
   
}
