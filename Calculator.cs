public class Calculator{
    public static int counter;
    public Calculator(){
        counter = 0;
    }
    public float Tinh(float a, float b){
        counter++;
        return a + b;
    }
    public float Tinh(float a, float b, float c){
        counter++;
        return a - b;
    }
    public float TinhN(params float[] args){
        counter++;
        float sum = 0;
        foreach(int v in args)
            sum += v;
        return sum;
    }
}