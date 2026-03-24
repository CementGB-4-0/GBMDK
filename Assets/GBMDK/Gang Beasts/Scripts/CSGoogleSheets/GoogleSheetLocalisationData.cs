using System;
using System.Collections.Generic;
using UnityEngine;

public class GoogleSheetLocalisationData : ScriptableObject
{
    public string SheetID;

    public string SheetName;

    public int StartingRow;

    public string KeyColumn;

    public string OutputLocation;

    public List<LanguageData> Languages;

    [Serializable]
    public class LanguageData
    {
        public string LanguageName;

        public string Column;

        public string OutputFileName;
    }
}