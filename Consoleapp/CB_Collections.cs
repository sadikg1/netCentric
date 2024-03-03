class Collections{
    void LearnCollection(){
        //Arrays
        double[] weights=new double[20];
        weights[0]=23.4;
        weights[1]=23.4;
        weights[2]=23.4;
        weights[3]=23.4;
        weights[4]=23.4;
        weights[5]=23.4;
        double[] age=[34.5,67.8,89.6];
        // string[,] namelist={{"",""},{"",""}};
        // string[,] namelist=new string[3,4];
        string[][] names=[["A","B","C"],["D","E"],["F","G","H"]];
        //Built in collection: list, dictionary etc.

        List<string> fNAme=["Ram","Shyam","Hari","Rajesh"];
        Dictionary<string, char> studentGrades=new(){
            ["Ram"]='A',
            ["Shyam"]='B',
            ["Hari"]='C',
        };
        var grade=studentGrades["Ram"];

    }
}