using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();

// Call Sample Method
var result = vm.ForEachQueryCallingMethod();

// Display Results
vm.Display(result);