using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VR;


public class selectForVR : MonoBehaviour
{
    public float gazeTime = 1f;
    private float timer;
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
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                VRSettings.enabled = true;
                SceneManager.LoadScene(nextScene);
            }
        }
        else
        {
            timer = 0f;
        }


    }
    public void PointerEnter()
    {
        //Debug.Log("Pointer Enter");
        gazedat = true;



    }
    public void PointerExit()
    {
        //Debug.Log("Pointer Exit");
        gazedat = false;

    }
}
