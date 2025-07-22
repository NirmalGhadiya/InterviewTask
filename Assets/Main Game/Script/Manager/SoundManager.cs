using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Card
{
    public class SoundManager : MonoBehaviour
    {
        #region PUBLIC_VARS

        public static SoundManager instance;
        public AudioSource audioSourceCardFlip;
        public AudioSource audioSourceMatchSuccess;
        public AudioSource audioSourceMatchFail;
        public AudioSource audioSourceLevelComplete;

        #endregion

        #region PRIVATE_VARS

        #endregion

        #region PROTECTED_VARS

        #endregion

        #region UNITY_CALLBACKS

        void Awake()
        {
            instance = this;
        }

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

        #endregion
    }
}