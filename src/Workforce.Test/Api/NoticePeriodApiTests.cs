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
    ///  Class for testing NoticePeriodApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class NoticePeriodApiTests : IDisposable
    {
        private NoticePeriodApi instance;

        public NoticePeriodApiTests()
        {
            instance = new NoticePeriodApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NoticePeriodApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NoticePeriodApi
            //Assert.IsType(typeof(NoticePeriodApi), instance, "instance is a NoticePeriodApi");
        }

        
        /// <summary>
        /// Test NoticePeriodById
        /// </summary>
        [Fact]
        public void NoticePeriodByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.NoticePeriodById(id);
            //Assert.IsType<NoticePeriod> (response, "response is NoticePeriod");
        }
        
        /// <summary>
        /// Test V1NoticePeriodGet
        /// </summary>
        [Fact]
        public void V1NoticePeriodGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V1NoticePeriodGet();
            //Assert.IsType<List<NoticePeriod>> (response, "response is List<NoticePeriod>");
        }
        
        /// <summary>
        /// Test V1NoticePeriodPost
        /// </summary>
        [Fact]
        public void V1NoticePeriodPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NoticePeriod noticePeriod = null;
            //instance.V1NoticePeriodPost(noticePeriod);
            
        }
        
    }

}