package _2_LV1Shop.Exceptions;

/**
 * Created by Simooo on 30.10.2015 �..
 */
public class NoMoneyException extends Exception{

    public NoMoneyException(){
        super("You do not have enough money to buy this product!");
    }
}
