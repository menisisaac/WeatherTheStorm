using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HouseController : MonoBehaviour
{
    // house types
    // wood = 1; health = 10
    private int woodHouse = 1;

    // stone = 2; health 30
    private int stoneHouse = 2;

    // metal = 3; health 50
    private int metalHouse = 3;

    private int houseType;

    private int houseHealthValue;

    [SerializeField]
    private TMP_Text houseHealthText;



    // Start is called before the first frame update
    void Start()
    {
        houseHealthValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        houseHealthText.text = houseHealthValue.ToString() + "%";
    }


    public void SelectWoodHouse(int value)
    {
        houseType = value;
        houseHealthValue = 10;

    }
    public void SelectStoneHouse(int value)
    {
        houseType = value;
        houseHealthValue = 30;

    }
    public void SelectMetalHouse(int value)
    {
        houseType = value;
        houseHealthValue = 50;
    }
}
