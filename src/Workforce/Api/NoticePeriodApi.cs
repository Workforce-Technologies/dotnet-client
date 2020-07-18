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
    public interface INoticePeriodApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a new Notice Period to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticePeriod"> (optional)</param>
        /// <returns></returns>
        void CreateOrUpdateNoticePeriod (NoticePeriod noticePeriod = default(NoticePeriod));

        /// <summary>
        /// Add a new Notice Period to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticePeriod"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateOrUpdateNoticePeriodWithHttpInfo (NoticePeriod noticePeriod = default(NoticePeriod));
        /// <summary>
        /// Get a specific Notice Period from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Notice Period</param>
        /// <returns>NoticePeriod</returns>
        NoticePeriod GetNoticePeriod (Guid id);

        /// <summary>
        /// Get a specific Notice Period from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Notice Period</param>
        /// <returns>ApiResponse of NoticePeriod</returns>
        ApiResponse<NoticePeriod> GetNoticePeriodWithHttpInfo (Guid id);
        /// <summary>
        /// Get all Notice Periods within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;NoticePeriod&gt;</returns>
        List<NoticePeriod> GetNoticePeriods ();

        /// <summary>
        /// Get all Notice Periods within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;NoticePeriod&gt;</returns>
        ApiResponse<List<NoticePeriod>> GetNoticePeriodsWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INoticePeriodApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add a new Notice Period to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticePeriod"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateOrUpdateNoticePeriodAsync (NoticePeriod noticePeriod = default(NoticePeriod));

        /// <summary>
        /// Add a new Notice Period to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticePeriod"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateOrUpdateNoticePeriodAsyncWithHttpInfo (NoticePeriod noticePeriod = default(NoticePeriod));
        /// <summary>
        /// Get a specific Notice Period from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Notice Period</param>
        /// <returns>Task of NoticePeriod</returns>
        System.Threading.Tasks.Task<NoticePeriod> GetNoticePeriodAsync (Guid id);

        /// <summary>
        /// Get a specific Notice Period from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Notice Period</param>
        /// <returns>Task of ApiResponse (NoticePeriod)</returns>
        System.Threading.Tasks.Task<ApiResponse<NoticePeriod>> GetNoticePeriodAsyncWithHttpInfo (Guid id);
        /// <summary>
        /// Get all Notice Periods within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;NoticePeriod&gt;</returns>
        System.Threading.Tasks.Task<List<NoticePeriod>> GetNoticePeriodsAsync ();

        /// <summary>
        /// Get all Notice Periods within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;NoticePeriod&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NoticePeriod>>> GetNoticePeriodsAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INoticePeriodApi : INoticePeriodApiSync, INoticePeriodApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NoticePeriodApi : INoticePeriodApi
    {
        private Workforce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NoticePeriodApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NoticePeriodApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoticePeriodApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NoticePeriodApi(String basePath)
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
        /// Initializes a new instance of the <see cref="NoticePeriodApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NoticePeriodApi(Workforce.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="NoticePeriodApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public NoticePeriodApi(Workforce.Client.ISynchronousClient client,Workforce.Client.IAsynchronousClient asyncClient, Workforce.Client.IReadableConfiguration configuration)
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
        /// Add a new Notice Period to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticePeriod"> (optional)</param>
        /// <returns></returns>
        public void CreateOrUpdateNoticePeriod (NoticePeriod noticePeriod = default(NoticePeriod))
        {
             CreateOrUpdateNoticePeriodWithHttpInfo(noticePeriod);
        }

        /// <summary>
        /// Add a new Notice Period to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticePeriod"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Workforce.Client.ApiResponse<Object> CreateOrUpdateNoticePeriodWithHttpInfo (NoticePeriod noticePeriod = default(NoticePeriod))
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

            localVarRequestOptions.Data = noticePeriod;

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/v1/NoticePeriod", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateOrUpdateNoticePeriod", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a new Notice Period to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticePeriod"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateOrUpdateNoticePeriodAsync (NoticePeriod noticePeriod = default(NoticePeriod))
        {
             await CreateOrUpdateNoticePeriodAsyncWithHttpInfo(noticePeriod);

        }

        /// <summary>
        /// Add a new Notice Period to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="noticePeriod"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<Object>> CreateOrUpdateNoticePeriodAsyncWithHttpInfo (NoticePeriod noticePeriod = default(NoticePeriod))
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
            
            localVarRequestOptions.Data = noticePeriod;

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/v1/NoticePeriod", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateOrUpdateNoticePeriod", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a specific Notice Period from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Notice Period</param>
        /// <returns>NoticePeriod</returns>
        public NoticePeriod GetNoticePeriod (Guid id)
        {
             Workforce.Client.ApiResponse<NoticePeriod> localVarResponse = GetNoticePeriodWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific Notice Period from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Notice Period</param>
        /// <returns>ApiResponse of NoticePeriod</returns>
        public Workforce.Client.ApiResponse< NoticePeriod > GetNoticePeriodWithHttpInfo (Guid id)
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
            var localVarResponse = this.Client.Get< NoticePeriod >("/v1/NoticePeriod/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetNoticePeriod", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a specific Notice Period from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Notice Period</param>
        /// <returns>Task of NoticePeriod</returns>
        public async System.Threading.Tasks.Task<NoticePeriod> GetNoticePeriodAsync (Guid id)
        {
             Workforce.Client.ApiResponse<NoticePeriod> localVarResponse = await GetNoticePeriodAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a specific Notice Period from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Notice Period</param>
        /// <returns>Task of ApiResponse (NoticePeriod)</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<NoticePeriod>> GetNoticePeriodAsyncWithHttpInfo (Guid id)
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<NoticePeriod>("/v1/NoticePeriod/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetNoticePeriod", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Notice Periods within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;NoticePeriod&gt;</returns>
        public List<NoticePeriod> GetNoticePeriods ()
        {
             Workforce.Client.ApiResponse<List<NoticePeriod>> localVarResponse = GetNoticePeriodsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Notice Periods within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;NoticePeriod&gt;</returns>
        public Workforce.Client.ApiResponse< List<NoticePeriod> > GetNoticePeriodsWithHttpInfo ()
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
            var localVarResponse = this.Client.Get< List<NoticePeriod> >("/v1/NoticePeriod", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetNoticePeriods", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Notice Periods within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;NoticePeriod&gt;</returns>
        public async System.Threading.Tasks.Task<List<NoticePeriod>> GetNoticePeriodsAsync ()
        {
             Workforce.Client.ApiResponse<List<NoticePeriod>> localVarResponse = await GetNoticePeriodsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Notice Periods within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;NoticePeriod&gt;)</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<List<NoticePeriod>>> GetNoticePeriodsAsyncWithHttpInfo ()
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<NoticePeriod>>("/v1/NoticePeriod", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetNoticePeriods", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
