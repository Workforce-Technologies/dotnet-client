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

namespace Workforce.Test.Api
{
    /// <summary>
    ///  Class for testing ImageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ImageApiTests : IDisposable
    {
        private ImageApi instance;

        public ImageApiTests()
        {
            instance = new ImageApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ImageApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ImageApi
            //Assert.IsType<ImageApi>(instance);
        }

        /// <summary>
        /// Test V1ImagesEmployeeGet
        /// </summary>
        [Fact]
        public void V1ImagesEmployeeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? width = null;
            //int? height = null;
            //instance.V1ImagesEmployeeGet(id, width, height);
        }
    }
}