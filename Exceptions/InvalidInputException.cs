using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace POKESEMAPIDatabase.Exceptions {
    public class InvalidInputException : Exception {
        public ModelStateDictionary ModelState {get; set;}

        /// <summary>
        /// Custom message for invalid input AND model state has the validation errors
        /// </summary>
        /// <param name="message">The custom message</param>
        /// <param name="modelState">The model state dictionary's validation errors</param>
        public InvalidInputException(string message, ModelStateDictionary modelState) : base(message) {
            this.ModelState = modelState;
        }
    }
}