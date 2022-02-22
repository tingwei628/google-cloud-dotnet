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

namespace Google.Cloud.Datastream.V1Alpha1.Snippets
{
    // [START datastream_v1alpha1_generated_Datastream_CreateConnectionProfile_sync_flattened]
    using Google.Cloud.Datastream.V1Alpha1;
    using Google.LongRunning;

    public sealed partial class GeneratedDatastreamClientSnippets
    {
        /// <summary>Snippet for CreateConnectionProfile</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateConnectionProfile()
        {
            // Create client
            DatastreamClient datastreamClient = DatastreamClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ConnectionProfile connectionProfile = new ConnectionProfile();
            string connectionProfileId = "";
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = datastreamClient.CreateConnectionProfile(parent, connectionProfile, connectionProfileId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = datastreamClient.PollOnceCreateConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END datastream_v1alpha1_generated_Datastream_CreateConnectionProfile_sync_flattened]
}