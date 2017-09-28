package main;

public class SampleImpl implements Sample {
    private Dependency dependency;

    public SampleImpl(Dependency dependency) {
        this.dependency = dependency;
    }

    public String testDependency(){
        System.out.print(dependency.sayHello());
        return dependency.sayHello();
    }
    public Dependency getDependency() {
        return dependency;
    }
}
