open Expecto
open Library

let tests = 
    test "test TwoX" {
        let a = { MyType.x = 2; y = 4 }
        let res = a.TwoX()
        Expect.equal 4 res "TwoX should double the X value"
    }

[<EntryPoint>]
let main args = 
    runTestsWithArgs defaultConfig args tests
