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
    public interface ICountryApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a new Nationality to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <returns></returns>
        void CreateOrUpdateCountry (Country country = default(Country));

        /// <summary>
        /// Add a new Nationality to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateOrUpdateCountryWithHttpInfo (Country country = default(Country));
        /// <summary>
        /// Get all Countries within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Country&gt;</returns>
        List<Country> GetCountries ();

        /// <summary>
        /// Get all Countries within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Country&gt;</returns>
        ApiResponse<List<Country>> GetCountriesWithHttpInfo ();
        /// <summary>
        /// Get all Countries within Workforce and the assoicated regions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Country&gt;</returns>
        List<Country> GetCountriesWithRegions ();

        /// <summary>
        /// Get all Countries within Workforce and the assoicated regions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Country&gt;</returns>
        ApiResponse<List<Country>> GetCountriesWithRegionsWithHttpInfo ();
        /// <summary>
        /// Get a specific Country from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Country</param>
        /// <returns>Country</returns>
        Country GetCountryById (Guid id);

        /// <summary>
        /// Get a specific Country from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Country</param>
        /// <returns>ApiResponse of Country</returns>
        ApiResponse<Country> GetCountryByIdWithHttpInfo (Guid id);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICountryApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add a new Nationality to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateOrUpdateCountryAsync (Country country = default(Country));

        /// <summary>
        /// Add a new Nationality to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateOrUpdateCountryAsyncWithHttpInfo (Country country = default(Country));
        /// <summary>
        /// Get all Countries within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Country&gt;</returns>
        System.Threading.Tasks.Task<List<Country>> GetCountriesAsync ();

        /// <summary>
        /// Get all Countries within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Country&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Country>>> GetCountriesAsyncWithHttpInfo ();
        /// <summary>
        /// Get all Countries within Workforce and the assoicated regions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Country&gt;</returns>
        System.Threading.Tasks.Task<List<Country>> GetCountriesWithRegionsAsync ();

        /// <summary>
        /// Get all Countries within Workforce and the assoicated regions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Country&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Country>>> GetCountriesWithRegionsAsyncWithHttpInfo ();
        /// <summary>
        /// Get a specific Country from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Country</param>
        /// <returns>Task of Country</returns>
        System.Threading.Tasks.Task<Country> GetCountryByIdAsync (Guid id);

        /// <summary>
        /// Get a specific Country from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Country</param>
        /// <returns>Task of ApiResponse (Country)</returns>
        System.Threading.Tasks.Task<ApiResponse<Country>> GetCountryByIdAsyncWithHttpInfo (Guid id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICountryApi : ICountryApiSync, ICountryApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CountryApi : ICountryApi
    {
        private Workforce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CountryApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CountryApi(String basePath)
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
        /// Initializes a new instance of the <see cref="CountryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CountryApi(Workforce.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="CountryApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CountryApi(Workforce.Client.ISynchronousClient client,Workforce.Client.IAsynchronousClient asyncClient, Workforce.Client.IReadableConfiguration configuration)
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
        /// Add a new Nationality to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <returns></returns>
        public void CreateOrUpdateCountry (Country country = default(Country))
        {
             CreateOrUpdateCountryWithHttpInfo(country);
        }

        /// <summary>
        /// Add a new Nationality to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Workforce.Client.ApiResponse<Object> CreateOrUpdateCountryWithHttpInfo (Country country = default(Country))
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

            localVarRequestOptions.Data = country;

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/v1/Country", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateOrUpdateCountry", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a new Nationality to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateOrUpdateCountryAsync (Country country = default(Country))
        {
             await CreateOrUpdateCountryAsyncWithHttpInfo(country);

        }

        /// <summary>
        /// Add a new Nationality to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<Object>> CreateOrUpdateCountryAsyncWithHttpInfo (Country country = default(Country))
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
            
            localVarRequestOptions.Data = country;

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/v1/Country", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateOrUpdateCountry", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Countries within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Country&gt;</returns>
        public List<Country> GetCountries ()
        {
             Workforce.Client.ApiResponse<List<Country>> localVarResponse = GetCountriesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Countries within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Country&gt;</returns>
        public Workforce.Client.ApiResponse< List<Country> > GetCountriesWithHttpInfo ()
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
            var localVarResponse = this.Client.Get< List<Country> >("/v1/Country", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCountries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Countries within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Country&gt;</returns>
        public async System.Threading.Tasks.Task<List<Country>> GetCountriesAsync ()
        {
             Workforce.Client.ApiResponse<List<Country>> localVarResponse = await GetCountriesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Countries within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Country&gt;)</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<List<Country>>> GetCountriesAsyncWithHttpInfo ()
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Country>>("/v1/Country", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCountries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Countries within Workforce and the assoicated regions 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Country&gt;</returns>
        public List<Country> GetCountriesWithRegions ()
        {
             Workforce.Client.ApiResponse<List<Country>> localVarResponse = GetCountriesWithRegionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Countries within Workforce and the assoicated regions 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Country&gt;</returns>
        public Workforce.Client.ApiResponse< List<Country> > GetCountriesWithRegionsWithHttpInfo ()
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
            var localVarResponse = this.Client.Get< List<Country> >("/v1/Country/full", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCountriesWithRegions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Countries within Workforce and the assoicated regions 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Country&gt;</returns>
        public async System.Threading.Tasks.Task<List<Country>> GetCountriesWithRegionsAsync ()
        {
             Workforce.Client.ApiResponse<List<Country>> localVarResponse = await GetCountriesWithRegionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Countries within Workforce and the assoicated regions 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Country&gt;)</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<List<Country>>> GetCountriesWithRegionsAsyncWithHttpInfo ()
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Country>>("/v1/Country/full", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCountriesWithRegions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a specific Country from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Country</param>
        /// <returns>Country</returns>
        public Country GetCountryById (Guid id)
        {
             Workforce.Client.ApiResponse<Country> localVarResponse = GetCountryByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific Country from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Country</param>
        /// <returns>ApiResponse of Country</returns>
        public Workforce.Client.ApiResponse< Country > GetCountryByIdWithHttpInfo (Guid id)
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
            var localVarResponse = this.Client.Get< Country >("/v1/Country/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCountryById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a specific Country from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Country</param>
        /// <returns>Task of Country</returns>
        public async System.Threading.Tasks.Task<Country> GetCountryByIdAsync (Guid id)
        {
             Workforce.Client.ApiResponse<Country> localVarResponse = await GetCountryByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a specific Country from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Country</param>
        /// <returns>Task of ApiResponse (Country)</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<Country>> GetCountryByIdAsyncWithHttpInfo (Guid id)
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Country>("/v1/Country/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCountryById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
