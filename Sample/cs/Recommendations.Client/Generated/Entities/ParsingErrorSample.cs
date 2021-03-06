// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Recommendations.Client.Entities
{
    using System.Linq;

    /// <summary>
    /// A line parsing error sample
    /// </summary>
    public partial class ParsingErrorSample
    {
        /// <summary>
        /// Initializes a new instance of the ParsingErrorSample class.
        /// </summary>
        public ParsingErrorSample() { }

        /// <summary>
        /// Initializes a new instance of the ParsingErrorSample class.
        /// </summary>
        /// <param name="file">The name and relative path of the file
        /// containing the error line</param>
        /// <param name="line">The error line number</param>
        public ParsingErrorSample(string file = default(string), long? line = default(long?))
        {
            File = file;
            Line = line;
        }

        /// <summary>
        /// Gets or sets the name and relative path of the file containing the
        /// error line
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "file")]
        public string File { get; set; }

        /// <summary>
        /// Gets or sets the error line number
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "line")]
        public long? Line { get; set; }

    }
}
