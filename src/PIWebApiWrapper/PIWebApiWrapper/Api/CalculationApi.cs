using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PIWebAPIWrapper.Client;
using PIWebAPIWrapper.Model;
using PIWebAPIWrapper.Responses;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Api
{

	[Guid("40B4F84C-CE75-44EA-AA74-362B6C5058EA")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface ICalculationApi
	{
		#region Synchronous Operations
		[DispId(1)]
		PITimedValues GetAtIntervals(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null);

		[DispId(2)]
		ApiResponsePITimedValues GetAtIntervalsWithHttpInfo(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null);

		[DispId(3)]
		PITimedValues GetAtRecorded(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null);

		[DispId(4)]
		ApiResponsePITimedValues GetAtRecordedWithHttpInfo(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null);

		[DispId(5)]
		PIItemsSummaryValue GetSummary(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string webId = null);

		[DispId(6)]
		ApiResponsePIItemsSummaryValue GetSummaryWithHttpInfo(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string webId = null);

		[DispId(7)]
		PITimedValues GetAtTimes(string expression = null, string selectedFields = null, string sortOrder = null, string times = null, string webId = null);

		[DispId(8)]
		ApiResponsePITimedValues GetAtTimesWithHttpInfo(string expression = null, string selectedFields = null, string sortOrder = null, string times = null, string webId = null);

		#endregion
	}

	[Guid("E8959297-C344-4DF8-9DA1-6048944BD0CB")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(ICalculationApi))]
	[ProgId("PIWebAPIWrapper.CalculationApi")]

	public class CalculationApi : ICalculationApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public CalculationApi(Configuration configuration = null)
		{
			if (configuration == null)
				this.Configuration = Configuration.Default;
			else
				this.Configuration = configuration;

			ExceptionFactory = PIWebAPIWrapper.Client.Configuration.DefaultExceptionFactory;
			if (Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		public Configuration Configuration { get; set; }

		public PIWebAPIWrapper.Client.ExceptionFactory ExceptionFactory
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

		public PITimedValues GetAtIntervals(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null)
		{
			ApiResponsePITimedValues localVarResponse = GetAtIntervalsWithHttpInfo(endTime, expression, sampleInterval, selectedFields, startTime, webId);
			return localVarResponse.Data;
		}

		public ApiResponsePITimedValues GetAtIntervalsWithHttpInfo(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null)
		{
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(expression)==true)
			{
				expression = null;
			}
			if (string.IsNullOrEmpty(sampleInterval)==true)
			{
				sampleInterval = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}

			var localVarPath = "/calculation/intervals";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (expression!= null) localVarQueryParams.Add("expression", Configuration.ApiClient.ParameterToString(expression));
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", Configuration.ApiClient.ParameterToString(sampleInterval));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (webId!= null) localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));

			if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
			{
				localVarHeaderParams["Authorization"] = "Basic" + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAtIntervals", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePITimedValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		public PITimedValues GetAtRecorded(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null)
		{
			ApiResponsePITimedValues localVarResponse = GetAtRecordedWithHttpInfo(endTime, expression, selectedFields, startTime, webId);
			return localVarResponse.Data;
		}

		public ApiResponsePITimedValues GetAtRecordedWithHttpInfo(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null)
		{
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(expression)==true)
			{
				expression = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}

			var localVarPath = "/calculation/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (expression!= null) localVarQueryParams.Add("expression", Configuration.ApiClient.ParameterToString(expression));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (webId!= null) localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));

			if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
			{
				localVarHeaderParams["Authorization"] = "Basic" + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAtRecorded", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePITimedValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		public PIItemsSummaryValue GetSummary(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string webId = null)
		{
			ApiResponsePIItemsSummaryValue localVarResponse = GetSummaryWithHttpInfo(calculationBasis, endTime, expression, sampleInterval, sampleType, selectedFields, startTime, summaryDuration, summaryTypes, timeType, webId);
			return localVarResponse.Data;
		}

		public ApiResponsePIItemsSummaryValue GetSummaryWithHttpInfo(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string webId = null)
		{
			List<string> summaryType = ExtensionMethods.ConvertToList(summaryTypes);
			if (string.IsNullOrEmpty(calculationBasis)==true)
			{
				calculationBasis = null;
			}
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(expression)==true)
			{
				expression = null;
			}
			if (string.IsNullOrEmpty(sampleInterval)==true)
			{
				sampleInterval = null;
			}
			if (string.IsNullOrEmpty(sampleType)==true)
			{
				sampleType = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (string.IsNullOrEmpty(summaryDuration)==true)
			{
				summaryDuration = null;
			}
			if (string.IsNullOrEmpty(timeType)==true)
			{
				timeType = null;
			}
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}

			var localVarPath = "/calculation/summary";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (calculationBasis!= null) localVarQueryParams.Add("calculationBasis", Configuration.ApiClient.ParameterToString(calculationBasis));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (expression!= null) localVarQueryParams.Add("expression", Configuration.ApiClient.ParameterToString(expression));
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", Configuration.ApiClient.ParameterToString(sampleInterval));
			if (sampleType!= null) localVarQueryParams.Add("sampleType", Configuration.ApiClient.ParameterToString(sampleType));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (summaryDuration!= null) localVarQueryParams.Add("summaryDuration", Configuration.ApiClient.ParameterToString(summaryDuration));
			localVarQueryParams.Add("summaryType", Configuration.ApiClient.ParameterToString(summaryType));
			if (timeType!= null) localVarQueryParams.Add("timeType", Configuration.ApiClient.ParameterToString(timeType));
			if (webId!= null) localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));

			if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
			{
				localVarHeaderParams["Authorization"] = "Basic" + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSummary", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsSummaryValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSummaryValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSummaryValue)));
		}

		public PITimedValues GetAtTimes(string expression = null, string selectedFields = null, string sortOrder = null, string times = null, string webId = null)
		{
			ApiResponsePITimedValues localVarResponse = GetAtTimesWithHttpInfo(expression, selectedFields, sortOrder, times, webId);
			return localVarResponse.Data;
		}

		public ApiResponsePITimedValues GetAtTimesWithHttpInfo(string expression = null, string selectedFields = null, string sortOrder = null, string times = null, string webId = null)
		{
			List<string> time = ExtensionMethods.ConvertToList(times);
			if (string.IsNullOrEmpty(expression)==true)
			{
				expression = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}

			var localVarPath = "/calculation/times";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (expression!= null) localVarQueryParams.Add("expression", Configuration.ApiClient.ParameterToString(expression));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (webId!= null) localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));

			if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
			{
				localVarHeaderParams["Authorization"] = "Basic" + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAtTimes", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePITimedValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

	}
}
