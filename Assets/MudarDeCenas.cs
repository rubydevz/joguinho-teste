using UnityEngine;
using UnityEngine.SceneManagement;
public class MudarDeCenas : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] private string nomeDaProxCena;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float distance = Vector2.Distance(player.transform.position, transform.position);
        if(distance < 0.5f)
        {
            SceneManager.LoadScene(nomeDaProxCena);
        }
    }
}