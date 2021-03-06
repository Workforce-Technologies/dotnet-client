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
    public interface INationalityApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a new Nationality to the Workforce system
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nationality">The nationality to add (optional)</param>
        /// <returns></returns>
        void CreateOrUpdateNationality(Nationality nationality = default(Nationality));

        /// <summary>
        /// Add a new Nationality to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nationality">The nationality to add (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateOrUpdateNationalityWithHttpInfo(Nationality nationality = default(Nationality));
        /// <summary>
        /// Delete a Nationality from the Workforce system
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <returns></returns>
        void DeleteNationality(Guid? id = default(Guid?));

        /// <summary>
        /// Delete a Nationality from the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteNationalityWithHttpInfo(Guid? id = default(Guid?));
        /// <summary>
        /// Get all Nationalities within Workforce
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Nationality&gt;</returns>
        List<Nationality> GetNationalities();

        /// <summary>
        /// Get all Nationalities within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Nationality&gt;</returns>
        ApiResponse<List<Nationality>> GetNationalitiesWithHttpInfo();
        /// <summary>
        /// Get a specific Nationality from Workforce
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Nationality</param>
        /// <returns>Nationality</returns>
        Nationality GetNationality(Guid id);

        /// <summary>
        /// Get a specific Nationality from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Nationality</param>
        /// <returns>ApiResponse of Nationality</returns>
        ApiResponse<Nationality> GetNationalityWithHttpInfo(Guid id);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INationalityApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add a new Nationality to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nationality">The nationality to add (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateOrUpdateNationalityAsync(Nationality nationality = default(Nationality), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Add a new Nationality to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nationality">The nationality to add (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateOrUpdateNationalityWithHttpInfoAsync(Nationality nationality = default(Nationality), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete a Nationality from the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteNationalityAsync(Guid? id = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a Nationality from the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteNationalityWithHttpInfoAsync(Guid? id = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get all Nationalities within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Nationality&gt;</returns>
        System.Threading.Tasks.Task<List<Nationality>> GetNationalitiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all Nationalities within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Nationality&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Nationality>>> GetNationalitiesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a specific Nationality from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Nationality</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Nationality</returns>
        System.Threading.Tasks.Task<Nationality> GetNationalityAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a specific Nationality from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Nationality</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Nationality)</returns>
        System.Threading.Tasks.Task<ApiResponse<Nationality>> GetNationalityWithHttpInfoAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INationalityApi : INationalityApiSync, INationalityApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NationalityApi : INationalityApi
    {
        private Workforce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NationalityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NationalityApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NationalityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NationalityApi(String basePath)
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
        /// Initializes a new instance of the <see cref="NationalityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NationalityApi(Workforce.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="NationalityApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public NationalityApi(Workforce.Client.ISynchronousClient client, Workforce.Client.IAsynchronousClient asyncClient, Workforce.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

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
        public Workforce.Client.IReadableConfiguration Configuration { get; set; }

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
        /// <param name="nationality">The nationality to add (optional)</param>
        /// <returns></returns>
        public void CreateOrUpdateNationality(Nationality nationality = default(Nationality))
        {
            CreateOrUpdateNationalityWithHttpInfo(nationality);
        }

        /// <summary>
        /// Add a new Nationality to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nationality">The nationality to add (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Workforce.Client.ApiResponse<Object> CreateOrUpdateNationalityWithHttpInfo(Nationality nationality = default(Nationality))
        {
            Workforce.Client.RequestOptions localVarRequestOptions = new Workforce.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Workforce.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Workforce.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = nationality;

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/v1/Nationality", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateOrUpdateNationality", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a new Nationality to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nationality">The nationality to add (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateOrUpdateNationalityAsync(Nationality nationality = default(Nationality), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await CreateOrUpdateNationalityWithHttpInfoAsync(nationality, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Add a new Nationality to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nationality">The nationality to add (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<Object>> CreateOrUpdateNationalityWithHttpInfoAsync(Nationality nationality = default(Nationality), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Workforce.Client.RequestOptions localVarRequestOptions = new Workforce.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Workforce.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Workforce.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = nationality;

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/v1/Nationality", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateOrUpdateNationality", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a Nationality from the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <returns></returns>
        public void DeleteNationality(Guid? id = default(Guid?))
        {
            DeleteNationalityWithHttpInfo(id);
        }

        /// <summary>
        /// Delete a Nationality from the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Workforce.Client.ApiResponse<Object> DeleteNationalityWithHttpInfo(Guid? id = default(Guid?))
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

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Workforce.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/v1/Nationality", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteNationality", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a Nationality from the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteNationalityAsync(Guid? id = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteNationalityWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a Nationality from the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<Object>> DeleteNationalityWithHttpInfoAsync(Guid? id = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Workforce.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/v1/Nationality", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteNationality", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Nationalities within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Nationality&gt;</returns>
        public List<Nationality> GetNationalities()
        {
            Workforce.Client.ApiResponse<List<Nationality>> localVarResponse = GetNationalitiesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Nationalities within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Nationality&gt;</returns>
        public Workforce.Client.ApiResponse<List<Nationality>> GetNationalitiesWithHttpInfo()
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
            var localVarResponse = this.Client.Get<List<Nationality>>("/v1/Nationality", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetNationalities", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Nationalities within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Nationality&gt;</returns>
        public async System.Threading.Tasks.Task<List<Nationality>> GetNationalitiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Workforce.Client.ApiResponse<List<Nationality>> localVarResponse = await GetNationalitiesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Nationalities within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Nationality&gt;)</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<List<Nationality>>> GetNationalitiesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Nationality>>("/v1/Nationality", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetNationalities", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a specific Nationality from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Nationality</param>
        /// <returns>Nationality</returns>
        public Nationality GetNationality(Guid id)
        {
            Workforce.Client.ApiResponse<Nationality> localVarResponse = GetNationalityWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific Nationality from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Nationality</param>
        /// <returns>ApiResponse of Nationality</returns>
        public Workforce.Client.ApiResponse<Nationality> GetNationalityWithHttpInfo(Guid id)
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
            var localVarResponse = this.Client.Get<Nationality>("/v1/Nationality/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetNationality", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a specific Nationality from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Nationality</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Nationality</returns>
        public async System.Threading.Tasks.Task<Nationality> GetNationalityAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Workforce.Client.ApiResponse<Nationality> localVarResponse = await GetNationalityWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific Nationality from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Nationality</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Nationality)</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<Nationality>> GetNationalityWithHttpInfoAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Nationality>("/v1/Nationality/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetNationality", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
