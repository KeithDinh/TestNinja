# C# Unit Tests

## Notes

TDD: loop(write failing tests => write simpliest code to pass => refactor)

Don't test private members. If we test private members, the tests will be coupled to the implementation details which break when change implementation

Code Coverage: scan your project and shows part that you didn't test

### Jetbrain Rider:

To add project as reference for testing, right click on testing project => Add reference => original project 

### Naming Convention

[MethodName]_[Scenario]_[ExpectedBehaviour]
<br/> Ex: Add_WhenCalled_ReturnSumOfArguments()

