package tp3;

public class Debut {
	public static void main(String[] args)
    {
        GUIFactory aFactory = GUIFactory.os("Windows");
        Button aButton = aFactory.createButton();
        aButton.objet("WPF");
        aButton.paint();
        GUIFactory aFactory1 = GUIFactory.os("Unix");
        Button aButton1 = aFactory1.createButton();
        aButton1.objet("MOTIF");
        aButton1.paint();
    }
}
