using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestingController : MonoBehaviour {

    public int maxIndex;
    private int index = 0;

	void Start ()
    {
		if(PlayerPrefs.GetString("Coffin") == "Center")
        {
            FindObjectOfType<Animator>().SetTrigger("Center");
        }
        if (PlayerPrefs.GetString("Coffin") == "Right")
        {
            FindObjectOfType<Animator>().SetTrigger("Right");
        }
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (index >= maxIndex)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                FindObjectOfType<Animator>().SetTrigger("Continue");
            }
            index++;
        }
    }
}
