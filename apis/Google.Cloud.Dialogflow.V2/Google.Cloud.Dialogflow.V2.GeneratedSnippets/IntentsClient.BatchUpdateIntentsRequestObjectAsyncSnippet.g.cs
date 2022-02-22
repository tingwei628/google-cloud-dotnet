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

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    // [START dialogflow_v2_generated_Intents_BatchUpdateIntents_async]
    using Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedIntentsClientSnippets
    {
        /// <summary>Snippet for BatchUpdateIntentsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task BatchUpdateIntentsRequestObjectAsync()
        {
            // Create client
            IntentsClient intentsClient = await IntentsClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateIntentsRequest request = new BatchUpdateIntentsRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                IntentBatchUri = "",
                LanguageCode = "",
                UpdateMask = new FieldMask(),
                IntentView = IntentView.Unspecified,
            };
            // Make the request
            Operation<BatchUpdateIntentsResponse, Struct> response = await intentsClient.BatchUpdateIntentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateIntentsResponse, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchUpdateIntentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateIntentsResponse, Struct> retrievedResponse = await intentsClient.PollOnceBatchUpdateIntentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateIntentsResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dialogflow_v2_generated_Intents_BatchUpdateIntents_async]
}