using SunamoExceptions;

namespace RunnerJson.ToDelete;
/// <summary>
/// nepotřebuji serializovat toto ale DictionaryCPP
/// </summary>
public class CPPSerializable //: ISerialization2
{
    public Phases<string> Phases = new Phases<string>();
    public Phases<bool?> PhasesB = new Phases<bool?>();
    //public void Load()
    //{
    //    var o = JsonConvert.DeserializeObject<CPPSerializable>(Path);
    //    Phases = o.Phases;
    //    PhasesB = o.PhasesB;
    //}
    //public void Save()
    //{
    //    SerializerHelperJson.WriteToJsonFile<CPPSerializable>(Path, this);
    //}
}
public class CPP : CPPSerializable
{
    public string nameOfSln;
    /// <summary>
    /// Musí být static protože se využívá v CPP.allOk do kterého se to nepředá přes parametry
    /// </summary>
    public static bool serializeNow = false;
    public static bool allOkCheckOverride = true;
    bool _allOk = true;

    internal void SetAllOkToTrue()
    {
        _allOk = true;
    }

    /// <summary>
    /// Nastavuje se průběžně ale pouze na false aby se vědělo že se dále již nemá pokračovat
    /// 
    /// </summary>
    public bool allOk
    {
        get { return _allOk; }
        set
        {
            if (allOkCheckOverride && !serializeNow && value && !_allOk)
            {
                ThrowEx.Custom("Je to kvůli tomu že by se mi false mohlo nevědomky přepsat na true. Pokud jsi si jistý že k tomu nedojde, volej SetAllOkToTrue().");
            }
#if DEBUG
            if (!value)
            {
            }
#endif
            _allOk = value;
        }
    }



}