
using UnityEngine;

namespace UI
{
   public class SoungButtonManager : MonoBehaviour
   {
      [SerializeField] private AudioSource soungButtonEnter;
      [SerializeField] private AudioSource soungButtonClick;

      [SerializeField] private AudioClip [] clip;


      private void Start()
      {
         clip = GetComponent<AudioClip[]>();
      }

      public void EnterButtonSoungCanvace()
      {
         soungButtonEnter.clip = clip[0];
         soungButtonEnter.Play();

      }

      public void ClickButtonSoundCanvace()
      {
         soungButtonClick.clip = clip[1];
         soungButtonClick.Play();
      }
   }
}
