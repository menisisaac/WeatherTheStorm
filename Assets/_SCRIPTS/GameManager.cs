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
        InitializeComponents();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void InitializeComponents()
    {
        _goldController = GetComponent<GoldController>();
        _turnController = GetComponent<TurnController>();

    }
}

