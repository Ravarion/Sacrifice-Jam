using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TypingController : MonoBehaviour {

    public string[] inputs;
    private int index = 0;
	
	// Update is called once per frame
	void Update () {
        if(index >= inputs.Length)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKeyDown(inputs[index]))
        {
            FindObjectOfType<Animator>().SetTrigger("Continue");
            index++;
        }
	}
}
