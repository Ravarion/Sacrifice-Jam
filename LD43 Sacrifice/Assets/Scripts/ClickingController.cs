using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickingController : MonoBehaviour {

    public int maxIndex;
    public GameObject cursorSprite;
    private GameObject cursor;
    private int index = 1;

    private void Start()
    {
        Cursor.visible = false;
        cursor = Instantiate(cursorSprite);
    }

    private void Update()
    {
        cursor.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x+50, Input.mousePosition.y-90, 10f));
    }

    public void Continue()
    {
        if(index >= maxIndex)
        {
            Cursor.visible = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            FindObjectOfType<Animator>().SetTrigger("Continue");
        }
        index++;
    }
}
