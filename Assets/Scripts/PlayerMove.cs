using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    
    public float speed = 10.0f;
    public float jumpforce = 30.0f;
    private bool walkUp;
    private bool walkLeft;
    private bool walkRight;
    public Transform player;
    public Rigidbody2D player1;
    public bool paused;
    bool isStopped;
    public GameObject mouse;
    public GameObject yarn;
    public GameObject scratcher;
    public GameObject check1;
    public GameObject check2;
    public GameObject check3;
    public GameObject pauseText;
    bool mousecheck;
    bool yarncheck;
    bool scratchercheck;
    bool facecheck = true;
    public GameObject wheelRight;
    public GameObject wheelLeft;
    bool canJump = false;


    float transX;

    IEnumerator waitToAdjust()
    {
        
        yield return new WaitForSeconds(3.0f);
        
        this.transform.eulerAngles = new Vector3(0, 0, 0);

    }

    //public void Jump()
    //{
    //    GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
    //}

    public void Start()
    {
        check1.SetActive(false);
        check2.SetActive(false);
        check3.SetActive(false);
        transX = this.transform.localScale.x;


    }

    public void FixedUpdate()
    {
        //if (walkUp)
        //{
            //player.GetComponent<Rigidbody2D>();
      //  GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            //GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpforce);
            //player.Translate(Vector2.up * jumpforce * Time.deltaTime);


            // GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpforce);
       // }
       if (walkLeft)
        {
            GetComponent<Rigidbody2D>().AddForce(-Vector2.right * speed);
            wheelLeft.transform.Rotate(Vector3.forward * 90);
            wheelRight.transform.Rotate(Vector3.forward * 90);

        }
        else if (walkRight)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed);
            wheelRight.transform.Rotate(Vector3.forward * 90);
            wheelLeft.transform.Rotate(Vector3.forward * 90);

            Debug.Log("walkright");


        }


        if (paused)
         {
           Time.timeScale = 0;
            pauseText.SetActive(true);
         }
       else if (!paused)
         {
            Time.timeScale = 1;
            pauseText.SetActive(false);

        }

        if (isStopped == true)
        {
            player1.drag = 20.0f;
        }
       else if(isStopped == false)
        {
            player1.drag = 0.02f;
        }

        if(mousecheck == true && yarncheck == true && scratchercheck == true)
        {
            if (SceneManager.GetActiveScene().name == "GameScene")
            {               
                PlayerPrefs.SetInt("LevelCompleted", 1);
                Debug.Log("savedLevel = 1");
            }
            else if (SceneManager.GetActiveScene().name == "Level2")
            {                
                PlayerPrefs.SetInt("LevelCompleted", 2);
                Debug.Log("savedLevel = 2");
            }
            else if (SceneManager.GetActiveScene().name == "Level3")
            {
               
                PlayerPrefs.SetInt("LevelCompleted", 3);
                Debug.Log("savedLevel = 3");

            }
            else if (SceneManager.GetActiveScene().name == "Level4")
            {
               
                PlayerPrefs.SetInt("LevelCompleted", 4);
                Debug.Log("savedLevel = 4");

            }
            else if (SceneManager.GetActiveScene().name == "Level5")
            {
                
                PlayerPrefs.SetInt("LevelCompleted", 5);
                Debug.Log("savedLevel = 5");

            }
            else if (SceneManager.GetActiveScene().name == "Level6")
            {
                
                PlayerPrefs.SetInt("LevelCompleted", 6);
                Debug.Log("savedLevel = 6");

            }
            else if (SceneManager.GetActiveScene().name == "Level7")
            {
                
                PlayerPrefs.SetInt("LevelCompleted", 7);
                Debug.Log("savedLevel = 7");

            }
            else if (SceneManager.GetActiveScene().name == "Level8")
            {
              
                PlayerPrefs.SetInt("LevelCompleted", 8);
                Debug.Log("savedLevel = 8");

            }
            else if (SceneManager.GetActiveScene().name == "Level9")
            {
                
                PlayerPrefs.SetInt("LevelCompleted", 9);
                Debug.Log("savedLevel = 9");

            }
            else if (SceneManager.GetActiveScene().name == "Level10")
            {
           
                PlayerPrefs.SetInt("LevelCompleted", 10);
                Debug.Log("savedLevel = 10");

            }
            SceneManager.LoadScene("LevelSelect");

        }

        if (this.transform.eulerAngles.z >= 178 && transform.eulerAngles.z <= 182) 
        {
            StartCoroutine(waitToAdjust());
            //this.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (this.transform.eulerAngles.z >= 267 && transform.eulerAngles.z <= 271)
        {
            StartCoroutine(waitToAdjust());
            //this.transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (this.transform.eulerAngles.z >= 238 && transform.eulerAngles.z <= 242)
        {
            StartCoroutine(waitToAdjust());
           // this.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (this.transform.eulerAngles.z >= 88 && transform.eulerAngles.z <= 92)
        {
            StartCoroutine(waitToAdjust());
            //this.transform.eulerAngles = new Vector3(0, 0, 0);
        }

    }
    public void PlayerWalkUp(int value)
    {
        if (canJump == true)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            Debug.Log("Jumped");
        } 

    }

    public void PlayerWalkLeft(int value)
    {
        if (value == 1)
        {
          
            if (facecheck == false)
            {
                transX *= -1;
                this.transform.localScale = new Vector3(transX, transform.localScale.y, transform.localScale.z);
                facecheck = !facecheck;
            }
            walkLeft = true;
            //canJump = true;
            walkRight = false;
            isStopped = false;
        }
        else
        {
            walkLeft = false;
        }

    }

    public void PlayerWalkRight(int value)
    {
       

        if (value == 1)
        {
            if (facecheck == true)
            {
                transX *= -1;
                this.transform.localScale = new Vector3(transX, transform.localScale.y, transform.localScale.z);
                facecheck = !facecheck;

            }
            walkRight = true;
            //canJump = true;
            walkLeft = false;
            isStopped = false;
        }
        else
        {
            walkRight = false;
        }

    }

    public void Pause()
    {
        paused = !paused;

    }

    public void Stop()
    {
        isStopped = true;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "mouse")
        {
            Debug.Log("called");
            mouse.SetActive(false);
            check1.SetActive(true);
            mousecheck = true;        }
        else if (col.gameObject.tag == "yarn")
        {
            yarn.SetActive(false);
            check2.SetActive(true);
            yarncheck = true;
        }

        else if (col.gameObject.tag == "scratcher")
        {
            scratcher.SetActive(false);
            check3.SetActive(true);
            scratchercheck = true;
        }

       if (col.gameObject.tag == "Platform")
        {
            canJump = true;
            Debug.Log("canjump");
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Platform")
        {
            canJump = false;
            Debug.Log("can't jump");

        }
    }

    
}
