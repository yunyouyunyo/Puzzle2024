using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Portal : MonoBehaviour
{
    public string SceneName;
    // public int pointNumber;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.tag = "Portal";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene(){
        print("change");
        SceneManager.LoadScene(SceneName);
        // CheckingInit.startPointNumber = pointNumber;
    }
}
