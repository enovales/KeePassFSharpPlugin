module Library

type MyType = 
    {
        x: int
        y: int
    }
    with
        member this.TwoX() = this.x * 2
