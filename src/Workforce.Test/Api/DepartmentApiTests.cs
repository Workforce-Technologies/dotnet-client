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
    ///  Class for testing DepartmentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DepartmentApiTests : IDisposable
    {
        private DepartmentApi instance;

        public DepartmentApiTests()
        {
            instance = new DepartmentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DepartmentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DepartmentApi
            //Assert.IsType(typeof(DepartmentApi), instance, "instance is a DepartmentApi");
        }

        
        /// <summary>
        /// Test DepartmentById
        /// </summary>
        [Fact]
        public void DepartmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.DepartmentById(id);
            //Assert.IsType<Department> (response, "response is Department");
        }
        
        /// <summary>
        /// Test V1DepartmentGet
        /// </summary>
        [Fact]
        public void V1DepartmentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V1DepartmentGet();
            //Assert.IsType<List<Department>> (response, "response is List<Department>");
        }
        
        /// <summary>
        /// Test V1DepartmentPost
        /// </summary>
        [Fact]
        public void V1DepartmentPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Department department = null;
            //instance.V1DepartmentPost(department);
            
        }
        
    }

}