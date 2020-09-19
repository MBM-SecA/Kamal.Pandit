using System;
class Array
{
    void learn1DArray()
    {
        int[] ages1 = new int[10];
        double[] ages2 = new double[10];

        ages1[0] = 18;
        ages1[5] = 21;
        float[] numbers = new float[]{23.5f, 60.5f, 92.66f};
        float[] numbers1 = {23.5f, 60.5f, 92.66f};
    }
    void learn2DArray()
    {
        // 2 dimensional array
        int[,] agesMatrix = new int[10, 15];
        agesMatrix[0,0] = 21;

        int[,,] agesMatrix1 = new int[10,15,5];



    }
    void learnjaggedArray()
    {
        byte[][] ageofperson = new byte[3][];
        ageofperson[0] = new byte[]{34, 6};
        ageofperson[1] = new byte[]{34,35,52,60,70};
        ageofperson[2] = new byte[]{5,65,75};
}
}