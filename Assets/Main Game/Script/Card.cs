using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using PrimeTween;

namespace Card
{
    public class Card : MonoBehaviour
    {
        #region PUBLIC_VARS

        public Image imageCardIcon;
        public GameObject objCardBack;
        public GameObject objCardFront;
        public CanvasGroup canvasGroup;

        #endregion

        #region PRIVATE_VARS

        public bool IsSelected => isSelected;

        private bool isSelected;

        #endregion

        #region PROTECTED_VARS

        #endregion

        #region UNITY_CALLBACKS

        #endregion

        #region PUBLIC_FUNCTIONS

        public void SetIconSprite(Sprite sprite)
        {
            imageCardIcon.sprite = sprite;
        }

        public void ShowCard()
        {
            SoundManager.instance.audioSourceCardFlip.Play();
            Tween.Rotation(transform, new Vector3(0, 180, 0), 0.2f);
            Tween.Delay(0.1f, () =>
            {
                objCardBack.SetActive(false);
                objCardFront.SetActive(true);
            });
            isSelected = true;
        }

        public void HideCard()
        {
            SoundManager.instance.audioSourceCardFlip.Play();
            Tween.Rotation(transform, new Vector3(0, 0, 0), 0.2f);
            Tween.Delay(0.1f, () =>
            {
                objCardBack.SetActive(true);
                objCardFront.SetActive(false);
                isSelected = false;
            });
        }

        public void ShowCardForHint()
        {
            SoundManager.instance.audioSourceCardFlip.Play();
            Tween.Rotation(transform, new Vector3(0, 180, 0), 0.2f);
            Tween.Delay(0.1f, () =>
            {
                objCardBack.SetActive(false);
                objCardFront.SetActive(true);
            });


            Tween.Delay(1f, () =>
            {
                SoundManager.instance.audioSourceCardFlip.Play();
                Tween.Rotation(transform, new Vector3(0, 0, 0), 0.2f);
                Tween.Delay(0.1f, () =>
                {
                    objCardBack.SetActive(true);
                    objCardFront.SetActive(false);
                });
            });
        }

        public void OnCardMatched()
        {
            Sequence.Create().Chain(Tween.Scale(transform, Vector3.one * 1.2f, 0.2f, Ease.OutBack))
                .Chain(Tween.Scale(transform, Vector3.one, 0.1f));

            canvasGroup.interactable = false;
            canvasGroup.alpha = 0.5f;
        }

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

        public void OnButtonClick_Card()
        {
            CardController.instance.SetSelected(this);
        }

        #endregion
    }
}