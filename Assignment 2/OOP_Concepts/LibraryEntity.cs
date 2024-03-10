public abstract class LibraryEntity
{
    public string Name { get; set; }
    public abstract string EntityType { get; } // Read-only property
    public string Description;


    public abstract void DisplayInfo();
}
