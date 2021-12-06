namespace MuziekSpelerLib.Contracts
{
    internal interface IApplicationResult
    {
        /// <summary>
        /// Weither the operation has succeeded or not.
        /// </summary>
        public bool HasSucceeded { get; }

        /// <summary>
        /// A custom reason message as to why it may not have succeeded.
        /// </summary>
        public string Reason { get; }

        /// <summary>
        /// The eventual Exception related to the failure of the operation.
        /// </summary>
        public Exception RelatedException { get; }
    }
}
