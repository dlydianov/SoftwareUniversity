package _2_LV1Shop.Exceptions;

/**
 * Created by Simooo on 30.10.2015 �..
 */
public class NoPermissionException extends Exception {
    public NoPermissionException(){
        super("You are too young to buy this product!");
    }
}
