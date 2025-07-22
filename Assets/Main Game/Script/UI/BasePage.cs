using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Card.UI
{
    public class BasePage : MonoBehaviour
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

        public virtual void ShowPage()
        {
            gameObject.SetActive(true);
        }

        public virtual void HidePage()
        {
            gameObject.SetActive(false);
        }

        #endregion

        #region CO-ROUTINES

        #endregion

        #region UI_CALLBACKS

        #endregion
    }
}