// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Swagger.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WordInfo
    {
        /// <summary>
        /// Initializes a new instance of the WordInfo class.
        /// </summary>
        public WordInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WordInfo class.
        /// </summary>
        public WordInfo(string text, string dictionaryForm, string reading)
        {
            Text = text;
            DictionaryForm = dictionaryForm;
            Reading = reading;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dictionaryForm")]
        public string DictionaryForm { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reading")]
        public string Reading { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Text == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Text");
            }
            if (DictionaryForm == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DictionaryForm");
            }
            if (Reading == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Reading");
            }
        }
    }
}
