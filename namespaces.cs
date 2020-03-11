//every class has to be inside a namepsace
// the point of namespaces is to be able to have classes share the same name without have a conflict
//without namespaces the compiler wouldn't know which of two classes with the same name to use


//defaults to the name of the project you are in
namespace yourProjectName {
    public class Car {

    }
}

//the code knows that these are two different classes because of different namespaces
namespace mySecondNameSpace {
    public class Car {

    }
}

//by default everytime you add a folder you add a part to the namepsace
//if I added a classes project to mySecondNameSpace program I would then by default have the following namespace
namespace mySecondNameSpace.Classes {
    public class SecondClass {
        
    }
}

