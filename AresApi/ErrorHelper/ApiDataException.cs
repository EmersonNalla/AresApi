﻿using System;
using System.Net;
using System.Runtime.Serialization;

namespace AresApi.ErrorHelper
{
    /// <summary>  
    /// Api Data Exception  
    /// </summary>  
    [Serializable]
    [DataContract]
    public class ApiDataException : Exception, IApiExceptions
    {
        [DataMember]
        public int ErrorCode { get; set; }
        [DataMember]
        public string ErrorDescription { get; set; }
        [DataMember]
        public HttpStatusCode HttpStatus { get; set; }

        string reasonPhrase = "ApiDataException";

        [DataMember]
        public string ReasonPhrase
        {
            get { return this.reasonPhrase; }

            set { this.reasonPhrase = value; }
        }

        /// <summary>  
        /// Public constructor for Api Data Exception  
        /// </summary>  
        /// <param name="errorCode"></param>  
        /// <param name="errorDescription"></param>  
        /// <param name="httpStatus"></param>  
        public ApiDataException(int errorCode, string errorDescription, HttpStatusCode httpStatus)
        {
            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
            HttpStatus = httpStatus;
        }
    }
}