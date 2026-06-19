using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class StoryScript : MonoBehaviour
{
    [SerializeField] GameObject[] slides;
    int i = 0, j = 0;
    [SerializeField] string sceneToLoad;
    [SerializeField] PersonagemSlides PersonagemSlides;
    [SerializeField] GameObject nextSlideButton;

    int SlideToShow;
    void Start()
    {
        foreach (GameObject slide in slides)
        {
            slide.SetActive(false);
            i++;
        }
        //slides[0].SetActive(true);
        nextSlideButton.SetActive(false);
    }
    public void ShowFirstSlide()
    {
        slides[0].SetActive(true);
        nextSlideButton.SetActive(true);

    }

    public void NextSlide()
    {
        if (j == i - 1)
        {
            slides[j].SetActive(false);
            //SceneManager.LoadScene(sceneToLoad);
            PersonagemSlides.WalkAway();
            nextSlideButton.SetActive(false);
        }
        if (j < i - 1)
        {
            slides[j].SetActive(false);
            slides[j + 1].SetActive(true);
            j++;
        }
        GetComponent<FMODUnity.StudioEventEmitter>().Play();
    }
   
    public void SkipSlides()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}


/*public class StoryScript : MonoBehaviour
{
    [SerializeField] SlideData[] slideData;
    [SerializeField] GameObject test;
    SlideData thisSlide;
    int i = 0, j = 0;
    int SlideToShow;
    UnityEngine.UI.Image imagem;

    private void Start()
    {
        SlideToShow = SlidesManeger.instance.GiveSlideNumber();
        imagem = test.GetComponent<UnityEngine.UI.Image>();
        thisSlide = slideData[SlideToShow];
        foreach (Sprite slide in thisSlide.sprites)
        {
            i++;
        }
        imagem.sprite = thisSlide.sprites[j];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextSlide();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeScene();
        }
    }

    public void NextSlide()
    {
        j++;
        if (j < i)
        {
            imagem.sprite = thisSlide.sprites[j];
        }
        if (j == i)
        {
            ChangeScene();
        }
    }
    public void ChangeScene()
    {
        if (SlideToShow % 2 != 0)
        {
            SceneManager.LoadScene("Menu");
        }
        switch (SlideToShow)
        {
            case 0:
                SlidesManeger.instance.UpdateSlidesToShow(SlideToShow + 1);
                SceneManager.LoadScene("Gameplay 1");
                break;
        }
    }
}*/