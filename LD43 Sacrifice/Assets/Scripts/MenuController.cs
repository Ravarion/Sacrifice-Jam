using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public int maxIndex;
    private int index = 1;

	void Update ()
    {
		if(Input.anyKeyDown)
        {
            if(index >= maxIndex)
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
