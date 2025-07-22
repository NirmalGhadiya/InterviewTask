using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Card.UI
{
    public class UIManager : MonoBehaviour
    {
        #region PUBLIC_VARS

        public static UIManager instance;
        public BasePage[] views;

        #endregion

        #region PRIVATE_VARS

        private Dictionary<Type, BasePage> m_views = new Dictionary<Type, BasePage>();

        #endregion

        #region PROTECTED_VARS

        #endregion

        #region UNITY_CALLBACKS

        void Awake()
        {
            instance = this;
            MapViews();
            ShowPage<HomePage>();
        }

        #endregion

        #region PUBLIC_FUNCTIONS

        public T GetPage<T>()
        {
            if (m_views.ContainsKey(typeof(T)))
            {
                return (T) Convert.ChangeType(m_views[typeof(T)], typeof(T));
            }

            return (T) Convert.ChangeType(null, typeof(T));
        }

        public void ShowPage<T>()
        {
            if (m_views.ContainsKey(typeof(T)))
            {
                m_views[typeof(T)].ShowPage();
            }
        }

        public void HidePage<T>()
        {
            if (m_views.ContainsKey(typeof(T)))
            {
                m_views[typeof(T)].HidePage();
            }
        }

        #endregion

        #region PRIVATE_FUNCTIONS

        private void MapViews()
        {
            for (int i = 0; i < views.Length; i++)
            {
                if (!m_views.ContainsKey(views[i].GetType()))
                {
                    m_views.Add(views[i].GetType(), views[i]);
                }
            }
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