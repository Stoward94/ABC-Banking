﻿using System.Collections.Generic;

namespace ABC_Banking.Core.Validation
{
    /// <summary>
    /// Interface to handle the validity of an action/method between the controller and logic layers
    /// </summary>
    public interface IValidationResult
    {
        /// <summary>
        /// Contains a collection of error messages
        /// </summary>
        List<string> Errors { get; }

        /// <summary>
        /// Call to check if the result contains an error
        /// </summary>
        /// <returns>boolean</returns>
        bool HasError();

        /// <summary>
        /// Add a string error message to the errors collection
        /// </summary>
        /// <param name="errorMessage"></param>
        void AddError(string errorMessage);


    }
}
