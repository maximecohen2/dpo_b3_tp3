package tp3;

public abstract class Button {
	private String caption;

    public String objet()
    {
        return caption;
    }

    public void objet(String caption)
    {
        this.caption = caption;
    }

    public abstract void paint();
}
