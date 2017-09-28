package main;

public class MainModule {
    public static void main(String [] args){
        System.out.print("Hello World");
        SampleImpl p = new SampleImpl(new Dependency());
        p.sayHi();
    }
}
