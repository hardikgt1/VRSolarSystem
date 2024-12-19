using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Public method to load the next scene
    public void LoadNextScene()
    {
        // Replace "SolarSystem" with the name of your next scene
        SceneManager.LoadScene("SolarSystem");
    }

    // Public method to quit the application
    public void QuitApplication()
    {
        // Logs to indicate the application is quitting (useful for debugging in the editor)
        Debug.Log("Application Quit");

        // Quits the application (only works in a built application)
        Application.Quit();
    }
}
