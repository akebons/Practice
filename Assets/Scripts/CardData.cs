using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class CardData : MonoBehaviour
{
    public int no { get; private set; }
    public int step { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MyClass : no = " + no + ", step" + step);
    }

    public void Initialize(int _no, int _step)
    {
        no = _no;
        step = _step;
        
    }

    public void setSprite(float nom)
    {
        string name = "CardSet_" + (int)nom;
        Sprite sp = GetSprite("CardSet", name);
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = sp;

    }

    public Sprite GetSprite(string fileName, string spriteName)
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>(fileName);
        return System.Array.Find<Sprite>(sprites, (sprite) => sprite.name.Equals(spriteName));
    }


}
