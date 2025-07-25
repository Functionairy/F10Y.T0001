using System;

using F10Y.T0000;


namespace F10Y.T0001
{
    /// <summary>
    /// Attribute indicating a type is a documentations class. (Used for containing sets of documentation instances.)
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of documentation classes.
    /// </remarks>
    [AttributeUsage(
        AttributeTargets.Class, // Documentations should be in a static class (and nested static classes), so demand a class.
        AllowMultiple = false, // A type is either a documentation class, or it is not. No need for multiple attributes.
        Inherited = false // While documentation classes can be inherited, generally they are not. So force users to re-mark any inherited attribute types.
    )]
    [MarkerAttributeMarker]
    public class DocumentationsMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a class is *not* a documentation class, even if it is marked with the documentations marker attribute.
        /// This is useful for marking types that end up canonical documentation class code file locations, but are not actually documentation classes for surveying.
        /// </summary>
        public bool Is_Documentation { get; }


        public DocumentationsMarkerAttribute(
            bool is_Documentation = true)
        {
            this.Is_Documentation = is_Documentation;
        }
    }
}
