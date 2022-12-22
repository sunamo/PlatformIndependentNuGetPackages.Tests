using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Must be public, otherwise 
/// 'Type 'Utf8Json.Formatters.JsonDataDotFormatter2' from assembly 'Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullFalseNameMutateOriginal, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null' is attempting to implement an inaccessible interface.'
/// </summary>
public class Root
{
    /// <summary>
    /// is working also with public variables
    /// </summary>
    public string price = string.Empty;
    public string position { get; set; }
    public string id { get; set; }
    public string stitky { get; set; }

}
