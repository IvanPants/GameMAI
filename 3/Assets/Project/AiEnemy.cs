using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class AiEnemy : MonoBehaviour
{
    private NavMeshAgent AI_Agent;
    private GameObject Player;
    public GameObject PanelGameOver;
    public GameObject SoundOff;
    public int waitTime;
    
    // Start is called before the first frame update

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log("restart");
        PanelGameOver.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    }
    void Start()
    {
        AI_Agent = gameObject.GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    
    void FixedUpdate()
    {
        AI_Agent.SetDestination(Player.transform.position);
        float Dist_Player = Vector3.Distance(Player.transform.position, gameObject.transform.position);
        if(Dist_Player < 2)
        {
            Debug.Log("Button pressed");
            Player.SetActive(false);
            PanelGameOver.SetActive(true);
            StartCoroutine(NextLevel());

        }
    }
}
