package tp3;

public abstract class GUIFactory {
	public static GUIFactory os(String sys)
    {

         if (sys == "Windows")
             return(new WinFactory());
         if (sys == "Unix")
         return(new UnixFactory());
		return null;
    }
    public abstract Button createButton();
}
