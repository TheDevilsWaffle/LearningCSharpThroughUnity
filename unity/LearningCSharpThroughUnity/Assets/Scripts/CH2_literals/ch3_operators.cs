﻿/*/////////////////////////////////////////////////////////////////////////////////////////////////*/
/// ch3_operators.cs
/// PURPOSE -
/// 
/// 
/// 
/// 
/// 
/// 
/*/////////////////////////////////////////////////////////////////////////////////////////////////*/

using UnityEngine;
//using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;


public class ch3_operators : MonoBehaviour
{
  #region PROPERTIES
  [SerializeField] Vector2 a = Vector2.zero;
  [SerializeField] Vector2 b = Vector2.zero;
  [SerializeField] TMP_Text oeAdd;
  [SerializeField] TMP_Text oeSubtract;
  [SerializeField] TMP_Text oeMultiply;
  [SerializeField] TMP_Text oeDivide;

  #endregion
  #region INITIALIZATION
  ///////////////////////////////////////////////////////////////////////////////////////////////
  /// <summary>
  /// set variables and instantly check them while still in inspector
  /// </summary>
  ///////////////////////////////////////////////////////////////////////////////////////////////
  void OnValidate()
  {
    OverloadableOperatorsExample();
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
  ///////////////////////////////////////////////////////////////////////////////////////////////
  /// <summary>
  /// called on first frame when script is enabled before Update()
  /// </summary>
  ///////////////////////////////////////////////////////////////////////////////////////////////
  void Start()
  {
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
  #region METHODS
  /*////////////////////////////////////////////////////////////////////////////////////////////////*/
  /// <summary>
  /// Overloaded operator example
  /// </summary>
  /*///////////////////////////////////////////////////////////////////////////////////////////////*/
  void OverloadableOperatorsExample()
  {
    IntVector2 _a = new IntVector2((int)a.x, (int)a.y);
    IntVector2 _b = new IntVector2((int)b.x, (int)b.y);
    IntVector2 c = _a + _b;
    IntVector2 d = _a - _b;
    IntVector2 e = _a * _b;
    IntVector2 f = _a / _b;

    oeAdd.text = "a(" + _a.x + ", " + _a.y + ") + b(" + _b.x + ", " + _b.y + ") = c(" + c.x + ", " + c.y + ")";
    oeSubtract.text = "a(" + _a.x + ", " + _a.y + ") - b(" + _b.x + ", " + _b.y + ") = d(" + d.x + ", " + d.y + ")";
    oeMultiply.text = "a(" + _a.x + ", " + _a.y + ") * b(" + _b.x + ", " + _b.y + ") = e(" + e.x + ", " + e.y + ")";
    oeDivide.text = "a(" + _a.x + ", " + _a.y + ") / b(" + _b.x + ", " + _b.y + ") = f(" + f.x + ", " + f.y + ")";
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
    if (Input.GetKeyDown(KeyCode.Keypad0))
    {

    }
    //Keypad 1
    if (Input.GetKeyDown(KeyCode.Keypad1))
    {

    }
    //Keypad 2
    if (Input.GetKeyDown(KeyCode.Keypad2))
    {

    }
    //Keypad 3
    if (Input.GetKeyDown(KeyCode.Keypad3))
    {

    }
    //Keypad 4
    if (Input.GetKeyDown(KeyCode.Keypad4))
    {

    }
    //Keypad 5
    if (Input.GetKeyDown(KeyCode.Keypad5))
    {

    }
    //Keypad 6
    if (Input.GetKeyDown(KeyCode.Keypad6))
    {

    }
  }
  #endregion
}

//struct to demonstrate overloading a new type that we've created.
public struct IntVector2
{
  public int x, y;
  public IntVector2(int _x, int _y)
  {
    x = _x;
    y = _y;
  }
  /*////////////////////////////////////////////////////////////////////////////////////////////////*/
  /// <summary>
  /// Overloaded the + operator
  /// </summary>
  /*///////////////////////////////////////////////////////////////////////////////////////////////*/
  public static IntVector2 operator +(IntVector2 a, IntVector2 b)
  {
    a.x += b.x;
    a.y += b.y;
    return a;
  }
  /*////////////////////////////////////////////////////////////////////////////////////////////////*/
  /// <summary>
  /// Overloaded the - operator
  /// </summary>
  /*///////////////////////////////////////////////////////////////////////////////////////////////*/
  public static IntVector2 operator -(IntVector2 a, IntVector2 b)
  {
    a.x -= b.x;
    a.y -= b.y;
    return a;
  }
  /*////////////////////////////////////////////////////////////////////////////////////////////////*/
  /// <summary>
  /// Overloaded the * operator
  /// </summary>
  /*///////////////////////////////////////////////////////////////////////////////////////////////*/
  public static IntVector2 operator *(IntVector2 a, IntVector2 b)
  {
    a.x *= b.x;
    a.y *= b.y;
    return a;
  }
  /*////////////////////////////////////////////////////////////////////////////////////////////////*/
  /// <summary>
  /// Overloaded the * operator
  /// </summary>
  /*///////////////////////////////////////////////////////////////////////////////////////////////*/
  public static IntVector2 operator /(IntVector2 a, IntVector2 b)
  {
    a.x /= b.x;
    a.y /= b.y;
    return a;
  }
}