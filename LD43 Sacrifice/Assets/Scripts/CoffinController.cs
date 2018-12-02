using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoffinController : MonoBehaviour {

	public void Left()
    {
        FindObjectOfType<Animator>().SetTrigger("Left");
        StartCoroutine("NextScene");
    }

    public void Center()
    {
        FindObjectOfType<Animator>().SetTrigger("Center");
        StartCoroutine("NextScene");
    }

    public void Right()
    {
        FindObjectOfType<Animator>().SetTrigger("Right");
        StartCoroutine("NextScene");
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
