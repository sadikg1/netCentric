class CSStudent:Student,IGradeable
{
    //Multiple Inheritence
    public CSStudent(string name, byte roll, string email, string project)
    :base(name,roll,email)
    {
        ProjectTitle=project;
    }
    public string ProjectTitle{get; set;}
    public string InternReport{get; set;}
    public double GetGrade()=>3.6;

    public override string PrintInfo()
    {
        var details = base.PrintInfo();
        details += $" Project Title: {ProjectTitle}";
        return details;
    }

}