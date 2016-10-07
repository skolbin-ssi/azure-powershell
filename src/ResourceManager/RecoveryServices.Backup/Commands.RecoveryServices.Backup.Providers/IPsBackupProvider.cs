﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.ServiceClientAdapterNS;
using CmdletModel = Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models;
using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.ProviderModel
{
    /// <summary>
    /// This interface contains methods 
    /// which needs to be implemented by different providers.
    /// </summary>
    public interface IPsBackupProvider
    {
        void Initialize(Dictionary<System.Enum, object> providerData, ServiceClientAdapter serviceClientAdapter);

        Microsoft.Rest.Azure.AzureOperationResponse EnableProtection();

        Microsoft.Rest.Azure.AzureOperationResponse DisableProtection();

        Microsoft.Rest.Azure.AzureOperationResponse TriggerBackup();

        Microsoft.Rest.Azure.AzureOperationResponse TriggerRestore();

        //ProtectedItemResponse GetProtectedItem();
        ProtectedItemResource GetProtectedItem();

        CmdletModel.RecoveryPointBase GetRecoveryPointDetails();

        List<CmdletModel.RecoveryPointBase> ListRecoveryPoints();

        ProtectionPolicyResource CreatePolicy();

        Microsoft.Rest.Azure.AzureOperationResponse<ProtectionPolicyResource> ModifyPolicy();

        SchedulePolicyBase GetDefaultSchedulePolicyObject();

        RetentionPolicyBase GetDefaultRetentionPolicyObject();

        List<ContainerBase> ListProtectionContainers();

        List<CmdletModel.BackupEngineBase> ListBackupManagementServers();

        List<ItemBase> ListProtectedItems();
    }
}
