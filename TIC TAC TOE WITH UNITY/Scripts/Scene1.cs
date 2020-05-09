using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1 : MonoBehaviour
{
    public void BtnNewScene()
    {
        SceneManager.LoadScene("Menu");
    }

}