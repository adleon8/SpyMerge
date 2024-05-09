using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Merged.

public class SceneSwitch : MonoBehaviour
{
    public int sceneSwitchTo;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (sceneSwitchTo==2&&other.GetComponent<PlayerController>().hasFile==true)
            {
                GameObject.Find("Canvas").transform.Find("Winscreen").gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                SceneManager.LoadScene(sceneSwitchTo);
            }
            //   SceneManager.LoadScene(sceneSwitchTo);

           
        }
    }
}
