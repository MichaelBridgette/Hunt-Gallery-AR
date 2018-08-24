using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void OpenGiftShop()
   {
        Application.OpenURL("http://www.huntmuseum.com/gift-shop/");
   }
    public void OpenUpcoming()
    {
        Application.OpenURL("http://www.huntmuseum.com/event-category/upcoming-exhibitions/");
    }
    public void OpenExisting()
    {
        Application.OpenURL("http://www.huntmuseum.com/event-category/all-exhibitions/?date=current");
    }
    public void OpenEventLists()
    {
        Application.OpenURL("http://www.huntmuseum.com/wp-content/uploads/2018/03/Events-Guide-March-May-2018-1.pdf");
    }
}
