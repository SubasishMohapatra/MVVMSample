# MVVMSample
Sample app showcasing basic MVVM example
Refer MVVMSample2 that captures all basic ingredient of MVVM - Model, View and ViewModel
There are primarily 3 components - MainView, MainModel and a MainViewModel
MainViewModel is clean and holds an instance of a Model and the Model can initialize from any service(in this case I initialize in the constructor)
Model has an observable collection and a current item to show current selection
