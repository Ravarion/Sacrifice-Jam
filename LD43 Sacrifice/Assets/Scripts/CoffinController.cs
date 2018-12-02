using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoffinController : MonoBehaviour {

    public GameObject cursorSprite;
    private GameObject cursor;

    private void Start()
    {
        Cursor.visible = false;
        cursor = Instantiate(cursorSprite);
    }

    private void Update()
    {
        cursor.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x+50, Input.mousePosition.y-90, 10f));
    }

    public void Left()
    {
        FindObjectOfType<Animator>().SetTrigger("Left");
        PlayerPrefs.SetString("Coffin", "Left");
        StartCoroutine("NextScene");
    }

    public void Center()
    {
        FindObjectOfType<Animator>().SetTrigger("Center");
        PlayerPrefs.SetString("Coffin", "Center");
        StartCoroutine("NextScene");
    }

    public void Right()
    {
        FindObjectOfType<Animator>().SetTrigger("Right");
        PlayerPrefs.SetString("Coffin", "Right");
        StartCoroutine("NextScene");
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(1);
        Cursor.visible = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
