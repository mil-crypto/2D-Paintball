using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Transform player;
    bool leftPressed=false;
    bool rightPressed=false;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Update()
    {
        if(leftPressed)
            player.transform.Translate(new Vector3(-0.15f, 0, 0));

        if(rightPressed)
            player.transform.Translate(new Vector3(0.15f, 0, 0));
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void MoveOnLeftButton()
    {
        leftPressed = true;
        Debug.Log("нажата");
    }
    public void LeftButtonUp()
    {
        leftPressed = false;
    }

    public void MoveOnRightButton()
    {
        rightPressed = true;

    }
    public void RightButtonUp()
    {
        rightPressed = false;
    }

}
