using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loader : MonoBehaviour {
    public Transform LoadingBar;

    [SerializeField]
    private string nextScene;
     float speed=30f;
    private bool gazedat;
    public float gazeTime = 3f;
    private float timer;
    // Use this for initialization


    // Update is called once per frame
    void Update () {

        if (gazedat)
        {
            timer += Time.deltaTime;
            LoadingBar.GetComponent<Image>().fillAmount = timer;
            if (timer >= gazeTime)
            {
                timer = 0f;
                SceneManager.LoadScene(nextScene);
            }
        }
        else
        {
            timer = 0f;
            LoadingBar.GetComponent<Image>().fillAmount = 0;
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
