using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void BtnNewScene()
    {
        SceneManager.LoadScene("TICTACTOE");
    }

}