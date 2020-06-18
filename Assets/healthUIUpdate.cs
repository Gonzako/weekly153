using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthUIUpdate : MonoBehaviour
{


    public void updateHealth(float healthPercent)
    {
        if (transform.GetChild(0).gameObject.activeSelf)
        {

            for (int i = 0; i < transform.childCount; i++)
            {
                var current = transform.GetChild(i);
                if (!current.gameObject.activeSelf)
                {
                    transform.GetChild(i - 1).gameObject.SetActive(false);
                    return;
                }

            }
            var last = transform.GetChild(transform.childCount - 1);
            last.gameObject.SetActive(false);
            return;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);

    }
}
