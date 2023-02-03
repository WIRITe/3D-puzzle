using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class ButtonsController : MonoBehaviour
{
    public Scene thisScene;

    public GameObject RestartButton;

    private void Start()
    {
        thisScene = SceneManager.GetActiveScene();
    }



    public void OnExitButton()
    {
        Application.Quit();
    }



    public void OnNextButton()
    {
        SceneManager.LoadScene(thisScene.buildIndex + 1);
    }



    public void OnLastButton()
    {
        if(thisScene.buildIndex != 1)
        {
            SceneManager.LoadScene(thisScene.buildIndex - 1);
        }
    }

    public void OnRestBut()
    {
        RestartButton.SetActive(false);
        MoveSir.canMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void OnRestartButton() 
    {
        SceneManager.LoadScene(thisScene.buildIndex);
        MoveSir.canMove = true;
    }
}
