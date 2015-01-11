namespace Tests

module Tests = 
    open System
    open Library
    open NUnit.Framework

    [<Test>]
    let ``1``() =
        Assert.IsFalse(Geometry.Checker (Geometry.Point (0.0, 0.0)) (Geometry.Point (2.0, 1.0)) (Geometry.Point (1.0, 2.0)));

    [<Test>]
    let ``2``() = 
        Assert.IsTrue(Geometry.Checker (Geometry.Point (0.0, 0.0)) (Geometry.Point (0.0, 1.0)) (Geometry.Point (1.0, 0.0)));