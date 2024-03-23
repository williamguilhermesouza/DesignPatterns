namespace Structural;
/* Proxy is a structural design pattern that lets you
 provide a substitute or placeholder for another object.
  A proxy controls access to the original object, allowing
   you to perform something either before or after the
   request gets through to the original object. */
public class Proxy
{
    // create a messy big class that needs access control
    // that will be handled by the proxy
    public class BigAndMessy {
        public int FirstProperty = 0;
    }

    // controls the access to big and messy
    public class ProxyClass {
        public int FirstProperty = 1;
    }
    
    public static Object ProxyMethod(int arg) {
        if (arg == 0) {
            return new BigAndMessy();
        } else {
            return new ProxyClass();
        }
    }
    
}