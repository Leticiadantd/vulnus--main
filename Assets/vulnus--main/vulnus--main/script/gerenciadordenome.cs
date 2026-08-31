using UnityEngine;
using TMPro;

public class GerenciadorDeNome : MonoBehaviour
{
    public TMP_InputField campoDeNome;

    // Chame este método em um botão de "Salvar" ou no evento OnEndEdit do InputField
    public void SalvarNome()
    {
        string nomeJogador = campoDeNome.text;
        Debug.Log("Nome digitado: " + nomeJogador);
    }
}