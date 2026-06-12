using UnityEngine;

public class PersonagemSlides : MonoBehaviour
{
    [SerializeField] StoryScript StoryScript;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    

    public void ShowFirstSlide()
    {
        StoryScript.ShowFirstSlide();
        this.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void WalkAway()
    {
        this.GetComponent<SpriteRenderer>().enabled = true;
        animator.SetTrigger("walkOut");
    }

    public void ChangeScene()
    {
        StoryScript.SkipSlides();
    }
}
