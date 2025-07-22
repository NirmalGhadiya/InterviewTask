using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Card.UI
{
    public class GameplayPage : BasePage
    {
        #region PUBLIC_VARS

        public Text textTotalMoves;
        public Text textTotalMatches;

        #endregion

        #region PRIVATE_VARS

        #endregion

        #region PROTECTED_VARS

        #endregion

        #region UNITY_CALLBACKS

        void OnEnable()
        {
            EventManager.onMove += EventManagerOnMove;
            EventManager.onCardMatch += EventManagerOnCardMatch;
        }

        void OnDisable()
        {
            EventManager.onMove -= EventManagerOnMove;
            EventManager.onCardMatch -= EventManagerOnCardMatch;
        }

        #endregion

        #region PUBLIC_FUNCTIONS

        #endregion

        #region PRIVATE_FUNCTIONS

        private void EventManagerOnMove(int count)
        {
            textTotalMoves.text = "Total Moves : " + count;
        }

        private void EventManagerOnCardMatch(int count)
        {
            textTotalMatches.text = "Total Matches : " + count;
        }

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

        #endregion
    }
}