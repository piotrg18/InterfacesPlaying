package main;

public interface Sample {
    default public void sayHi() {
        
        System.out.println("Interface");
    }
}
