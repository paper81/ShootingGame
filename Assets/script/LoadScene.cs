using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Trisibo;

public class LoadScene : MonoBehaviour
{
    [SerializeField]
    SceneField loadScene;
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip cliclSE;

    public void OnClick()
    {
        audioSource.PlayOneShot(cliclSE);
        Debug.Log(loadScene);
        SceneManager.LoadScene(loadScene.BuildIndex);
    }
}
