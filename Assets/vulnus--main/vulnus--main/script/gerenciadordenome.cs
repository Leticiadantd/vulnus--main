using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GerenciadorDeNome : MonoBehaviour
{
    public TMP_InputField campoDeNome;
    public TMP_InputField CampoDeSenha;
    public Button jogar;
    public Button criarSala;
    // Chame este método em um botão de "Salvar" ou no evento OnEndEdit do InputField
    public void SalvarNome()
    {
        string nomeJogador = campoDeNome.text;
        Debug.Log("Nome digitado: " + nomeJogador);
    }

    public void quandoOCampoDeNomeMudar( )
    {
        if (string.IsNullOrWhiteSpace(campoDeNome.text) || string.IsNullOrWhiteSpace(CampoDeSenha.text))
        {
             jogar.interactable = false; // Desativa o botão se o campo estiver vazio
             criarSala.interactable = false; // Desativa o botão se o campo estiver vazio
            Debug.LogWarning("O campo de nome está vazio!");
            return;
        }
        else
        {
            jogar.interactable = true; // Ativa o botão se o campo tiver texto
            criarSala.interactable = true; // Ativa o botão se o campo tiver texto
        }

    }
}