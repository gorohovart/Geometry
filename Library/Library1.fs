namespace Library
open System.Drawing
module Geometry = 
//    type Point(x0, y0) =
//        let mutable x : int = x0
//        let mutable y : int = y0
//        member this.X = x
//        member this.Y = y

    let segmentLength (A : Point) (B : Point) = 
        
        (A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y)

    let Checker A B C =
        let check A B C = 
            (segmentLength A B = segmentLength B C + segmentLength A C)
        
        (check A B C) || (check A C B) || (check C B A)
