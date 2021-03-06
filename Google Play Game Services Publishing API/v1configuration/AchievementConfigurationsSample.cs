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
//     Build date: 01/02/2017 22:32:57
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the GamesConfiguration v1configuration API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Publishing API for Google Play Game Services.
// API Documentation Link https://developers.google.com/games/services
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/GamesConfiguration/v1configuration/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.GamesConfiguration.v1configuration/ 
// Install Command: PM>  Install-Package Google.Apis.GamesConfiguration.v1configuration
//
//------------------------------------------------------------------------------  
using Google.Apis.GamesConfiguration.v1configuration;
using Google.Apis.GamesConfiguration.v1configuration.Data;
using System;

namespace GoogleSamplecSharpSample.GamesConfigurationv1configuration.Methods
{
  
    public static class AchievementConfigurationsSample
    {


        /// <summary>
        /// Delete the achievement configuration with the given ID. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/achievementConfigurations/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated GamesConfiguration service.</param>  
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        public static void Delete(GamesConfigurationService service, string achievementId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (achievementId == null)
                    throw new ArgumentNullException(achievementId);

                // Make the request.
                return service.AchievementConfigurations.Delete(achievementId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request AchievementConfigurations.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Retrieves the metadata of the achievement configuration with the given ID. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/achievementConfigurations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated GamesConfiguration service.</param>  
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        /// <returns>AchievementConfigurationResponse</returns>
        public static AchievementConfiguration Get(GamesConfigurationService service, string achievementId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (achievementId == null)
                    throw new ArgumentNullException(achievementId);

                // Make the request.
                return service.AchievementConfigurations.Get(achievementId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request AchievementConfigurations.Get failed.", ex);
            }
        }


        /// <summary>
        /// Insert a new achievement configuration in this application. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/achievementConfigurations/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated GamesConfiguration service.</param>  
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        /// <param name="body">A valid GamesConfiguration v1configuration body.</param>
        /// <returns>AchievementConfigurationResponse</returns>
        public static AchievementConfiguration Insert(GamesConfigurationService service, string applicationId, AchievementConfiguration body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (applicationId == null)
                    throw new ArgumentNullException(applicationId);

                // Make the request.
                return service.AchievementConfigurations.Insert(body, applicationId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request AchievementConfigurations.Insert failed.", ex);
            }
        }

        public class AchievementConfigurationsListOptionalParms
        {
            /// The maximum number of resource configurations to return in the response, used for paging. For any response, the actual number of resources returned may be less than the specified maxResults.
            public int MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a list of the achievement configurations in this application. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/achievementConfigurations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated GamesConfiguration service.</param>  
        /// <param name="applicationId">The application ID from the Google Play developer console.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>AchievementConfigurationListResponseResponse</returns>
        public static AchievementConfigurationListResponse List(GamesConfigurationService service, string applicationId, AchievementConfigurationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (applicationId == null)
                    throw new ArgumentNullException(applicationId);

                // Building the initial request.
                var request = service.AchievementConfigurations.List(applicationId);

                // Applying optional parameters to the request.                
                request = (AchievementConfigurationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request AchievementConfigurations.List failed.", ex);
            }
        }


        /// <summary>
        /// Update the metadata of the achievement configuration with the given ID. This method supports patch semantics. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/achievementConfigurations/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated GamesConfiguration service.</param>  
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        /// <param name="body">A valid GamesConfiguration v1configuration body.</param>
        /// <returns>AchievementConfigurationResponse</returns>
        public static AchievementConfiguration Patch(GamesConfigurationService service, string achievementId, AchievementConfiguration body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (achievementId == null)
                    throw new ArgumentNullException(achievementId);

                // Make the request.
                return service.AchievementConfigurations.Patch(body, achievementId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request AchievementConfigurations.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Update the metadata of the achievement configuration with the given ID. 
        /// Documentation https://developers.google.com/gamesconfiguration/v1configuration/reference/achievementConfigurations/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated GamesConfiguration service.</param>  
        /// <param name="achievementId">The ID of the achievement used by this method.</param>
        /// <param name="body">A valid GamesConfiguration v1configuration body.</param>
        /// <returns>AchievementConfigurationResponse</returns>
        public static AchievementConfiguration Update(GamesConfigurationService service, string achievementId, AchievementConfiguration body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (achievementId == null)
                    throw new ArgumentNullException(achievementId);

                // Make the request.
                return service.AchievementConfigurations.Update(body, achievementId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request AchievementConfigurations.Update failed.", ex);
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