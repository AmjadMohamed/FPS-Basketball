using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    public GameObject LoadingScreenPanel;
    public Slider slider;

    
    public void LoadLevel()
    {
        StartCoroutine(LoadAsynchronously());
    }

     IEnumerator LoadAsynchronously()
    {
        LoadingScreenPanel.SetActive(true);

        AsyncOperation operation = SceneManager.LoadSceneAsync(1);

        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }


}
