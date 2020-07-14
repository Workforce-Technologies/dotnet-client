/* 
 * Workforce API
 *
 * Public API for the Workforce software
 *
 * The version of the OpenAPI document: v1
 * Contact: adamlonsdale@me.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Workforce.Client;
using Workforce.Api;
using Workforce.Model;

namespace Workforce.Test
{
    /// <summary>
    ///  Class for testing JobRoleApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class JobRoleApiTests : IDisposable
    {
        private JobRoleApi instance;

        public JobRoleApiTests()
        {
            instance = new JobRoleApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of JobRoleApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' JobRoleApi
            //Assert.IsType(typeof(JobRoleApi), instance, "instance is a JobRoleApi");
        }

        
        /// <summary>
        /// Test JobRoleById
        /// </summary>
        [Fact]
        public void JobRoleByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.JobRoleById(id);
            //Assert.IsType<JobRole> (response, "response is JobRole");
        }
        
        /// <summary>
        /// Test V1JobRoleGet
        /// </summary>
        [Fact]
        public void V1JobRoleGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V1JobRoleGet();
            //Assert.IsType<List<JobRole>> (response, "response is List<JobRole>");
        }
        
        /// <summary>
        /// Test V1JobRolePost
        /// </summary>
        [Fact]
        public void V1JobRolePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //JobRole jobRole = null;
            //instance.V1JobRolePost(jobRole);
            
        }
        
    }

}
