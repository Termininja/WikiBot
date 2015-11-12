namespace Wiki.Data.Enums
{
    /// <summary>
    /// Wikidata data type: https://www.wikidata.org/wiki/Help:Data_type
    /// </summary>
    public enum DataType
    {
        /// <summary>
        /// References to files on Wikimedia Commons.
        /// </summary>
        CommonsMediaFile,

        /// <summary>
        /// Geographical position given as a latitude-longitude pair.
        /// </summary>
        GlobeCoordinate,

        /// <summary>
        /// Internal link to another item.
        /// </summary>
        Item,

        /// <summary>
        /// A string that is not translated into other languages.
        /// </summary>
        MonolingualText,

        /// <summary>
        /// Internal link to a property.
        /// </summary>
        Property,

        /// <summary>
        /// A general number value.
        /// </summary>
        Quantity,

        /// <summary>
        /// Chain of characters, numbers and symbols.
        /// </summary>
        String,

        /// <summary>
        /// Date in Gregorian or Julian calendar.
        /// </summary>
        Time,

        /// <summary>
        /// Link that identifies some kind of external resource.
        /// </summary>
        Url,
    }
}
