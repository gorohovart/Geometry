namespace Library
open System.Drawing
module Geometry = 
    let squaredSegmentLength (A : Point) (B : Point) =        
        (A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y)

    let Checker A B C =
        let check A B C = 
            (squaredSegmentLength A B = squaredSegmentLength B C + squaredSegmentLength A C)
        
        (check A B C) || (check A C B) || (check C B A)
