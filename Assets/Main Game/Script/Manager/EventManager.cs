using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class EventManager : MonoBehaviour
{
    #region PUBLIC_VARS

    #endregion

    #region PRIVATE_VARS

    #endregion

    #region PROTECTED_VARS

    #endregion

    #region UNITY_CALLBACKS

    #endregion

    #region PUBLIC_FUNCTIONS

    #endregion

    #region PRIVATE_FUNCTIONS

    #endregion

    #region PROTECTED_FUNCTIONS

    #endregion

    #region OVERRIDE_FUNCTIONS

    #endregion

    #region VIRTUAL_FUNCTIONS

    #endregion

    #region EVENT_DELEGATES

    public delegate void OnCardMatch(int count);

    public static event OnCardMatch onCardMatch;

    public static void RaiseOnCardMatch(int count)
    {
        if (onCardMatch != null)
            onCardMatch(count);
    }

    public delegate void OnMove(int count);

    public static event OnMove onMove;

    public static void RaiseOnMove(int count)
    {
        if (onMove != null)
            onMove(count);
    }

    #endregion

    #region CO-ROUTINES

    #endregion

    #region UI_CALLBACKS

    #endregion
}