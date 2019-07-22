﻿///////////////////////////////////////////////////////////////////////////////////////////////////
/// ch2_literals.cs
/// PURPOSE -
/// 
/// 
/// 
/// 
/// 
/// 
///////////////////////////////////////////////////////////////////////////////////////////////////

using UnityEngine;
//using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

#region ENUMS
//public enum EnumStatus
//{
//	
//};
#endregion

public class ch2_literals : MonoBehaviour
{
    #region PROPERTIES
    [Tooltip("8-bit signed integer: Range is -128 to 127.")]
    [SerializeField] sbyte _sbyte;
    [Tooltip("8-bit unsigned integer: Range is 0 to 255.")]
    [SerializeField] byte _byte;
    [Tooltip("16-bit signed integer: Range is -32,768 to 32,767.")]
    [SerializeField] short _short;
    [Tooltip("16-bit unsigned integer: Range is 0 to 65,535.")]
    [SerializeField] ushort _uShort;
    [Tooltip("32-bit unsigned integer. Range is 0 to 4294967295.")]
    [SerializeField] uint _uint;
    [Tooltip("32-bit signed integer. Range is –2147483648 to 2147483647.")]
    [SerializeField] int _int;
    [Tooltip("64-bit signed integer. Range is –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.")]
    [SerializeField] long _long;
    [Tooltip("64-bit unsigned integer. Range is 0 to 18,446,744,073,709,551,615.")]
    [SerializeField] ulong _uLong;

    [Tooltip("64-bit unsigned floating-point value. Range is approx. +/- 1.5 z 10 to the 45th power to approx to  +/- 3.4 z 10 to the 38th power.")]
    [SerializeField] float _float;
    [Tooltip("64-bit signed floating-point value. Range is approx. +/- 5 x 10 to the 324th; the largest possible value is approx. +/- 1.7 x 10 to the 308th. ")]
    [SerializeField] double _double;
    
    [Tooltip("holds one 16-bit Unicode character. Value can be 0 to 65,535.")]
    [SerializeField] char _char;
    [Tooltip("holds a string of Unicode characters. Strings are immutable, they cannot be modified once created. Manipulation requires making a new string object.")]
    [SerializeField] string _string;
    
    [Tooltip("holds either 'true' or 'false'. Breaks from C and C++ by not being synonymous with integer values 0 or 1 and cannot be converted to an integer type.")]
    [SerializeField] bool _bool;

    [SerializeField] decimal _decimal; //doesn't show up in inspector

    #endregion
    #region INITIALIZATION
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// set variables and instantly check them while still in inspector
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void OnValidate()
    {
        //refs


        //initial values

    }
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// initialize references/connections/functions in this script and other scripts
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Awake()
    {
        //SetSubscriptions();
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// called on first frame when script is enabled before Update()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Start()
    {
    
    }
    #endregion
    #region SUBSCRIPTIONS
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// listen to specific GameEvents
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void SetSubscriptions()
    {
        //Events.instance.AddListener<event>(function);
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// end listening to specific GameEvents
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void RemoveSubscriptions()
    {
        //Events.instance.RemoveListener<event>(function);
    }
    #endregion
    #region UPDATE
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// runs every frame
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Update()
    {

    //turn this to true if you want to test something in update loop
    #if false
        UpdateTesting();
    #endif
    
    }
    #endregion
    #region PUBLIC METHODS
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// function desc.
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////

    #endregion
    #region PRIVATE METHODS
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// function desc.
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////

    #endregion

    #region ONDESTORY
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// called when the gameobject with this script is destroyed
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void OnDestroy()
    {
        RemoveSubscriptions();
    }
    #endregion
    #region TESTING
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// test functions using the numpad (make sure numpad is turned on)
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void UpdateTesting()
    {
        //Keypad 0
        if(Input.GetKeyDown(KeyCode.Keypad0))
        {

        }
        //Keypad 1
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            
        }
        //Keypad 2
        if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            
        }
        //Keypad 3
        if(Input.GetKeyDown(KeyCode.Keypad3))
        {
            
        }
        //Keypad 4
        if(Input.GetKeyDown(KeyCode.Keypad4))
        {
            
        }
        //Keypad 5
        if(Input.GetKeyDown(KeyCode.Keypad5))
        {
            
        }
        //Keypad 6
        if(Input.GetKeyDown(KeyCode.Keypad6))
        {
            
        }
    }
    #endregion
}