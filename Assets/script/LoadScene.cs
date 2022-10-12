using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Trisibo;

public class LoadScene : MonoBehaviour
{
    public SceneField loadScene;

    public void OnClick()
    {
        Debug.Log(loadScene);
        SceneManager.LoadScene(loadScene.BuildIndex);
    }
}
