package SaveACustomObject;

import com.google.common.base.Joiner;

import java.io.Serializable;
import java.util.List;

public class Student implements Serializable {
    private String name;
    private int age;
    private List<Double> grades;

    public Student(String name, int age, List<Double> grades) {
        this.setName(name);
        this.setAge(age);
        this.setGrades(grades);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        if(name == " " || name.chars().anyMatch(ch-> Character.isDigit(ch))){
            throw new IllegalArgumentException("The name cannot contain digits or be empty string");
        }
            this.name = name;


    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        if(age < 0){
            throw new IllegalArgumentException ("The age cannot be a negative number");
        }
        this.age = age;
    }

    public List<Double> getGrades() {
        return grades;
    }

    public void setGrades(List<Double> grades) {
        if(grades.stream().anyMatch(grade-> grade < 2 || grade > 6)){
            throw new IllegalArgumentException ("The grades are from 2 to 6");
        }
        this.grades = grades;
    }

    @Override
    public String toString() {
        return String.format("Name: %s, Age: %d, Grades: %s", this.name, this.age, Joiner.on(", ").join(grades));
    }
}
