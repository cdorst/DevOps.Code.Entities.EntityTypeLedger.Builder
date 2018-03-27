// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

namespace DevOps.Code.Entities.EntityTypeLedger.Builder
{
    /// <summary>Function returns an instance of EntityTypeTable</summary>
    public static class EntityTypeTableHelper
    {
        /// <summary>Returns an instance of EntityTypeTable</summary>
        public static EntityTypeTable EntityTypeTableEntry(string accountName, string repositoryName, int entityTypeId) => new EntityTypeTable(accountName, repositoryName, entityTypeId);
    }
}
