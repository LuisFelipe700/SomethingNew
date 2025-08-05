using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    private string nomeFase;
    private float pontos;

    // M�todo para salvar o estado do jogo
    public void SalvarJogo(string fase, float pontos)
    {
        PlayerPrefs.SetInt(fase, 1);
        PlayerPrefs.SetFloat("Pontos", pontos);
        PlayerPrefs.Save();
    }

    public void SalvarCheckPoint(string fase, float pontos, Vector3 local)
    {
        PlayerPrefs.SetInt("Check" + fase, 1);
        PlayerPrefs.SetFloat("Pontos", pontos);
        PlayerPrefs.SetFloat("CheckPosX" + fase, local.x); //CheckPosXFase1
        PlayerPrefs.SetFloat("CheckPosY" + fase, local.y); //CheckPosYFase2
                                                           //CheckPosZFase3
        PlayerPrefs.SetFloat("CheckPosZ" + fase, local.z);
        PlayerPrefs.Save();
    }

    // M�todo para carregar o estado do jogo
    public void CarregarPontos()
    {
        pontos = PlayerPrefs.GetFloat("Pontos");
    }

    //Verifica se tem save
    public bool VerificarSaveGame(string nomeFase)
    {
        bool temSave = PlayerPrefs.HasKey(nomeFase) && 
                            PlayerPrefs.HasKey("Pontos");
        return temSave;
    }

    public bool VerificarSaveCheckPoint(string nomeFase)

    {
        bool temSave = PlayerPrefs.HasKey("Check" + nomeFase);
        return temSave;
    }    // M�todos para obter os valores carregados
    
    public float GetPontos()
    {
        return pontos;
    }

    public void ResetarSave()
    {
        PlayerPrefs.DeleteAll();
        pontos = 0f;
        Debug.Log("Todos os saves foram resetados.");
    }

}
