using UnityEngine;
//using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    //private int width = 126;
    //private int height = 57;
    
    public void draw()
    {
        //Incase we want to change the position of the button later
        //Camera.main.transform.position = new Vector3(width / 2f, height / 2f, -10f);
        //transform.position =new Vector3(width, height, 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        draw();
    }

    // Update is called once per frame
    void Update()
    {
        draw();
    }
}
