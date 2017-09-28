import main.Dependency;
import main.SampleImpl;
import mockit.Expectations;


import mockit.Mocked;
import mockit.integration.junit4.JMockit;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;

import static org.junit.Assert.*;

@RunWith(JMockit.class)
public class TestClass {
    @Mocked
    private Dependency mockInstance;


    @Test
    public void testCase() {
        new Expectations() {{
            // An expectation for an instance method:
            mockInstance.sayHello();
            result = "mocked";
        }};
        SampleImpl sut = new SampleImpl(mockInstance);
        String result  =  sut.testDependency();

        assertEquals("mocked", result);

    }
}
