package tp3;

public class WinFactory extends GUIFactory{
	public Button createButton()
    {
        return(new BouttonWindows());
    }
}
