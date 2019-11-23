﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HistoryCardManager : MonoBehaviour
{
    List<GameObject> cardList = new List<GameObject>();
    public GameObject cardPrefab;
    private const int CARD_MAX = 3;

    private void Start()
    {
        GenerateHistoryCard();
    }

    public void GenerateHistoryCard()
    {
        SaveData mySaveData = new SaveData();
        int[] saveCardNum = { mySaveData.historyData01, mySaveData.historyData02, mySaveData.historyData03 };

        for (int cardNum = 0; cardNum < CARD_MAX; cardNum++)
        {
            GameObject card = Instantiate(cardPrefab) as GameObject;
            Vector3 cardVector = new Vector3(0.0f, 0.0f, 0.0f);

            switch (cardNum)
            {
                case 0:
                    cardVector.y = 3.0f;
                    break;
                case 1:
                    cardVector.y = 0.0f;
                    break;
                case 2:
                    cardVector.y = -3.0f;
                    break;
                default:
                    break;
            }
            card.transform.position = cardVector;

            card.GetComponent<SetSprite>().SetSpriteSpecification(saveCardNum[cardNum]);

            cardList.Add(card);
        }
    }
}
