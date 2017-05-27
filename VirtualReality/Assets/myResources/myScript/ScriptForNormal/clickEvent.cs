using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VR;


public class clickEvent : MonoBehaviour
{
    private bool gazedat;
    [SerializeField]
    private string nextScene;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gazedat)
        {            
                SceneManager.LoadScene(nextScene);
        }
        


    }
    public void PointerDown()
    {
        //Debug.Log("Pointer Enter");
        gazedat = true;



    }
  
}
