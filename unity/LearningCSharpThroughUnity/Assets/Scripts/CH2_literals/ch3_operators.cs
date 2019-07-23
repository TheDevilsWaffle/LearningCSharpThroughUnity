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
using TMPro;

public class ch3_operators : MonoBehaviour
{
  #region PROPERTIES
  [Header("3.1 Overloading Operators")]
  [SerializeField] bool enableSection3_1 = true;
  [SerializeField] Vector2 a = Vector2.zero;
  [SerializeField] Vector2 b = Vector2.zero;
  [SerializeField] TMP_Text oeAdd;
  [SerializeField] TMP_Text oeSubtract;
  [SerializeField] TMP_Text oeMultiply;
  [SerializeField] TMP_Text oeDivide;
  [Header("3.3 Relational Operators")]
  [SerializeField] bool enableSection3_3 = true;
  [SerializeField] TMP_Text relationalText1;
  [SerializeField] string relational1 = "a";
  [SerializeField] TMP_Text relationalText2;
  [SerializeField] string relational2 = "b";
  [SerializeField] TMP_Text relationalText3;
  [Range(0,1)][SerializeField] int relational3 = 1;
  [SerializeField] TMP_Text relationalText4;
  [Range(0,1)][SerializeField] int relational4 = 0;
  [SerializeField] TMP_Text relationalText5;
  [SerializeField] bool relational5 = true;
  [SerializeField] TMP_Text relationalText6;
  [SerializeField] bool relational6 = false;
  
  

  #endregion
  #region INITIALIZATION
  ///////////////////////////////////////////////////////////////////////////////////////////////
  /// <summary>
  /// set variables and instantly check them while still in inspector
  /// </summary>
  ///////////////////////////////////////////////////////////////////////////////////////////////
  void OnValidate()
  {
    if (enableSection3_1)
      Section3_1_OverloadableOperatorsExample();
    if (enableSection3_3)
      Section3_3_RelationalOperators();
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
  /// Overloaded operator example
  /// </summary>
  /*///////////////////////////////////////////////////////////////////////////////////////////////*/
  void Section3_1_OverloadableOperatorsExample()
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
  /*////////////////////////////////////////////////////////////////////////////////////////////////*/
  /// <summary>
  /// checks whether the supplied operands (arguments) are equal
  /// </summary>
  /*///////////////////////////////////////////////////////////////////////////////////////////////*/
  void Section3_3_RelationalOperators()
  {
    relationalText1.text = "\"" + relational1 + "\" == \"" + relational2 + "\" returns " + (relational1 == relational2);
    relationalText2.text = "\"" + relational1 + "\" == \"" + relational1 + "\"returns " + (relational1 == relational1);

    relationalText3.text = relational3 + " ==  " + relational4 + " returns " + (relational3 == relational4);
    relationalText4.text = relational4 + " ==  " + relational4 + " returns " + (relational4 == relational4);

    relationalText5.text = relational5 + " ==  " + relational6 + " returns " + (relational5 == relational6);
    relationalText6.text = relational6 + " ==  " + relational6 + " returns " + (relational6 == relational6);
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