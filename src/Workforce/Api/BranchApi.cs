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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Workforce.Client;
using Workforce.Model;

namespace Workforce.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBranchApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a specific Branch from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Branch</param>
        /// <returns>Branch</returns>
        Branch BranchById (Guid id);

        /// <summary>
        /// Get a specific Branch from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Branch</param>
        /// <returns>ApiResponse of Branch</returns>
        ApiResponse<Branch> BranchByIdWithHttpInfo (Guid id);
        /// <summary>
        /// Get all Branches within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Branch&gt;</returns>
        List<Branch> V1BranchGet ();

        /// <summary>
        /// Get all Branches within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Branch&gt;</returns>
        ApiResponse<List<Branch>> V1BranchGetWithHttpInfo ();
        /// <summary>
        /// Add a new Branch to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="branch"> (optional)</param>
        /// <returns></returns>
        void V1BranchPost (Branch branch = default(Branch));

        /// <summary>
        /// Add a new Branch to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="branch"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1BranchPostWithHttpInfo (Branch branch = default(Branch));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBranchApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get a specific Branch from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Branch</param>
        /// <returns>Task of Branch</returns>
        System.Threading.Tasks.Task<Branch> BranchByIdAsync (Guid id);

        /// <summary>
        /// Get a specific Branch from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Branch</param>
        /// <returns>Task of ApiResponse (Branch)</returns>
        System.Threading.Tasks.Task<ApiResponse<Branch>> BranchByIdAsyncWithHttpInfo (Guid id);
        /// <summary>
        /// Get all Branches within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Branch&gt;</returns>
        System.Threading.Tasks.Task<List<Branch>> V1BranchGetAsync ();

        /// <summary>
        /// Get all Branches within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Branch&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Branch>>> V1BranchGetAsyncWithHttpInfo ();
        /// <summary>
        /// Add a new Branch to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="branch"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1BranchPostAsync (Branch branch = default(Branch));

        /// <summary>
        /// Add a new Branch to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="branch"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1BranchPostAsyncWithHttpInfo (Branch branch = default(Branch));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBranchApi : IBranchApiSync, IBranchApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BranchApi : IBranchApi
    {
        private Workforce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BranchApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BranchApi(String basePath)
        {
            this.Configuration = Workforce.Client.Configuration.MergeConfigurations(
                Workforce.Client.GlobalConfiguration.Instance,
                new Workforce.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Workforce.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Workforce.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Workforce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BranchApi(Workforce.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Workforce.Client.Configuration.MergeConfigurations(
                Workforce.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Workforce.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Workforce.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Workforce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BranchApi(Workforce.Client.ISynchronousClient client,Workforce.Client.IAsynchronousClient asyncClient, Workforce.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Workforce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Workforce.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Workforce.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Workforce.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Workforce.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get a specific Branch from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Branch</param>
        /// <returns>Branch</returns>
        public Branch BranchById (Guid id)
        {
             Workforce.Client.ApiResponse<Branch> localVarResponse = BranchByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific Branch from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Branch</param>
        /// <returns>ApiResponse of Branch</returns>
        public Workforce.Client.ApiResponse< Branch > BranchByIdWithHttpInfo (Guid id)
        {
            Workforce.Client.RequestOptions localVarRequestOptions = new Workforce.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Workforce.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Workforce.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Workforce.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< Branch >("/v1/Branch/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BranchById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a specific Branch from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Branch</param>
        /// <returns>Task of Branch</returns>
        public async System.Threading.Tasks.Task<Branch> BranchByIdAsync (Guid id)
        {
             Workforce.Client.ApiResponse<Branch> localVarResponse = await BranchByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a specific Branch from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Branch</param>
        /// <returns>Task of ApiResponse (Branch)</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<Branch>> BranchByIdAsyncWithHttpInfo (Guid id)
        {

            Workforce.Client.RequestOptions localVarRequestOptions = new Workforce.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("id", Workforce.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Branch>("/v1/Branch/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BranchById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Branches within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Branch&gt;</returns>
        public List<Branch> V1BranchGet ()
        {
             Workforce.Client.ApiResponse<List<Branch>> localVarResponse = V1BranchGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Branches within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Branch&gt;</returns>
        public Workforce.Client.ApiResponse< List<Branch> > V1BranchGetWithHttpInfo ()
        {
            Workforce.Client.RequestOptions localVarRequestOptions = new Workforce.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Workforce.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Workforce.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< List<Branch> >("/v1/Branch", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1BranchGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Branches within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Branch&gt;</returns>
        public async System.Threading.Tasks.Task<List<Branch>> V1BranchGetAsync ()
        {
             Workforce.Client.ApiResponse<List<Branch>> localVarResponse = await V1BranchGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Branches within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Branch&gt;)</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<List<Branch>>> V1BranchGetAsyncWithHttpInfo ()
        {

            Workforce.Client.RequestOptions localVarRequestOptions = new Workforce.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Branch>>("/v1/Branch", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1BranchGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a new Branch to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="branch"> (optional)</param>
        /// <returns></returns>
        public void V1BranchPost (Branch branch = default(Branch))
        {
             V1BranchPostWithHttpInfo(branch);
        }

        /// <summary>
        /// Add a new Branch to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="branch"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Workforce.Client.ApiResponse<Object> V1BranchPostWithHttpInfo (Branch branch = default(Branch))
        {
            Workforce.Client.RequestOptions localVarRequestOptions = new Workforce.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/_*+json", 
                "application/json-patch+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Workforce.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Workforce.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = branch;

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/v1/Branch", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1BranchPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a new Branch to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="branch"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1BranchPostAsync (Branch branch = default(Branch))
        {
             await V1BranchPostAsyncWithHttpInfo(branch);

        }

        /// <summary>
        /// Add a new Branch to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="branch"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<Object>> V1BranchPostAsyncWithHttpInfo (Branch branch = default(Branch))
        {

            Workforce.Client.RequestOptions localVarRequestOptions = new Workforce.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/_*+json", 
                "application/json-patch+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = branch;

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/v1/Branch", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1BranchPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}