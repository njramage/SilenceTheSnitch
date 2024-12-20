using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameOverEvents : MonoBehaviour
{
    protected UIDocument document;

    private Button playAgainButton;
    private Label timeText; 

    protected virtual void Awake()
    {
        document = GetComponent<UIDocument>();

        playAgainButton = document.rootVisualElement.Q("PlayAgainButton") as Button;
        playAgainButton.RegisterCallback<ClickEvent>(OnPlayAgainClick);
    }

    private void OnPlayAgainClick(ClickEvent clickEvent)
    {
        Debug.Log("Clicked play again");
        SceneManager.LoadScene("GameScene");
    }
}
