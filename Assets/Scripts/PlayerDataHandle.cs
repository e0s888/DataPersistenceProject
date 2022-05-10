using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    public static PlayerDataHandle Instance;
    //makes it accesible for scipts from other instances
    //Static class for save the current player data
    //Singleton pattern - only a singnle instance of PlayerDataHandle (or Main manager in course) can ever exist
    
    public string PlayerName;
   
    public int Score;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
