// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Channel.V1.Snippets
{
    // [START cloudchannel_v1_generated_CloudChannelService_GetCustomer_sync_flattened_resourceNames]
    using Google.Cloud.Channel.V1;

    public sealed partial class GeneratedCloudChannelServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomer</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetCustomerResourceNames()
        {
            // Create client
            CloudChannelServiceClient cloudChannelServiceClient = CloudChannelServiceClient.Create();
            // Initialize request argument(s)
            CustomerName name = CustomerName.FromAccountCustomer("[ACCOUNT]", "[CUSTOMER]");
            // Make the request
            Customer response = cloudChannelServiceClient.GetCustomer(name);
        }
    }
    // [END cloudchannel_v1_generated_CloudChannelService_GetCustomer_sync_flattened_resourceNames]
}