using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenteFase : MonoBehaviour
{
    [SerializeField] private SaveGame saveGame;

    private void Awake()
    {
        if (saveGame == null)
        {
            if(saveGame.VerificarSaveCheckPoint(SceneManager.GetActiveScene().name))
            {
                Debug.Log("Fase carregada com CheckPoint");
            }
            else
            {
                Debug.Log("Fase carregada sem CheckPoint");
            }
        }
    }
}
