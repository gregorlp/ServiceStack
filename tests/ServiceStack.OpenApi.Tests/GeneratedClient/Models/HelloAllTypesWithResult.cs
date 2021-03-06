// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// HelloAllTypesWithResult
    /// </summary>
    public partial class HelloAllTypesWithResult
    {
        /// <summary>
        /// Initializes a new instance of the HelloAllTypesWithResult class.
        /// </summary>
        public HelloAllTypesWithResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HelloAllTypesWithResult class.
        /// </summary>
        public HelloAllTypesWithResult(string name = default(string), AllTypes allTypes = default(AllTypes), AllCollectionTypes allCollectionTypes = default(AllCollectionTypes))
        {
            Name = name;
            AllTypes = allTypes;
            AllCollectionTypes = allCollectionTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllTypes")]
        public AllTypes AllTypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllCollectionTypes")]
        public AllCollectionTypes AllCollectionTypes { get; set; }

    }
}
