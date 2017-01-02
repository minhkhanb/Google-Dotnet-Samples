﻿// Copyright 2017 DAIMTO :  www.daimto.com
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  Methodtemplate.tt
//     Build date: 01/02/2017 22:32:46
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the drive v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages files in Drive including uploading, downloading, searching, detecting changes, and updating sharing permissions.
// API Documentation Link https://developers.google.com/drive/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/drive/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.drive.v2/ 
// Install Command: PM>  Install-Package Google.Apis.drive.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.drive.v2;
using Google.Apis.drive.v2.Data;
using System;

namespace GoogleSamplecSharpSample.drivev2.Methods
{
  
    public static class ChangesSample
    {


        /// <summary>
        /// Gets a specific change. 
        /// Documentation https://developers.google.com/drive/v2/reference/changes/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated drive service.</param>  
        /// <param name="changeId">The ID of the change.</param>
        /// <returns>ChangeResponse</returns>
        public static Change Get(driveService service, string changeId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (changeId == null)
                    throw new ArgumentNullException(changeId);

                // Make the request.
                return service.Changes.Get(changeId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Changes.Get failed.", ex);
            }
        }

        public class ChangesListOptionalParms
        {
            /// Whether to include deleted items.
            public bool IncludeDeleted { get; set; }  
            /// Whether to include public files the user has opened and shared files. When set to false, the list only includes owned files plus any shared or public files the user has explicitly added to a folder they own.
            public bool IncludeSubscribed { get; set; }  
            /// Maximum number of changes to return.
            public int MaxResults { get; set; }  
            /// Page token for changes.
            public string PageToken { get; set; }  
            /// A comma-separated list of spaces to query. Supported values are 'drive', 'appDataFolder' and 'photos'.
            public string Spaces { get; set; }  
            /// Change ID to start listing changes from.
            public string StartChangeId { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the changes for a user. 
        /// Documentation https://developers.google.com/drive/v2/reference/changes/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated drive service.</param>  
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ChangeListResponse</returns>
        public static ChangeList List(driveService service, ChangesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Changes.List();

                // Applying optional parameters to the request.                
                request = (ChangesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Changes.List failed.", ex);
            }
        }

        public class ChangesWatchOptionalParms
        {
            /// Whether to include deleted items.
            public bool IncludeDeleted { get; set; }  
            /// Whether to include public files the user has opened and shared files. When set to false, the list only includes owned files plus any shared or public files the user has explicitly added to a folder they own.
            public bool IncludeSubscribed { get; set; }  
            /// Maximum number of changes to return.
            public int MaxResults { get; set; }  
            /// Page token for changes.
            public string PageToken { get; set; }  
            /// A comma-separated list of spaces to query. Supported values are 'drive', 'appDataFolder' and 'photos'.
            public string Spaces { get; set; }  
            /// Change ID to start listing changes from.
            public string StartChangeId { get; set; }  
        
        }
 
        /// <summary>
        /// Subscribe to changes for a user. 
        /// Documentation https://developers.google.com/drive/v2/reference/changes/watch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated drive service.</param>  
        /// <param name="body">A valid drive v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ChannelResponse</returns>
        public static Channel Watch(driveService service, Channel body, ChangesWatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Changes.Watch(body);

                // Applying optional parameters to the request.                
                request = (ChangesResource.WatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Changes.Watch failed.", ex);
            }
        }

        
	}
		public static class SampleHelpers
    {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}