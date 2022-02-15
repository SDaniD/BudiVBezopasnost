using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject button; 
    public const int gridRows = 2;
    public const int gridCols = 6;
    public const float offsetX = 2.7f;
    public const float offsetY = 3f;
    [SerializeField] private MainCard originalCard;
    [SerializeField] private Sprite[] images;
    private void Start()
    {
        Vector3 startPos = originalCard.transform.position;
        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
        numbers = ShuffleArray(numbers);
        for (int i = 0; i < gridCols; i++)
        {
            for (int j = 0; j < gridRows; j++)
            {
                MainCard card;
                if (i == 0 && j == 0)
                {
                    card = originalCard;
                }
                else
                {
                    card = Instantiate(originalCard) as MainCard;
                }
                int index = j * gridCols + i;
                int id = numbers[index];
                card.ChangeSprite(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = (offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }
    }
    
    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }

    private MainCard _firstRevealed;
    private MainCard _secondRevealed;

    private int _score = 6;
    private int _scoreWrong = 0;
    private int righttries = 0;
    [SerializeField] private TextMesh scoreLabel;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public bool canReveal
    {
        get { return _secondRevealed == null; }
    }

    public void CardRevealed(MainCard card)
    {
        if (_firstRevealed == null)
        {
            _firstRevealed = card;
        }
        else
        {
            _secondRevealed = card;
            StartCoroutine(CheckMatch());
        }
    }

    private IEnumerator CheckMatch()
    {
        if (_firstRevealed.id != _secondRevealed.id)
        {

            _scoreWrong++;
            if (_scoreWrong == 2)
            {
                _score = _score - 2;
                heart1.SetActive(false);
                scoreLabel.text = "Опити: " + _score;
            }
            else if (_scoreWrong == 4)
            {
                _score = _score - 2;
                heart2.SetActive(false);
                scoreLabel.text = "Опити: " + _score;
            }
            else if (_scoreWrong == 6)
            {
                _score = _score - 2;
                heart3.SetActive(false);
                scoreLabel.text = "Опити: " + _score;
            }
            else if (_scoreWrong == 7)
            {
                ResetScene();
            }

            yield return new WaitForSeconds(0.5f);

            _firstRevealed.Unreveal();
            _secondRevealed.Unreveal();
        }
        else {
            righttries++;
        }
        if (righttries == 6)
        {
            button.SetActive(true);
        }

        _firstRevealed = null;
        _secondRevealed = null;

    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}