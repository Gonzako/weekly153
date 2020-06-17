using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class advanceLevel : MonoBehaviour
{

    public void loadNextLevel()
    {
        StartCoroutine(levelLoadCoroutine());
    }

    public IEnumerator levelLoadCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        var idx = SceneManager.GetActiveScene().buildIndex + 1;

        SceneManager.LoadScene(idx, LoadSceneMode.Single);
    }

}
