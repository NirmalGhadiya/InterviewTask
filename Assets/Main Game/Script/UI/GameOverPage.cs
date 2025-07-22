using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Card.UI
{
    public class GameOverPage : BasePage
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

        public void OnButtonClick_PlayAgain()
        {
            HidePage();
            UIManager.instance.ShowPage<GameplayPage>();
            CardController.instance.StartGame();
        }

        public void OnButtonClick_Home()
        {
            HidePage();
            UIManager.instance.ShowPage<HomePage>();
        }

        #endregion
    }
}