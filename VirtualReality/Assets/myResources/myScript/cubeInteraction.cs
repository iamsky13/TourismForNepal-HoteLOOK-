using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class cubeInteraction : MonoBehaviour {

    public float gazeTime = 2f;
    private float timer;
    private bool gazedat;
    [SerializeField]
    private string SecondScene;
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
            Transform child = transform.GetChild(0);
            Vector3 newScale = new Vector3(timer / gazeTime, child.localScale.y, child.localScale.z);
            Vector3 newPosition = new Vector3(0.5f - (timer / gazeTime) / 2, child.localPosition.y, child.localPosition.z);
            child.localScale = newScale;
            child.localPosition = newPosition;
            if (timer >= gazeTime)
            {
                timer = 0f;
                SceneManager.LoadScene(SecondScene);



            }
        }
        else
        {
            timer = 0f;
            Transform child = transform.GetChild(0);
            Vector3 newScale = new Vector3(timer / gazeTime, child.localScale.y, child.localScale.z);
            Vector3 newPosition = new Vector3(0.5f - (timer / gazeTime) / 2, child.localPosition.y, child.localPosition.z);
            child.localScale = newScale;
            child.localPosition = newPosition;

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



