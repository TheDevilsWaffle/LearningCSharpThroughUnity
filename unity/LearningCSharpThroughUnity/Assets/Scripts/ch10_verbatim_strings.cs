﻿///////////////////////////////////////////////////////////////////////////////////////////////////
/// ch10_verbatim_strings.cs
/// PURPOSE -
/// 
/// 
/// 
/// 
/// 
/// 
///////////////////////////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using TMPro;

public class ch10_verbatim_strings : MonoBehaviour
{
    #region PROPERTIES
    [Header("Interpolated Verbatim Strings")]
    [SerializeField] TMP_Text title;
    [SerializeField] string titleText = "10.1 Interpolated Vebatim Strings";
    [SerializeField] TMP_Text s10_1_text;
    [Tooltip("Verbatim strings can be combined w/ the new string features found in C#6. Backslashes are ignored as escape characters and any expression inside curly braces are evaluated before being inserted into the string at the position")]
    [SerializeField] string s10_1_example = "Testing \n 1 2 {5 - 2}";
    #endregion
    #region INITIALIZATION
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// set variables and instantly check them while still in inspector
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void OnValidate()
    {
        title.text = titleText;
        Section10_1_InterpolatedVerbatimStrings();
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// initialize references/connections/functions in this script and other scripts
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Awake()
    {
        OnValidate();
    }
    #endregion
    #region METHODS
    /*////////////////////////////////////////////////////////////////////////////////////////////////*/
    /// <summary>
    /// description
    /// </summary>
    /*///////////////////////////////////////////////////////////////////////////////////////////////*/
    void Section10_1_InterpolatedVerbatimStrings()
    {
        s10_1_text.text = string.Format(@"""..\{0}""", s10_1_example);
    }
    #endregion
}