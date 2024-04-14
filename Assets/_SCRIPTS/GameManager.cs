using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GoldController _goldController;
    [SerializeField]
    private TurnController _turnController;
    [SerializeField]
    private HouseController _houseController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void IncrimentTurn()
    {
        _turnController.IncrimentTurn(1);

        _goldController.AddGoldOnTurn(10);

        // call other methods her (ie: natural disasters)


    }

    public void ChooseWoodHouse()
    {
        _houseController.SelectWoodHouse(1);
    }

    public void ChooseStoneHouse()
    {
        _houseController.SelectStoneHouse(2);
    }

    public void ChooseMetalHouse()
    {
        _houseController.SelectMetalHouse(3);
    }


}

