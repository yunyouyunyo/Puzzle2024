using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("playerHp",10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
