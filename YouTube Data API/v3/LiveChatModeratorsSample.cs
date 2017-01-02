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
//     Build date: 01/02/2017 22:34:59
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the YouTube v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Supports core YouTube features, such as uploading videos, creating and managing playlists, searching for content, and much more.
// API Documentation Link https://developers.google.com/youtube/v3
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/YouTube/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.YouTube.v3/ 
// Install Command: PM>  Install-Package Google.Apis.YouTube.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;

namespace GoogleSamplecSharpSample.YouTubev3.Methods
{
  
    public static class LiveChatModeratorsSample
    {


        /// <summary>
        /// Removes a chat moderator. 
        /// Documentation https://developers.google.com/youtube/v3/reference/liveChatModerators/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated YouTube service.</param>  
        /// <param name="id">The id parameter identifies the chat moderator to remove. The value uniquely identifies both the moderator and the chat.</param>
        public static void Delete(YouTubeService service, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.LiveChatModerators.Delete(id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LiveChatModerators.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Adds a new moderator for the chat. 
        /// Documentation https://developers.google.com/youtube/v3/reference/liveChatModerators/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated YouTube service.</param>  
        /// <param name="part">The part parameter serves two purposes in this operation. It identifies the properties that the write operation will set as well as the properties that the API response returns. Set the parameter value to snippet.</param>
        /// <param name="body">A valid YouTube v3 body.</param>
        /// <returns>LiveChatModeratorResponse</returns>
        public static LiveChatModerator Insert(YouTubeService service, string part, LiveChatModerator body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (part == null)
                    throw new ArgumentNullException(part);

                // Make the request.
                return service.LiveChatModerators.Insert(body, part).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LiveChatModerators.Insert failed.", ex);
            }
        }

        public class LiveChatModeratorsListOptionalParms
        {
            /// The maxResults parameter specifies the maximum number of items that should be returned in the result set.
            public int MaxResults { get; set; }  
            /// The pageToken parameter identifies a specific page in the result set that should be returned. In an API response, the nextPageToken and prevPageToken properties identify other pages that could be retrieved.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists moderators for a live chat. 
        /// Documentation https://developers.google.com/youtube/v3/reference/liveChatModerators/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated YouTube service.</param>  
        /// <param name="liveChatId">The liveChatId parameter specifies the YouTube live chat for which the API should return moderators.</param>
        /// <param name="part">The part parameter specifies the liveChatModerator resource parts that the API response will include. Supported values are id and snippet.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>LiveChatModeratorListResponseResponse</returns>
        public static LiveChatModeratorListResponse List(YouTubeService service, string liveChatId, string part, LiveChatModeratorsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (liveChatId == null)
                    throw new ArgumentNullException(liveChatId);
                if (part == null)
                    throw new ArgumentNullException(part);

                // Building the initial request.
                var request = service.LiveChatModerators.List(liveChatId, part);

                // Applying optional parameters to the request.                
                request = (LiveChatModeratorsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LiveChatModerators.List failed.", ex);
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