using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuInicio : MonoBehaviour
{
    public TMP_InputField campoDeNome;
    public GameObject mensagemDeErro; // Opcional: um texto de aviso "Digite seu nome!"

    public void TentarIniciarJogo()
    {
        // string.IsNullOrWhiteSpace verifica se está vazio ou apenas com espaços
        if (string.IsNullOrWhiteSpace(campoDeNome.text))
        {
            Debug.LogWarning("O nome do jogador não pode estar vazio!");

            if (mensagemDeErro != null)
            {
                mensagemDeErro.SetActive(true); // Exibe aviso na tela
            }
        }
        else
        {
            // Salva o nome para usar durante o jogo
            PlayerPrefs.SetString("NomeJogador", campoDeNome.text.Trim());

            // Inicia o jogo (substitua pelo nome da sua cena)
            SceneManager.LoadScene("NomeDaSuaCena");
        }
    }
}