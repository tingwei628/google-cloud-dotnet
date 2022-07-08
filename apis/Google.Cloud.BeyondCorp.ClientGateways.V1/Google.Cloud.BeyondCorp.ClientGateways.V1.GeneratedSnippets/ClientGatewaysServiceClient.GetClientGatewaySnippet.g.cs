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

namespace Google.Cloud.BeyondCorp.ClientGateways.V1.Snippets
{
    // [START beyondcorp_v1_generated_ClientGatewaysService_GetClientGateway_sync_flattened]
    using Google.Cloud.BeyondCorp.ClientGateways.V1;

    public sealed partial class GeneratedClientGatewaysServiceClientSnippets
    {
        /// <summary>Snippet for GetClientGateway</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetClientGateway()
        {
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientGateways/[CLIENT_GATEWAY]";
            // Make the request
            ClientGateway response = clientGatewaysServiceClient.GetClientGateway(name);
        }
    }
    // [END beyondcorp_v1_generated_ClientGatewaysService_GetClientGateway_sync_flattened]
}