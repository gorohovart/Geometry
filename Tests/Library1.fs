namespace Tests
open System.Drawing
module Tests = 
    open System
    open Library
    open NUnit.Framework

    [<Test>]
    let ``1``() =
        Assert.IsFalse(Geometry.Checker (Point (0, 0)) (Point (2, 1)) (Point (1, 2)));

    [<Test>]
    let ``2``() = 
        Assert.IsTrue(Geometry.Checker (Point (0, 0)) (Point (0, 1)) (Point (1, 0)));