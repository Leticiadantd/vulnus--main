using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public TMP_InputField campoDeNome;

    public void Jogar()
    {
        // Impede de continuar se o campo estiver vazio
        if (string.IsNullOrWhiteSpace(campoDeNome.text))
        {
            Debug.LogWarning("Digite um nome antes de começar!");
            return;
        }

        // Salva o nome para usar nas próximas cenas
        PlayerPrefs.SetString("NomeJogador", campoDeNome.text.Trim());

        // Carrega a cena 2 do seu jogo
        SceneManager.LoadScene("cena 2");
    }
}