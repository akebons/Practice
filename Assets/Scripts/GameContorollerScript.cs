using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameContorollerScript : MonoBehaviour
{

    //private int isGameState = 0;
    public CardData card;
    public GameObject CanvasCard;

    // Start is called before the first frame update
    void Start()
    {
        SetCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetCard()
    {
        for (int i = 1; i < 6; i++)
        {
            var pos = new Vector3(-150f, -108f, 0f);
            pos.x += i * 50;
            //prefabオブジェクトをクローン生成
            var cardPrefab = Instantiate(
                card,
                pos,
                transform.rotation
            );

            var step = Random.Range(1f, 6f);
            cardPrefab.Initialize(i, (int)step);
            cardPrefab.setSprite(Random.Range(1f, 20f));


            //キャンバスを親要素として配置
            cardPrefab.transform.SetParent(CanvasCard.transform, false);
        }
    }

}
