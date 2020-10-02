using SolutionBD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBD.Service.CustomException
{
   public class CustomHttpException:Exception
    {
        public CustomHttpExceptionDTO CustomContent { get; set; }

        private int _errorCode;
        public CustomHttpException(int errorCode, string message) : base(message)
        {
            _errorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the Haaloom.KashbackService.Service.CustomHttpException class and creates
        /// an empty Haaloom.KashbackService.Service.Exceptions.CustomHttpException object.
        /// </summary>
        public CustomHttpException()
        {
            _errorCode = 500;
        }

        /// <summary>
        /// Gets the HTTP response status code to return to the client.
        /// </summary>
        /// <returns>A non-zero HTTP code representing the exception; otherwise, HTTP response status code 500.</returns>
        public int GetHttpCode()
        {
            return _errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the Haaloom.KashbackService.Service.CustomHttpException class using an error
        ///  message and an exception code.
        /// </summary>
        /// <param name="message">The error message displayed to the client when the exception is thrown.</param>
        public CustomHttpException(string message)
        : base(message)
        {
            _errorCode = 500;
        }
    }
}
