using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CriarSala : MonoBehaviour
{
    
    public void Abrircena3()
    {
        SceneManager.LoadScene("cena 3");
    }

    public void CampoCriarSala(TMP_InputField CampoCriarSala)
    {
        // Impede de continuar se o campo estiver vazio
        if (string.IsNullOrWhiteSpace(CampoCriarSala.text))
        {
            Debug.LogWarning("Digite um nome antes de começar!");
            return;
        }

        // Salva o nome para usar nas próximas cenas
        PlayerPrefs.SetString("NomeJogador", CampoCriarSala.text.Trim());

    }
}
