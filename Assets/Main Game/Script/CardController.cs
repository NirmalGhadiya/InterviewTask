using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Card.UI;
using PrimeTween;

namespace Card
{
    public class CardController : MonoBehaviour
    {
        #region PUBLIC_VARS

        public static CardController instance;
        public Card cardPrefeb;
        public Transform transformCardParent;
        public Sprite[] sprites;

        #endregion

        #region PRIVATE_VARS

        private int _totalMoves;
        private int _matchCount;
        private List<Sprite> _listGeneratedSprites = new List<Sprite>();
        private List<Card> _listGeneratedCards = new List<Card>();
        private Card _firstSelectedCard;
        private Card _secondSelectedCard;

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

        public void StartGame()
        {
            ResetCardController();
            PrepareSprites();
            CreateCards();
        }

        public void ResetCardController()
        {
            _matchCount = 0;
            _totalMoves = 0;
            EventManager.RaiseOnMove(_totalMoves);
            EventManager.RaiseOnCardMatch(_matchCount);

            for (int i = 0; i < _listGeneratedCards.Count; i++)
            {
                Destroy(_listGeneratedCards[i].gameObject);
            }

            _listGeneratedCards.Clear();
            _listGeneratedSprites.Clear();
        }

        public void SetSelected(Card card)
        {
            if (card.IsSelected == false)
            {
                card.ShowCard();
                if (_firstSelectedCard == null)
                {
                    _firstSelectedCard = card;
                    return;
                }

                if (_secondSelectedCard == null)
                {
                    _secondSelectedCard = card;
                    StartCoroutine(DoCheckCardMatching(_firstSelectedCard, _secondSelectedCard));
                    _firstSelectedCard = null;
                    _secondSelectedCard = null;
                }
            }
        }

        #endregion

        #region PRIVATE_FUNCTIONS

        public void CreateCards()
        {
            for (int i = 0; i < _listGeneratedSprites.Count; i++)
            {
                Card card = Instantiate(cardPrefeb, transformCardParent);
                card.SetIconSprite(_listGeneratedSprites[i]);
                _listGeneratedCards.Add(card);
            }

            for (int i = 0; i < _listGeneratedCards.Count; i++)
            {
                _listGeneratedCards[i].ShowCardForHint();
            }
        }

        private void PrepareSprites()
        {
            for (int i = 0; i < sprites.Length; i++)
            {
                _listGeneratedSprites.Add(sprites[i]);
                _listGeneratedSprites.Add(sprites[i]);
            }

            ShuffleCardSprites(_listGeneratedSprites);
        }

        private void ShuffleCardSprites(List<Sprite> spriteList)
        {
            for (int i = spriteList.Count - 1; i > 0; i--)
            {
                int randomNumber = Random.Range(0, i + 1);

                Sprite tempSprite = spriteList[i];
                spriteList[i] = spriteList[randomNumber];
                spriteList[randomNumber] = tempSprite;
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

        private IEnumerator DoCheckCardMatching(Card a, Card b)
        {
            yield return new WaitForSeconds(0.3f);

            _totalMoves++;
            EventManager.RaiseOnMove(_totalMoves);
            if (a.imageCardIcon.sprite == b.imageCardIcon.sprite)
            {
                // card matched...
                SoundManager.instance.audioSourceMatchSuccess.Play();

                a.OnCardMatched();
                b.OnCardMatched();
                _matchCount++;
                EventManager.RaiseOnCardMatch(_matchCount);
                if (_matchCount >= _listGeneratedSprites.Count / 2)
                {
                    // All card matched...
                    Tween.Delay(1f, () =>
                    {
                        UIManager.instance.ShowPage<GameOverPage>();
                        UIManager.instance.HidePage<GameplayPage>();
                        SoundManager.instance.audioSourceLevelComplete.Play();
                    });
                }
            }
            else
            {
                // card not matched...
                SoundManager.instance.audioSourceMatchFail.Play();

                a.HideCard();
                b.HideCard();
            }
        }

        #endregion

        #region UI_CALLBACKS

        #endregion
    }
}