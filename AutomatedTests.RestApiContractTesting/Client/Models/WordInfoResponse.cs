// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Swagger.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class WordInfoResponse
    {
        /// <summary>
        /// Initializes a new instance of the WordInfoResponse class.
        /// </summary>
        public WordInfoResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WordInfoResponse class.
        /// </summary>
        public WordInfoResponse(IList<IList<WordInfo>> wordInformation, string identifier)
        {
            WordInformation = wordInformation;
            Identifier = identifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "wordInformation")]
        public IList<IList<WordInfo>> WordInformation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (WordInformation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WordInformation");
            }
            if (Identifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Identifier");
            }
            if (WordInformation != null)
            {
                foreach (var element in WordInformation)
                {
                    if (element != null)
                    {
                        foreach (var element1 in element)
                        {
                            if (element1 != null)
                            {
                                element1.Validate();
                            }
                        }
                    }
                }
            }
        }
    }
}
