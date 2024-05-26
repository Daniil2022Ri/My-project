
using UnityEngine;

namespace UI
{
   public class SoungButtonManager : MonoBehaviour
   {
      [SerializeField] private AudioClip [] clip;
      
      private AudioSource _soungButton;
      
      private void Start()
      {
         
         _soungButton = GetComponent<AudioSource>();
      }

      public void EnterButtonSoungCanvace()
      {
         _soungButton.clip = clip[0];
         _soungButton.Play();

      }

      public void ClickButtonSoundCanvace()
      {
         _soungButton.clip = clip[1];
         _soungButton.Play();
      }
   }
}
