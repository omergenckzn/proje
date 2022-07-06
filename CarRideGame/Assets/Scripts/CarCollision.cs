using UnityEngine.SceneManagement;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    [SerializeField] int coinCount = 6;
    int coinPoint;

    void OnCollisionEnter(Collision collision)
    {
     
        switch (collision.gameObject.tag)
        {
            case "Floor":
                break;

            case "Collision":
                GetComponent<CarMovement>().enabled = false;
                Invoke("Reload", 1);
                break;
            case "Finish":
                GetComponent<CarMovement>().enabled = false;
                Invoke("nextLevel", 1);
                break;
            case "Point":
                Destroy(collision.gameObject);
                coinPoint++;
                Debug.Log(coinPoint);
                break;

        }
    }

    void Reload()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    void nextLevel()
    {
        

        if(coinPoint == coinCount)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex + 1;

            if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
            {
                nextSceneIndex = 0;
            }

            SceneManager.LoadScene(nextSceneIndex);

        }
        else
        {
            Debug.Log("Please Collect All Points");
        }

        
    }
}
