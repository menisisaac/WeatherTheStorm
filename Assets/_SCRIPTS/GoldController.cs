using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GoldController : MonoBehaviour
{
    // pre start
    private int PlayerGoldTotal; // get
    [SerializeField]
    private GameObject GoldTextObject;
    [SerializeField]
    private TMP_Text GoldText;

    private int MaximumGoldTotal = 100;



    // Start is called before the first frame update
    void Start()
    {
        PlayerGoldTotal = 10;// intialize gold

        // per turn = 10 gold


    }

    // Update is called once per frame
    void Update()
    {
        GoldText.text = PlayerGoldTotal.ToString();

    }


    public void AddMaximumGoldTotal()
    {
        PlayerGoldTotal += MaximumGoldTotal;
    }


    public void AddGoldOnTurn(int value)
    {
        PlayerGoldTotal += value;
    }
    
}
