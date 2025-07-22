using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Card.UI
{
    public class HomePage : BasePage
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

        #region CO-ROUTINES

        #endregion

        #region UI_CALLBACKS

        public void OnButtonClick_Play()
        {
            HidePage();
            UIManager.instance.ShowPage<GameplayPage>();
            CardController.instance.StartGame();
        }

        #endregion
    }
}