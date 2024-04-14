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


    private int houseHealthMaximumValue;

    private bool isHouseTypeSet = false;

    



    // Start is called before the first frame update
    void Start()
    {
        houseHealthValue = houseHealthMaximumValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHouseTypeSet) // if house value is set, then try it
        {
            houseHealthText.text = ((houseHealthValue/houseHealthMaximumValue) * 100).ToString() + "%";
        }
        
    }


    public void SelectWoodHouse(int value)
    {
        houseType = value;
        houseHealthMaximumValue = 10;
        houseHealthValue = houseHealthMaximumValue;
        isHouseTypeSet = true;

    }
    public void SelectStoneHouse(int value)
    {
        houseType = value;
        houseHealthMaximumValue = 30;
        houseHealthValue = houseHealthMaximumValue;
        isHouseTypeSet = true;

    }
    public void SelectMetalHouse(int value)
    {
        houseType = value;
        houseHealthMaximumValue = 50;
        houseHealthValue = houseHealthMaximumValue;
        isHouseTypeSet = true;

    }

    public int GetHouseTypeValue()
    {
        return houseType;
    }
}
