using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{

    public void LoadGame()
    {
        if (SceneManager.GetSceneByName("DemoScene_edit") == null)
        {
            Debug.Log("Sceny nie ma");
        }
        else
        {
            SceneManager.LoadScene("DemoScene_edit");
        }
            
    }
}
