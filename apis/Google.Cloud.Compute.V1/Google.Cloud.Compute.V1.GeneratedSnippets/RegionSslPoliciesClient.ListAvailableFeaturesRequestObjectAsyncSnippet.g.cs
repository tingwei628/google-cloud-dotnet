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

namespace Google.Cloud.Compute.V1.Snippets
{
    // [START compute_v1_generated_RegionSslPolicies_ListAvailableFeatures_async]
    using Google.Cloud.Compute.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRegionSslPoliciesClientSnippets
    {
        /// <summary>Snippet for ListAvailableFeaturesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ListAvailableFeaturesRequestObjectAsync()
        {
            // Create client
            RegionSslPoliciesClient regionSslPoliciesClient = await RegionSslPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListAvailableFeaturesRegionSslPoliciesRequest request = new ListAvailableFeaturesRegionSslPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslPoliciesListAvailableFeaturesResponse response = await regionSslPoliciesClient.ListAvailableFeaturesAsync(request);
        }
    }
    // [END compute_v1_generated_RegionSslPolicies_ListAvailableFeatures_async]
}