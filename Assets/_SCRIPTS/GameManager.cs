using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GoldController _goldController;
    [SerializeField]
    private TurnController _turnController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void IncrimentTurn()
    {
        _turnController.IncrimentTurn(1);

        // call other methods her (ie: natural disasters)

    }
}

