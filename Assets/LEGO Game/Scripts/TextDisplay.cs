using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisplay : MonoBehaviour
{
   [SerializeField]
   public GameObject[] Text;
    [SerializeField]
   public GameObject ActiveTextBox;
   private int TextIndex;


   private void Start()
   {
      ActiveTextBox = Text[0];
      ActiveTextBox.SetActive(true);
   }


   void Update()
   {
    if (Input.GetMouseButtonDown(0))
    {
      if(ActiveTextBox != Text[Text.Length - 1])
      {
         ActiveTextBox.SetActive(false);
         TextIndex++;
         ActiveTextBox = Text[TextIndex];
         ActiveTextBox.SetActive(true);

      }
    }

if (Input.GetMouseButtonDown(1))
    {
      if(ActiveTextBox != Text[0])
      {
         ActiveTextBox.SetActive(false);
         TextIndex--;
         ActiveTextBox = Text[TextIndex];
         ActiveTextBox.SetActive(true);

      }
    }

   }

}
