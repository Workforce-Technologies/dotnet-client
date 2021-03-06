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
    public interface ILocationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a new Location to the Workforce system
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"> (optional)</param>
        /// <returns></returns>
        void CreateOrUpdateLocation(Location location = default(Location));

        /// <summary>
        /// Add a new Location to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateOrUpdateLocationWithHttpInfo(Location location = default(Location));
        /// <summary>
        /// Delete a Location from the Workforce system
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <returns></returns>
        void DeleteLocation(Guid? id = default(Guid?));

        /// <summary>
        /// Delete a Location from the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLocationWithHttpInfo(Guid? id = default(Guid?));
        /// <summary>
        /// Get a specific Location from Workforce
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Location</param>
        /// <returns>Location</returns>
        Location GetLocation(Guid id);

        /// <summary>
        /// Get a specific Location from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Location</param>
        /// <returns>ApiResponse of Location</returns>
        ApiResponse<Location> GetLocationWithHttpInfo(Guid id);
        /// <summary>
        /// Get all Locations within Workforce
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Location&gt;</returns>
        List<Location> GetLocations();

        /// <summary>
        /// Get all Locations within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Location&gt;</returns>
        ApiResponse<List<Location>> GetLocationsWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add a new Location to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateOrUpdateLocationAsync(Location location = default(Location), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Add a new Location to the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateOrUpdateLocationWithHttpInfoAsync(Location location = default(Location), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete a Location from the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLocationAsync(Guid? id = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a Location from the Workforce system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationWithHttpInfoAsync(Guid? id = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a specific Location from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Location</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        System.Threading.Tasks.Task<Location> GetLocationAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a specific Location from Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Location</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        System.Threading.Tasks.Task<ApiResponse<Location>> GetLocationWithHttpInfoAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get all Locations within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Location&gt;</returns>
        System.Threading.Tasks.Task<List<Location>> GetLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all Locations within Workforce
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Location&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Location>>> GetLocationsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocationApi : ILocationApiSync, ILocationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LocationApi : ILocationApi
    {
        private Workforce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationApi(String basePath)
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
        /// Initializes a new instance of the <see cref="LocationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocationApi(Workforce.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="LocationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LocationApi(Workforce.Client.ISynchronousClient client, Workforce.Client.IAsynchronousClient asyncClient, Workforce.Client.IReadableConfiguration configuration)
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
        /// Add a new Location to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"> (optional)</param>
        /// <returns></returns>
        public void CreateOrUpdateLocation(Location location = default(Location))
        {
            CreateOrUpdateLocationWithHttpInfo(location);
        }

        /// <summary>
        /// Add a new Location to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Workforce.Client.ApiResponse<Object> CreateOrUpdateLocationWithHttpInfo(Location location = default(Location))
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

            localVarRequestOptions.Data = location;

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/v1/Location", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateOrUpdateLocation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a new Location to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateOrUpdateLocationAsync(Location location = default(Location), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await CreateOrUpdateLocationWithHttpInfoAsync(location, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Add a new Location to the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<Object>> CreateOrUpdateLocationWithHttpInfoAsync(Location location = default(Location), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = location;

            // authentication (Bearer) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/v1/Location", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateOrUpdateLocation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a Location from the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <returns></returns>
        public void DeleteLocation(Guid? id = default(Guid?))
        {
            DeleteLocationWithHttpInfo(id);
        }

        /// <summary>
        /// Delete a Location from the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Workforce.Client.ApiResponse<Object> DeleteLocationWithHttpInfo(Guid? id = default(Guid?))
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
            var localVarResponse = this.Client.Delete<Object>("/v1/Location", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteLocation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a Location from the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLocationAsync(Guid? id = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteLocationWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a Location from the Workforce system 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Id of the entity to delete (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<Object>> DeleteLocationWithHttpInfoAsync(Guid? id = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/v1/Location", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteLocation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a specific Location from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Location</param>
        /// <returns>Location</returns>
        public Location GetLocation(Guid id)
        {
            Workforce.Client.ApiResponse<Location> localVarResponse = GetLocationWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific Location from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Location</param>
        /// <returns>ApiResponse of Location</returns>
        public Workforce.Client.ApiResponse<Location> GetLocationWithHttpInfo(Guid id)
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
            var localVarResponse = this.Client.Get<Location>("/v1/Location/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLocation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a specific Location from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Location</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        public async System.Threading.Tasks.Task<Location> GetLocationAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Workforce.Client.ApiResponse<Location> localVarResponse = await GetLocationWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a specific Location from Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique ID of the Location</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<Location>> GetLocationWithHttpInfoAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Location>("/v1/Location/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLocation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Locations within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Location&gt;</returns>
        public List<Location> GetLocations()
        {
            Workforce.Client.ApiResponse<List<Location>> localVarResponse = GetLocationsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Locations within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Location&gt;</returns>
        public Workforce.Client.ApiResponse<List<Location>> GetLocationsWithHttpInfo()
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
            var localVarResponse = this.Client.Get<List<Location>>("/v1/Location", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLocations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all Locations within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Location&gt;</returns>
        public async System.Threading.Tasks.Task<List<Location>> GetLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Workforce.Client.ApiResponse<List<Location>> localVarResponse = await GetLocationsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Locations within Workforce 
        /// </summary>
        /// <exception cref="Workforce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Location&gt;)</returns>
        public async System.Threading.Tasks.Task<Workforce.Client.ApiResponse<List<Location>>> GetLocationsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Location>>("/v1/Location", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLocations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
