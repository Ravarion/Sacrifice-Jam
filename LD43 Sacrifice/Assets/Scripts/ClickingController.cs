using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickingController : MonoBehaviour {

    public int maxIndex;
    private int index;
	
	public void Continue()
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
