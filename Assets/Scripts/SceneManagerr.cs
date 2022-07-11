using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerr : MonoBehaviour
{
    public void LoadMenu(){
        SceneManager.LoadScene(1);
    }
    public void LoadGameScene(){
        SceneManager.LoadScene(0);
    }
}
